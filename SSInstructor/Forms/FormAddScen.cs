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
        public FormAddScen()
        {
            InitializeComponent();
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
                    string scens = await response.Content.ReadAsStringAsync();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            await CreateScenario();

            DialogResult = DialogResult.OK;
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
    }
}
