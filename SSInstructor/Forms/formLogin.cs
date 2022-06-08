using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSInstructor
{
    public partial class formLogin : Form
    {
        Form _parent;

        public formLogin(Form parent)
        {
            InitializeComponent();
            this._parent = parent;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Proccess Authenticate

            // Goto Main Form

        }
    }
}
