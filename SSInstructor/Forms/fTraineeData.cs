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

namespace SSInstructor.Forms
{
    public partial class fTraineeData : Form
    {
        #region "Fields"
        int formMode = 0; // 0 = Add, 1 = Edit
        string idData = "";
        #endregion

        #region "Constructor"
        public fTraineeData()
        {
            InitializeComponent();
        }
        #endregion

        #region "Properties"
        #endregion

        #region "Method"
        private void fTraineeData_Load(object sender, EventArgs e)
        {
            // Load Trainee List Data
            LoadTraineeListData();
        }

        private void btnAddTrainee_Click(object sender, EventArgs e)
        {
            formMode = 0;
            pnlAddTrainee.Dock = DockStyle.Fill;
            lblPnlAddEdit.Text = "Add Trainee";
            pnlAddTrainee.Visible = true;
        }

        private void dgv_TraineeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idCell = e.RowIndex;
            if (dgv_TraineeList.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Are you sure want to delete this trainee data?", "Delete Trainee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RemoveData(dgv_TraineeList["TraineeID", idCell].Value.ToString());
                }
            }

            if (dgv_TraineeList.Columns[e.ColumnIndex].Name == "Edit")
            {
                formMode = 1;

                idData = dgv_TraineeList["TraineeID", idCell].Value.ToString();
                txtName.Text = dgv_TraineeList["TraineeName", idCell].Value.ToString();
                txtNIT.Text = dgv_TraineeList["TraineeNIT", idCell].Value.ToString();
                txtEmail.Text = dgv_TraineeList["TraineeEmail", idCell].Value.ToString();
                if (dgv_TraineeList["Gender", idCell].Value.ToString() == "P")
                {
                    rbFemale.Checked = true;
                }
                else rbMale.Checked = true;
                lblPnlAddEdit.Text = "Edit Trainee";
                dgv_TraineeList.Dock = DockStyle.Fill;
                pnlAddTrainee.Visible = true;
            }
        }

        private void LoadTraineeListData()
        {
            DataTable dtTrainee = new DataTable();
            string qListTrainee = "SELECT a.uc, " +
                "b.first_name, b.last_name, b.id_number, b.birthday, b.sex, b.email, b.photos, " +
                "c.typename " +
                "FROM shp_assets.ss_user a " +
                "INNER JOIN shp_assets.ss_subject b " +
                "ON a.uc_subject = b.uc " +
                "INNER JOIN shp_assets.ss_usertype c " +
                "ON b.type = c.id " +
                "WHERE b.type = 3";

            if (ConnectorDB.MySQLConn.GetTableData(qListTrainee, ref dtTrainee))
            {
                // Reset Rows First
                dgv_TraineeList.Rows.Clear();

                int iddata = 0;
                foreach (DataRow row in dtTrainee.Rows)
                {
                    iddata++;
                    dgv_TraineeList.Rows.Add(
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

        private void btnSaveTrainee_Click(object sender, EventArgs e)
        {
            // validate textbox
            if (string.IsNullOrEmpty(txtNIT.Text))
            {
                MessageBox.Show("NIT Number cannot be empty!", "Emplty NIP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNIT.Focus();
                return;
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    MessageBox.Show("Name cannot be empty!", "Emplty Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtName.Focus();
                    return;
                }
                string nit = txtNIT.Text;
                string name = txtName.Text;

                char gender = 'L';
                if (rbMale.Checked) gender = 'L';
                else if (rbFemale.Checked) gender = 'P';

                string email = txtEmail.Text;
                string qCombine = "";
                if (formMode == 0)
                {
                    string ucgen = Utility.GenerateUC();
                    string qInputTraineeSubject = "INSERT INTO shp_assets.ss_subject " +
                        "(`uc`, `first_name`, `id_number`, `sex`, `email`, `type`) " +
                        "VALUES ('" + ucgen + "', '" + name + "', '" + nit + "', '" + gender + "', '" + email + "', '3');";
                    string qInputUserLogin = "INSERT INTO shp_assets.ss_user " +
                        "(`uc`, `u_name`, `u_pass`, `uc_subject`) " +
                        "VALUES ('" + ucgen + "', '" + nit + "', MD5('" + nit + "'), '" + ucgen + "');";
                    qCombine = qInputTraineeSubject + qInputUserLogin;
                }
                else if (formMode == 1)
                {
                    string qUpdateSubject = "UPDATE shp_assets.ss_subject SET " +
                        "`first_name`='" + name + "', `id_number`='" + nit + "', `sex`='" + gender + "', `email`='" + email + "' " +
                        "WHERE `uc`='" + idData + "';";
                    string qUpdateLogin = "UPDATE shp_assets.ss_user SET " +
                        "`u_name`='" + nit + "', `u_pass`= MD5('" + nit + "') " +
                        "WHERE `uc`='" + idData + "';";
                    qCombine = qUpdateSubject + qUpdateLogin;
                }

                if (ConnectorDB.MySQLConn.SetCommand(qCombine))
                {
                    pnlAddTrainee.Visible = false;
                    txtName.Text = string.Empty;
                    txtNIT.Text = string.Empty;
                    txtEmail.Text = string.Empty;

                    // Reload List Table
                    LoadTraineeListData();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddTrainee.Visible = false;
            txtNIT.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            rbMale.Checked = true;
        }

        private void RemoveData(string ucId)
        {
            string qDeleteSubject = "DELETE FROM `shp_assets`.`ss_subject` WHERE `uc`='" + ucId + "';";
            string qDeleteUser = "DELETE FROM `shp_assets`.`ss_user` WHERE `uc`='" + ucId + "';";
            string qCombine = qDeleteSubject + qDeleteUser;

            if (ConnectorDB.MySQLConn.SetCommand(qCombine))
            {
                MessageBox.Show("Trainee data deleted successfully!!!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
