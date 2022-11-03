
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
            this.shiptype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isactive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isexist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scenAction = new System.Windows.Forms.DataGridViewImageColumn();
            this.scenDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlAddScenario = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnScenSave = new ViControls.ViButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAddScen = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblVesselSelect = new System.Windows.Forms.Label();
            this.cbVesselSelect = new System.Windows.Forms.ComboBox();
            this.rbTest = new System.Windows.Forms.RadioButton();
            this.rbTraining = new System.Windows.Forms.RadioButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ScenList)).BeginInit();
            this.pnlAddScenario.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 189);
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
            this.shiptype,
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
            this.dgv_ScenList.Location = new System.Drawing.Point(48, 235);
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
            this.dgv_ScenList.Size = new System.Drawing.Size(1236, 502);
            this.dgv_ScenList.TabIndex = 20;
            this.dgv_ScenList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ScenList_CellDoubleClick);
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
            // shiptype
            // 
            this.shiptype.HeaderText = "Vessel Type";
            this.shiptype.Name = "shiptype";
            this.shiptype.ReadOnly = true;
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
            this.scenAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.scenAction.FillWeight = 64.52919F;
            this.scenAction.HeaderText = "";
            this.scenAction.Image = global::SSInstructor.Properties.Resources.inactive;
            this.scenAction.Name = "scenAction";
            this.scenAction.ReadOnly = true;
            this.scenAction.Width = 17;
            // 
            // scenDelete
            // 
            this.scenDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.scenDelete.HeaderText = "";
            this.scenDelete.Image = global::SSInstructor.Properties.Resources.delete;
            this.scenDelete.Name = "scenDelete";
            this.scenDelete.ReadOnly = true;
            this.scenDelete.Width = 17;
            // 
            // pnlAddScenario
            // 
            this.pnlAddScenario.Controls.Add(this.groupBox1);
            this.pnlAddScenario.Controls.Add(this.lblAddScen);
            this.pnlAddScenario.Location = new System.Drawing.Point(439, 495);
            this.pnlAddScenario.Name = "pnlAddScenario";
            this.pnlAddScenario.Size = new System.Drawing.Size(690, 403);
            this.pnlAddScenario.TabIndex = 21;
            this.pnlAddScenario.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnScenSave);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(48, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 265);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // btnScenSave
            // 
            this.btnScenSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScenSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(184)))), ((int)(((byte)(249)))));
            this.btnScenSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(184)))), ((int)(((byte)(249)))));
            this.btnScenSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnScenSave.BorderRadius = 10;
            this.btnScenSave.BorderSize = 0;
            this.btnScenSave.FlatAppearance.BorderSize = 0;
            this.btnScenSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScenSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScenSave.ForeColor = System.Drawing.Color.White;
            this.btnScenSave.Location = new System.Drawing.Point(35, 155);
            this.btnScenSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnScenSave.Name = "btnScenSave";
            this.btnScenSave.Size = new System.Drawing.Size(121, 32);
            this.btnScenSave.TabIndex = 27;
            this.btnScenSave.Text = "Save";
            this.btnScenSave.TextColor = System.Drawing.Color.White;
            this.btnScenSave.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bulk Carrier 50000 DWT",
            "General Cargo 3650 DWT",
            "Containership 4180 DWT"});
            this.comboBox1.Location = new System.Drawing.Point(208, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 32);
            this.comboBox1.TabIndex = 26;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(208, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 29);
            this.textBox1.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Vessel Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Scenario Name";
            // 
            // lblAddScen
            // 
            this.lblAddScen.AutoSize = true;
            this.lblAddScen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddScen.Location = new System.Drawing.Point(44, 35);
            this.lblAddScen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddScen.Name = "lblAddScen";
            this.lblAddScen.Size = new System.Drawing.Size(160, 24);
            this.lblAddScen.TabIndex = 18;
            this.lblAddScen.Text = "Create Scenario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Exercise Mode";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblVesselSelect);
            this.groupBox2.Controls.Add(this.cbVesselSelect);
            this.groupBox2.Controls.Add(this.rbTest);
            this.groupBox2.Controls.Add(this.rbTraining);
            this.groupBox2.Location = new System.Drawing.Point(48, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(798, 100);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // lblVesselSelect
            // 
            this.lblVesselSelect.AutoSize = true;
            this.lblVesselSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVesselSelect.Location = new System.Drawing.Point(459, 41);
            this.lblVesselSelect.Name = "lblVesselSelect";
            this.lblVesselSelect.Size = new System.Drawing.Size(96, 16);
            this.lblVesselSelect.TabIndex = 28;
            this.lblVesselSelect.Text = "Vessel Type";
            // 
            // cbVesselSelect
            // 
            this.cbVesselSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVesselSelect.FormattingEnabled = true;
            this.cbVesselSelect.Items.AddRange(new object[] {
            "Bulk Carrier 50000 DWT",
            "General Cargo 3650 DWT",
            "Containership 4180 DWT"});
            this.cbVesselSelect.Location = new System.Drawing.Point(578, 32);
            this.cbVesselSelect.Name = "cbVesselSelect";
            this.cbVesselSelect.Size = new System.Drawing.Size(195, 32);
            this.cbVesselSelect.TabIndex = 27;
            this.cbVesselSelect.SelectedIndexChanged += new System.EventHandler(this.cbVesselSelect_SelectedIndexChanged);
            // 
            // rbTest
            // 
            this.rbTest.AutoSize = true;
            this.rbTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTest.Location = new System.Drawing.Point(195, 39);
            this.rbTest.Name = "rbTest";
            this.rbTest.Size = new System.Drawing.Size(100, 20);
            this.rbTest.TabIndex = 1;
            this.rbTest.Text = "Mode Test";
            this.rbTest.UseVisualStyleBackColor = true;
            this.rbTest.CheckedChanged += new System.EventHandler(this.rbTest_CheckedChanged);
            // 
            // rbTraining
            // 
            this.rbTraining.AutoSize = true;
            this.rbTraining.Checked = true;
            this.rbTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTraining.Location = new System.Drawing.Point(25, 39);
            this.rbTraining.Name = "rbTraining";
            this.rbTraining.Size = new System.Drawing.Size(126, 20);
            this.rbTraining.TabIndex = 0;
            this.rbTraining.TabStop = true;
            this.rbTraining.Text = "Mode Training";
            this.rbTraining.UseVisualStyleBackColor = true;
            this.rbTraining.CheckedChanged += new System.EventHandler(this.rbTraining_CheckedChanged);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.FillWeight = 64.52919F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::SSInstructor.Properties.Resources.delete;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // fScenario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 841);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlAddScenario);
            this.Controls.Add(this.dgv_ScenList);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fScenario";
            this.Text = "fScenario";
            this.Load += new System.EventHandler(this.fScenario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ScenList)).EndInit();
            this.pnlAddScenario.ResumeLayout(false);
            this.pnlAddScenario.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ViControls.ViButton btnDetail;
        private System.Windows.Forms.DataGridView dgv_ScenList;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel pnlAddScenario;
        private System.Windows.Forms.Label lblAddScen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ViControls.ViButton btnScenSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbTraining;
        private System.Windows.Forms.RadioButton rbTest;
        private System.Windows.Forms.Label lblVesselSelect;
        private System.Windows.Forms.ComboBox cbVesselSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn scenid;
        private System.Windows.Forms.DataGridViewTextBoxColumn scenname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbname;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiptype;
        private System.Windows.Forms.DataGridViewTextBoxColumn createtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn isactive;
        private System.Windows.Forms.DataGridViewTextBoxColumn isexist;
        private System.Windows.Forms.DataGridViewImageColumn scenAction;
        private System.Windows.Forms.DataGridViewImageColumn scenDelete;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
    }
}