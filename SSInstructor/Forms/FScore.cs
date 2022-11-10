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

        private void DummyDataBulk()
        {
            dgv_ScoreList.Rows.Clear();

            dgv_ScoreList.Rows.Add(
                new object[]
                {
                    1,
                    "ANT-123467-34",
                    "Budi Bastian",
                    100, // heel
                    100, // trim
                    100, // aft draft
                    100, // fwd draft
                    80, // time
                    100, // accomplished
                    96.6, // final
                    "Passed" // Status
                }
            );
            dgv_ScoreList.Rows.Add(
                new object[]
                {
                    2,
                    "ANT-435526-64",
                    "Heru Supardjo",
                    100, // heel
                    100, // trim
                    100, // aft draft
                    100, // fwd draft
                    80, // time
                    100, // accomplished
                    96.6, // final
                    "Passed" // Status
                }
            );
            dgv_ScoreList.Rows.Add(
                new object[]
                {
                    3,
                    "ANT-5678878-47",
                    "Siska Afrida",
                    100, // heel
                    100, // trim
                    100, // aft draft
                    100, // fwd draft
                    70, // time
                    100, // accomplished
                    95, // final
                    "Passed" // Status
                }
            );
        }

        private void DummyDataGencar()
        {
            dgv_ScoreList.Rows.Clear();

            dgv_ScoreList.Rows.Add(
                new object[]
                {
                    1,
                    "ANT-123467-34",
                    "Budi Bastian",
                    100, // heel
                    100, // trim
                    100, // aft draft
                    100, // fwd draft
                    70, // time
                    100, // accomplished
                    95, // final
                    "Passed" // Status
                }
            );
            dgv_ScoreList.Rows.Add(
                new object[]
                {
                    2,
                    "ANT-435526-64",
                    "Heru Supardjo",
                    100, // heel
                    100, // trim
                    100, // aft draft
                    100, // fwd draft
                    80, // time
                    100, // accomplished
                    96.6, // final
                    "Passed" // Status
                }
            );
            dgv_ScoreList.Rows.Add(
                new object[]
                {
                    3,
                    "ANT-5678878-47",
                    "Siska Afrida",
                    100, // heel
                    100, // trim
                    100, // aft draft
                    100, // fwd draft
                    70, // time
                    100, // accomplished
                    95, // final
                    "Passed" // Status
                }
            );
        }

        private void DummyDataCont()
        {
            dgv_ScoreList.Rows.Clear();

            dgv_ScoreList.Rows.Add(
                new object[]
                {
                    1,
                    "ANT-123467-34",
                    "Budi Bastian",
                    100, // heel
                    100, // trim
                    100, // aft draft
                    100, // fwd draft
                    70, // time
                    100, // accomplished
                    95, // final
                    "Passed" // Status
                }
            );
            dgv_ScoreList.Rows.Add(
                new object[]
                {
                    2,
                    "ANT-435526-64",
                    "Heru Supardjo",
                    100, // heel
                    100, // trim
                    100, // aft draft
                    100, // fwd draft
                    70, // time
                    100, // accomplished
                    95, // final
                    "Passed" // Status
                }
            );
            dgv_ScoreList.Rows.Add(
                new object[]
                {
                    3,
                    "ANT-5678878-47",
                    "Siska Afrida",
                    100, // heel
                    100, // trim
                    100, // aft draft
                    100, // fwd draft
                    70, // time
                    100, // accomplished
                    95, // final
                    "Passed" // Status
                }
            );
        }
        private void LoadTestResult(string ucScen)
        {
            DataTable dtTestResult = new DataTable();
            string qTestRes = "SELECT a.*, b.first_name FROM `shp_assets`.`ss_scoring` a " +
                "INNER JOIN `shp_assets`.`ss_subject` b " +
                "ON a.uc_student = b.uc " +
                "WHERE `uc_scenario` = '" + ucScen + "'";

            if(ConnectorDB.MySQLConn.GetTableData(qTestRes, ref dtTestResult))
            {
                dgv_ScoreList.Rows.Clear();

                int idx = 0;
                foreach(DataRow drow in dtTestResult.Rows)
                {
                    string status = "Failed";
                    idx++;

                    if (float.Parse(drow["final_score"].ToString()) >= 70)
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
                            drow["uc_student"].ToString(),
                            drow["first_name"].ToString(),
                            drow["angle_heel_score"],
                            drow["angle_trim_score"],
                            drow["draft_aft_score"],
                            drow["draft_fwd_score"],
                            drow["time_elapsed_score"],
                            drow["accomplished_score"],
                            drow["final_score"],
                            status
                        }
                    );
                }
            }
        }

        private void FScore_Load(object sender, EventArgs e)
        {
            // Load Scen Name List To Combobox
            LoadScenNameList();
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
        #endregion
    }
}
