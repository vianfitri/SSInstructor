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

            // Goto Main Form if success
            this._parent.openChildForm(this._parent.fDash);

        }
    }
}
