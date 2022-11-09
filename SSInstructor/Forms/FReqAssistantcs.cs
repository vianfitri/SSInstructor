using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSInstructor.Forms
{
    public partial class FReqAssistantcs : Form
    {
        #region "Fields"
        formDashboard _parent;
        #endregion

        #region "Constructor"
        public FReqAssistantcs(formDashboard parent)
        {
            InitializeComponent();
            this._parent = parent;
        }
        #endregion

        #region "Properties"
        #endregion

        #region "Method"
        private void FReqAssistantcs_Load(object sender, EventArgs e)
        {
            // Get State of Req Assistant Feature
            if(_parent.Reqenabled)
            {
                btnReqAssEnable.Enabled = false;
                btnReqAssSilent.Enabled = true;
            } 
            else
            {
                btnReqAssEnable.Enabled = true;
                btnReqAssSilent.Enabled = false;
            }

            // Load List Of Trainee Need Help
            LoadTraineeNeedHelp();
        }

        private void btnReqAssEnable_Click(object sender, EventArgs e)
        {
            this._parent.Reqenabled = true;
            this._parent.Send("en$");
            btnReqAssSilent.Enabled = true;
            btnReqAssEnable.Enabled = false;
        }

        private void btnReqAssSilent_Click(object sender, EventArgs e)
        {
            this._parent.Reqenabled = false;
            this._parent.Send("dis$");
            btnReqAssSilent.Enabled = false;
            btnReqAssEnable.Enabled = true;
        }

        private void LoadTraineeNeedHelp()
        {
            dgv_ReqAssList.Rows.Clear();

            int idNo = 0;
            foreach (string pcName in _parent.pc_name)
            {
                idNo++;
                dgv_ReqAssList.Rows.Add(
                    new object[]
                    {
                        idNo,
                        pcName,
                        new Button()
                    }
                );
            }
        }
        #endregion


    }
}
