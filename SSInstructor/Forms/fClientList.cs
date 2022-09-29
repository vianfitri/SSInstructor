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
                if(clientObj.PcName == hostname && clientObj.IpAddress == IPAddress)
                {
                    if (status == Machine.StatusCodes.Online)
                    {
                        clientObj.PowerState = true;
                    }
                    else
                        clientObj.PowerState = false;
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
            //MachineModule.Machines.Load(Pool);
            //MachineModule.Machines.Dirty = false;

            // populate client list and create control
            if (MachineModule.Machines.Count > 0)
            {
                foreach (Machine machine in MachineModule.Machines)
                {
                    ClientPanel clientObj = new ClientPanel();

                    machine.StatusChange += StatusChange;

                    clientObj.IpAddress = machine.IP;
                    clientObj.MacAddress = machine.MAC;
                    clientObj.PcName = machine.Name;
                    clientObj.Margin = new Padding(40, 40, 40, 40);

                    flowLayoutPanel1.Controls.Add(clientObj);
                }

                flowLayoutPanel1.Invalidate();
            }
        }

        private void fClientList_Shown(object sender, EventArgs e)
        {
            //Pool.Release(10);
        }
        #endregion

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            ClientProperties cp = new ClientProperties();
            cp.Create();

            if (cp.DialogResult == DialogResult.OK)
                Console.WriteLine("Add Client Success");

            cp.Dispose();
        }
    }
}
