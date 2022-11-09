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
            int idNo = 0;
            foreach(string pcName in _parent.pc_name)
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
