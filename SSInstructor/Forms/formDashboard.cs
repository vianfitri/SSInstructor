using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSInstructor.Forms;
using SSInstructor.Class;

namespace SSInstructor
{
    public partial class formDashboard : Form
    {
        #region "Fields"
        formMain _parent;
        private Form activeForm = null;
        private DB mysqlDbConn = null;

        private bool isLogin = false;
        #endregion

        #region "Constructor"
        public formDashboard(formMain parent)
        {
            InitializeComponent();
            customizeDesign();
            this._parent = parent;
        }
        #endregion

        #region "Properties"
        public DB MySQLConn
        {
            get { return mysqlDbConn; }
            set { mysqlDbConn = value; }
        }

        public bool IsLogin
        {
            get { return isLogin; }
            set { isLogin = value; }
        }
        #endregion

        #region "Methods"
        private void customizeDesign()
        {
            pnlMasterDataSubmenu.Visible = false;
            pnlUserSubmenu.Visible = false;
        }

        private void hideSubmenu()
        {
            // Killl Another Application If Exist
            Process[] procs = Process.GetProcessesByName("ShipStability");
            foreach(Process proc in procs)
            {
                proc.Kill();
            }

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

        private void loadLoginInfo(string logId)
        {
            DataTable dtLoginInfo = new DataTable();
            string qrStr = "SELECT a.uc, " +
                "b.first_name, b.last_name, b.birthday, b.sex, b.email, b.photos, " +
                "c.typename " +
                "FROM shp_assets.ss_user a " +
                "INNER JOIN shp_assets.ss_subject b " +
                "ON a.uc_subject = b.uc " +
                "INNER JOIN shp_assets.ss_usertype c " +
                "ON b.type = c.id " +
                "WHERE a.uc = '" + logId + "' LIMIT 0, 1";

            if(mysqlDbConn.GetTableData(qrStr, ref dtLoginInfo))
            {
                lblUsername.Text = dtLoginInfo.Rows[0]["first_name"].ToString();
                lblPriviledge.Text = dtLoginInfo.Rows[0]["typename"].ToString();
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
            openChildForm(new fScenario(this));

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
                isLogin = false;
                this._parent.LoginId = "";
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
            MySQLConn = this._parent.DBConn;

            // fetch login user information
            string currentLogId = this._parent.LoginId;

            loadLoginInfo(currentLogId);

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
            openChildForm(new fInstructorData(this));

            hideSubmenu();
        }

        private void btnTrainee_Click(object sender, EventArgs e)
        {
            // Load Trainee Data
            openChildForm(new fTraineeData());

            hideSubmenu();
        }

        private void btnStability_Click(object sender, EventArgs e)
        {
            // Load Instructor Data
            openChildForm(new fSSS(this));

            hideSubmenu();
        }

        private void hiddenPannel_Click(object sender, EventArgs e)
        {
            // Load Instructor Data
            //openChildForm(new fSSS());

            //hideSubmenu();
        }

        private void hiddenPannel_Click_1(object sender, EventArgs e)
        {
            // Load Scenario Page
            openChildForm(new fFCStowPlan());

            hideSubmenu();
        }

        private void formDashboard_VisibleChanged(object sender, EventArgs e)
        {
            if(isLogin)
            {
                loadLoginInfo(this._parent.LoginId);
            }
        }
        #endregion


    }
}
