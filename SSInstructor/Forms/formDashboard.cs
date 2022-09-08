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
using SSInstructor.Class;

namespace SSInstructor
{
    public partial class formDashboard : Form
    {
        formMain _parent;
        private Form activeForm = null;
        private DB mysqlDbConn;

        public formDashboard(formMain parent)
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

        private void loadLoginInfo(int logId)
        {
            DataTable dtLoginInfo = null;
            string qrStr = "SELECT a.idss_user, " +
                "b.first_name, b.last_name, b.birthday, b.sex, b.email, b.photos, " +
                "c.typename " +
                "FROM shp_stability.ss_user a " +
                "INNER JOIN shp_stability.ss_subject b " +
                "ON a.id_subject = b.idsubject " +
                "INNER JOIN shp_stability.ss_usertype c " +
                "ON b.type = c.id " +
                "WHERE a.idss_user = " + logId + " LIMIT 0, 1";

            if(mysqlDbConn.GetTableData(qrStr, ref dtLoginInfo))
            {

            }
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
            // Load Account Data
            openChildForm(new fAccount());

            hideSubmenu();
        }

        private void btnScenario_Click(object sender, EventArgs e)
        {
            // Load Scenario Page
            openChildForm(new fLoadPos());

            hideSubmenu();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            // Load Report Page
            openChildForm(new fBCStowPlan());

            hideSubmenu();
        }

        private void btnClientList_Click(object sender, EventArgs e)
        {
            // Load Client List
            openChildForm(new fClientList());

            hideSubmenu();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            // Load Setting Page
            openChildForm(new fSetting());

            hideSubmenu();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to logout ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this._parent.LoginId = -1;
                this._parent.openChildForm(this._parent.fLogin);
                openChildForm(new formWelcome());
            }
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void formDashboard_Load(object sender, EventArgs e)
        {
            // Load default content
            openChildForm(new formWelcome());

            // set mysql data connector
            mysqlDbConn = this._parent.DBConn;

            // fetch login user information
            int currentLogId = this._parent.LoginId;

            MessageBox.Show("LogId : " + this._parent.LoginId.ToString());
            hideSubmenu();
        }

        private void btnShipData_Click(object sender, EventArgs e)
        {
            // Load Ship Data
            openChildForm(new fShipData());

            hideSubmenu();
        }

        private void btnCargoData_Click(object sender, EventArgs e)
        {
            // Load Cargo Data
            openChildForm(new fCargoData());

            hideSubmenu();
        }

        private void btnInstructor_Click(object sender, EventArgs e)
        {
            // Load Instructor Data
            openChildForm(new fInstructorData());

            hideSubmenu();
        }

        private void btnTrainee_Click(object sender, EventArgs e)
        {
            // Load Trainee Data
            openChildForm(new fTraineeData());

            hideSubmenu();
        }
    }
}
