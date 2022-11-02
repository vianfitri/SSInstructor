
namespace SSInstructor.Forms
{
    partial class fTraineeData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTraineeData));
            this.btnImportTrainee = new ViControls.ViButton();
            this.btnAddTrainee = new ViControls.ViButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_TraineeList = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TraineeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TraineeNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TraineeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TraineeEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlAddTrainee = new System.Windows.Forms.Panel();
            this.btnCancel = new ViControls.ViButton();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSaveTrainee = new ViControls.ViButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNIT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPnlAddEdit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TraineeList)).BeginInit();
            this.pnlAddTrainee.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImportTrainee
            // 
            this.btnImportTrainee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportTrainee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(70)))), ((int)(((byte)(60)))));
            this.btnImportTrainee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(70)))), ((int)(((byte)(60)))));
            this.btnImportTrainee.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnImportTrainee.BorderRadius = 10;
            this.btnImportTrainee.BorderSize = 0;
            this.btnImportTrainee.FlatAppearance.BorderSize = 0;
            this.btnImportTrainee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportTrainee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportTrainee.ForeColor = System.Drawing.Color.White;
            this.btnImportTrainee.Location = new System.Drawing.Point(386, 484);
            this.btnImportTrainee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImportTrainee.Name = "btnImportTrainee";
            this.btnImportTrainee.Size = new System.Drawing.Size(112, 32);
            this.btnImportTrainee.TabIndex = 16;
            this.btnImportTrainee.Text = "Import Data";
            this.btnImportTrainee.TextColor = System.Drawing.Color.White;
            this.btnImportTrainee.UseVisualStyleBackColor = false;
            this.btnImportTrainee.Visible = false;
            // 
            // btnAddTrainee
            // 
            this.btnAddTrainee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTrainee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(184)))), ((int)(((byte)(249)))));
            this.btnAddTrainee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(184)))), ((int)(((byte)(249)))));
            this.btnAddTrainee.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddTrainee.BorderRadius = 10;
            this.btnAddTrainee.BorderSize = 0;
            this.btnAddTrainee.FlatAppearance.BorderSize = 0;
            this.btnAddTrainee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTrainee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTrainee.ForeColor = System.Drawing.Color.White;
            this.btnAddTrainee.Location = new System.Drawing.Point(510, 484);
            this.btnAddTrainee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddTrainee.Name = "btnAddTrainee";
            this.btnAddTrainee.Size = new System.Drawing.Size(112, 32);
            this.btnAddTrainee.TabIndex = 15;
            this.btnAddTrainee.Text = "Add Data";
            this.btnAddTrainee.TextColor = System.Drawing.Color.White;
            this.btnAddTrainee.UseVisualStyleBackColor = false;
            this.btnAddTrainee.Click += new System.EventHandler(this.btnAddTrainee_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(118)))), ((int)(((byte)(159)))));
            this.label2.Location = new System.Drawing.Point(45, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Trainee";
            // 
            // dgv_TraineeList
            // 
            this.dgv_TraineeList.AllowUserToAddRows = false;
            this.dgv_TraineeList.AllowUserToDeleteRows = false;
            this.dgv_TraineeList.AllowUserToResizeColumns = false;
            this.dgv_TraineeList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgv_TraineeList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_TraineeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_TraineeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TraineeList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_TraineeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_TraineeList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_TraineeList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TraineeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_TraineeList.ColumnHeadersHeight = 40;
            this.dgv_TraineeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_TraineeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.TraineeID,
            this.TraineeNIT,
            this.TraineeName,
            this.TraineeEmail,
            this.Gender,
            this.dataGridViewImageColumn1,
            this.dataGridViewImageColumn2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TraineeList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_TraineeList.EnableHeadersVisualStyles = false;
            this.dgv_TraineeList.Location = new System.Drawing.Point(48, 103);
            this.dgv_TraineeList.MultiSelect = false;
            this.dgv_TraineeList.Name = "dgv_TraineeList";
            this.dgv_TraineeList.ReadOnly = true;
            this.dgv_TraineeList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_TraineeList.RowHeadersVisible = false;
            this.dgv_TraineeList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgv_TraineeList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_TraineeList.RowTemplate.Height = 40;
            this.dgv_TraineeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TraineeList.Size = new System.Drawing.Size(577, 366);
            this.dgv_TraineeList.TabIndex = 22;
            this.dgv_TraineeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TraineeList_CellContentClick);
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
            // TraineeID
            // 
            this.TraineeID.HeaderText = "id";
            this.TraineeID.Name = "TraineeID";
            this.TraineeID.ReadOnly = true;
            this.TraineeID.Visible = false;
            // 
            // TraineeNIT
            // 
            this.TraineeNIT.FillWeight = 73.92908F;
            this.TraineeNIT.HeaderText = "NIT";
            this.TraineeNIT.Name = "TraineeNIT";
            this.TraineeNIT.ReadOnly = true;
            // 
            // TraineeName
            // 
            this.TraineeName.FillWeight = 114.5669F;
            this.TraineeName.HeaderText = "Name";
            this.TraineeName.Name = "TraineeName";
            this.TraineeName.ReadOnly = true;
            // 
            // TraineeEmail
            // 
            this.TraineeEmail.HeaderText = "Email";
            this.TraineeEmail.Name = "TraineeEmail";
            this.TraineeEmail.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Visible = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.FillWeight = 40.56242F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::SSInstructor.Properties.Resources.pencil;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 17;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 17;
            // 
            // pnlAddTrainee
            // 
            this.pnlAddTrainee.Controls.Add(this.btnCancel);
            this.pnlAddTrainee.Controls.Add(this.label8);
            this.pnlAddTrainee.Controls.Add(this.btnSaveTrainee);
            this.pnlAddTrainee.Controls.Add(this.txtEmail);
            this.pnlAddTrainee.Controls.Add(this.rbFemale);
            this.pnlAddTrainee.Controls.Add(this.rbMale);
            this.pnlAddTrainee.Controls.Add(this.txtName);
            this.pnlAddTrainee.Controls.Add(this.txtNIT);
            this.pnlAddTrainee.Controls.Add(this.label7);
            this.pnlAddTrainee.Controls.Add(this.label6);
            this.pnlAddTrainee.Controls.Add(this.label5);
            this.pnlAddTrainee.Controls.Add(this.label3);
            this.pnlAddTrainee.Controls.Add(this.lblPnlAddEdit);
            this.pnlAddTrainee.Location = new System.Drawing.Point(25, 25);
            this.pnlAddTrainee.Name = "pnlAddTrainee";
            this.pnlAddTrainee.Size = new System.Drawing.Size(600, 373);
            this.pnlAddTrainee.TabIndex = 23;
            this.pnlAddTrainee.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(70)))), ((int)(((byte)(60)))));
            this.btnCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(70)))), ((int)(((byte)(60)))));
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(181, 246);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 32);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Standard password is NIT number";
            // 
            // btnSaveTrainee
            // 
            this.btnSaveTrainee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(184)))), ((int)(((byte)(249)))));
            this.btnSaveTrainee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(184)))), ((int)(((byte)(249)))));
            this.btnSaveTrainee.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSaveTrainee.BorderRadius = 10;
            this.btnSaveTrainee.BorderSize = 0;
            this.btnSaveTrainee.FlatAppearance.BorderSize = 0;
            this.btnSaveTrainee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveTrainee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTrainee.ForeColor = System.Drawing.Color.White;
            this.btnSaveTrainee.Location = new System.Drawing.Point(48, 246);
            this.btnSaveTrainee.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveTrainee.Name = "btnSaveTrainee";
            this.btnSaveTrainee.Size = new System.Drawing.Size(112, 32);
            this.btnSaveTrainee.TabIndex = 17;
            this.btnSaveTrainee.Text = "Save";
            this.btnSaveTrainee.TextColor = System.Drawing.Color.White;
            this.btnSaveTrainee.UseVisualStyleBackColor = false;
            this.btnSaveTrainee.Click += new System.EventHandler(this.btnSaveTrainee_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(171, 202);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(235, 22);
            this.txtEmail.TabIndex = 16;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(246, 163);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 15;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(171, 163);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 14;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(171, 125);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(281, 22);
            this.txtName.TabIndex = 13;
            // 
            // txtNIT
            // 
            this.txtNIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIT.Location = new System.Drawing.Point(171, 87);
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.Size = new System.Drawing.Size(222, 22);
            this.txtNIT.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "NIT";
            // 
            // lblPnlAddEdit
            // 
            this.lblPnlAddEdit.AutoSize = true;
            this.lblPnlAddEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPnlAddEdit.Location = new System.Drawing.Point(44, 35);
            this.lblPnlAddEdit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPnlAddEdit.Name = "lblPnlAddEdit";
            this.lblPnlAddEdit.Size = new System.Drawing.Size(126, 24);
            this.lblPnlAddEdit.TabIndex = 7;
            this.lblPnlAddEdit.Text = "Add Trainee";
            // 
            // fTraineeData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 586);
            this.Controls.Add(this.pnlAddTrainee);
            this.Controls.Add(this.dgv_TraineeList);
            this.Controls.Add(this.btnImportTrainee);
            this.Controls.Add(this.btnAddTrainee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fTraineeData";
            this.Text = "fTraineeData";
            this.Load += new System.EventHandler(this.fTraineeData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TraineeList)).EndInit();
            this.pnlAddTrainee.ResumeLayout(false);
            this.pnlAddTrainee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ViControls.ViButton btnImportTrainee;
        private ViControls.ViButton btnAddTrainee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_TraineeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn TraineeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TraineeNIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TraineeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TraineeEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Panel pnlAddTrainee;
        private ViControls.ViButton btnCancel;
        private System.Windows.Forms.Label label8;
        private ViControls.ViButton btnSaveTrainee;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNIT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPnlAddEdit;
    }
}