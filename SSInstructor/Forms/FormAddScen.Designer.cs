
namespace SSInstructor.Forms
{
    partial class FormAddScen
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
            this.txtScenarioName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnScenSave = new ViControls.ViButton();
            this.cbVesselType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAddScen = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtScenarioName
            // 
            this.txtScenarioName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScenarioName.Location = new System.Drawing.Point(208, 35);
            this.txtScenarioName.Name = "txtScenarioName";
            this.txtScenarioName.Size = new System.Drawing.Size(233, 29);
            this.txtScenarioName.TabIndex = 25;
            this.txtScenarioName.TextChanged += new System.EventHandler(this.txtScenarioName_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnScenSave);
            this.groupBox1.Controls.Add(this.cbVesselType);
            this.groupBox1.Controls.Add(this.txtScenarioName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(41, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 265);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // btnScenSave
            // 
            this.btnScenSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScenSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(133)))), ((int)(((byte)(193)))));
            this.btnScenSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(133)))), ((int)(((byte)(193)))));
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
            this.btnScenSave.Click += new System.EventHandler(this.btnScenSave_Click);
            // 
            // cbVesselType
            // 
            this.cbVesselType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVesselType.FormattingEnabled = true;
            this.cbVesselType.Items.AddRange(new object[] {
            "Bulk Carrier 50000 DWT",
            "General Cargo 3650 DWT",
            "Containership 4180 DWT"});
            this.cbVesselType.Location = new System.Drawing.Point(208, 85);
            this.cbVesselType.Name = "cbVesselType";
            this.cbVesselType.Size = new System.Drawing.Size(195, 32);
            this.cbVesselType.TabIndex = 26;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Scenario Name";
            // 
            // lblAddScen
            // 
            this.lblAddScen.AutoSize = true;
            this.lblAddScen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddScen.Location = new System.Drawing.Point(37, 25);
            this.lblAddScen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddScen.Name = "lblAddScen";
            this.lblAddScen.Size = new System.Drawing.Size(160, 24);
            this.lblAddScen.TabIndex = 24;
            this.lblAddScen.Text = "Create Scenario";
            // 
            // FormAddScen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 364);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAddScen);
            this.Name = "FormAddScen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddScen";
            this.Load += new System.EventHandler(this.FormAddScen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtScenarioName;
        private System.Windows.Forms.GroupBox groupBox1;
        private ViControls.ViButton btnScenSave;
        private System.Windows.Forms.ComboBox cbVesselType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAddScen;
    }
}