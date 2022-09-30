using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSInstructor.Forms
{
    public partial class fSSS : Form
    {
        #region "Fields"
        #endregion

        #region "Constructor"
        public fSSS()
        {
            InitializeComponent();
        }
        #endregion

        #region "Properties"
        #endregion

        #region "Method"
        private void fSSS_Load(object sender, EventArgs e)
        {
            StabilityCalculator.LoadConfiguration(Application.StartupPath + "\\Data\\BC.cfg");


        }
        #endregion
    }
}
