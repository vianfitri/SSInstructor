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
            dummyTraineeData();
        }

        private void dummyTraineeData()
        {
            bdgv_Trainee.Rows.Add(
                new object[]
                {
                    1,
                    "122663782763",
                    "Muhammad Ramdan",
                    "ANT IV",
                    null,
                    null
                }
            );
            bdgv_Trainee.Rows.Add(
                new object[]
                {
                    2,
                    "784653648834",
                    "Ahmad Nugraha",
                    "ANT IV",
                    null,
                    null
                }
            );
            bdgv_Trainee.Rows.Add(
                new object[]
                {
                    3,
                    "122664566563",
                    "Budi Santosa",
                    "ANT IV",
                    null,
                    null
                }
            );
            bdgv_Trainee.Rows.Add(
                new object[]
                {
                    4,
                    "128878996763",
                    "Arif Rahman",
                    "ANT IV",
                    null,
                    null
                }
            );
            bdgv_Trainee.Rows.Add(
                new object[]
                {
                    5,
                    "1226638735763",
                    "Dovisioso Albert",
                    "ANT IV",
                    null,
                    null
                }
            );
        }

        private void btnAddTrainee_Click(object sender, EventArgs e)
        {
            Form fTraineeAdd = new fAddTrainee();
            fTraineeAdd.StartPosition = FormStartPosition.CenterParent;
            fTraineeAdd.ShowDialog();
        }
    }
}
