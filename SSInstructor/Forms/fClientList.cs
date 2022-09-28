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
        public static void StatusChange(string hostname, Machine.StatusCodes status, string IPAddress)
        {
            Console.WriteLine("Hostname : " + hostname + " => Status : " + status + " => IP Address : " + IPAddress);
        }
        
        private void SaveChanges()
        {
            MachineModule.Machines.Save();
            MachineModule.Machines.Close();
        }

        private void fClientList_Load(object sender, EventArgs e)
        {
            MachineModule.Machines.Load(Pool);
            MachineModule.Machines.Dirty = false;
        }

        private void fClientList_Shown(object sender, EventArgs e)
        {
            Pool.Release(10);
        }
        #endregion
    }
}
