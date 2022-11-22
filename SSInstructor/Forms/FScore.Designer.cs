
namespace SSInstructor.Forms
{
    partial class FScore
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ScoreList = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTrainee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scHeel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scTrim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scAftDrft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scFwdDrf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scAcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVesselType = new System.Windows.Forms.Label();
            this.cbScenName = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ScoreList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score Data";
            // 
            // dgv_ScoreList
            // 
            this.dgv_ScoreList.AllowUserToAddRows = false;
            this.dgv_ScoreList.AllowUserToDeleteRows = false;
            this.dgv_ScoreList.AllowUserToResizeColumns = false;
            this.dgv_ScoreList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgv_ScoreList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ScoreList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ScoreList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ScoreList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ScoreList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ScoreList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_ScoreList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ScoreList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ScoreList.ColumnHeadersHeight = 40;
            this.dgv_ScoreList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_ScoreList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.idTrainee,
            this.name,
            this.scHeel,
            this.scTrim,
            this.scAftDrft,
            this.scFwdDrf,
            this.scTime,
            this.scAcc,
            this.scFinal,
            this.Status});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ScoreList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ScoreList.EnableHeadersVisualStyles = false;
            this.dgv_ScoreList.Location = new System.Drawing.Point(48, 178);
            this.dgv_ScoreList.MultiSelect = false;
            this.dgv_ScoreList.Name = "dgv_ScoreList";
            this.dgv_ScoreList.ReadOnly = true;
            this.dgv_ScoreList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_ScoreList.RowHeadersVisible = false;
            this.dgv_ScoreList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgv_ScoreList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_ScoreList.RowTemplate.Height = 40;
            this.dgv_ScoreList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ScoreList.Size = new System.Drawing.Size(1221, 504);
            this.dgv_ScoreList.TabIndex = 21;
            this.dgv_ScoreList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ScoreList_CellClick);
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
            // idTrainee
            // 
            this.idTrainee.HeaderText = "NIT";
            this.idTrainee.Name = "idTrainee";
            this.idTrainee.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // scHeel
            // 
            this.scHeel.HeaderText = "Heel Score";
            this.scHeel.Name = "scHeel";
            this.scHeel.ReadOnly = true;
            // 
            // scTrim
            // 
            this.scTrim.HeaderText = "Trim Score";
            this.scTrim.Name = "scTrim";
            this.scTrim.ReadOnly = true;
            // 
            // scAftDrft
            // 
            this.scAftDrft.HeaderText = "Aft Draft Score";
            this.scAftDrft.Name = "scAftDrft";
            this.scAftDrft.ReadOnly = true;
            // 
            // scFwdDrf
            // 
            this.scFwdDrf.HeaderText = "Fwd Draft Score";
            this.scFwdDrf.Name = "scFwdDrf";
            this.scFwdDrf.ReadOnly = true;
            // 
            // scTime
            // 
            this.scTime.HeaderText = "Time Score";
            this.scTime.Name = "scTime";
            this.scTime.ReadOnly = true;
            // 
            // scAcc
            // 
            this.scAcc.HeaderText = "Acomplished Score";
            this.scAcc.Name = "scAcc";
            this.scAcc.ReadOnly = true;
            // 
            // scFinal
            // 
            this.scFinal.HeaderText = "Final Score";
            this.scFinal.Name = "scFinal";
            this.scFinal.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Scenario Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Vessel Type";
            // 
            // lblVesselType
            // 
            this.lblVesselType.AutoSize = true;
            this.lblVesselType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVesselType.Location = new System.Drawing.Point(194, 126);
            this.lblVesselType.Name = "lblVesselType";
            this.lblVesselType.Size = new System.Drawing.Size(180, 20);
            this.lblVesselType.TabIndex = 24;
            this.lblVesselType.Text = "Bulk Carrier 50000 DWT";
            // 
            // cbScenName
            // 
            this.cbScenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbScenName.FormattingEnabled = true;
            this.cbScenName.Location = new System.Drawing.Point(198, 83);
            this.cbScenName.Name = "cbScenName";
            this.cbScenName.Size = new System.Drawing.Size(337, 26);
            this.cbScenName.TabIndex = 25;
            this.cbScenName.SelectedIndexChanged += new System.EventHandler(this.cbScenName_SelectedIndexChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1159, 702);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(110, 35);
            this.btnPrint.TabIndex = 26;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 782);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cbScenName);
            this.Controls.Add(this.lblVesselType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_ScoreList);
            this.Controls.Add(this.label1);
            this.Name = "FScore";
            this.Text = "FScore";
            this.Load += new System.EventHandler(this.FScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ScoreList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_ScoreList;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTrainee;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn scHeel;
        private System.Windows.Forms.DataGridViewTextBoxColumn scTrim;
        private System.Windows.Forms.DataGridViewTextBoxColumn scAftDrft;
        private System.Windows.Forms.DataGridViewTextBoxColumn scFwdDrf;
        private System.Windows.Forms.DataGridViewTextBoxColumn scTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn scAcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn scFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVesselType;
        private System.Windows.Forms.ComboBox cbScenName;
        private System.Windows.Forms.Button btnPrint;
    }
}