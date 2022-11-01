﻿using System;
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
            string qListInst = "SELECT a.idss_user, " +
                "b.first_name, b.last_name, b.id_number, b.birthday, b.sex, b.email, b.photos, " +
                "c.typename " +
                "FROM shp_assets.ss_user a " +
                "INNER JOIN shp_assets.ss_subject b " +
                "ON a.id_subject = b.idsubject " +
                "INNER JOIN shp_assets.ss_usertype c " +
                "ON b.type = c.id " +
                "WHERE b.type = 2";

            if(MySQLConn.GetTableData(qListInst, ref dtInstructor)){
                // Reset Rows First
                bdgv_Instructor.Rows.Clear();

                int iddata = 0;
                foreach(DataRow row in dtInstructor.Rows)
                {
                    iddata++;
                    bdgv_Instructor.Rows.Add(
                        new object[]{
                            iddata,
                            row["idss_user"],
                            row["id_number"],
                            row["first_name"],
                            null,
                            null
                        }
                    );
                }
            }
        }

        private void dummyInstructorData()
        {
            bdgv_Instructor.Rows.Add(
                new object[]
                {
                    1,
                    "19781217 200512 2 001",
                    "Dodi Sudrajat",
                    "-",
                    null,
                    null
                }
            );
            bdgv_Instructor.Rows.Add(
                new object[]
                {
                    2,
                    "19881217 180512 1 003",
                    "Heru Herlambang",
                    "-",
                    null,
                    null
                }
            );
            bdgv_Instructor.Rows.Add(
                new object[]
                {
                    3,
                    "19781312 190512 2 002",
                    "Elvin Mudhita",
                    "-",
                    null,
                    null
                }
            );
            bdgv_Instructor.Rows.Add(
                new object[]
                {
                    4,
                    "19861347 182312 1 003",
                    "Bayu Sudjatmiko",
                    "-",
                    null,
                    null
                }
            );
        }

        private void btnAddInstructor_Click(object sender, EventArgs e)
        {
            Form fInstAdd = new fAddInstructor();
            fInstAdd.StartPosition = FormStartPosition.CenterParent;
            fInstAdd.ShowDialog();
        }

        private void bdgv_Instructor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bdgv_Instructor.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Are you sure want to delete this instructor data?", "Delete Instructor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Delete Succesfully");
                }
            }
        }

        // Merge Column Action
        /*
        private void bdgv_Instructor_Paint(object sender, PaintEventArgs e)
        {
            //Offsets to adjust the position of the merged Header.
            int heightOffset = -1;
            int widthOffset = -1;
            int xOffset = 0;
            int yOffset = 1;

            //Index of Header column from where the merging will start.
            int columnIndex = 4;

            //Number of Header columns to be merged.
            int columnCount = 2;

            //Get the position of the Header Cell.
            Rectangle headerCellRectangle = bdgv_Instructor.GetCellDisplayRectangle(columnIndex, 0, true);

            //X coordinate of the merged Header Column.
            int xCord = headerCellRectangle.Location.X + xOffset;

            //Y coordinate of the merged Header Column.
            int yCord = headerCellRectangle.Location.Y - headerCellRectangle.Height + yOffset;

            //Calculate Width of merged Header Column by adding the widths of all Columns to be merged.
            int mergedHeaderWidth = bdgv_Instructor.Columns[columnIndex].Width + bdgv_Instructor.Columns[columnIndex + columnCount - 1].Width + widthOffset;

            //Generate the merged Header Column Rectangle.
            Rectangle mergedHeaderRect = new Rectangle(xCord, yCord, mergedHeaderWidth, headerCellRectangle.Height + heightOffset);

            //Draw the merged Header Column Rectangle.
            e.Graphics.FillRectangle(new SolidBrush(bdgv_Instructor.ColumnHeadersDefaultCellStyle.BackColor), mergedHeaderRect);

            //Draw the merged Header Column Text.
            e.Graphics.DrawString("Action", bdgv_Instructor.ColumnHeadersDefaultCellStyle.Font, Brushes.Black, xCord + 2, yCord + 3);

        }
        */
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

            int gender = 0;
            if (rbMale.Checked) gender = 0;
            else if (rbFemale.Checked) gender = 1;

            string email = txtEmail.Text;
            
            string qInputInstructor = "INSERT INTO ss_assets."
        }
        #endregion


    }
}
