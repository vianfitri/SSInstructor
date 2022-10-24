
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
            this.btnAdd = new ViControls.ViButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScenName = new ViControls.ViTextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(133)))), ((int)(((byte)(193)))));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(133)))), ((int)(((byte)(193)))));
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(217, 103);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 32);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "SAVE";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Scenario Name";
            // 
            // txtScenName
            // 
            this.txtScenName.BackColor = System.Drawing.SystemColors.Window;
            this.txtScenName.BorderColor = System.Drawing.Color.Gray;
            this.txtScenName.BorderFocusColor = System.Drawing.Color.SkyBlue;
            this.txtScenName.BorderRadius = 10;
            this.txtScenName.BorderSize = 1;
            this.txtScenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScenName.ForeColor = System.Drawing.Color.DimGray;
            this.txtScenName.Location = new System.Drawing.Point(196, 41);
            this.txtScenName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtScenName.Multiline = false;
            this.txtScenName.Name = "txtScenName";
            this.txtScenName.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtScenName.PasswordChar = false;
            this.txtScenName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtScenName.PlaceholderText = "";
            this.txtScenName.Size = new System.Drawing.Size(250, 33);
            this.txtScenName.TabIndex = 14;
            this.txtScenName.Texts = "";
            this.txtScenName.UnderlinedStyle = false;
            this.txtScenName._TextChanged += new System.EventHandler(this.txtScenName__TextChanged);
            // 
            // FormAddScen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 163);
            this.Controls.Add(this.txtScenName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Name = "FormAddScen";
            this.Text = "FormAddScen";
            this.Load += new System.EventHandler(this.FormAddScen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ViControls.ViButton btnAdd;
        private System.Windows.Forms.Label label2;
        private ViControls.ViTextBox txtScenName;
    }
}