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
        #endregion

        #region "Constructor"
        public fScenario()
        {
            InitializeComponent();
        }
        #endregion

        #region "Properties"
        #endregion

        #region "Method"
        private async Task LoadScenario()
        {
            string uri = "http://localhost/s3-api/api/scenario/GetSce";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(uri))
            {
                if (response.IsSuccessStatusCode)
                {
                    string scens = await response.Content.ReadAsStringAsync();

                    List<ScenarioModel> listscen = JsonConvert.DeserializeObject<List<ScenarioModel>>(scens);

                    // build datagrid view content
                    dgv_ScenList.Rows.Clear();

                    int ids = 0;
                    foreach(ScenarioModel item in listscen)
                    {
                        ids++;
                        dgv_ScenList.Rows.Add(
                            new object[]
                            {
                                ids,
                                item.Id,
                                item.Scenario_Name,
                                item.Db_Name,
                                item.Create_Time,
                                item.Is_Active,
                                item.Is_Exist,
                                null,
                                null
                            }
                        ); ;
                    }
                } 
                else
                {
                    //throw new Exception(response.ReasonPhrase);
                    Console.WriteLine(response.ReasonPhrase);
                }
            }
        }
        #endregion

        #region "Events"
        private async void fScenario_Load(object sender, EventArgs e)
        {
            // load data scenario
            await LoadScenario();
        }
        #endregion

        // Add Scenario
        private void btnDetail_Click(object sender, EventArgs e)
        {
            FormAddScen faddScen = new FormAddScen();
            faddScen.create();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dbnew = "CobaDuplicate_"+DateTime.Now.ToString("yyyyMMdd");


        }
    }
}
