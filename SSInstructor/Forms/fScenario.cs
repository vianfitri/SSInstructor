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
                    //dgv_ScenList.Rows.Clear();
                    
                    foreach(ScenarioModel item in listscen)
                    {
                        Console.WriteLine("<========");
                        Console.WriteLine(string.Format("id:{0}", item.Id));
                        Console.WriteLine(string.Format("scenario_name:{0}", item.ScenarioName));
                        Console.WriteLine(string.Format("create_time:{0}", item.CreateTime));
                        Console.WriteLine("========>");
                    }
                } 
                else
                {
                    throw new Exception(response.ReasonPhrase);
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
    }
}
