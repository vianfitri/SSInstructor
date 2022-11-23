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
    public partial class FScore : Form
    {

        #region "Fields"
        DataTable dtScenList = new DataTable();
        SSReport rpt;
        int rowIdSelected = 0;
        #endregion

        #region "Constructor"
        public FScore()
        {
            InitializeComponent();
        }
        #endregion

        #region "Properties"
        #endregion

        #region "Method"
        private void LoadScenNameList()
        {
            string qScenName = "SELECT * FROM `shp_assets`.`ss_scenario`";

            if (ConnectorDB.MySQLConn.GetTableData(qScenName, ref dtScenList))
            {
                foreach(DataRow drow in dtScenList.Rows)
                {
                    cbScenName.Items.Add(drow["scenario_name"].ToString());
                }
            }
        }

        private void LoadTestResult(string ucScen)
        {
            btnPrint.Enabled = false;

            DataTable dtTestResult = new DataTable();
            string qTestRes = "SELECT a.*, b.first_name, b.id_number FROM `shp_assets`.`ss_scoring` a " +
                "INNER JOIN `shp_assets`.`ss_subject` b " +
                "ON a.uc_student = b.uc " +
                "WHERE `uc_scenario` = '" + ucScen + "'";

            if(ConnectorDB.MySQLConn.GetTableData(qTestRes, ref dtTestResult))
            {
                dgv_ScoreList.Rows.Clear();

                int idx = 0;
                foreach(DataRow drow in dtTestResult.Rows)
                {
                    idx++;

                    // calculate score
                    float objPayloadPos_score = 0;
                    float WeightBalance_score = 0;
                    float RollPitch_score = 0;
                    float accomplished_score = 0;
                    float decisioMaking_score = 0;
                    float vol_dim_score = 0;
                    float final_score = 0;
                    string status = "Failed";

                    float heel = float.Parse(drow["angle_heel"].ToString());
                    float trim = float.Parse(drow["angle_trim"].ToString());

                    // Obj Payload Pos Score
                    if(heel < 1 && trim < 1)
                    {
                        objPayloadPos_score = 100;
                    } 
                    else if(heel >= 1 && heel < 2 && trim >= 1 && trim < 2)
                    {
                        objPayloadPos_score = 80;
                    } 
                    else if(heel >= 2 && heel < 3 && trim >= 2 && trim < 3)
                    {
                        objPayloadPos_score = 70;
                    } 
                    else
                    {
                        objPayloadPos_score = 60;
                    }

                    // Weight balance score
                    if (heel < 1 && trim < 1)
                    {
                        WeightBalance_score = 100;
                    }
                    else if (heel >= 1 && heel < 2 && trim >= 1 && trim < 2)
                    {
                        WeightBalance_score = 80;
                    }
                    else if (heel >= 2 && heel < 3 && trim >= 2 && trim < 3)
                    {
                        WeightBalance_score = 70;
                    }
                    else
                    {
                        WeightBalance_score = 60;
                    }

                    // Roll Pitch Score
                    float angle_heel_score = float.Parse(drow["angle_heel_score"].ToString());
                    float angle_trim_score = float.Parse(drow["angle_trim_score"].ToString());

                    RollPitch_score = (angle_heel_score + angle_trim_score) / 2;

                    // accomplished score
                    if (bool.Parse(drow["is_accomplished"].ToString()) == true)
                    {
                        accomplished_score = 100;
                    }

                    // decision making score
                    decisioMaking_score = float.Parse(drow["time_elapsed_score"].ToString());

                    // voldim score
                    float drAftScr = float.Parse(drow["draft_aft_score"].ToString());
                    float drFwdScr = float.Parse(drow["draft_fwd_score"].ToString());
                    vol_dim_score = (drAftScr + drFwdScr) / 2;

                    // final score
                    final_score = (objPayloadPos_score + WeightBalance_score + RollPitch_score + accomplished_score + decisioMaking_score + vol_dim_score) / 6;

                    // status
                    if (final_score >= 70)
                    {
                        if (bool.Parse(drow["is_accomplished"].ToString()) == true)
                        {
                            status = "Passed";
                        }
                        else
                        {
                            status = "Failed";
                        }
                    }

                    dgv_ScoreList.Rows.Add(
                        new object[]
                        {
                            idx,
                            drow["id_number"].ToString(),
                            drow["first_name"].ToString(),
                            objPayloadPos_score,
                            WeightBalance_score,
                            RollPitch_score,
                            accomplished_score,
                            decisioMaking_score,
                            vol_dim_score,
                            final_score,
                            status
                        }
                    );
                }

                if(idx > 0)
                {
                    btnPrint.Enabled = true;
                }
            }
        }

        private void FScore_Load(object sender, EventArgs e)
        {
            // Load Scen Name List To Combobox
            LoadScenNameList();

            // set default index for combobox
            cbScenName.SelectedIndex = 0;

            // Report Test
            rpt = new SSReport();
        }

        private void cbScenName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int vessel_type = int.Parse(dtScenList.Rows[cbScenName.SelectedIndex]["vessel_type"].ToString());

            if(vessel_type == 0)
            {
                lblVesselType.Text = "Bulk Carrier 50000 DWT";
            }
            else if(vessel_type == 1)
            {
                lblVesselType.Text = "General Cargo 3650 DWT";
            }
            else if(vessel_type == 2)
            {
                lblVesselType.Text = "Container 4180 DWT";
            }

            LoadTestResult(dtScenList.Rows[cbScenName.SelectedIndex]["uc"].ToString());
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // reload test result to datatable
            DataTable dtTestResult = new DataTable();
            string qTestRes = "SELECT a.*, b.first_name, b.id_number FROM `shp_assets`.`ss_scoring` a " +
                "INNER JOIN `shp_assets`.`ss_subject` b " +
                "ON a.uc_student = b.uc " +
                "WHERE `uc_scenario` = '" + dtScenList.Rows[cbScenName.SelectedIndex]["uc"].ToString() + "'";

            rpt.ReportLogo = Properties.Resources.PIP_SEMARANG_LOGO;
            rpt.PrintingIcon = this.Icon;
            rpt.ScenName = cbScenName.Items[cbScenName.SelectedIndex].ToString();
            rpt.TypeVessel = int.Parse(dtScenList.Rows[cbScenName.SelectedIndex]["vessel_type"].ToString());
            rpt.RowId = rowIdSelected;
            if(ConnectorDB.MySQLConn.GetTableData(qTestRes, ref dtTestResult))
            {
                rpt.TableScore = dtTestResult;
            }
            rpt.ShowReport();
        }

        private void dgv_ScoreList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIdSelected = e.RowIndex;
        }
        #endregion


    }
}
