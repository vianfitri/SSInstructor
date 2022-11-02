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

namespace SSInstructor.Forms
{
    public partial class fTraineeData : Form
    {
        public fTraineeData()
        {
            InitializeComponent();
        }

        private void fTraineeData_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAddTrainee_Click(object sender, EventArgs e)
        {
            Form fTraineeAdd = new fAddTrainee();
            fTraineeAdd.StartPosition = FormStartPosition.CenterParent;
            fTraineeAdd.ShowDialog();
        }

        private void dgv_TraineeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_TraineeList.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Are you sure want to delete this trainee data?", "Delete Trainee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Delete Succesfully");
                }
            }
        }
    }
}
