
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
            this.tabTransversal = new System.Windows.Forms.TabPage();
            this.tabLongitudinal = new System.Windows.Forms.TabPage();
            this.tabHydrostaticCurve = new System.Windows.Forms.TabPage();
            this.tabGZCrossCurve = new System.Windows.Forms.TabPage();
            this.tabKNCrossCurve = new System.Windows.Forms.TabPage();
            this.spcLoad1 = new System.Windows.Forms.SplitContainer();
            this.spcLoad2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabControlInput = new System.Windows.Forms.TabControl();
            this.tabMovingLoad = new System.Windows.Forms.TabPage();
            this.tabStabilityInput = new System.Windows.Forms.TabPage();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabGraphTransversal = new System.Windows.Forms.TabPage();
            this.tabGraphHSCurve = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.spcShipStability)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.spcShipStability.SuspendLayout();
            this.tabControlGraph.SuspendLayout();
            this.tabLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcLoad1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.spcLoad1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcLoad2)).BeginInit();
            this.spcLoad2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControlInput.SuspendLayout();
            this.tabControl2.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.tabControlGraph);
            // 
            // spcShipStability.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer1);
            this.spcShipStability.Size = new System.Drawing.Size(1557, 973);
            this.spcShipStability.SplitterDistance = 1102;
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
            this.tabControlGraph.Size = new System.Drawing.Size(1102, 973);
            this.tabControlGraph.TabIndex = 0;
            // 
            // tabLoad
            // 
            this.tabLoad.Controls.Add(this.spcLoad1);
            this.tabLoad.Location = new System.Drawing.Point(4, 25);
            this.tabLoad.Margin = new System.Windows.Forms.Padding(4);
            this.tabLoad.Name = "tabLoad";
            this.tabLoad.Padding = new System.Windows.Forms.Padding(4);
            this.tabLoad.Size = new System.Drawing.Size(1094, 944);
            this.tabLoad.TabIndex = 0;
            this.tabLoad.Text = "Shear Load";
            this.tabLoad.UseVisualStyleBackColor = true;
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
            this.splitContainer1.Panel1.Controls.Add(this.spcLoad2);
            this.spcLoad1.Size = new System.Drawing.Size(1086, 936);
            this.spcLoad1.SplitterDistance = 362;
            this.spcLoad1.SplitterWidth = 5;
            this.spcLoad1.TabIndex = 0;
            // 
            // spcLoad2
            // 
            this.spcLoad2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcLoad2.Location = new System.Drawing.Point(0, 0);
            this.spcLoad2.Name = "spcLoad2";
            this.spcLoad2.Size = new System.Drawing.Size(1086, 362);
            this.spcLoad2.SplitterDistance = 665;
            this.spcLoad2.TabIndex = 0;
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
            this.splitContainer1.Size = new System.Drawing.Size(450, 973);
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
            this.tabControlInput.Size = new System.Drawing.Size(450, 650);
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
            this.tabInfo.Size = new System.Drawing.Size(442, 621);
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
            this.tabControl2.Size = new System.Drawing.Size(450, 318);
            this.tabControl2.TabIndex = 0;
            // 
            // tabGraphTransversal
            // 
            this.tabGraphTransversal.Location = new System.Drawing.Point(4, 25);
            this.tabGraphTransversal.Margin = new System.Windows.Forms.Padding(4);
            this.tabGraphTransversal.Name = "tabGraphTransversal";
            this.tabGraphTransversal.Padding = new System.Windows.Forms.Padding(4);
            this.tabGraphTransversal.Size = new System.Drawing.Size(442, 289);
            this.tabGraphTransversal.TabIndex = 0;
            this.tabGraphTransversal.Text = "Transversal Diagram Graph Setting";
            this.tabGraphTransversal.UseVisualStyleBackColor = true;
            // 
            // tabGraphHSCurve
            // 
            this.tabGraphHSCurve.Location = new System.Drawing.Point(4, 25);
            this.tabGraphHSCurve.Margin = new System.Windows.Forms.Padding(4);
            this.tabGraphHSCurve.Name = "tabGraphHSCurve";
            this.tabGraphHSCurve.Padding = new System.Windows.Forms.Padding(4);
            this.tabGraphHSCurve.Size = new System.Drawing.Size(442, 289);
            this.tabGraphHSCurve.TabIndex = 1;
            this.tabGraphHSCurve.Text = "Hydrostatic Curve Graph Setting";
            this.tabGraphHSCurve.UseVisualStyleBackColor = true;
            // 
            // fSSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 973);
            this.Controls.Add(this.spcShipStability);
            this.Name = "fSSS";
            this.Text = "fSSS";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcShipStability)).EndInit();
            this.spcShipStability.ResumeLayout(false);
            this.tabControlGraph.ResumeLayout(false);
            this.tabLoad.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
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
    }
}