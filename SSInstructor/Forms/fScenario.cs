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
        private void LoadExercise()
        {
            string qExerc = "SELECT * FROM `shp_assets`.`ss_exercise` WHERE uc = '111-11111-11'";
            int exerciseMode = 0;
            
            if(ConnectorDB.MySQLConn.GetData(qExerc, "mode", ref exerciseMode))
            {
                if(exerciseMode == 0)
                {
                    rbTraining.Checked = true;
                }
                else if(exerciseMode == 1)
                {
                    rbTest.Checked = true;
                }
            }
        }

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

                    Bitmap status = null;
                    if (Convert.ToInt32(row["is_active"]) == 0)
                    {
                        status = Properties.Resources.inactive;
                    }
                    else if(Convert.ToInt32(row["is_active"]) == 1)
                    { 
                        status = Properties.Resources.active;
                    }

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
                            status,
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
            // Load Exercise Mode
            LoadExercise();

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

        private void rbTraining_CheckedChanged(object sender, EventArgs e)
        {
            if(rbTraining.Checked == true)
            {
                cbVesselSelect.SelectedIndex = ExerciseController.VesselType;
                if (ConnectorDB.MySQLConn.SetCommand("UPDATE `shp_assets`.`ss_exercise` SET mode = 0 WHERE uc = '111-11111-11'"))
                {
                    ExerciseController.EMode = ExerciseController.ExerciseMode.Training;
                    lblVesselSelect.Visible = true;
                    cbVesselSelect.Visible = true;
                }

            }
        }

        private void rbTest_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTest.Checked == true)
            {
                if (ConnectorDB.MySQLConn.SetCommand("UPDATE `shp_assets`.`ss_exercise` SET mode = 1 WHERE uc = '111-11111-11'"))
                {
                    ExerciseController.EMode = ExerciseController.ExerciseMode.Test;
                    cbVesselSelect.SelectedIndex = 0;
                    lblVesselSelect.Visible = false;
                    cbVesselSelect.Visible = false;
                }
            }
        }

        private void cbVesselSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExerciseController.VesselType = cbVesselSelect.SelectedIndex;
        }

        private void dgv_ScenList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Use for setting scenario
            string ucScen = dgv_ScenList["scenid", e.RowIndex].Value.ToString();
            string dbName = dgv_ScenList["dbname", e.RowIndex].Value.ToString();

            // get vessel type
            string qScen = "SELECT * FROM `shp_assets`.`ss_scenario` WHERE uc = '" + ucScen + "'";
            int vessel_type = 0;

            if (ConnectorDB.MySQLConn.GetData(qScen, "vessel_type", ref vessel_type))
            {
                ExerciseController.CurrentUCScen = ucScen;
                ExerciseController.CurrentDBName = dbName;
                ExerciseController.VesselType = vessel_type;
                ExerciseController.Reason = 1;
                this._parent.btnStability_Click(null, null);
            }
        }
        #endregion


    }
}
