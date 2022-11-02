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
    public partial class fInstructorData : Form
    {
        #region "Fields"
        formDashboard _parent;
        private DB mysqlConn = null;
        int formMode = 0; // 0 = Add, 1 = Edit
        string idData = "";
        #endregion

        #region "Constructor"
        public fInstructorData(formDashboard parent)
        {
            InitializeComponent();
            this._parent = parent;
        }
        #endregion

        #region "Properties"
        public DB MySQLConn
        {
            get { return mysqlConn; }
            set { mysqlConn = value; }
        }
        #endregion

        #region "Method"
        private void fInstructorData_Load(object sender, EventArgs e)
        {
            // Set MySQL Connector
            MySQLConn = this._parent.MySQLConn;

            // Load Instructor List Data
            LoadInstructorListData();
        }

        // Load Instructor List Data
        private void LoadInstructorListData()
        {
            DataTable dtInstructor = new DataTable();
            string qListInst = "SELECT a.uc, " +
                "b.first_name, b.last_name, b.id_number, b.birthday, b.sex, b.email, b.photos, " +
                "c.typename " +
                "FROM shp_assets.ss_user a " +
                "INNER JOIN shp_assets.ss_subject b " +
                "ON a.uc_subject = b.uc " +
                "INNER JOIN shp_assets.ss_usertype c " +
                "ON b.type = c.id " +
                "WHERE b.type = 2";

            if(MySQLConn.GetTableData(qListInst, ref dtInstructor)){
                // Reset Rows First
                dgv_InstructorList.Rows.Clear();

                int iddata = 0;
                foreach(DataRow row in dtInstructor.Rows)
                {
                    iddata++;
                    dgv_InstructorList.Rows.Add(
                        new object[]{
                            iddata,
                            row["uc"],
                            row["id_number"],
                            row["first_name"],
                            row["email"],
                            row["sex"],
                            null,
                            null
                        }
                    );
                }
            }
        }


        private void btnAddInstructor_Click(object sender, EventArgs e)
        {
            formMode = 0;
            pnlAddInstructor.Dock = DockStyle.Fill;
            lblPnlAddEdit.Text = "Add Instructor";
            pnlAddInstructor.Visible = true;
        }

        private void dgv_InstructorList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_InstructorList.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Are you sure want to delete this instructor data?", "Delete Instructor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Delete Succesfully");
                }
            }

            if(dgv_InstructorList.Columns[e.ColumnIndex].Name == "Edit")
            {
                formMode = 1;
                int idCell = e.RowIndex;

                idData = dgv_InstructorList["instID", idCell].Value.ToString();
                txtName.Text = dgv_InstructorList["InstName", idCell].Value.ToString();
                txtNIP.Text = dgv_InstructorList["instNip", idCell].Value.ToString();
                txtEmail.Text = dgv_InstructorList["InstEmail", idCell].Value.ToString();
                if (dgv_InstructorList["Gender", idCell].Value.ToString() == "P")
                {
                    rbFemale.Checked = true;
                }
                else rbMale.Checked = true;
                lblPnlAddEdit.Text = "Edit Instructor";
                pnlAddInstructor.Dock = DockStyle.Fill;
                pnlAddInstructor.Visible = true;
            }
        }

        private void btnSaveInstructor_Click(object sender, EventArgs e)
        {
            // validate textbox
            if(string.IsNullOrEmpty(txtNIP.Text))
            {
                MessageBox.Show("NIP Number cannot be empty!", "Emplty NIP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNIP.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name cannot be empty!", "Emplty Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }
            string nip = txtNIP.Text;
            string name = txtName.Text;

            char gender = 'L';
            if (rbMale.Checked) gender = 'L';
            else if (rbFemale.Checked) gender = 'P';

            string email = txtEmail.Text;
            string qCombine = "";
            if (formMode == 0)
            {
                string ucgen = Utility.GenerateUC();
                string qInputInstructorSubject = "INSERT INTO shp_assets.ss_subject " +
                    "(`uc`, `first_name`, `id_number`, `sex`, `email`, `type`) " +
                    "VALUES ('" + ucgen + "', '" + name + "', '" + nip + "', '" + gender + "', '" + email + "', '2');";
                string qInputUserLogin = "INSERT INTO shp_assets.ss_user " +
                    "(`uc`, `u_name`, `u_pass`, `uc_subject`) " +
                    "VALUES ('" + ucgen + "', '" + nip + "', MD5('" + nip + "'), '" + ucgen + "');";
                qCombine = qInputInstructorSubject + qInputUserLogin;
            } 
            else if(formMode == 1)
            {
                string qUpdateSubject = "UPDATE shp_assets.ss_subject SET " +
                    "`first_name`='" + name + "', `id_number`='" + nip + "', `sex`='" + gender + "', `email`='" + email + "' " +
                    "WHERE `uc`='" + idData + "';";
                string qUpdateLogin = "UPDATE shp_assets.ss_user SET " +
                    "`u_name`='" + nip + "', `u_pass`= MD5('" + nip + "') " +
                    "WHERE `uc`='" + idData + "';";
                qCombine = qUpdateSubject + qUpdateLogin;
            }

            if (MySQLConn.SetCommand(qCombine))
            {
                pnlAddInstructor.Visible = false;
                txtName.Text = string.Empty;
                txtNIP.Text = string.Empty;
                txtEmail.Text = string.Empty;

                // Reload List Table
                LoadInstructorListData();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddInstructor.Visible = false;
            txtNIP.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            rbMale.Checked = true;
        }
        #endregion


    }
}
