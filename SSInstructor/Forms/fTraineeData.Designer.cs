
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
            this.btnImportTrainee = new ViControls.ViButton();
            this.btnAddTrainee = new ViControls.ViButton();
            this.dgv_trainee = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trainee)).BeginInit();
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
            this.btnImportTrainee.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportTrainee.ForeColor = System.Drawing.Color.White;
            this.btnImportTrainee.Location = new System.Drawing.Point(515, 596);
            this.btnImportTrainee.Name = "btnImportTrainee";
            this.btnImportTrainee.Size = new System.Drawing.Size(150, 40);
            this.btnImportTrainee.TabIndex = 16;
            this.btnImportTrainee.Text = "Import Data";
            this.btnImportTrainee.TextColor = System.Drawing.Color.White;
            this.btnImportTrainee.UseVisualStyleBackColor = false;
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
            this.btnAddTrainee.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTrainee.ForeColor = System.Drawing.Color.White;
            this.btnAddTrainee.Location = new System.Drawing.Point(680, 596);
            this.btnAddTrainee.Name = "btnAddTrainee";
            this.btnAddTrainee.Size = new System.Drawing.Size(150, 40);
            this.btnAddTrainee.TabIndex = 15;
            this.btnAddTrainee.Text = "Add Data";
            this.btnAddTrainee.TextColor = System.Drawing.Color.White;
            this.btnAddTrainee.UseVisualStyleBackColor = false;
            // 
            // dgv_trainee
            // 
            this.dgv_trainee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_trainee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_trainee.Location = new System.Drawing.Point(61, 160);
            this.dgv_trainee.Name = "dgv_trainee";
            this.dgv_trainee.RowHeadersWidth = 51;
            this.dgv_trainee.RowTemplate.Height = 24;
            this.dgv_trainee.Size = new System.Drawing.Size(769, 413);
            this.dgv_trainee.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(118)))), ((int)(((byte)(159)))));
            this.label2.Location = new System.Drawing.Point(60, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Trainee";
            // 
            // fTraineeData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 721);
            this.Controls.Add(this.btnImportTrainee);
            this.Controls.Add(this.btnAddTrainee);
            this.Controls.Add(this.dgv_trainee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fTraineeData";
            this.Text = "fTraineeData";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trainee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ViControls.ViButton btnImportTrainee;
        private ViControls.ViButton btnAddTrainee;
        private System.Windows.Forms.DataGridView dgv_trainee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}