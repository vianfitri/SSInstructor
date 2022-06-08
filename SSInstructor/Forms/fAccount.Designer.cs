
namespace SSInstructor.Forms
{
    partial class fAccount
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
            this.btnAssignAccount = new ViControls.ViButton();
            this.dgv_account = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_account)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAssignAccount
            // 
            this.btnAssignAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAssignAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(184)))), ((int)(((byte)(249)))));
            this.btnAssignAccount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(184)))), ((int)(((byte)(249)))));
            this.btnAssignAccount.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAssignAccount.BorderRadius = 10;
            this.btnAssignAccount.BorderSize = 0;
            this.btnAssignAccount.FlatAppearance.BorderSize = 0;
            this.btnAssignAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignAccount.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignAccount.ForeColor = System.Drawing.Color.White;
            this.btnAssignAccount.Location = new System.Drawing.Point(680, 596);
            this.btnAssignAccount.Name = "btnAssignAccount";
            this.btnAssignAccount.Size = new System.Drawing.Size(150, 40);
            this.btnAssignAccount.TabIndex = 19;
            this.btnAssignAccount.Text = "Assign";
            this.btnAssignAccount.TextColor = System.Drawing.Color.White;
            this.btnAssignAccount.UseVisualStyleBackColor = false;
            // 
            // dgv_account
            // 
            this.dgv_account.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_account.Location = new System.Drawing.Point(61, 160);
            this.dgv_account.Name = "dgv_account";
            this.dgv_account.RowHeadersWidth = 51;
            this.dgv_account.RowTemplate.Height = 24;
            this.dgv_account.Size = new System.Drawing.Size(769, 413);
            this.dgv_account.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(118)))), ((int)(((byte)(159)))));
            this.label2.Location = new System.Drawing.Point(60, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Account";
            // 
            // fAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 721);
            this.Controls.Add(this.btnAssignAccount);
            this.Controls.Add(this.dgv_account);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fAccount";
            this.Text = "fAccount";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_account)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ViControls.ViButton btnAssignAccount;
        private System.Windows.Forms.DataGridView dgv_account;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}