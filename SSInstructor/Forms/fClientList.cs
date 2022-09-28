using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Machines;
using SSInstructor.Class;

namespace SSInstructor.Forms
{
    public partial class fClientList : Form
    {
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
        #endregion
    }
}
