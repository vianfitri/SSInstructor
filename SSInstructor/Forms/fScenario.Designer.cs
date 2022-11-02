
namespace SSInstructor.Forms
{
    partial class fScenario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fScenario));
            this.label1 = new System.Windows.Forms.Label();
            this.btnDetail = new ViControls.ViButton();
            this.dgv_ScenList = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scenid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scenname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isactive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isexist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scenAction = new System.Windows.Forms.DataGridViewImageColumn();
            this.scenDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlAddScenario = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ScenList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Scenario";
            // 
            // btnDetail
            // 
            this.btnDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(184)))), ((int)(((byte)(249)))));
            this.btnDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(184)))), ((int)(((byte)(249)))));
            this.btnDetail.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDetail.BorderRadius = 10;
            this.btnDetail.BorderSize = 0;
            this.btnDetail.FlatAppearance.BorderSize = 0;
            this.btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.ForeColor = System.Drawing.Color.White;
            this.btnDetail.Location = new System.Drawing.Point(1134, 767);
            this.btnDetail.Margin = new System.Windows.Forms.Padding(2);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(151, 32);
            this.btnDetail.TabIndex = 19;
            this.btnDetail.Text = "Create Scenario";
            this.btnDetail.TextColor = System.Drawing.Color.White;
            this.btnDetail.UseVisualStyleBackColor = false;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // dgv_ScenList
            // 
            this.dgv_ScenList.AllowUserToAddRows = false;
            this.dgv_ScenList.AllowUserToDeleteRows = false;
            this.dgv_ScenList.AllowUserToResizeColumns = false;
            this.dgv_ScenList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgv_ScenList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ScenList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ScenList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ScenList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ScenList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ScenList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_ScenList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ScenList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ScenList.ColumnHeadersHeight = 40;
            this.dgv_ScenList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_ScenList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.scenid,
            this.scenname,
            this.dbname,
            this.createtime,
            this.isactive,
            this.isexist,
            this.scenAction,
            this.scenDelete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ScenList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ScenList.EnableHeadersVisualStyles = false;
            this.dgv_ScenList.Location = new System.Drawing.Point(48, 91);
            this.dgv_ScenList.MultiSelect = false;
            this.dgv_ScenList.Name = "dgv_ScenList";
            this.dgv_ScenList.ReadOnly = true;
            this.dgv_ScenList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_ScenList.RowHeadersVisible = false;
            this.dgv_ScenList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgv_ScenList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_ScenList.RowTemplate.Height = 40;
            this.dgv_ScenList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ScenList.Size = new System.Drawing.Size(1236, 646);
            this.dgv_ScenList.TabIndex = 20;
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.No.FillWeight = 80F;
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 80;
            // 
            // scenid
            // 
            this.scenid.HeaderText = "id";
            this.scenid.Name = "scenid";
            this.scenid.ReadOnly = true;
            this.scenid.Visible = false;
            // 
            // scenname
            // 
            this.scenname.FillWeight = 64.52919F;
            this.scenname.HeaderText = "Scenario Name";
            this.scenname.Name = "scenname";
            this.scenname.ReadOnly = true;
            // 
            // dbname
            // 
            this.dbname.HeaderText = "Database Name";
            this.dbname.Name = "dbname";
            this.dbname.ReadOnly = true;
            this.dbname.Visible = false;
            // 
            // createtime
            // 
            this.createtime.FillWeight = 64.52919F;
            this.createtime.HeaderText = "Create Time";
            this.createtime.Name = "createtime";
            this.createtime.ReadOnly = true;
            // 
            // isactive
            // 
            this.isactive.HeaderText = "IsActive";
            this.isactive.Name = "isactive";
            this.isactive.ReadOnly = true;
            this.isactive.Visible = false;
            // 
            // isexist
            // 
            this.isexist.HeaderText = "IsExist";
            this.isexist.Name = "isexist";
            this.isexist.ReadOnly = true;
            this.isexist.Visible = false;
            // 
            // scenAction
            // 
            this.scenAction.FillWeight = 64.52919F;
            this.scenAction.HeaderText = "";
            this.scenAction.Name = "scenAction";
            this.scenAction.ReadOnly = true;
            // 
            // scenDelete
            // 
            this.scenDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.scenDelete.HeaderText = "";
            this.scenDelete.Image = ((System.Drawing.Image)(resources.GetObject("scenDelete.Image")));
            this.scenDelete.Name = "scenDelete";
            this.scenDelete.ReadOnly = true;
            this.scenDelete.Width = 17;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // pnlAddScenario
            // 
            this.pnlAddScenario.Location = new System.Drawing.Point(1306, 60);
            this.pnlAddScenario.Name = "pnlAddScenario";
            this.pnlAddScenario.Size = new System.Drawing.Size(659, 403);
            this.pnlAddScenario.TabIndex = 21;
            this.pnlAddScenario.Visible = false;
            // 
            // fScenario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 841);
            this.Controls.Add(this.pnlAddScenario);
            this.Controls.Add(this.dgv_ScenList);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fScenario";
            this.Text = "fScenario";
            this.Load += new System.EventHandler(this.fScenario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ScenList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ViControls.ViButton btnDetail;
        private System.Windows.Forms.DataGridView dgv_ScenList;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn scenid;
        private System.Windows.Forms.DataGridViewTextBoxColumn scenname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbname;
        private System.Windows.Forms.DataGridViewTextBoxColumn createtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn isactive;
        private System.Windows.Forms.DataGridViewTextBoxColumn isexist;
        private System.Windows.Forms.DataGridViewImageColumn scenAction;
        private System.Windows.Forms.DataGridViewImageColumn scenDelete;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel pnlAddScenario;
    }
}