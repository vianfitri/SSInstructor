
namespace SSInstructor.Forms
{
    partial class fClientList
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddClient = new ViControls.ViButton();
            this.contextMenuStrip_Machines = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.wakeUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newHostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnWakeUpAll = new ViControls.ViButton();
            this.btnShutdownAll = new ViControls.ViButton();
            this.contextMenuStrip_Machines.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(118)))), ((int)(((byte)(159)))));
            this.label2.Location = new System.Drawing.Point(60, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Client";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(61, 160);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(769, 474);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(184)))), ((int)(((byte)(249)))));
            this.btnAddClient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(184)))), ((int)(((byte)(249)))));
            this.btnAddClient.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddClient.BorderRadius = 10;
            this.btnAddClient.BorderSize = 0;
            this.btnAddClient.FlatAppearance.BorderSize = 0;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.ForeColor = System.Drawing.Color.White;
            this.btnAddClient.Location = new System.Drawing.Point(680, 652);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(150, 40);
            this.btnAddClient.TabIndex = 13;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.TextColor = System.Drawing.Color.White;
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // contextMenuStrip_Machines
            // 
            this.contextMenuStrip_Machines.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_Machines.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wakeUpToolStripMenuItem,
            this.shutdownToolStripMenuItem,
            this.toolStripSeparator1,
            this.newHostToolStripMenuItem,
            this.propertiesToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip_Machines.Name = "contextMenuStrip_Machines";
            this.contextMenuStrip_Machines.Size = new System.Drawing.Size(151, 130);
            // 
            // wakeUpToolStripMenuItem
            // 
            this.wakeUpToolStripMenuItem.Name = "wakeUpToolStripMenuItem";
            this.wakeUpToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.wakeUpToolStripMenuItem.Text = "Wake Up";
            // 
            // newHostToolStripMenuItem
            // 
            this.newHostToolStripMenuItem.Name = "newHostToolStripMenuItem";
            this.newHostToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.newHostToolStripMenuItem.Text = "New host";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.propertiesToolStripMenuItem.Text = "Properties";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // shutdownToolStripMenuItem
            // 
            this.shutdownToolStripMenuItem.Enabled = false;
            this.shutdownToolStripMenuItem.Name = "shutdownToolStripMenuItem";
            this.shutdownToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.shutdownToolStripMenuItem.Text = "Shut Down";
            // 
            // btnWakeUpAll
            // 
            this.btnWakeUpAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnWakeUpAll.BackColor = System.Drawing.Color.Green;
            this.btnWakeUpAll.BackgroundColor = System.Drawing.Color.Green;
            this.btnWakeUpAll.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnWakeUpAll.BorderRadius = 10;
            this.btnWakeUpAll.BorderSize = 0;
            this.btnWakeUpAll.FlatAppearance.BorderSize = 0;
            this.btnWakeUpAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWakeUpAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWakeUpAll.ForeColor = System.Drawing.Color.White;
            this.btnWakeUpAll.Location = new System.Drawing.Point(61, 652);
            this.btnWakeUpAll.Name = "btnWakeUpAll";
            this.btnWakeUpAll.Size = new System.Drawing.Size(177, 40);
            this.btnWakeUpAll.TabIndex = 15;
            this.btnWakeUpAll.Text = "Wake Up All";
            this.btnWakeUpAll.TextColor = System.Drawing.Color.White;
            this.btnWakeUpAll.UseVisualStyleBackColor = false;
            this.btnWakeUpAll.Click += new System.EventHandler(this.btnWakeUpAll_Click);
            // 
            // btnShutdownAll
            // 
            this.btnShutdownAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShutdownAll.BackColor = System.Drawing.Color.Maroon;
            this.btnShutdownAll.BackgroundColor = System.Drawing.Color.Maroon;
            this.btnShutdownAll.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnShutdownAll.BorderRadius = 10;
            this.btnShutdownAll.BorderSize = 0;
            this.btnShutdownAll.FlatAppearance.BorderSize = 0;
            this.btnShutdownAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutdownAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutdownAll.ForeColor = System.Drawing.Color.White;
            this.btnShutdownAll.Location = new System.Drawing.Point(260, 652);
            this.btnShutdownAll.Name = "btnShutdownAll";
            this.btnShutdownAll.Size = new System.Drawing.Size(198, 40);
            this.btnShutdownAll.TabIndex = 16;
            this.btnShutdownAll.Text = "Shut Down All";
            this.btnShutdownAll.TextColor = System.Drawing.Color.White;
            this.btnShutdownAll.UseVisualStyleBackColor = false;
            // 
            // fClientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 721);
            this.Controls.Add(this.btnShutdownAll);
            this.Controls.Add(this.btnWakeUpAll);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fClientList";
            this.Text = "fClientList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fClientList_FormClosing);
            this.Load += new System.EventHandler(this.fClientList_Load);
            this.Shown += new System.EventHandler(this.fClientList_Shown);
            this.contextMenuStrip_Machines.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ViControls.ViButton btnAddClient;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Machines;
        private System.Windows.Forms.ToolStripMenuItem wakeUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem newHostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shutdownToolStripMenuItem;
        private ViControls.ViButton btnWakeUpAll;
        private ViControls.ViButton btnShutdownAll;
    }
}