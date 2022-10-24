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
    public partial class FormAddScen : Form
    {
        public FormAddScen()
        {
            InitializeComponent();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtScenName.Texts))
            {
                MessageBox.Show("Scenario Name Cannot be empty");
                txtScenName.Focus();
            }
        }
    }
}
