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
            string db_scen_name = "ss_" + scen_name.ToLower().Replace(' ', '_') + DateTime.Now.ToString("yyyyMMdd");
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

                }
            }
        }

        private async Task CreateScenario()
        {
            string uri = "http://localhost/s3-api/api/scenario/StoreSce";

            string payload = JsonConvert.SerializeObject(new
            {
                scenario_name = txtScenName.Texts
            });
            var content = new StringContent(payload, Encoding.UTF8, "application/json");

            using (HttpResponseMessage response = await ApiHelper.ApiClient.PostAsync(uri, content))
            {
                if (response.IsSuccessStatusCode)
                {
                    string resp = await response.Content.ReadAsStringAsync();

                    Dictionary<string, object> respdict = JsonConvert.DeserializeObject<Dictionary<string, object>>(resp);

                    if(respdict.ContainsKey("status") && (bool)respdict["status"] == true)
                    {
                        ParamsGlobal.CurrentScenario = txtScenName.Texts;
                        DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    //throw new Exception(response.ReasonPhrase);
                    Console.WriteLine(response.ReasonPhrase);
                }
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            await CreateScenario();

            Close();
        }

        private bool IsTextNotEmpty()
        {
            return txtScenName.Texts != string.Empty;
        }

        private void FormAddScen_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = IsTextNotEmpty();
        }

        private void txtScenName__TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = IsTextNotEmpty();
        }

        public void create()
        {
            ShowDialog();
        }
        #endregion
    }
}
