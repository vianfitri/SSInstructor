
namespace SSInstructor.Forms
{
    partial class FReqAssistantcs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReqAssSilent = new System.Windows.Forms.Button();
            this.btnReqAssEnable = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_ReqAssList = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAck = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReqAssList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Requestable Assistant";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnReqAssSilent);
            this.groupBox1.Controls.Add(this.btnReqAssEnable);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(48, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 186);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Feature Control";
            // 
            // btnReqAssSilent
            // 
            this.btnReqAssSilent.Location = new System.Drawing.Point(43, 111);
            this.btnReqAssSilent.Name = "btnReqAssSilent";
            this.btnReqAssSilent.Size = new System.Drawing.Size(102, 49);
            this.btnReqAssSilent.TabIndex = 1;
            this.btnReqAssSilent.Text = "Silent";
            this.btnReqAssSilent.UseVisualStyleBackColor = true;
            this.btnReqAssSilent.Click += new System.EventHandler(this.btnReqAssSilent_Click);
            // 
            // btnReqAssEnable
            // 
            this.btnReqAssEnable.Location = new System.Drawing.Point(43, 46);
            this.btnReqAssEnable.Name = "btnReqAssEnable";
            this.btnReqAssEnable.Size = new System.Drawing.Size(102, 49);
            this.btnReqAssEnable.TabIndex = 0;
            this.btnReqAssEnable.Text = "Enable";
            this.btnReqAssEnable.UseVisualStyleBackColor = true;
            this.btnReqAssEnable.Click += new System.EventHandler(this.btnReqAssEnable_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 315);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Assistant ToDo List";
            // 
            // dgv_ReqAssList
            // 
            this.dgv_ReqAssList.AllowUserToAddRows = false;
            this.dgv_ReqAssList.AllowUserToDeleteRows = false;
            this.dgv_ReqAssList.AllowUserToResizeColumns = false;
            this.dgv_ReqAssList.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgv_ReqAssList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_ReqAssList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ReqAssList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ReqAssList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ReqAssList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ReqAssList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_ReqAssList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ReqAssList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_ReqAssList.ColumnHeadersHeight = 40;
            this.dgv_ReqAssList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_ReqAssList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.pcname,
            this.btnAck});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ReqAssList.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_ReqAssList.EnableHeadersVisualStyles = false;
            this.dgv_ReqAssList.Location = new System.Drawing.Point(48, 361);
            this.dgv_ReqAssList.MultiSelect = false;
            this.dgv_ReqAssList.Name = "dgv_ReqAssList";
            this.dgv_ReqAssList.ReadOnly = true;
            this.dgv_ReqAssList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_ReqAssList.RowHeadersVisible = false;
            this.dgv_ReqAssList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgv_ReqAssList.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_ReqAssList.RowTemplate.Height = 40;
            this.dgv_ReqAssList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ReqAssList.Size = new System.Drawing.Size(363, 234);
            this.dgv_ReqAssList.TabIndex = 21;
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
            // pcname
            // 
            this.pcname.FillWeight = 64.52919F;
            this.pcname.HeaderText = "Computer Name";
            this.pcname.Name = "pcname";
            this.pcname.ReadOnly = true;
            // 
            // btnAck
            // 
            this.btnAck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btnAck.HeaderText = "ACK";
            this.btnAck.MinimumWidth = 6;
            this.btnAck.Name = "btnAck";
            this.btnAck.ReadOnly = true;
            this.btnAck.Width = 50;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FReqAssistantcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 643);
            this.Controls.Add(this.dgv_ReqAssList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FReqAssistantcs";
            this.Text = "FReqAssistantcs";
            this.Load += new System.EventHandler(this.FReqAssistantcs_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReqAssList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReqAssEnable;
        private System.Windows.Forms.Button btnReqAssSilent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_ReqAssList;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcname;
        private System.Windows.Forms.DataGridViewButtonColumn btnAck;
        private System.Windows.Forms.Button button1;
    }
}