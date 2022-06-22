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
        public fInstructorData()
        {
            InitializeComponent();
        }

        private void fInstructorData_Load(object sender, EventArgs e)
        {
            dummyInstructorData();
        }

        private void dummyInstructorData()
        {
            bdgv_Instructor.Rows.Add(
                new object[]
                {
                    1,
                    "789648399",
                    "Dodi Sudrajat",
                    "-",
                    "edit - delete"
                }
            );
            bdgv_Instructor.Rows.Add(
                new object[]
                {
                    2,
                    "5647366647",
                    "Heru Herlambang",
                    "-",
                    "edit - delete"
                }
            );
            bdgv_Instructor.Rows.Add(
                new object[]
                {
                    3,
                    "9837638899",
                    "Elvin Mudhita",
                    "-",
                    "edit - delete"
                }
            );
            bdgv_Instructor.Rows.Add(
                new object[]
                {
                    4,
                    "87736527726",
                    "Bayu Sudjatmiko",
                    "-",
                    "edit - delete"
                }
            );
        }

        private void btnAddInstructor_Click(object sender, EventArgs e)
        {
            ModalPopup popup = new ModalPopup();
            popup.Init(this.FindForm().FindForm(), new Label() { Text = "PopUp Test" });
            popup.ShowPopup();
        }
    }
}
