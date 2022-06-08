
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_instructor = new System.Windows.Forms.DataGridView();
            this.btnAddInstructor = new ViControls.ViButton();
            this.btnImportInstructor = new ViControls.ViButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_instructor)).BeginInit();
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
            this.dgv_instructor.Location = new System.Drawing.Point(61, 160);
            this.dgv_instructor.Name = "dgv_instructor";
            this.dgv_instructor.RowHeadersWidth = 51;
            this.dgv_instructor.RowTemplate.Height = 24;
            this.dgv_instructor.Size = new System.Drawing.Size(769, 413);
            this.dgv_instructor.TabIndex = 8;
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
            // fInstructorData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 721);
            this.Controls.Add(this.btnImportInstructor);
            this.Controls.Add(this.btnAddInstructor);
            this.Controls.Add(this.dgv_instructor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fInstructorData";
            this.Text = "fInstructorData";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_instructor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_instructor;
        private ViControls.ViButton btnAddInstructor;
        private ViControls.ViButton btnImportInstructor;
    }
}