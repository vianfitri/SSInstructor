using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSInstructor.Models;
using SSInstructor.Class;

namespace SSInstructor.Forms
{
    public partial class fScenario : Form
    {
        #region "Fields"
        formDashboard _parent;
        #endregion

        #region "Constructor"
        public fScenario(formDashboard parent)
        {
            InitializeComponent();
            this._parent = parent;
        }
        #endregion

        #region "Properties"
        #endregion

        #region "Method"

        private void LoadScenList()
        {
            DataTable dtScenList = new DataTable();
            string qListScen = "SELECT * FROM `shp_assets`.`ss_scenario`";

            if(ConnectorDB.MySQLConn.GetTableData(qListScen, ref dtScenList))
            {
                dgv_ScenList.Rows.Clear();

                int idData = 0;
                foreach(DataRow row in dtScenList.Rows)
                {
                    string vessel_type = "";
                    if (row["vessel_type"].ToString() == "0")
                        vessel_type = "Bulk Carrier 50000 DWT";
                    else if (row["vessel_type"].ToString() == "1")
                        vessel_type = "General Cargo 3650 DWT";
                    else if (row["vessel_type"].ToString() == "2")
                        vessel_type = "Containership 4180 DWT";

                    idData++;
                    dgv_ScenList.Rows.Add(
                        new object[]
                        {
                            idData,
                            row["uc"],
                            row["scenario_name"],
                            row["db_name"],
                            vessel_type,
                            row["create_time"],
                            row["is_active"],
                            row["is_exist"],
                            null,
                            null
                        }
                    );
                }
            }
        }
        #endregion

        #region "Events"
        private void fScenario_Load(object sender, EventArgs e)
        {
            // load data scenario
            LoadScenList();
        }

        // Add Scenario
        private void btnDetail_Click(object sender, EventArgs e)
        {
            FormAddScen faddScen = new FormAddScen();
            faddScen.create();

            if (faddScen.DialogResult == DialogResult.OK)
            {
                LoadScenList();
            }
        }
        #endregion
    }
}
