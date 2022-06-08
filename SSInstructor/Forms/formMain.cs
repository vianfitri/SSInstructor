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
    public partial class formMain : Form
    {
        private Form activeForm = null;
        private String loginUsername = "";
        private int loginId = -1;

        public formMain()
        {
            InitializeComponent();
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
        #endregion

        #region Method

        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
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
                Form LoginForm = new formLogin(this);
                openChildForm(LoginForm);
            }
        }
    }
}
