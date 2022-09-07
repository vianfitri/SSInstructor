using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSInstructor.Class;

namespace SSInstructor.Forms
{
    public partial class formMain : Form
    {
        private Form activeForm = null;
        private String loginUsername = "";
        private int loginId = -1;
        private DB mysqlDbConn;
        public formLogin fLogin = null;
        public formDashboard fDash = null;

        public formMain()
        {
            InitializeComponent();
            fLogin = new formLogin(this);
            fDash = new formDashboard(this);
        }

        #region Properties
        public string LoginUsername {
            get { return loginUsername; }
            set { loginUsername = value; }
        }

        public int LoginId {
            get { return loginId; }
            set { loginId = value; }
        }

        public DB DBConn
        {
            get { return mysqlDbConn; }
            set { mysqlDbConn = value; }
        }
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
        #endregion

        private void formMain_Load(object sender, EventArgs e)
        {
            if(loginId == -1)
            {
               openChildForm(fLogin);
            }
        }
    }
}
