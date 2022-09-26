
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chartLoadSideView = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartLoadTopView = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartLoadFrontView = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLoadSideView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLoadTopView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLoadFrontView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Load Position";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(64, 261);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chartLoadTopView);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(760, 358);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TOP VIEW";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chartLoadFrontView);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(760, 358);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "FRONT VIEW";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chartLoadSideView
            // 
            chartArea4.Name = "ChartArea1";
            this.chartLoadSideView.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartLoadSideView.Legends.Add(legend4);
            this.chartLoadSideView.Location = new System.Drawing.Point(29, 21);
            this.chartLoadSideView.Name = "chartLoadSideView";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartLoadSideView.Series.Add(series4);
            this.chartLoadSideView.Size = new System.Drawing.Size(703, 315);
            this.chartLoadSideView.TabIndex = 0;
            // 
            // chartLoadTopView
            // 
            chartArea5.Name = "ChartArea1";
            this.chartLoadTopView.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartLoadTopView.Legends.Add(legend5);
            this.chartLoadTopView.Location = new System.Drawing.Point(29, 19);
            this.chartLoadTopView.Name = "chartLoadTopView";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartLoadTopView.Series.Add(series5);
            this.chartLoadTopView.Size = new System.Drawing.Size(700, 311);
            this.chartLoadTopView.TabIndex = 0;
            this.chartLoadTopView.Text = "chart2";
            // 
            // chartLoadFrontView
            // 
            chartArea6.Name = "ChartArea1";
            this.chartLoadFrontView.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartLoadFrontView.Legends.Add(legend6);
            this.chartLoadFrontView.Location = new System.Drawing.Point(26, 21);
            this.chartLoadFrontView.Name = "chartLoadFrontView";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartLoadFrontView.Series.Add(series6);
            this.chartLoadFrontView.Size = new System.Drawing.Size(709, 311);
            this.chartLoadFrontView.TabIndex = 0;
            this.chartLoadFrontView.Text = "chart1";
            // 
            // fLoadPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 721);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "fLoadPos";
            this.Text = "fLoadPos";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartLoadSideView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLoadTopView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLoadFrontView)).EndInit();
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
    }
}