
namespace SSInstructor.Forms
{
    partial class fSSS
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
            this.spcShipStability = new System.Windows.Forms.SplitContainer();
            this.tabControlGraph = new System.Windows.Forms.TabControl();
            this.tabLoad = new System.Windows.Forms.TabPage();
            this.spcLoad1 = new System.Windows.Forms.SplitContainer();
            this.spcLoad2 = new System.Windows.Forms.SplitContainer();
            this.tabTransversal = new System.Windows.Forms.TabPage();
            this.tabLongitudinal = new System.Windows.Forms.TabPage();
            this.tabHydrostaticCurve = new System.Windows.Forms.TabPage();
            this.tabGZCrossCurve = new System.Windows.Forms.TabPage();
            this.tabKNCrossCurve = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControlInput = new System.Windows.Forms.TabControl();
            this.tabMovingLoad = new System.Windows.Forms.TabPage();
            this.tabStabilityInput = new System.Windows.Forms.TabPage();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabGraphTransversal = new System.Windows.Forms.TabPage();
            this.tabGraphHSCurve = new System.Windows.Forms.TabPage();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label38 = new System.Windows.Forms.Label();
            this.pnlLineColor = new System.Windows.Forms.Panel();
            this.label37 = new System.Windows.Forms.Label();
            this.pnlMarkerColor = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.nudLineWidth = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.nudMarkerSize = new System.Windows.Forms.NumericUpDown();
            this.cbxLineShow = new System.Windows.Forms.CheckBox();
            this.cbxMarkerShow = new System.Windows.Forms.CheckBox();
            this.cbbLineSelect = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbbMarkerSelect = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.pnlHSLegendTextColor = new System.Windows.Forms.Panel();
            this.label32 = new System.Windows.Forms.Label();
            this.pnlHSGridColor = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlHSLineColor = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.pnlHSBGColor = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.nudHSLineWidth = new System.Windows.Forms.NumericUpDown();
            this.cbbHSLineSelect = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spcShipStability)).BeginInit();
            this.spcShipStability.Panel1.SuspendLayout();
            this.spcShipStability.Panel2.SuspendLayout();
            this.spcShipStability.SuspendLayout();
            this.tabControlGraph.SuspendLayout();
            this.tabLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcLoad1)).BeginInit();
            this.spcLoad1.Panel1.SuspendLayout();
            this.spcLoad1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcLoad2)).BeginInit();
            this.spcLoad2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControlInput.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabGraphTransversal.SuspendLayout();
            this.tabGraphHSCurve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLineWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMarkerSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHSLineWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // spcShipStability
            // 
            this.spcShipStability.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcShipStability.Location = new System.Drawing.Point(0, 0);
            this.spcShipStability.Name = "spcShipStability";
            // 
            // spcShipStability.Panel1
            // 
            this.spcShipStability.Panel1.Controls.Add(this.tabControlGraph);
            // 
            // spcShipStability.Panel2
            // 
            this.spcShipStability.Panel2.Controls.Add(this.splitContainer1);
            this.spcShipStability.Size = new System.Drawing.Size(1557, 973);
            this.spcShipStability.SplitterDistance = 1033;
            this.spcShipStability.SplitterWidth = 5;
            this.spcShipStability.TabIndex = 0;
            // 
            // tabControlGraph
            // 
            this.tabControlGraph.Controls.Add(this.tabLoad);
            this.tabControlGraph.Controls.Add(this.tabTransversal);
            this.tabControlGraph.Controls.Add(this.tabLongitudinal);
            this.tabControlGraph.Controls.Add(this.tabHydrostaticCurve);
            this.tabControlGraph.Controls.Add(this.tabGZCrossCurve);
            this.tabControlGraph.Controls.Add(this.tabKNCrossCurve);
            this.tabControlGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlGraph.Location = new System.Drawing.Point(0, 0);
            this.tabControlGraph.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlGraph.Multiline = true;
            this.tabControlGraph.Name = "tabControlGraph";
            this.tabControlGraph.SelectedIndex = 0;
            this.tabControlGraph.Size = new System.Drawing.Size(1033, 973);
            this.tabControlGraph.TabIndex = 0;
            // 
            // tabLoad
            // 
            this.tabLoad.Controls.Add(this.spcLoad1);
            this.tabLoad.Location = new System.Drawing.Point(4, 25);
            this.tabLoad.Margin = new System.Windows.Forms.Padding(4);
            this.tabLoad.Name = "tabLoad";
            this.tabLoad.Padding = new System.Windows.Forms.Padding(4);
            this.tabLoad.Size = new System.Drawing.Size(1025, 944);
            this.tabLoad.TabIndex = 0;
            this.tabLoad.Text = "Shear Load";
            this.tabLoad.UseVisualStyleBackColor = true;
            // 
            // spcLoad1
            // 
            this.spcLoad1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcLoad1.Location = new System.Drawing.Point(4, 4);
            this.spcLoad1.Margin = new System.Windows.Forms.Padding(4);
            this.spcLoad1.Name = "spcLoad1";
            this.spcLoad1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcLoad1.Panel1
            // 
            this.spcLoad1.Panel1.Controls.Add(this.spcLoad2);
            this.spcLoad1.Size = new System.Drawing.Size(1017, 936);
            this.spcLoad1.SplitterDistance = 362;
            this.spcLoad1.SplitterWidth = 5;
            this.spcLoad1.TabIndex = 0;
            // 
            // spcLoad2
            // 
            this.spcLoad2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcLoad2.Location = new System.Drawing.Point(0, 0);
            this.spcLoad2.Name = "spcLoad2";
            this.spcLoad2.Size = new System.Drawing.Size(1017, 362);
            this.spcLoad2.SplitterDistance = 622;
            this.spcLoad2.TabIndex = 0;
            // 
            // tabTransversal
            // 
            this.tabTransversal.Location = new System.Drawing.Point(4, 25);
            this.tabTransversal.Margin = new System.Windows.Forms.Padding(4);
            this.tabTransversal.Name = "tabTransversal";
            this.tabTransversal.Padding = new System.Windows.Forms.Padding(4);
            this.tabTransversal.Size = new System.Drawing.Size(1094, 944);
            this.tabTransversal.TabIndex = 1;
            this.tabTransversal.Text = "Transversal Diagram";
            this.tabTransversal.UseVisualStyleBackColor = true;
            // 
            // tabLongitudinal
            // 
            this.tabLongitudinal.Location = new System.Drawing.Point(4, 25);
            this.tabLongitudinal.Margin = new System.Windows.Forms.Padding(4);
            this.tabLongitudinal.Name = "tabLongitudinal";
            this.tabLongitudinal.Padding = new System.Windows.Forms.Padding(4);
            this.tabLongitudinal.Size = new System.Drawing.Size(1094, 944);
            this.tabLongitudinal.TabIndex = 2;
            this.tabLongitudinal.Text = "Longitudinal Diagram";
            this.tabLongitudinal.UseVisualStyleBackColor = true;
            // 
            // tabHydrostaticCurve
            // 
            this.tabHydrostaticCurve.Location = new System.Drawing.Point(4, 25);
            this.tabHydrostaticCurve.Margin = new System.Windows.Forms.Padding(4);
            this.tabHydrostaticCurve.Name = "tabHydrostaticCurve";
            this.tabHydrostaticCurve.Padding = new System.Windows.Forms.Padding(4);
            this.tabHydrostaticCurve.Size = new System.Drawing.Size(1094, 944);
            this.tabHydrostaticCurve.TabIndex = 3;
            this.tabHydrostaticCurve.Text = "Hydrostatic Curve";
            this.tabHydrostaticCurve.UseVisualStyleBackColor = true;
            // 
            // tabGZCrossCurve
            // 
            this.tabGZCrossCurve.Location = new System.Drawing.Point(4, 25);
            this.tabGZCrossCurve.Margin = new System.Windows.Forms.Padding(4);
            this.tabGZCrossCurve.Name = "tabGZCrossCurve";
            this.tabGZCrossCurve.Padding = new System.Windows.Forms.Padding(4);
            this.tabGZCrossCurve.Size = new System.Drawing.Size(1094, 944);
            this.tabGZCrossCurve.TabIndex = 4;
            this.tabGZCrossCurve.Text = "GZ Cross Curve";
            this.tabGZCrossCurve.UseVisualStyleBackColor = true;
            // 
            // tabKNCrossCurve
            // 
            this.tabKNCrossCurve.Location = new System.Drawing.Point(4, 25);
            this.tabKNCrossCurve.Margin = new System.Windows.Forms.Padding(4);
            this.tabKNCrossCurve.Name = "tabKNCrossCurve";
            this.tabKNCrossCurve.Padding = new System.Windows.Forms.Padding(4);
            this.tabKNCrossCurve.Size = new System.Drawing.Size(1094, 944);
            this.tabKNCrossCurve.TabIndex = 5;
            this.tabKNCrossCurve.Text = "KN Cross Curve";
            this.tabKNCrossCurve.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControlInput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer1.Size = new System.Drawing.Size(519, 973);
            this.splitContainer1.SplitterDistance = 650;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControlInput
            // 
            this.tabControlInput.Controls.Add(this.tabMovingLoad);
            this.tabControlInput.Controls.Add(this.tabStabilityInput);
            this.tabControlInput.Controls.Add(this.tabInfo);
            this.tabControlInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlInput.Location = new System.Drawing.Point(0, 0);
            this.tabControlInput.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlInput.Name = "tabControlInput";
            this.tabControlInput.SelectedIndex = 0;
            this.tabControlInput.Size = new System.Drawing.Size(519, 650);
            this.tabControlInput.TabIndex = 0;
            // 
            // tabMovingLoad
            // 
            this.tabMovingLoad.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabMovingLoad.Location = new System.Drawing.Point(4, 25);
            this.tabMovingLoad.Margin = new System.Windows.Forms.Padding(4);
            this.tabMovingLoad.Name = "tabMovingLoad";
            this.tabMovingLoad.Padding = new System.Windows.Forms.Padding(4);
            this.tabMovingLoad.Size = new System.Drawing.Size(442, 621);
            this.tabMovingLoad.TabIndex = 0;
            this.tabMovingLoad.Text = "Shear Load";
            // 
            // tabStabilityInput
            // 
            this.tabStabilityInput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabStabilityInput.Location = new System.Drawing.Point(4, 25);
            this.tabStabilityInput.Margin = new System.Windows.Forms.Padding(4);
            this.tabStabilityInput.Name = "tabStabilityInput";
            this.tabStabilityInput.Padding = new System.Windows.Forms.Padding(4);
            this.tabStabilityInput.Size = new System.Drawing.Size(442, 621);
            this.tabStabilityInput.TabIndex = 1;
            this.tabStabilityInput.Text = "Hydrostatic Calculation";
            // 
            // tabInfo
            // 
            this.tabInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabInfo.Location = new System.Drawing.Point(4, 25);
            this.tabInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(4);
            this.tabInfo.Size = new System.Drawing.Size(511, 621);
            this.tabInfo.TabIndex = 2;
            this.tabInfo.Text = "Info";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabGraphTransversal);
            this.tabControl2.Controls.Add(this.tabGraphHSCurve);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(519, 318);
            this.tabControl2.TabIndex = 0;
            // 
            // tabGraphTransversal
            // 
            this.tabGraphTransversal.Controls.Add(this.label38);
            this.tabGraphTransversal.Controls.Add(this.pnlLineColor);
            this.tabGraphTransversal.Controls.Add(this.label37);
            this.tabGraphTransversal.Controls.Add(this.pnlMarkerColor);
            this.tabGraphTransversal.Controls.Add(this.label24);
            this.tabGraphTransversal.Controls.Add(this.nudLineWidth);
            this.tabGraphTransversal.Controls.Add(this.label20);
            this.tabGraphTransversal.Controls.Add(this.nudMarkerSize);
            this.tabGraphTransversal.Controls.Add(this.cbxLineShow);
            this.tabGraphTransversal.Controls.Add(this.cbxMarkerShow);
            this.tabGraphTransversal.Controls.Add(this.cbbLineSelect);
            this.tabGraphTransversal.Controls.Add(this.label19);
            this.tabGraphTransversal.Controls.Add(this.cbbMarkerSelect);
            this.tabGraphTransversal.Controls.Add(this.label18);
            this.tabGraphTransversal.Location = new System.Drawing.Point(4, 25);
            this.tabGraphTransversal.Margin = new System.Windows.Forms.Padding(4);
            this.tabGraphTransversal.Name = "tabGraphTransversal";
            this.tabGraphTransversal.Padding = new System.Windows.Forms.Padding(4);
            this.tabGraphTransversal.Size = new System.Drawing.Size(511, 289);
            this.tabGraphTransversal.TabIndex = 0;
            this.tabGraphTransversal.Text = "Transversal Diagram Graph Setting";
            this.tabGraphTransversal.UseVisualStyleBackColor = true;
            // 
            // tabGraphHSCurve
            // 
            this.tabGraphHSCurve.Controls.Add(this.label33);
            this.tabGraphHSCurve.Controls.Add(this.pnlHSLegendTextColor);
            this.tabGraphHSCurve.Controls.Add(this.label32);
            this.tabGraphHSCurve.Controls.Add(this.pnlHSGridColor);
            this.tabGraphHSCurve.Controls.Add(this.label13);
            this.tabGraphHSCurve.Controls.Add(this.pnlHSLineColor);
            this.tabGraphHSCurve.Controls.Add(this.label14);
            this.tabGraphHSCurve.Controls.Add(this.pnlHSBGColor);
            this.tabGraphHSCurve.Controls.Add(this.label29);
            this.tabGraphHSCurve.Controls.Add(this.nudHSLineWidth);
            this.tabGraphHSCurve.Controls.Add(this.cbbHSLineSelect);
            this.tabGraphHSCurve.Controls.Add(this.label31);
            this.tabGraphHSCurve.Location = new System.Drawing.Point(4, 25);
            this.tabGraphHSCurve.Margin = new System.Windows.Forms.Padding(4);
            this.tabGraphHSCurve.Name = "tabGraphHSCurve";
            this.tabGraphHSCurve.Padding = new System.Windows.Forms.Padding(4);
            this.tabGraphHSCurve.Size = new System.Drawing.Size(511, 289);
            this.tabGraphHSCurve.TabIndex = 1;
            this.tabGraphHSCurve.Text = "Hydrostatic Curve Graph Setting";
            this.tabGraphHSCurve.UseVisualStyleBackColor = true;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(268, 136);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(72, 17);
            this.label38.TabIndex = 68;
            this.label38.Text = "Line Color";
            // 
            // pnlLineColor
            // 
            this.pnlLineColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLineColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlLineColor.Location = new System.Drawing.Point(403, 130);
            this.pnlLineColor.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLineColor.Name = "pnlLineColor";
            this.pnlLineColor.Size = new System.Drawing.Size(90, 25);
            this.pnlLineColor.TabIndex = 67;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(15, 136);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(89, 17);
            this.label37.TabIndex = 66;
            this.label37.Text = "Marker Color";
            // 
            // pnlMarkerColor
            // 
            this.pnlMarkerColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMarkerColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlMarkerColor.Location = new System.Drawing.Point(159, 131);
            this.pnlMarkerColor.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMarkerColor.Name = "pnlMarkerColor";
            this.pnlMarkerColor.Size = new System.Drawing.Size(90, 25);
            this.pnlMarkerColor.TabIndex = 65;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(268, 100);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(75, 17);
            this.label24.TabIndex = 64;
            this.label24.Text = "Line Width";
            // 
            // nudLineWidth
            // 
            this.nudLineWidth.Location = new System.Drawing.Point(403, 98);
            this.nudLineWidth.Margin = new System.Windows.Forms.Padding(4);
            this.nudLineWidth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudLineWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLineWidth.Name = "nudLineWidth";
            this.nudLineWidth.Size = new System.Drawing.Size(91, 22);
            this.nudLineWidth.TabIndex = 63;
            this.nudLineWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(15, 100);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 17);
            this.label20.TabIndex = 62;
            this.label20.Text = "Marker Size";
            // 
            // nudMarkerSize
            // 
            this.nudMarkerSize.Location = new System.Drawing.Point(159, 98);
            this.nudMarkerSize.Margin = new System.Windows.Forms.Padding(4);
            this.nudMarkerSize.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudMarkerSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMarkerSize.Name = "nudMarkerSize";
            this.nudMarkerSize.Size = new System.Drawing.Size(91, 22);
            this.nudMarkerSize.TabIndex = 61;
            this.nudMarkerSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbxLineShow
            // 
            this.cbxLineShow.AutoSize = true;
            this.cbxLineShow.Checked = true;
            this.cbxLineShow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxLineShow.Location = new System.Drawing.Point(272, 69);
            this.cbxLineShow.Margin = new System.Windows.Forms.Padding(4);
            this.cbxLineShow.Name = "cbxLineShow";
            this.cbxLineShow.Size = new System.Drawing.Size(95, 21);
            this.cbxLineShow.TabIndex = 60;
            this.cbxLineShow.Text = "Show Line";
            this.cbxLineShow.UseVisualStyleBackColor = true;
            // 
            // cbxMarkerShow
            // 
            this.cbxMarkerShow.AutoSize = true;
            this.cbxMarkerShow.Checked = true;
            this.cbxMarkerShow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxMarkerShow.Location = new System.Drawing.Point(19, 69);
            this.cbxMarkerShow.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMarkerShow.Name = "cbxMarkerShow";
            this.cbxMarkerShow.Size = new System.Drawing.Size(112, 21);
            this.cbxMarkerShow.TabIndex = 59;
            this.cbxMarkerShow.Text = "Show Marker";
            this.cbxMarkerShow.UseVisualStyleBackColor = true;
            // 
            // cbbLineSelect
            // 
            this.cbbLineSelect.FormattingEnabled = true;
            this.cbbLineSelect.Location = new System.Drawing.Point(320, 25);
            this.cbbLineSelect.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLineSelect.Name = "cbbLineSelect";
            this.cbbLineSelect.Size = new System.Drawing.Size(172, 24);
            this.cbbLineSelect.TabIndex = 58;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(268, 29);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 17);
            this.label19.TabIndex = 57;
            this.label19.Text = "Line";
            // 
            // cbbMarkerSelect
            // 
            this.cbbMarkerSelect.FormattingEnabled = true;
            this.cbbMarkerSelect.Location = new System.Drawing.Point(76, 25);
            this.cbbMarkerSelect.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMarkerSelect.Name = "cbbMarkerSelect";
            this.cbbMarkerSelect.Size = new System.Drawing.Size(172, 24);
            this.cbbMarkerSelect.TabIndex = 56;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 29);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 17);
            this.label18.TabIndex = 55;
            this.label18.Text = "Marker";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(13, 100);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(124, 17);
            this.label33.TabIndex = 79;
            this.label33.Text = "Legend Text Color";
            // 
            // pnlHSLegendTextColor
            // 
            this.pnlHSLegendTextColor.BackColor = System.Drawing.Color.White;
            this.pnlHSLegendTextColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHSLegendTextColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlHSLegendTextColor.Location = new System.Drawing.Point(166, 96);
            this.pnlHSLegendTextColor.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHSLegendTextColor.Name = "pnlHSLegendTextColor";
            this.pnlHSLegendTextColor.Size = new System.Drawing.Size(90, 25);
            this.pnlHSLegendTextColor.TabIndex = 78;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(13, 64);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(72, 17);
            this.label32.TabIndex = 77;
            this.label32.Text = "Grid Color";
            // 
            // pnlHSGridColor
            // 
            this.pnlHSGridColor.BackColor = System.Drawing.Color.White;
            this.pnlHSGridColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHSGridColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlHSGridColor.Location = new System.Drawing.Point(166, 61);
            this.pnlHSGridColor.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHSGridColor.Name = "pnlHSGridColor";
            this.pnlHSGridColor.Size = new System.Drawing.Size(90, 25);
            this.pnlHSGridColor.TabIndex = 76;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(274, 106);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 17);
            this.label13.TabIndex = 75;
            this.label13.Text = "Line Color";
            // 
            // pnlHSLineColor
            // 
            this.pnlHSLineColor.BackColor = System.Drawing.Color.Black;
            this.pnlHSLineColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHSLineColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlHSLineColor.Location = new System.Drawing.Point(409, 100);
            this.pnlHSLineColor.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHSLineColor.Name = "pnlHSLineColor";
            this.pnlHSLineColor.Size = new System.Drawing.Size(90, 25);
            this.pnlHSLineColor.TabIndex = 74;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 27);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 17);
            this.label14.TabIndex = 73;
            this.label14.Text = "Background Color";
            // 
            // pnlHSBGColor
            // 
            this.pnlHSBGColor.BackColor = System.Drawing.Color.White;
            this.pnlHSBGColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHSBGColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlHSBGColor.Location = new System.Drawing.Point(166, 24);
            this.pnlHSBGColor.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHSBGColor.Name = "pnlHSBGColor";
            this.pnlHSBGColor.Size = new System.Drawing.Size(90, 25);
            this.pnlHSBGColor.TabIndex = 72;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(274, 70);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(75, 17);
            this.label29.TabIndex = 71;
            this.label29.Text = "Line Width";
            // 
            // nudHSLineWidth
            // 
            this.nudHSLineWidth.Location = new System.Drawing.Point(409, 68);
            this.nudHSLineWidth.Margin = new System.Windows.Forms.Padding(4);
            this.nudHSLineWidth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudHSLineWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHSLineWidth.Name = "nudHSLineWidth";
            this.nudHSLineWidth.Size = new System.Drawing.Size(91, 22);
            this.nudHSLineWidth.TabIndex = 70;
            this.nudHSLineWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbbHSLineSelect
            // 
            this.cbbHSLineSelect.FormattingEnabled = true;
            this.cbbHSLineSelect.Location = new System.Drawing.Point(326, 24);
            this.cbbHSLineSelect.Margin = new System.Windows.Forms.Padding(4);
            this.cbbHSLineSelect.Name = "cbbHSLineSelect";
            this.cbbHSLineSelect.Size = new System.Drawing.Size(172, 24);
            this.cbbHSLineSelect.TabIndex = 69;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(274, 27);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(35, 17);
            this.label31.TabIndex = 68;
            this.label31.Text = "Line";
            // 
            // fSSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 973);
            this.Controls.Add(this.spcShipStability);
            this.Name = "fSSS";
            this.Text = "fSSS";
            this.spcShipStability.Panel1.ResumeLayout(false);
            this.spcShipStability.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcShipStability)).EndInit();
            this.spcShipStability.ResumeLayout(false);
            this.tabControlGraph.ResumeLayout(false);
            this.tabLoad.ResumeLayout(false);
            this.spcLoad1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcLoad1)).EndInit();
            this.spcLoad1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcLoad2)).EndInit();
            this.spcLoad2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControlInput.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabGraphTransversal.ResumeLayout(false);
            this.tabGraphTransversal.PerformLayout();
            this.tabGraphHSCurve.ResumeLayout(false);
            this.tabGraphHSCurve.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLineWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMarkerSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHSLineWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcShipStability;
        private System.Windows.Forms.TabControl tabControlGraph;
        private System.Windows.Forms.TabPage tabLoad;
        private System.Windows.Forms.TabPage tabTransversal;
        private System.Windows.Forms.TabPage tabLongitudinal;
        private System.Windows.Forms.TabPage tabHydrostaticCurve;
        private System.Windows.Forms.TabPage tabGZCrossCurve;
        private System.Windows.Forms.TabPage tabKNCrossCurve;
        private System.Windows.Forms.SplitContainer spcLoad1;
        private System.Windows.Forms.SplitContainer spcLoad2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TabControl tabControlInput;
        private System.Windows.Forms.TabPage tabMovingLoad;
        private System.Windows.Forms.TabPage tabStabilityInput;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabGraphTransversal;
        private System.Windows.Forms.TabPage tabGraphHSCurve;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Panel pnlLineColor;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Panel pnlMarkerColor;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.NumericUpDown nudLineWidth;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown nudMarkerSize;
        private System.Windows.Forms.CheckBox cbxLineShow;
        private System.Windows.Forms.CheckBox cbxMarkerShow;
        private System.Windows.Forms.ComboBox cbbLineSelect;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbbMarkerSelect;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Panel pnlHSLegendTextColor;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Panel pnlHSGridColor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel pnlHSLineColor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel pnlHSBGColor;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.NumericUpDown nudHSLineWidth;
        private System.Windows.Forms.ComboBox cbbHSLineSelect;
        private System.Windows.Forms.Label label31;
    }
}