using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using SSInstructor.Class;

namespace SSInstructor.Forms
{
    public partial class FormAddScen : Form
    {
        #region "Fields"
        #endregion

        #region "Constructor"
        public FormAddScen()
        {
            InitializeComponent();
        }
        #endregion

        #region "Properties"
        #endregion

        #region "Method"
        private void AddScenario()
        {
            string scen_name = txtScenarioName.Text;
            int vessel_type = cbVesselType.SelectedIndex;
            string db_scen_name = "ss_" + scen_name.ToLower().Replace(' ', '_') + "_" + DateTime.Now.ToString("yyyyMMdd");
            string db_from = "shp_master";
            string create_time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            string ucData = Utility.GenerateUC();

            // insert data to scenario table
            string qNewScen = "INSERT INTO `shp_assets`.`ss_scenario` " +
                "(`uc`, `scenario_name`, `db_name`, `vessel_type`, `create_time`, `is_active`, `is_exist`) VALUES " +
                "('"+ ucData +"', '"+ scen_name +"', '"+ db_scen_name +"', "+ vessel_type +", '"+ create_time +"', 0, 1);";

            if (ConnectorDB.MySQLConn.SetCommand(qNewScen))
            {
                // duplicate master data
                if (ConnectorDB.MySQLConn.DuplicateDB(db_from, db_scen_name))
                {
                    ParamsGlobal.CurrentScenario = txtScenarioName.Text;
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void FormAddScen_Load(object sender, EventArgs e)
        {
            btnScenSave.Enabled = IsNotEmptyTextName();
        }

        private void btnScenSave_Click(object sender, EventArgs e)
        {
            AddScenario();

            Close();
        }

        private void txtScenarioName_TextChanged(object sender, EventArgs e)
        {
            btnScenSave.Enabled = IsNotEmptyTextName();
        }

        private bool IsNotEmptyTextName()
        {
            return (txtScenarioName.Text != string.Empty);
        }

        public void create()
        {
            ShowDialog();
        }

        #endregion
    }
}
