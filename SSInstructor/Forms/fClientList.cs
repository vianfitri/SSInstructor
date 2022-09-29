using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Machines;
using SSInstructor.Class;
using SSInstructor.Controls;

namespace SSInstructor.Forms
{
    public partial class fClientList : Form
    {
        #region "Fields"
        public static Semaphore Pool = new Semaphore(0, 10);
        #endregion

        #region "Constructor"
        public fClientList()
        {
            InitializeComponent();
        }
        #endregion

        #region "Method"
        public void StatusChange(string hostname, Machine.StatusCodes status, string IPAddress)
        {
            Console.WriteLine("Hostname : " + hostname + " => Status : " + status + " => IP Address : " + IPAddress);

            foreach(ClientPanel clientObj in flowLayoutPanel1.Controls)
            {
                if(clientObj.PcName == hostname)
                {
                    if (status == Machine.StatusCodes.Online)
                    {
                        clientObj.PowerState = true;
                    }
                    else
                        clientObj.PowerState = false;
                    return;
                }
            }
        }
        
        private void SaveChanges()
        {
            //MachineModule.Machines.Save();
            //MachineModule.Machines.Close();
        }

        private void fClientList_Load(object sender, EventArgs e)
        {
            // populate client list and create control
            if (MachineModule.Machines.Count > 0)
            {
                RegisterHandle();

                PopulateClient();

                flowLayoutPanel1.Invalidate();
            }
        }

        private void fClientList_Shown(object sender, EventArgs e)
        {
            //Pool.Release(10);
        }
        
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            // Unregister Client Handle
            UnregisterHandle();

            ClientProperties cp = new ClientProperties();
            cp.Create();

            if (cp.DialogResult == DialogResult.OK)
            {
                // Clear flowLayoutPanel Child Control
                flowLayoutPanel1.Controls.Clear();

                // Register Client Handle
                RegisterHandle();

                // Populate Client List
                PopulateClient();

                flowLayoutPanel1.Invalidate();

                cp.Dispose();

                return;
            }

            RegisterHandle();
        }

        private void fClientList_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Unload Event Handler for Machine
            UnregisterHandle();

            flowLayoutPanel1.Controls.Clear();
        }

        private void UnregisterHandle()
        {
            foreach(Machine machine in MachineModule.Machines)
            {
                machine.StatusChange -= StatusChange;
            }
        }

        private void RegisterHandle()
        {
            foreach(Machine machine in MachineModule.Machines)
            {
                machine.StatusChange += StatusChange;
            }
        }

        private void PopulateClient()
        {
            foreach (Machine machine in MachineModule.Machines)
            {
                ClientPanel clientObj = new ClientPanel();

                clientObj.IpAddress = machine.IP;
                clientObj.MacAddress = machine.MAC;
                clientObj.PcName = machine.Name;
                clientObj.Margin = new Padding(40, 40, 40, 40);
                clientObj.BorderStyle = BorderStyle.FixedSingle;

                if (machine.Status == Machine.StatusCodes.Online)
                    clientObj.PowerState = true;

                flowLayoutPanel1.Controls.Add(clientObj);
            }
        }

        private void btnWakeUpAll_Click(object sender, EventArgs e)
        {
            foreach(ClientPanel cp in flowLayoutPanel1.Controls)
            {
                Networking.Wake(cp.MacAddress);
                Application.DoEvents();
                Thread.Sleep(750);
            }
        }
        #endregion


    }
}
