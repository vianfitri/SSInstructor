
namespace SSInstructor.Forms
{
    partial class fSetting
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnlChangeDBConn = new System.Windows.Forms.Panel();
            this.btnDBChange = new ViControls.ViButton();
            this.txtDBName = new ViControls.ViTextBox();
            this.txtDBPass = new ViControls.ViTextBox();
            this.txtDBUser = new ViControls.ViTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChangePass = new ViControls.ViButton();
            this.txtRetyprPass = new ViControls.ViTextBox();
            this.txtNewPass = new ViControls.ViTextBox();
            this.txtOldPassword = new ViControls.ViTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.viPanel1 = new ViControls.ViPanel();
            this.pnlChangeDBConn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Setting";
            // 
            // pnlChangeDBConn
            // 
            this.pnlChangeDBConn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(235)))), ((int)(((byte)(221)))));
            this.pnlChangeDBConn.Controls.Add(this.btnDBChange);
            this.pnlChangeDBConn.Controls.Add(this.txtDBName);
            this.pnlChangeDBConn.Controls.Add(this.txtDBPass);
            this.pnlChangeDBConn.Controls.Add(this.txtDBUser);
            this.pnlChangeDBConn.Controls.Add(this.label5);
            this.pnlChangeDBConn.Controls.Add(this.label4);
            this.pnlChangeDBConn.Controls.Add(this.label3);
            this.pnlChangeDBConn.Controls.Add(this.label2);
            this.pnlChangeDBConn.Location = new System.Drawing.Point(64, 128);
            this.pnlChangeDBConn.Name = "pnlChangeDBConn";
            this.pnlChangeDBConn.Size = new System.Drawing.Size(337, 413);
            this.pnlChangeDBConn.TabIndex = 10;
            // 
            // btnDBChange
            // 
            this.btnDBChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(162)))), ((int)(((byte)(220)))));
            this.btnDBChange.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(162)))), ((int)(((byte)(220)))));
            this.btnDBChange.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDBChange.BorderRadius = 10;
            this.btnDBChange.BorderSize = 0;
            this.btnDBChange.FlatAppearance.BorderSize = 0;
            this.btnDBChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDBChange.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDBChange.ForeColor = System.Drawing.Color.White;
            this.btnDBChange.Location = new System.Drawing.Point(183, 318);
            this.btnDBChange.Name = "btnDBChange";
            this.btnDBChange.Size = new System.Drawing.Size(107, 40);
            this.btnDBChange.TabIndex = 7;
            this.btnDBChange.Text = "Change";
            this.btnDBChange.TextColor = System.Drawing.Color.White;
            this.btnDBChange.UseVisualStyleBackColor = false;
            // 
            // txtDBName
            // 
            this.txtDBName.BackColor = System.Drawing.SystemColors.Window;
            this.txtDBName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDBName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDBName.BorderRadius = 8;
            this.txtDBName.BorderSize = 1;
            this.txtDBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDBName.ForeColor = System.Drawing.Color.DimGray;
            this.txtDBName.Location = new System.Drawing.Point(37, 262);
            this.txtDBName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDBName.Multiline = false;
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDBName.PasswordChar = false;
            this.txtDBName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDBName.PlaceholderText = "";
            this.txtDBName.Size = new System.Drawing.Size(253, 35);
            this.txtDBName.TabIndex = 6;
            this.txtDBName.Texts = "Database";
            this.txtDBName.UnderlinedStyle = false;
            // 
            // txtDBPass
            // 
            this.txtDBPass.BackColor = System.Drawing.SystemColors.Window;
            this.txtDBPass.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDBPass.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDBPass.BorderRadius = 8;
            this.txtDBPass.BorderSize = 1;
            this.txtDBPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDBPass.ForeColor = System.Drawing.Color.DimGray;
            this.txtDBPass.Location = new System.Drawing.Point(37, 186);
            this.txtDBPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDBPass.Multiline = false;
            this.txtDBPass.Name = "txtDBPass";
            this.txtDBPass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDBPass.PasswordChar = true;
            this.txtDBPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDBPass.PlaceholderText = "Password";
            this.txtDBPass.Size = new System.Drawing.Size(253, 35);
            this.txtDBPass.TabIndex = 5;
            this.txtDBPass.Texts = "";
            this.txtDBPass.UnderlinedStyle = false;
            // 
            // txtDBUser
            // 
            this.txtDBUser.BackColor = System.Drawing.SystemColors.Window;
            this.txtDBUser.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDBUser.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDBUser.BorderRadius = 8;
            this.txtDBUser.BorderSize = 1;
            this.txtDBUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDBUser.ForeColor = System.Drawing.Color.DimGray;
            this.txtDBUser.Location = new System.Drawing.Point(37, 113);
            this.txtDBUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDBUser.Multiline = false;
            this.txtDBUser.Name = "txtDBUser";
            this.txtDBUser.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDBUser.PasswordChar = false;
            this.txtDBUser.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDBUser.PlaceholderText = "Username";
            this.txtDBUser.Size = new System.Drawing.Size(253, 35);
            this.txtDBUser.TabIndex = 4;
            this.txtDBUser.Texts = "";
            this.txtDBUser.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Database";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Database Connection";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.panel1.Controls.Add(this.btnChangePass);
            this.panel1.Controls.Add(this.txtRetyprPass);
            this.panel1.Controls.Add(this.txtNewPass);
            this.panel1.Controls.Add(this.txtOldPassword);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(464, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 413);
            this.panel1.TabIndex = 11;
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(162)))), ((int)(((byte)(220)))));
            this.btnChangePass.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(162)))), ((int)(((byte)(220)))));
            this.btnChangePass.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnChangePass.BorderRadius = 10;
            this.btnChangePass.BorderSize = 0;
            this.btnChangePass.FlatAppearance.BorderSize = 0;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.ForeColor = System.Drawing.Color.White;
            this.btnChangePass.Location = new System.Drawing.Point(183, 318);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(107, 40);
            this.btnChangePass.TabIndex = 7;
            this.btnChangePass.Text = "Change";
            this.btnChangePass.TextColor = System.Drawing.Color.White;
            this.btnChangePass.UseVisualStyleBackColor = false;
            // 
            // txtRetyprPass
            // 
            this.txtRetyprPass.BackColor = System.Drawing.SystemColors.Window;
            this.txtRetyprPass.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtRetyprPass.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtRetyprPass.BorderRadius = 8;
            this.txtRetyprPass.BorderSize = 1;
            this.txtRetyprPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetyprPass.ForeColor = System.Drawing.Color.DimGray;
            this.txtRetyprPass.Location = new System.Drawing.Point(37, 262);
            this.txtRetyprPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRetyprPass.Multiline = false;
            this.txtRetyprPass.Name = "txtRetyprPass";
            this.txtRetyprPass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRetyprPass.PasswordChar = true;
            this.txtRetyprPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtRetyprPass.PlaceholderText = "Re-type Password";
            this.txtRetyprPass.Size = new System.Drawing.Size(253, 35);
            this.txtRetyprPass.TabIndex = 6;
            this.txtRetyprPass.Texts = "";
            this.txtRetyprPass.UnderlinedStyle = false;
            // 
            // txtNewPass
            // 
            this.txtNewPass.BackColor = System.Drawing.SystemColors.Window;
            this.txtNewPass.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNewPass.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNewPass.BorderRadius = 8;
            this.txtNewPass.BorderSize = 1;
            this.txtNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.ForeColor = System.Drawing.Color.DimGray;
            this.txtNewPass.Location = new System.Drawing.Point(37, 186);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewPass.Multiline = false;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNewPass.PasswordChar = true;
            this.txtNewPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNewPass.PlaceholderText = "New Password";
            this.txtNewPass.Size = new System.Drawing.Size(253, 35);
            this.txtNewPass.TabIndex = 5;
            this.txtNewPass.Texts = "";
            this.txtNewPass.UnderlinedStyle = false;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtOldPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtOldPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtOldPassword.BorderRadius = 8;
            this.txtOldPassword.BorderSize = 1;
            this.txtOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtOldPassword.Location = new System.Drawing.Point(37, 113);
            this.txtOldPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOldPassword.Multiline = false;
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtOldPassword.PasswordChar = true;
            this.txtOldPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtOldPassword.PlaceholderText = "Old Password";
            this.txtOldPassword.Size = new System.Drawing.Size(253, 35);
            this.txtOldPassword.TabIndex = 4;
            this.txtOldPassword.Texts = "";
            this.txtOldPassword.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Re-type Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "New Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Old Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(218, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Change Password Account";
            // 
            // viPanel1
            // 
            this.viPanel1.Location = new System.Drawing.Point(372, 594);
            this.viPanel1.MBack = System.Drawing.Color.Silver;
            this.viPanel1.MMatrixRound = 8;
            this.viPanel1.Name = "viPanel1";
            this.viPanel1.Size = new System.Drawing.Size(200, 100);
            this.viPanel1.TabIndex = 12;
            // 
            // fSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 721);
            this.Controls.Add(this.viPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlChangeDBConn);
            this.Controls.Add(this.label1);
            this.Name = "fSetting";
            this.Text = "fSetting";
            this.pnlChangeDBConn.ResumeLayout(false);
            this.pnlChangeDBConn.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlChangeDBConn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private ViControls.ViButton btnDBChange;
        private ViControls.ViTextBox txtDBName;
        private ViControls.ViTextBox txtDBPass;
        private ViControls.ViTextBox txtDBUser;
        private System.Windows.Forms.Panel panel1;
        private ViControls.ViButton btnChangePass;
        private ViControls.ViTextBox txtRetyprPass;
        private ViControls.ViTextBox txtNewPass;
        private ViControls.ViTextBox txtOldPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private ViControls.ViPanel viPanel1;
    }
}