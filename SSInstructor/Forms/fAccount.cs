﻿using System;
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
    public partial class fAccount : Form
    {
        public fAccount()
        {
            InitializeComponent();
        }

        private void fAccount_Load(object sender, EventArgs e)
        {
            dummyAccountData();
        }

        private void dummyAccountData()
        {
            bdgv_account.Rows.Add(
                new object[]
                {
                    1,
                    "admintech",
                    "admintech",
                    "******",
                    "edit - delete"
                }
            );
        }
    }
}
