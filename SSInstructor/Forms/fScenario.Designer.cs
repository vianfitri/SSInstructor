
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fScenario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.bdgv_scenlist = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.bdgv_scenlist)).BeginInit();
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
            // bdgv_scenlist
            // 
            this.bdgv_scenlist.AllowUserToAddRows = false;
            this.bdgv_scenlist.AllowUserToDeleteRows = false;
            this.bdgv_scenlist.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.bdgv_scenlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bdgv_scenlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bdgv_scenlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bdgv_scenlist.BackgroundColor = System.Drawing.Color.White;
            this.bdgv_scenlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdgv_scenlist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bdgv_scenlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bdgv_scenlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bdgv_scenlist.ColumnHeadersHeight = 40;
            this.bdgv_scenlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.bdgv_scenlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bdgv_scenlist.DefaultCellStyle = dataGridViewCellStyle5;
            this.bdgv_scenlist.DoubleBuffered = true;
            this.bdgv_scenlist.EnableHeadersVisualStyles = false;
            this.bdgv_scenlist.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.bdgv_scenlist.HeaderForeColor = System.Drawing.Color.White;
            this.bdgv_scenlist.Location = new System.Drawing.Point(48, 340);
            this.bdgv_scenlist.Margin = new System.Windows.Forms.Padding(2);
            this.bdgv_scenlist.MultiSelect = false;
            this.bdgv_scenlist.Name = "bdgv_scenlist";
            this.bdgv_scenlist.ReadOnly = true;
            this.bdgv_scenlist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bdgv_scenlist.RowHeadersVisible = false;
            this.bdgv_scenlist.RowHeadersWidth = 51;
            this.bdgv_scenlist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.bdgv_scenlist.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.bdgv_scenlist.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.bdgv_scenlist.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdgv_scenlist.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bdgv_scenlist.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bdgv_scenlist.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.bdgv_scenlist.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.bdgv_scenlist.RowTemplate.DividerHeight = 1;
            this.bdgv_scenlist.RowTemplate.Height = 40;
            this.bdgv_scenlist.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.bdgv_scenlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bdgv_scenlist.Size = new System.Drawing.Size(1236, 658);
            this.bdgv_scenlist.TabIndex = 18;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 10F;
            this.Column1.HeaderText = "No";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 27.94853F;
            this.Column2.HeaderText = "Scenario Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 27.94853F;
            this.Column3.HeaderText = "Ship Type";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4);
            this.Edit.DefaultCellStyle = dataGridViewCellStyle3;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 17;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(4);
            this.Delete.DefaultCellStyle = dataGridViewCellStyle4;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 17;
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
            this.btnDetail.Location = new System.Drawing.Point(1173, 767);
            this.btnDetail.Margin = new System.Windows.Forms.Padding(2);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(112, 32);
            this.btnDetail.TabIndex = 19;
            this.btnDetail.Text = "SHOW DETAIL";
            this.btnDetail.TextColor = System.Drawing.Color.White;
            this.btnDetail.UseVisualStyleBackColor = false;
            // 
            // dgv_ScenList
            // 
            this.dgv_ScenList.AllowUserToAddRows = false;
            this.dgv_ScenList.AllowUserToDeleteRows = false;
            this.dgv_ScenList.AllowUserToResizeColumns = false;
            this.dgv_ScenList.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgv_ScenList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_ScenList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ScenList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ScenList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ScenList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ScenList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_ScenList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ScenList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
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
            this.dgv_ScenList.EnableHeadersVisualStyles = false;
            this.dgv_ScenList.Location = new System.Drawing.Point(48, 91);
            this.dgv_ScenList.MultiSelect = false;
            this.dgv_ScenList.Name = "dgv_ScenList";
            this.dgv_ScenList.ReadOnly = true;
            this.dgv_ScenList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_ScenList.RowHeadersVisible = false;
            this.dgv_ScenList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgv_ScenList.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_ScenList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ScenList.Size = new System.Drawing.Size(1236, 215);
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
            this.scenDelete.Name = "scenDelete";
            this.scenDelete.ReadOnly = true;
            this.scenDelete.Width = 17;
            // 
            // fScenario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 841);
            this.Controls.Add(this.dgv_ScenList);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.bdgv_scenlist);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fScenario";
            this.Text = "fScenario";
            this.Load += new System.EventHandler(this.fScenario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdgv_scenlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ScenList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bdgv_scenlist;
        private ViControls.ViButton btnDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
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
    }
}