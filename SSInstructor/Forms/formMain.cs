using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Machines;
using SSInstructor.Class;

namespace SSInstructor.Forms
{
    public partial class formMain : Form
    {
        #region "Fields"

        private Form activeForm = null;
        public formLogin fLogin = null;
        public formDashboard fDash = null;
        private static Semaphore Pool = new Semaphore(0, 10);

        #endregion

        #region "Constructor"
        public formMain()
        {
            InitializeComponent();
            fLogin = new formLogin(this);
            fDash = new formDashboard(this);
        }
        #endregion

        #region Properties
        #endregion

        #region Method

        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                //activeForm.Dispose();
            }

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Clear();
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            // Get Screen Working Resolution
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            Console.WriteLine(string.Format("Screen Working Area : {0}x{1}",screenWidth,screenHeight));

            // Load PC Client List
            MachineModule.Machines.Load(Pool);
            MachineModule.Machines.Dirty = false;

            // Initiate ShutdownServer
            ShutdownServer.svrShutdown.StartServer();

            // Initialize Visual Server
            VisualServer.visualconn.StartServer();

            // Initialize API Client
            ApiHelper.InitializeClient();

            if (!UserController.isLogin)
            {
                openChildForm(fLogin);
            }
        }

        private void formMain_Shown(object sender, EventArgs e)
        {
            // Release PC Client Pool
            Pool.Release(10);
        }

        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save and Close PC Client
            MachineModule.Machines.Save();
            MachineModule.Machines.Close();
        }

        #endregion
    }
}
