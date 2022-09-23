using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
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

        #endregion

        #region "Constructor"
        public Machine()
        {
            _backgroundWorker.WorkerSupportsCancellation = true;
        }
        #endregion

        #region "Properties"
        public string Name { get => name; set => name = value; }
        public string Mac { get => mac; set => mac = value; }
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
        #endregion

        #region "Events"

        #endregion
    }
}
