using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Machines
{
    [Serializable()]
    public class Machine
    {
        #region "Delegates"
        public delegate void StatusChangeHandler(string Name, StatusCodes status, string IpAddress);
        #endregion

        #region "External Library"

        [DllImport("Iphlpapi.dll")]
        private static extern int SendARP(Int32 dest, Int32 host, ref Int64 mac, ref Int32 length);

        #endregion

        #region "Fields"
        private BackgroundWorker _backgroundWorker = new BackgroundWorker();
        private Ping ping = new Ping();

        public enum StatusCodes
        {
            Online,
            Offline,
            Unknown,
            Fail,
            Uninitialized
        }

        private string name = string.Empty;
        private string mac = string.Empty;
        private string ip = string.Empty;

        [NonSerialized()] public StatusCodes Status = StatusCodes.Uninitialized;
        [NonSerialized()] public PingReply Reply;
        [NonSerialized()] public Semaphore Pool;
        [NonSerialized()] const string data = "abcdefghijklmnopqrstuvwabcdefghi";
        [NonSerialized()] private byte[] buffer = Encoding.ASCII.GetBytes(data);
        [NonSerialized()] public string message;

        #endregion

        #region "Constructor"
        public Machine()
        {
            _backgroundWorker.WorkerSupportsCancellation = true;
            _backgroundWorker.DoWork += DoWork;
        }

        #endregion

        #region "Properties"
        public string Name { get => name; set => name = value; }
        public string MAC { get => mac; set => mac = value; }
        public string IP { get => ip; set => ip = value; }
        #endregion

        #region "Methode"
        public void Run()
        {
            if (_backgroundWorker.IsBusy)
                return;
            _backgroundWorker.WorkerReportsProgress = true;
            if (string.IsNullOrEmpty(IP))
                return;
            _backgroundWorker.RunWorkerAsync(IP);
        }

        public bool IsBusy()
        {
            return _backgroundWorker.IsBusy;
        }

        public void Cancel()
        {
            _backgroundWorker.CancelAsync();
        }

        public override string ToString()
        {
            return "Machine : " + Name;
        }

        private void DoWork(object sender, DoWorkEventArgs e)
        {
            do
            {
                try
                {
                    PingOptions options = new PingOptions(128, true);
                    Pool.WaitOne();
                    Reply = ping.Send(IPAddress.Parse((string)e.Argument), 10000, buffer, options);

                    switch (Reply.Status)
                    {
                        case IPStatus.Success:
                            _backgroundWorker.ReportProgress((int)StatusCodes.Online);
                            break;
                        case IPStatus.TimedOut:
                        case IPStatus.DestinationNetworkUnreachable:
                        case IPStatus.DestinationHostUnreachable:
                            _backgroundWorker.ReportProgress((int)StatusCodes.Offline);
                            break;
                        default:
                            _backgroundWorker.ReportProgress((int)StatusCodes.Unknown);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    message = ex.Message;
                    _backgroundWorker.ReportProgress((int)StatusCodes.Fail);
                }
                finally
                {
                    Pool.Release();
                    Thread.Sleep(2000);
                }
            } while (!_backgroundWorker.CancellationPending);
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                Status = StatusCodes.Unknown;
                StatusChange(Name, Status, string.Empty);
            }
            catch (Exception ex)
            {
                Debug.Fail(ex.Message);
            }
        }
        #endregion

        #region "Events"
        public event StatusChangeHandler StatusChanged;
        #endregion
    }
}
