﻿
namespace SSInstructor.Forms
{
    partial class fAddCargo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCargoName = new ViControls.ViTextBox();
            this.txtCargoWeight = new ViControls.ViTextBox();
            this.txtCargoVolume = new ViControls.ViTextBox();
            this.btnAdd = new ViControls.ViButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cargo name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Weight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Volume";
            // 
            // txtCargoName
            // 
            this.txtCargoName.BackColor = System.Drawing.SystemColors.Window;
            this.txtCargoName.BorderColor = System.Drawing.Color.Gray;
            this.txtCargoName.BorderFocusColor = System.Drawing.Color.SkyBlue;
            this.txtCargoName.BorderRadius = 10;
            this.txtCargoName.BorderSize = 1;
            this.txtCargoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargoName.ForeColor = System.Drawing.Color.DimGray;
            this.txtCargoName.Location = new System.Drawing.Point(164, 65);
            this.txtCargoName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCargoName.Multiline = false;
            this.txtCargoName.Name = "txtCargoName";
            this.txtCargoName.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtCargoName.PasswordChar = false;
            this.txtCargoName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCargoName.PlaceholderText = "";
            this.txtCargoName.Size = new System.Drawing.Size(250, 33);
            this.txtCargoName.TabIndex = 7;
            this.txtCargoName.Texts = "";
            this.txtCargoName.UnderlinedStyle = false;
            // 
            // txtCargoWeight
            // 
            this.txtCargoWeight.BackColor = System.Drawing.SystemColors.Window;
            this.txtCargoWeight.BorderColor = System.Drawing.Color.Gray;
            this.txtCargoWeight.BorderFocusColor = System.Drawing.Color.SkyBlue;
            this.txtCargoWeight.BorderRadius = 10;
            this.txtCargoWeight.BorderSize = 1;
            this.txtCargoWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargoWeight.ForeColor = System.Drawing.Color.DimGray;
            this.txtCargoWeight.Location = new System.Drawing.Point(164, 108);
            this.txtCargoWeight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCargoWeight.Multiline = false;
            this.txtCargoWeight.Name = "txtCargoWeight";
            this.txtCargoWeight.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtCargoWeight.PasswordChar = false;
            this.txtCargoWeight.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCargoWeight.PlaceholderText = "0";
            this.txtCargoWeight.Size = new System.Drawing.Size(134, 33);
            this.txtCargoWeight.TabIndex = 8;
            this.txtCargoWeight.Texts = "";
            this.txtCargoWeight.UnderlinedStyle = false;
            // 
            // txtCargoVolume
            // 
            this.txtCargoVolume.BackColor = System.Drawing.SystemColors.Window;
            this.txtCargoVolume.BorderColor = System.Drawing.Color.Gray;
            this.txtCargoVolume.BorderFocusColor = System.Drawing.Color.SkyBlue;
            this.txtCargoVolume.BorderRadius = 10;
            this.txtCargoVolume.BorderSize = 1;
            this.txtCargoVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargoVolume.ForeColor = System.Drawing.Color.DimGray;
            this.txtCargoVolume.Location = new System.Drawing.Point(164, 152);
            this.txtCargoVolume.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCargoVolume.Multiline = false;
            this.txtCargoVolume.Name = "txtCargoVolume";
            this.txtCargoVolume.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtCargoVolume.PasswordChar = false;
            this.txtCargoVolume.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCargoVolume.PlaceholderText = "0";
            this.txtCargoVolume.Size = new System.Drawing.Size(134, 33);
            this.txtCargoVolume.TabIndex = 9;
            this.txtCargoVolume.Texts = "";
            this.txtCargoVolume.UnderlinedStyle = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(133)))), ((int)(((byte)(193)))));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(133)))), ((int)(((byte)(193)))));
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(196, 219);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 32);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "SAVE";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(312, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "TON";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(312, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Metrics Ton";
            // 
            // fAddCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 302);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCargoVolume);
            this.Controls.Add(this.txtCargoWeight);
            this.Controls.Add(this.txtCargoName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fAddCargo";
            this.Text = "ADD CARGO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ViControls.ViTextBox txtCargoName;
        private ViControls.ViTextBox txtCargoWeight;
        private ViControls.ViTextBox txtCargoVolume;
        private ViControls.ViButton btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}