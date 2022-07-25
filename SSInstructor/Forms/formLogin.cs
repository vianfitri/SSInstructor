using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSInstructor.Forms;

namespace SSInstructor
{
    public partial class formLogin : Form
    {
        formMain _parent;

        public formLogin(formMain parent)
        {
            InitializeComponent();
            this._parent = parent;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Proccess Authenticate
            if(string.IsNullOrEmpty(txtUsername.Texts))
            {
                MessageBox.Show("Please insert 'USERNAME'!", "Info...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsername.Select();
                txtUsername.Focus();
                return;
            }

            if(string.IsNullOrEmpty(txtPassword.Texts))
            {
                MessageBox.Show("Please Insert 'PASSWORD'!", "Info...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Select();
                txtPassword.Focus();
                return;
            }

            this.Cursor = Cursors.WaitCursor;

            // Check MySQL State


            // Goto Main Form if success
            this._parent.openChildForm(this._parent.fDash);

        }

    }
}
