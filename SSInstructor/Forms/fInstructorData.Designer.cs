
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_instructor = new System.Windows.Forms.DataGridView();
            this.btnAddInstructor = new ViControls.ViButton();
            this.btnImportInstructor = new ViControls.ViButton();
            this.bdgv_Instructor = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_instructor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgv_Instructor)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(118)))), ((int)(((byte)(159)))));
            this.label2.Location = new System.Drawing.Point(60, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Instructor";
            // 
            // dgv_instructor
            // 
            this.dgv_instructor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_instructor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_instructor.Location = new System.Drawing.Point(61, 505);
            this.dgv_instructor.Name = "dgv_instructor";
            this.dgv_instructor.RowHeadersWidth = 51;
            this.dgv_instructor.RowTemplate.Height = 24;
            this.dgv_instructor.Size = new System.Drawing.Size(769, 68);
            this.dgv_instructor.TabIndex = 8;
            this.dgv_instructor.Visible = false;
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
            this.btnAddInstructor.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInstructor.ForeColor = System.Drawing.Color.White;
            this.btnAddInstructor.Location = new System.Drawing.Point(680, 596);
            this.btnAddInstructor.Name = "btnAddInstructor";
            this.btnAddInstructor.Size = new System.Drawing.Size(150, 40);
            this.btnAddInstructor.TabIndex = 10;
            this.btnAddInstructor.Text = "Add Data";
            this.btnAddInstructor.TextColor = System.Drawing.Color.White;
            this.btnAddInstructor.UseVisualStyleBackColor = false;
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
            this.btnImportInstructor.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportInstructor.ForeColor = System.Drawing.Color.White;
            this.btnImportInstructor.Location = new System.Drawing.Point(511, 596);
            this.btnImportInstructor.Name = "btnImportInstructor";
            this.btnImportInstructor.Size = new System.Drawing.Size(150, 40);
            this.btnImportInstructor.TabIndex = 11;
            this.btnImportInstructor.Text = "Import Data";
            this.btnImportInstructor.TextColor = System.Drawing.Color.White;
            this.btnImportInstructor.UseVisualStyleBackColor = false;
            // 
            // bdgv_Instructor
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bdgv_Instructor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bdgv_Instructor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bdgv_Instructor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bdgv_Instructor.BackgroundColor = System.Drawing.Color.White;
            this.bdgv_Instructor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bdgv_Instructor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bdgv_Instructor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bdgv_Instructor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bdgv_Instructor.ColumnHeadersHeight = 40;
            this.bdgv_Instructor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.bdgv_Instructor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.bdgv_Instructor.DoubleBuffered = true;
            this.bdgv_Instructor.EnableHeadersVisualStyles = false;
            this.bdgv_Instructor.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.bdgv_Instructor.HeaderForeColor = System.Drawing.Color.White;
            this.bdgv_Instructor.Location = new System.Drawing.Point(61, 160);
            this.bdgv_Instructor.Name = "bdgv_Instructor";
            this.bdgv_Instructor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bdgv_Instructor.RowHeadersVisible = false;
            this.bdgv_Instructor.RowHeadersWidth = 51;
            this.bdgv_Instructor.RowTemplate.Height = 24;
            this.bdgv_Instructor.Size = new System.Drawing.Size(769, 413);
            this.bdgv_Instructor.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NIP";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Name";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Level";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Action";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // fInstructorData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 721);
            this.Controls.Add(this.bdgv_Instructor);
            this.Controls.Add(this.btnImportInstructor);
            this.Controls.Add(this.btnAddInstructor);
            this.Controls.Add(this.dgv_instructor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fInstructorData";
            this.Text = "fInstructorData";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_instructor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgv_Instructor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_instructor;
        private ViControls.ViButton btnAddInstructor;
        private ViControls.ViButton btnImportInstructor;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bdgv_Instructor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}