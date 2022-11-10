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
                DummyDataBulk();
            }
            else if(vessel_type == 1)
            {
                lblVesselType.Text = "General Cargo 3650 DWT";
                DummyDataGencar();
            }
            else if(vessel_type == 2)
            {
                lblVesselType.Text = "Container 4180 DWT";
                DummyDataCont();
            }
        }
        #endregion
    }
}
