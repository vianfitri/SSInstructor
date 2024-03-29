﻿
namespace SSInstructor.Controls
{
    partial class ClientPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPCName = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pbStatus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPCName
            // 
            this.lblPCName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.lblPCName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPCName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPCName.ForeColor = System.Drawing.Color.White;
            this.lblPCName.Location = new System.Drawing.Point(0, 110);
            this.lblPCName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPCName.Name = "lblPCName";
            this.lblPCName.Size = new System.Drawing.Size(107, 20);
            this.lblPCName.TabIndex = 1;
            this.lblPCName.Text = "PC Name";
            this.lblPCName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLogin
            // 
            this.lblLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.lblLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(0, 130);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(107, 20);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Not Logged In Yet";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogin.Visible = false;
            // 
            // pbStatus
            // 
            this.pbStatus.Image = global::SSInstructor.Properties.Resources.computer_off;
            this.pbStatus.Location = new System.Drawing.Point(16, 9);
            this.pbStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(75, 81);
            this.pbStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStatus.TabIndex = 0;
            this.pbStatus.TabStop = false;
            // 
            // ClientPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPCName);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pbStatus);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ClientPanel";
            this.Size = new System.Drawing.Size(107, 150);
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbStatus;
        private System.Windows.Forms.Label lblPCName;
        private System.Windows.Forms.Label lblLogin;
    }
}
