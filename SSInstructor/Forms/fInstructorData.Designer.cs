
namespace SSInstructor.Forms
{
    partial class fInstructorData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fInstructorData));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddInstructor = new ViControls.ViButton();
            this.btnImportInstructor = new ViControls.ViButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlAddInstructor = new System.Windows.Forms.Panel();
            this.btnCancel = new ViControls.ViButton();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSaveInstructor = new ViControls.ViButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNIP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPnlAddEdit = new System.Windows.Forms.Label();
            this.dgv_InstructorList = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instNip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlAddInstructor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InstructorList)).BeginInit();
            this.SuspendLayout();
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
            this.label2.TabIndex = 7;
            this.label2.Text = "List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Instructor";
            // 
            // btnAddInstructor
            // 
            this.btnAddInstructor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddInstructor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(184)))), ((int)(((byte)(249)))));
            this.btnAddInstructor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(184)))), ((int)(((byte)(249)))));
            this.btnAddInstructor.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddInstructor.BorderRadius = 10;
            this.btnAddInstructor.BorderSize = 0;
            this.btnAddInstructor.FlatAppearance.BorderSize = 0;
            this.btnAddInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInstructor.ForeColor = System.Drawing.Color.White;
            this.btnAddInstructor.Location = new System.Drawing.Point(510, 484);
            this.btnAddInstructor.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddInstructor.Name = "btnAddInstructor";
            this.btnAddInstructor.Size = new System.Drawing.Size(112, 32);
            this.btnAddInstructor.TabIndex = 10;
            this.btnAddInstructor.Text = "Add Data";
            this.btnAddInstructor.TextColor = System.Drawing.Color.White;
            this.btnAddInstructor.UseVisualStyleBackColor = false;
            this.btnAddInstructor.Click += new System.EventHandler(this.btnAddInstructor_Click);
            // 
            // btnImportInstructor
            // 
            this.btnImportInstructor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportInstructor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(70)))), ((int)(((byte)(60)))));
            this.btnImportInstructor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(70)))), ((int)(((byte)(60)))));
            this.btnImportInstructor.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnImportInstructor.BorderRadius = 10;
            this.btnImportInstructor.BorderSize = 0;
            this.btnImportInstructor.FlatAppearance.BorderSize = 0;
            this.btnImportInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportInstructor.ForeColor = System.Drawing.Color.White;
            this.btnImportInstructor.Location = new System.Drawing.Point(383, 484);
            this.btnImportInstructor.Margin = new System.Windows.Forms.Padding(2);
            this.btnImportInstructor.Name = "btnImportInstructor";
            this.btnImportInstructor.Size = new System.Drawing.Size(112, 32);
            this.btnImportInstructor.TabIndex = 11;
            this.btnImportInstructor.Text = "Import Data";
            this.btnImportInstructor.TextColor = System.Drawing.Color.White;
            this.btnImportInstructor.UseVisualStyleBackColor = false;
            this.btnImportInstructor.Visible = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Edit";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 128;
            // 
            // pnlAddInstructor
            // 
            this.pnlAddInstructor.Controls.Add(this.btnCancel);
            this.pnlAddInstructor.Controls.Add(this.label8);
            this.pnlAddInstructor.Controls.Add(this.btnSaveInstructor);
            this.pnlAddInstructor.Controls.Add(this.txtEmail);
            this.pnlAddInstructor.Controls.Add(this.rbFemale);
            this.pnlAddInstructor.Controls.Add(this.rbMale);
            this.pnlAddInstructor.Controls.Add(this.txtName);
            this.pnlAddInstructor.Controls.Add(this.txtNIP);
            this.pnlAddInstructor.Controls.Add(this.label7);
            this.pnlAddInstructor.Controls.Add(this.label6);
            this.pnlAddInstructor.Controls.Add(this.label5);
            this.pnlAddInstructor.Controls.Add(this.label3);
            this.pnlAddInstructor.Controls.Add(this.lblPnlAddEdit);
            this.pnlAddInstructor.Location = new System.Drawing.Point(25, 26);
            this.pnlAddInstructor.Name = "pnlAddInstructor";
            this.pnlAddInstructor.Size = new System.Drawing.Size(600, 373);
            this.pnlAddInstructor.TabIndex = 13;
            this.pnlAddInstructor.Visible = false;
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
            this.label8.Size = new System.Drawing.Size(225, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Standard password is NIP number";
            // 
            // btnSaveInstructor
            // 
            this.btnSaveInstructor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(184)))), ((int)(((byte)(249)))));
            this.btnSaveInstructor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(184)))), ((int)(((byte)(249)))));
            this.btnSaveInstructor.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSaveInstructor.BorderRadius = 10;
            this.btnSaveInstructor.BorderSize = 0;
            this.btnSaveInstructor.FlatAppearance.BorderSize = 0;
            this.btnSaveInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveInstructor.ForeColor = System.Drawing.Color.White;
            this.btnSaveInstructor.Location = new System.Drawing.Point(48, 246);
            this.btnSaveInstructor.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveInstructor.Name = "btnSaveInstructor";
            this.btnSaveInstructor.Size = new System.Drawing.Size(112, 32);
            this.btnSaveInstructor.TabIndex = 17;
            this.btnSaveInstructor.Text = "Save";
            this.btnSaveInstructor.TextColor = System.Drawing.Color.White;
            this.btnSaveInstructor.UseVisualStyleBackColor = false;
            this.btnSaveInstructor.Click += new System.EventHandler(this.btnSaveInstructor_Click);
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
            // txtNIP
            // 
            this.txtNIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIP.Location = new System.Drawing.Point(171, 87);
            this.txtNIP.Name = "txtNIP";
            this.txtNIP.Size = new System.Drawing.Size(222, 22);
            this.txtNIP.TabIndex = 12;
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
            this.label3.Text = "NIP";
            // 
            // lblPnlAddEdit
            // 
            this.lblPnlAddEdit.AutoSize = true;
            this.lblPnlAddEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPnlAddEdit.Location = new System.Drawing.Point(44, 35);
            this.lblPnlAddEdit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPnlAddEdit.Name = "lblPnlAddEdit";
            this.lblPnlAddEdit.Size = new System.Drawing.Size(140, 24);
            this.lblPnlAddEdit.TabIndex = 7;
            this.lblPnlAddEdit.Text = "Add Instructor";
            // 
            // dgv_InstructorList
            // 
            this.dgv_InstructorList.AllowUserToAddRows = false;
            this.dgv_InstructorList.AllowUserToDeleteRows = false;
            this.dgv_InstructorList.AllowUserToResizeColumns = false;
            this.dgv_InstructorList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgv_InstructorList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_InstructorList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_InstructorList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_InstructorList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_InstructorList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_InstructorList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_InstructorList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_InstructorList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_InstructorList.ColumnHeadersHeight = 40;
            this.dgv_InstructorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_InstructorList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.instID,
            this.instNip,
            this.InstName,
            this.InstEmail,
            this.Gender,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_InstructorList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_InstructorList.EnableHeadersVisualStyles = false;
            this.dgv_InstructorList.Location = new System.Drawing.Point(48, 102);
            this.dgv_InstructorList.MultiSelect = false;
            this.dgv_InstructorList.Name = "dgv_InstructorList";
            this.dgv_InstructorList.ReadOnly = true;
            this.dgv_InstructorList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_InstructorList.RowHeadersVisible = false;
            this.dgv_InstructorList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgv_InstructorList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_InstructorList.RowTemplate.Height = 40;
            this.dgv_InstructorList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_InstructorList.Size = new System.Drawing.Size(577, 366);
            this.dgv_InstructorList.TabIndex = 21;
            this.dgv_InstructorList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_InstructorList_CellContentClick);
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
            // instID
            // 
            this.instID.HeaderText = "id";
            this.instID.Name = "instID";
            this.instID.ReadOnly = true;
            this.instID.Visible = false;
            // 
            // instNip
            // 
            this.instNip.FillWeight = 73.92908F;
            this.instNip.HeaderText = "NIP";
            this.instNip.Name = "instNip";
            this.instNip.ReadOnly = true;
            // 
            // InstName
            // 
            this.InstName.FillWeight = 114.5669F;
            this.InstName.HeaderText = "Name";
            this.InstName.Name = "InstName";
            this.InstName.ReadOnly = true;
            // 
            // InstEmail
            // 
            this.InstEmail.HeaderText = "Email";
            this.InstEmail.Name = "InstEmail";
            this.InstEmail.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Visible = false;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.FillWeight = 40.56242F;
            this.Edit.HeaderText = "";
            this.Edit.Image = global::SSInstructor.Properties.Resources.pencil;
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 17;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 17;
            // 
            // fInstructorData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 586);
            this.Controls.Add(this.pnlAddInstructor);
            this.Controls.Add(this.dgv_InstructorList);
            this.Controls.Add(this.btnImportInstructor);
            this.Controls.Add(this.btnAddInstructor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fInstructorData";
            this.Text = "fInstructorData";
            this.Load += new System.EventHandler(this.fInstructorData_Load);
            this.pnlAddInstructor.ResumeLayout(false);
            this.pnlAddInstructor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InstructorList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ViControls.ViButton btnAddInstructor;
        private ViControls.ViButton btnImportInstructor;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel pnlAddInstructor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPnlAddEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNIP;
        private System.Windows.Forms.Label label7;
        private ViControls.ViButton btnSaveInstructor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_InstructorList;
        private ViControls.ViButton btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn instID;
        private System.Windows.Forms.DataGridViewTextBoxColumn instNip;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}