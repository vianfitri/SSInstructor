
namespace SSInstructor.Forms
{
    partial class fCargoData
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_cargo = new System.Windows.Forms.DataGridView();
            this.btnAddCargo = new ViControls.ViButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cargo)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bulk Cargo",
            "General Cargo",
            "Container"});
            this.comboBox1.Location = new System.Drawing.Point(193, 161);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "-- Choose --";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(118)))), ((int)(((byte)(159)))));
            this.label2.Location = new System.Drawing.Point(60, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cargo Data";
            // 
            // dgv_cargo
            // 
            this.dgv_cargo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_cargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cargo.Location = new System.Drawing.Point(65, 218);
            this.dgv_cargo.Name = "dgv_cargo";
            this.dgv_cargo.RowHeadersWidth = 51;
            this.dgv_cargo.RowTemplate.Height = 24;
            this.dgv_cargo.Size = new System.Drawing.Size(766, 378);
            this.dgv_cargo.TabIndex = 8;
            // 
            // btnAddCargo
            // 
            this.btnAddCargo.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddCargo.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddCargo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddCargo.BorderRadius = 10;
            this.btnAddCargo.BorderSize = 0;
            this.btnAddCargo.FlatAppearance.BorderSize = 0;
            this.btnAddCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCargo.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCargo.ForeColor = System.Drawing.Color.White;
            this.btnAddCargo.Location = new System.Drawing.Point(681, 615);
            this.btnAddCargo.Name = "btnAddCargo";
            this.btnAddCargo.Size = new System.Drawing.Size(150, 40);
            this.btnAddCargo.TabIndex = 9;
            this.btnAddCargo.Text = "ADD";
            this.btnAddCargo.TextColor = System.Drawing.Color.White;
            this.btnAddCargo.UseVisualStyleBackColor = false;
            // 
            // fCargoData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 721);
            this.Controls.Add(this.btnAddCargo);
            this.Controls.Add(this.dgv_cargo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fCargoData";
            this.Text = "fCargoData";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cargo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_cargo;
        private ViControls.ViButton btnAddCargo;
    }
}