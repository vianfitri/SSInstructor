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
    public partial class fCargoData : Form
    {
        public fCargoData()
        {
            InitializeComponent();
        }

        private void fCargoData_Load(object sender, EventArgs e)
        {
            dummyCargoData();
        }

        private void dummyCargoData()
        {
            bdgv_cargo.Rows.Add(
                new object[]
                {
                    1,
                    "Grain",
                    "1500 TON",
                    "4500 TMT",
                    "edit - delete"
                }
            );

            bdgv_cargo.Rows.Add(
                new object[]
                {
                    2,
                    "Coal",
                    "3500 TON",
                    "5500 TMT",
                    "edit - delete"
                }
            );
        }
    }
}
