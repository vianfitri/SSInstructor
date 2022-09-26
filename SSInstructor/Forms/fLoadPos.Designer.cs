
namespace SSInstructor.Forms
{
    partial class fLoadPos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chartLoadSideView = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chartLoadTopView = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chartLoadFrontView = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label52 = new System.Windows.Forms.Label();
            this.txtTransvPosMtr = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.txtLoadTon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudTransvPos = new System.Windows.Forms.NumericUpDown();
            this.label94 = new System.Windows.Forms.Label();
            this.nudLoad = new System.Windows.Forms.NumericUpDown();
            this.txtLongPosMtr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudLongPos = new System.Windows.Forms.NumericUpDown();
            this.txtVertcPosM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudVertcPos = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLoadSideView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLoadTopView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLoadFrontView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTransvPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVertcPos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Stability Calculation";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(64, 613);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(768, 404);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chartLoadSideView);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(760, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SIDE VIEW";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chartLoadSideView
            // 
            chartArea7.Name = "ChartArea1";
            this.chartLoadSideView.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartLoadSideView.Legends.Add(legend7);
            this.chartLoadSideView.Location = new System.Drawing.Point(29, 21);
            this.chartLoadSideView.Name = "chartLoadSideView";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chartLoadSideView.Series.Add(series7);
            this.chartLoadSideView.Size = new System.Drawing.Size(703, 315);
            this.chartLoadSideView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chartLoadTopView);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(760, 375);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TOP VIEW";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartLoadTopView
            // 
            chartArea8.Name = "ChartArea1";
            this.chartLoadTopView.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartLoadTopView.Legends.Add(legend8);
            this.chartLoadTopView.Location = new System.Drawing.Point(29, 19);
            this.chartLoadTopView.Name = "chartLoadTopView";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chartLoadTopView.Series.Add(series8);
            this.chartLoadTopView.Size = new System.Drawing.Size(700, 311);
            this.chartLoadTopView.TabIndex = 0;
            this.chartLoadTopView.Text = "chart2";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chartLoadFrontView);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(760, 375);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "FRONT VIEW";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chartLoadFrontView
            // 
            chartArea9.Name = "ChartArea1";
            this.chartLoadFrontView.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chartLoadFrontView.Legends.Add(legend9);
            this.chartLoadFrontView.Location = new System.Drawing.Point(26, 21);
            this.chartLoadFrontView.Name = "chartLoadFrontView";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chartLoadFrontView.Series.Add(series9);
            this.chartLoadFrontView.Size = new System.Drawing.Size(709, 311);
            this.chartLoadFrontView.TabIndex = 0;
            this.chartLoadFrontView.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtVertcPosM);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudVertcPos);
            this.groupBox1.Controls.Add(this.txtLongPosMtr);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudLongPos);
            this.groupBox1.Controls.Add(this.label52);
            this.groupBox1.Controls.Add(this.txtTransvPosMtr);
            this.groupBox1.Controls.Add(this.label48);
            this.groupBox1.Controls.Add(this.txtLoadTon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudTransvPos);
            this.groupBox1.Controls.Add(this.label94);
            this.groupBox1.Controls.Add(this.nudLoad);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(64, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 296);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " LOAD ";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(289, 134);
            this.label52.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(37, 17);
            this.label52.TabIndex = 92;
            this.label52.Text = "( m )";
            // 
            // txtTransvPosMtr
            // 
            this.txtTransvPosMtr.Location = new System.Drawing.Point(208, 131);
            this.txtTransvPosMtr.Margin = new System.Windows.Forms.Padding(4);
            this.txtTransvPosMtr.Name = "txtTransvPosMtr";
            this.txtTransvPosMtr.ReadOnly = true;
            this.txtTransvPosMtr.Size = new System.Drawing.Size(73, 22);
            this.txtTransvPosMtr.TabIndex = 91;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(289, 79);
            this.label48.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(46, 17);
            this.label48.TabIndex = 90;
            this.label48.Text = "( ton )";
            // 
            // txtLoadTon
            // 
            this.txtLoadTon.Location = new System.Drawing.Point(208, 76);
            this.txtLoadTon.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoadTon.Name = "txtLoadTon";
            this.txtLoadTon.ReadOnly = true;
            this.txtLoadTon.Size = new System.Drawing.Size(73, 22);
            this.txtLoadTon.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 88;
            this.label2.Text = "Transversal Position";
            // 
            // nudTransvPos
            // 
            this.nudTransvPos.Location = new System.Drawing.Point(208, 104);
            this.nudTransvPos.Margin = new System.Windows.Forms.Padding(4);
            this.nudTransvPos.Maximum = new decimal(new int[] {
            1100,
            0,
            0,
            0});
            this.nudTransvPos.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudTransvPos.Name = "nudTransvPos";
            this.nudTransvPos.Size = new System.Drawing.Size(75, 22);
            this.nudTransvPos.TabIndex = 87;
            this.nudTransvPos.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Location = new System.Drawing.Point(27, 51);
            this.label94.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(88, 17);
            this.label94.TabIndex = 86;
            this.label94.Text = "Load Weight";
            // 
            // nudLoad
            // 
            this.nudLoad.DecimalPlaces = 1;
            this.nudLoad.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudLoad.Location = new System.Drawing.Point(208, 49);
            this.nudLoad.Margin = new System.Windows.Forms.Padding(4);
            this.nudLoad.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudLoad.Name = "nudLoad";
            this.nudLoad.Size = new System.Drawing.Size(75, 22);
            this.nudLoad.TabIndex = 85;
            // 
            // txtLongPosMtr
            // 
            this.txtLongPosMtr.Location = new System.Drawing.Point(208, 188);
            this.txtLongPosMtr.Margin = new System.Windows.Forms.Padding(4);
            this.txtLongPosMtr.Name = "txtLongPosMtr";
            this.txtLongPosMtr.ReadOnly = true;
            this.txtLongPosMtr.Size = new System.Drawing.Size(73, 22);
            this.txtLongPosMtr.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 17);
            this.label3.TabIndex = 94;
            this.label3.Text = "Longitudinal Position";
            // 
            // nudLongPos
            // 
            this.nudLongPos.Location = new System.Drawing.Point(208, 161);
            this.nudLongPos.Margin = new System.Windows.Forms.Padding(4);
            this.nudLongPos.Maximum = new decimal(new int[] {
            1100,
            0,
            0,
            0});
            this.nudLongPos.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudLongPos.Name = "nudLongPos";
            this.nudLongPos.Size = new System.Drawing.Size(75, 22);
            this.nudLongPos.TabIndex = 93;
            this.nudLongPos.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // txtVertcPosM
            // 
            this.txtVertcPosM.Location = new System.Drawing.Point(208, 245);
            this.txtVertcPosM.Margin = new System.Windows.Forms.Padding(4);
            this.txtVertcPosM.Name = "txtVertcPosM";
            this.txtVertcPosM.ReadOnly = true;
            this.txtVertcPosM.Size = new System.Drawing.Size(73, 22);
            this.txtVertcPosM.TabIndex = 98;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 97;
            this.label4.Text = "Vertical Position";
            // 
            // nudVertcPos
            // 
            this.nudVertcPos.Location = new System.Drawing.Point(208, 218);
            this.nudVertcPos.Margin = new System.Windows.Forms.Padding(4);
            this.nudVertcPos.Maximum = new decimal(new int[] {
            1100,
            0,
            0,
            0});
            this.nudVertcPos.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudVertcPos.Name = "nudVertcPos";
            this.nudVertcPos.Size = new System.Drawing.Size(75, 22);
            this.nudVertcPos.TabIndex = 96;
            this.nudVertcPos.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 99;
            this.label5.Text = "( kg )";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 100;
            this.label6.Text = "( mm )";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 163);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 102;
            this.label7.Text = "( mm )";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 191);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 101;
            this.label8.Text = "( m )";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(289, 220);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 104;
            this.label9.Text = "( mm )";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(289, 248);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 17);
            this.label10.TabIndex = 103;
            this.label10.Text = "( m )";
            // 
            // fLoadPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 721);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "fLoadPos";
            this.Text = "fLoadPos";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartLoadSideView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartLoadTopView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartLoadFrontView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTransvPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVertcPos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLoadSideView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLoadTopView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLoadFrontView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox txtTransvPosMtr;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox txtLoadTon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudTransvPos;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.NumericUpDown nudLoad;
        private System.Windows.Forms.TextBox txtVertcPosM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudVertcPos;
        private System.Windows.Forms.TextBox txtLongPosMtr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudLongPos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}