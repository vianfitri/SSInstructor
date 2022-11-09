using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using SSInstructor.Forms;
using SSInstructor.Class;
using Tulpep.NotificationWindow;
using Machines;

namespace SSInstructor
{
    public partial class formDashboard : Form
    {
        #region "Delegate"
        public delegate void AlertHelpEventHandler(string name);
        #endregion

        #region "Fields"
        formMain _parent;
        private Form activeForm = null;

        #region "Requestable Assistant"
        private bool active = false;
        public bool Reqenabled = false;
        private Thread listener = null;
        private long id = 0;
        public struct MyClient
        {
            public long id;
            public StringBuilder ipaddress;
            public TcpClient client;
            public NetworkStream stream;
            public byte[] buffer;
            public StringBuilder data;
            public EventWaitHandle handle;
        };

        public struct AskedClient
        {
            public long id;
            public string PCName;
        };

        public List<string> pc_name = new List<string>();
        public ConcurrentDictionary<long, MyClient> clients = new ConcurrentDictionary<long, MyClient>();
        private Task send = null;
        private Thread disconnect = null;
        private bool exit = false;
        #endregion

        #endregion

        #region "Constructor"
        public formDashboard(formMain parent)
        {
            InitializeComponent();
            customizeDesign();
            this._parent = parent;
        }
        #endregion

        #region "Properties"
        #endregion

        #region "Methods"
        private void customizeDesign()
        {
            pnlMasterDataSubmenu.Visible = false;
            pnlUserSubmenu.Visible = false;
        }

        private void hideSubmenu()
        {
            // Killl Another Application If Exist
            Process[] procs = Process.GetProcessesByName("ShipStability");
            foreach(Process proc in procs)
            {
                proc.Kill();
            }

            if (pnlMasterDataSubmenu.Visible) pnlMasterDataSubmenu.Visible = false;
            if (pnlUserSubmenu.Visible) pnlUserSubmenu.Visible = false;
        }

        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void loadLoginInfo(string logId)
        {
            DataTable dtLoginInfo = new DataTable();
            string qrStr = "SELECT a.uc, " +
                "b.first_name, b.last_name, b.birthday, b.sex, b.email, b.photos, " +
                "c.typename " +
                "FROM shp_assets.ss_user a " +
                "INNER JOIN shp_assets.ss_subject b " +
                "ON a.uc_subject = b.uc " +
                "INNER JOIN shp_assets.ss_usertype c " +
                "ON b.type = c.id " +
                "WHERE a.uc = '" + logId + "' LIMIT 0, 1";

            if(ConnectorDB.MySQLConn.GetTableData(qrStr, ref dtLoginInfo))
            {
                lblUsername.Text = dtLoginInfo.Rows[0]["first_name"].ToString();
                lblPriviledge.Text = dtLoginInfo.Rows[0]["typename"].ToString();
            }
        }

        private void btnMasterData_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlMasterDataSubmenu);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlUserSubmenu);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            // Load Account Data
            openChildForm(new fAccount());

            hideSubmenu();
        }

        public void btnScenario_Click(object sender, EventArgs e)
        {
            // Load Scenario Page
            openChildForm(new fScenario(this));

            hideSubmenu();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            // Load Report Page
            openChildForm(new FScore());

            hideSubmenu();
        }

        private void btnClientList_Click(object sender, EventArgs e)
        {
            // Load Client List
            openChildForm(new fClientList());

            hideSubmenu();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            // Load Setting Page
            openChildForm(new fSetting());

            hideSubmenu();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to logout ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                UserController.isLogin = false;
                UserController.currentUcUser = "";
                this._parent.openChildForm(this._parent.fLogin);
                openChildForm(new formWelcome());
            }
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void formDashboard_Load(object sender, EventArgs e)
        {
            // Load default content
            openChildForm(new formWelcome());

            // fetch login user information
            loadLoginInfo(UserController.currentUcUser);

            // Start Assistant Server
            StartServer();

            AlertHelp += ShowPopup;

            // Reset All Menu View
            hideSubmenu();
        }

        private void btnShipData_Click(object sender, EventArgs e)
        {
            // Load Ship Data
            openChildForm(new fShipData());

            hideSubmenu();
        }

        private void btnCargoData_Click(object sender, EventArgs e)
        {
            // Load Cargo Data
            openChildForm(new fCargoData());

            hideSubmenu();
        }

        private void btnInstructor_Click(object sender, EventArgs e)
        {
            // Load Instructor Data
            openChildForm(new fInstructorData());

            hideSubmenu();
        }

        private void btnTrainee_Click(object sender, EventArgs e)
        {
            // Load Trainee Data
            openChildForm(new fTraineeData());

            hideSubmenu();
        }

        public void btnStability_Click(object sender, EventArgs e)
        {
            // Load Instructor Data
            openChildForm(new fSSS(this));

            hideSubmenu();
        }

        private void hiddenPannel_Click(object sender, EventArgs e)
        {
            // Load Instructor Data
            //openChildForm(new fSSS());

            //hideSubmenu();
        }

        private void hiddenPannel_Click_1(object sender, EventArgs e)
        {
            // Load Scenario Page
            openChildForm(new fFCStowPlan());

            hideSubmenu();
        }

        private void formDashboard_VisibleChanged(object sender, EventArgs e)
        {
            if(UserController.isLogin)
            {
                loadLoginInfo(UserController.currentUcUser);
            }
        }

        private void btnReqAss_Click(object sender, EventArgs e)
        {
            // Load Form Requestable Assistant
            openChildForm(new FReqAssistantcs(this));

            hideSubmenu();
        }

        #region "Requestable Assistant"
        private void Active(bool status)
        {
            if (!exit)
            {
                active = status;
                if (status)
                {
                    Console.WriteLine("Assistant Server has started");
                }
                else
                {
                    Console.WriteLine("Assistant Server has stopped");
                }
            }
        }

        private void Read(IAsyncResult result)
        {
            MyClient obj = (MyClient)result.AsyncState;
            int bytes = 0;
            if (obj.client.Connected)
            {
                try
                {
                    bytes = obj.stream.EndRead(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Read : " + ex.Message);
                }
            }
            if (bytes > 0)
            {
                obj.data.AppendFormat("{0}", Encoding.UTF8.GetString(obj.buffer, 0, bytes));
                try
                {
                    if (obj.stream.DataAvailable)
                    {
                        obj.stream.BeginRead(obj.buffer, 0, obj.buffer.Length, new AsyncCallback(Read), obj);
                    }
                    else
                    {
                        string msg = string.Format("{0}: {1}", obj.ipaddress, obj.data);
                        Console.WriteLine("Read : " + msg);

                        // If message contain rh$ add todo list for ack
                        if (obj.data.ToString().Contains("rh$"))
                        {
                            foreach (Machine m in MachineModule.Machines)
                            {
                                if (m.IP == obj.ipaddress.ToString())
                                {
                                    // add PC Name to todo list
                                    pc_name.Add(m.Name);

                                    // Change Icon color
                                    btnReqAss.IconColor = Color.Yellow;
                                    btnReqAss.ForeColor = Color.Yellow;

                                    // show popup notification
                                    AlertHelp?.Invoke(m.Name);

                                    // break searcing pc name
                                    break;
                                }
                            }
                        }

                        //Send(msg, obj.id);
                        obj.data.Clear();
                        obj.handle.Set();
                    }
                }
                catch (Exception ex)
                {
                    obj.data.Clear();
                    Console.WriteLine(ex.Message);
                    obj.handle.Set();
                }
            }
            else
            {
                obj.client.Close();
                obj.handle.Set();
            }
        }

        private void ReadAuth(IAsyncResult result)
        {
            MyClient obj = (MyClient)result.AsyncState;
            int bytes = 0;
            if (obj.client.Connected)
            {
                try
                {
                    bytes = obj.stream.EndRead(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ReadAuth : " + ex.Message);
                }
            }
            if (bytes > 0)
            {
                obj.data.AppendFormat("{0}", Encoding.UTF8.GetString(obj.buffer, 0, bytes));
                try
                {
                    if (obj.stream.DataAvailable)
                    {
                        obj.stream.BeginRead(obj.buffer, 0, obj.buffer.Length, new AsyncCallback(ReadAuth), obj);
                    }
                    else
                    {
                        JavaScriptSerializer json = new JavaScriptSerializer(); // feel free to use JSON serializer
                        Dictionary<string, string> data = json.Deserialize<Dictionary<string, string>>(obj.data.ToString());
                        if (!data.ContainsKey("ipaddress") || data["ipaddress"].Length < 1 || !data.ContainsKey("key") || !data["key"].Equals("ShipStability"))
                        {
                            obj.client.Close();
                        }
                        else
                        {
                            bool accepted = false;
                            foreach (Machine m in MachineModule.Machines)
                            {
                                if (m.IP == data["ipaddress"].ToString())
                                {
                                    accepted = true;
                                    obj.ipaddress.Append(data["ipaddress"]);
                                    Send("{\"status\": \"ack\"}", obj);
                                }
                            }

                            if (!accepted)
                                obj.client.Close();
                        }
                        obj.data.Clear();
                        obj.handle.Set();
                    }
                }
                catch (Exception ex)
                {
                    obj.data.Clear();
                    Console.WriteLine("ReadAuth : " + ex.Message);
                    obj.handle.Set();
                }
            }
            else
            {
                obj.client.Close();
                obj.handle.Set();
            }
        }

        private bool Authorize(MyClient obj)
        {
            bool success = false;
            while (obj.client.Connected)
            {
                try
                {
                    obj.stream.BeginRead(obj.buffer, 0, obj.buffer.Length, new AsyncCallback(ReadAuth), obj); // get username and key
                    obj.handle.WaitOne();

                    if (obj.ipaddress.Length > 0)
                    {
                        success = true;
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Authorize : " + ex.Message);
                }
            }
            return success;
        }

        private void Connection(MyClient obj)
        {
            if (Authorize(obj))
            {
                clients.TryAdd(obj.id, obj);
                //StatusChange?.Invoke(true, obj.ipaddress.ToString());

                // Send Status of ReqAss
                if (ExerciseController.EMode == ExerciseController.ExerciseMode.Training)
                {
                    if (Reqenabled)
                    {
                        Send("en$");
                    }
                    else
                    {
                        Send("dis$");
                    }
                }
                else
                {
                    Send("dis$");
                }
                string msg = string.Format("Machine {0} has connected", obj.ipaddress);
                Console.WriteLine(msg);

                while (obj.client.Connected)
                {
                    try
                    {
                        obj.stream.BeginRead(obj.buffer, 0, obj.buffer.Length, new AsyncCallback(Read), obj);
                        obj.handle.WaitOne();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                obj.client.Close();
                clients.TryRemove(obj.id, out MyClient tmp);
                //StatusChange?.Invoke(false, tmp.ipaddress.ToString());
                msg = string.Format("Machine {0} has disconnected", tmp.ipaddress);
                Console.WriteLine(msg);
            }
        }

        private void Listener(IPAddress ip, int port)
        {
            TcpListener listener = null;
            try
            {
                listener = new TcpListener(ip, port);
                listener.Start();
                Active(true);
                while (active)
                {
                    if (listener.Pending())
                    {
                        try
                        {
                            MyClient obj = new MyClient();
                            obj.id = id;
                            obj.ipaddress = new StringBuilder();
                            obj.client = listener.AcceptTcpClient();
                            obj.stream = obj.client.GetStream();
                            obj.buffer = new byte[obj.client.ReceiveBufferSize];
                            obj.data = new StringBuilder();
                            obj.handle = new EventWaitHandle(false, EventResetMode.AutoReset);
                            Thread th = new Thread(() => Connection(obj))
                            {
                                IsBackground = true
                            };
                            th.Start();
                            id++;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Listener : " + ex.Message);
                        }
                    }
                    else
                    {
                        Thread.Sleep(500);
                    }
                }
                Active(false);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Listener : " + ex.Message);
            }
            finally
            {
                if (listener != null)
                {
                    listener.Server.Close();
                }
            }
        }

        private void Write(IAsyncResult result)
        {
            MyClient obj = (MyClient)result.AsyncState;
            if (obj.client.Connected)
            {
                try
                {
                    obj.stream.EndWrite(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Write : " + ex.Message);
                }
            }
        }

        private void BeginWrite(string msg, MyClient obj) // send the message to a specific client
        {
            byte[] buffer = Encoding.UTF8.GetBytes(msg);
            if (obj.client.Connected)
            {
                try
                {
                    obj.stream.BeginWrite(buffer, 0, buffer.Length, new AsyncCallback(Write), obj);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("BeginWrite : " + ex.Message);
                }
            }
        }

        private void BeginWrite(string msg, long id = -1) // send the message to everyone except the sender or set ID to lesser than zero to send to everyone
        {
            byte[] buffer = Encoding.UTF8.GetBytes(msg);
            foreach (KeyValuePair<long, MyClient> obj in clients)
            {
                if (id != obj.Value.id && obj.Value.client.Connected)
                {
                    try
                    {
                        obj.Value.stream.BeginWrite(buffer, 0, buffer.Length, new AsyncCallback(Write), obj.Value);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("BeginWrite : " + ex.Message);
                    }
                }
            }
        }

        public void Send(string msg, MyClient obj)
        {
            if (send == null || send.IsCompleted)
            {
                send = Task.Factory.StartNew(() => BeginWrite(msg, obj));
            }
            else
            {
                send.ContinueWith(antecendent => BeginWrite(msg, obj));
            }
        }

        public void Send(string msg, long id = -1)
        {
            if (send == null || send.IsCompleted)
            {
                send = Task.Factory.StartNew(() => BeginWrite(msg, id));
            }
            else
            {
                send.ContinueWith(antecendent => BeginWrite(msg, id));
            }
        }

        private void Disconnect(long id = -1) // disconnect everyone if ID is not supplied or is lesser than zero
        {
            if (disconnect == null || !disconnect.IsAlive)
            {
                disconnect = new Thread(() =>
                {
                    if (id >= 0)
                    {
                        clients.TryGetValue(id, out MyClient obj);
                        obj.client.Close();
                    }
                    else
                    {
                        foreach (KeyValuePair<long, MyClient> obj in clients)
                        {
                            obj.Value.client.Close();
                        }
                    }
                })
                {
                    IsBackground = true
                };
                disconnect.Start();
            }
        }

        private void StartServer()
        {
            if (active)
            {
                active = false;
            }
            else if (listener == null || !listener.IsAlive)
            {
                string hostName = Dns.GetHostName();

                // Get the IP from GetHostByName method of dns class.
                //IPHostEntry iPHostEntry = Dns.GetHostEntry(hostName);

                string address = "192.168.10.200";
                string number = "8789";
                bool error = false;
                IPAddress ip = null;

                try
                {
                    IPAddress[] ipA = Dns.GetHostEntry(hostName).AddressList;
                    ip = ipA[ipA.Length - 1];
                    Console.WriteLine(ip.ToString());
                    //ip = Dns.Resolve(address).AddressList[0];
                }
                catch
                {
                    error = true;
                    Console.WriteLine("Address is not valid");
                }

                int port = -1;
                error = !int.TryParse(number, out port);
                if (!error)
                {
                    listener = new Thread(() => Listener(ip, port))
                    {
                        IsBackground = true
                    };
                    listener.Start();
                }
            }
        }

        private void ClosingServer()
        {
            exit = true;
            active = false;
            Disconnect();
        }

        private void ShowPopup(string name)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.information;
            popup.BodyColor = Color.FromArgb(255, 193, 7);
            popup.TitleText = "Info";
            popup.TitleColor = Color.White;
            popup.TitleFont = new Font("Century Gothic", 15, FontStyle.Bold);

            popup.ContentText = name + " need an Assistant";
            popup.ContentColor = Color.White;
            popup.ContentFont = new Font("Century Gothic", 12);
            popup.Popup();
        }
        #endregion

        #endregion

        #region "Event"
        public event AlertHelpEventHandler AlertHelp;
        #endregion
    }
}
