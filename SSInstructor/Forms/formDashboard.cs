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
    public partial class formDashboard : Form
    {
        Form _parent;

        public formDashboard(Form parent)
        {
            InitializeComponent();
            customizeDesign();
            this._parent = parent;
        }

        private void customizeDesign()
        {
            pnlMasterDataSubmenu.Visible = false;
            pnlUserSubmenu.Visible = false;
        }

        private void hideSubmenu()
        {
            if (pnlMasterDataSubmenu.Visible) pnlMasterDataSubmenu.Visible = false;
            if (pnlUserSubmenu.Visible) pnlUserSubmenu.Visible = false;
        }

        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnMasterData_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlMasterDataSubmenu);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlUserSubmenu);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {

        }

        private void btnScenario_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnClientList_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void roundedTextBox1__TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Text Changed");
        }
    }
}
