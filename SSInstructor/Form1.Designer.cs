
namespace SSInstructor
{
    partial class Form1
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
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.btnClientList = new FontAwesome.Sharp.IconButton();
            this.btnReport = new FontAwesome.Sharp.IconButton();
            this.btnScenario = new FontAwesome.Sharp.IconButton();
            this.pnlUserSubmenu = new System.Windows.Forms.Panel();
            this.btnAccount = new FontAwesome.Sharp.IconButton();
            this.btnTrainee = new FontAwesome.Sharp.IconButton();
            this.btnInstructor = new FontAwesome.Sharp.IconButton();
            this.btnUsers = new FontAwesome.Sharp.IconButton();
            this.pnlMasterDataSubmenu = new System.Windows.Forms.Panel();
            this.btnCargoData = new FontAwesome.Sharp.IconButton();
            this.btnShipData = new FontAwesome.Sharp.IconButton();
            this.btnMasterData = new FontAwesome.Sharp.IconButton();
            this.pnlUserPic = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.viButton2 = new ViControls.ViButton();
            this.viButton1 = new ViControls.ViButton();
            this.viTextBox2 = new ViControls.ViTextBox();
            this.viTextBox1 = new ViControls.ViTextBox();
            this.userPic = new ViControls.CircularPicture();
            this.pnlMainMenu.SuspendLayout();
            this.pnlUserSubmenu.SuspendLayout();
            this.pnlMasterDataSubmenu.SuspendLayout();
            this.pnlUserPic.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlMainMenu.Controls.Add(this.btnSettings);
            this.pnlMainMenu.Controls.Add(this.btnClientList);
            this.pnlMainMenu.Controls.Add(this.btnReport);
            this.pnlMainMenu.Controls.Add(this.btnScenario);
            this.pnlMainMenu.Controls.Add(this.pnlUserSubmenu);
            this.pnlMainMenu.Controls.Add(this.btnUsers);
            this.pnlMainMenu.Controls.Add(this.pnlMasterDataSubmenu);
            this.pnlMainMenu.Controls.Add(this.btnMasterData);
            this.pnlMainMenu.Controls.Add(this.pnlUserPic);
            this.pnlMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(256, 721);
            this.pnlMainMenu.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnSettings.IconColor = System.Drawing.Color.White;
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.IconSize = 24;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 650);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSettings.Size = new System.Drawing.Size(256, 55);
            this.btnSettings.TabIndex = 22;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnClientList
            // 
            this.btnClientList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientList.FlatAppearance.BorderSize = 0;
            this.btnClientList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientList.ForeColor = System.Drawing.Color.White;
            this.btnClientList.IconChar = FontAwesome.Sharp.IconChar.Desktop;
            this.btnClientList.IconColor = System.Drawing.Color.White;
            this.btnClientList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientList.IconSize = 24;
            this.btnClientList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientList.Location = new System.Drawing.Point(0, 595);
            this.btnClientList.Name = "btnClientList";
            this.btnClientList.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnClientList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClientList.Size = new System.Drawing.Size(256, 55);
            this.btnClientList.TabIndex = 21;
            this.btnClientList.Text = "Client List";
            this.btnClientList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientList.UseVisualStyleBackColor = true;
            this.btnClientList.Click += new System.EventHandler(this.btnClientList_Click);
            // 
            // btnReport
            // 
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnReport.IconColor = System.Drawing.Color.White;
            this.btnReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReport.IconSize = 24;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(0, 540);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnReport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnReport.Size = new System.Drawing.Size(256, 55);
            this.btnReport.TabIndex = 20;
            this.btnReport.Text = "Report";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnScenario
            // 
            this.btnScenario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnScenario.FlatAppearance.BorderSize = 0;
            this.btnScenario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScenario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScenario.ForeColor = System.Drawing.Color.White;
            this.btnScenario.IconChar = FontAwesome.Sharp.IconChar.Scroll;
            this.btnScenario.IconColor = System.Drawing.Color.White;
            this.btnScenario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnScenario.IconSize = 24;
            this.btnScenario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScenario.Location = new System.Drawing.Point(0, 485);
            this.btnScenario.Name = "btnScenario";
            this.btnScenario.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnScenario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnScenario.Size = new System.Drawing.Size(256, 55);
            this.btnScenario.TabIndex = 19;
            this.btnScenario.Text = "Scenario";
            this.btnScenario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScenario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnScenario.UseVisualStyleBackColor = true;
            this.btnScenario.Click += new System.EventHandler(this.btnScenario_Click);
            // 
            // pnlUserSubmenu
            // 
            this.pnlUserSubmenu.Controls.Add(this.btnAccount);
            this.pnlUserSubmenu.Controls.Add(this.btnTrainee);
            this.pnlUserSubmenu.Controls.Add(this.btnInstructor);
            this.pnlUserSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserSubmenu.Location = new System.Drawing.Point(0, 320);
            this.pnlUserSubmenu.Name = "pnlUserSubmenu";
            this.pnlUserSubmenu.Size = new System.Drawing.Size(256, 165);
            this.pnlUserSubmenu.TabIndex = 16;
            // 
            // btnAccount
            // 
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnAccount.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.btnAccount.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccount.IconSize = 24;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(0, 110);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Padding = new System.Windows.Forms.Padding(42, 0, 20, 0);
            this.btnAccount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAccount.Size = new System.Drawing.Size(256, 55);
            this.btnAccount.TabIndex = 18;
            this.btnAccount.Text = "Account";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnTrainee
            // 
            this.btnTrainee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrainee.FlatAppearance.BorderSize = 0;
            this.btnTrainee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrainee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainee.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnTrainee.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.btnTrainee.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnTrainee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTrainee.IconSize = 24;
            this.btnTrainee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrainee.Location = new System.Drawing.Point(0, 55);
            this.btnTrainee.Name = "btnTrainee";
            this.btnTrainee.Padding = new System.Windows.Forms.Padding(42, 0, 20, 0);
            this.btnTrainee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTrainee.Size = new System.Drawing.Size(256, 55);
            this.btnTrainee.TabIndex = 17;
            this.btnTrainee.Text = "Trainee";
            this.btnTrainee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrainee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrainee.UseVisualStyleBackColor = true;
            // 
            // btnInstructor
            // 
            this.btnInstructor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInstructor.FlatAppearance.BorderSize = 0;
            this.btnInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructor.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnInstructor.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnInstructor.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnInstructor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInstructor.IconSize = 24;
            this.btnInstructor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInstructor.Location = new System.Drawing.Point(0, 0);
            this.btnInstructor.Name = "btnInstructor";
            this.btnInstructor.Padding = new System.Windows.Forms.Padding(42, 0, 20, 0);
            this.btnInstructor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnInstructor.Size = new System.Drawing.Size(256, 55);
            this.btnInstructor.TabIndex = 16;
            this.btnInstructor.Text = "Instructor";
            this.btnInstructor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInstructor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInstructor.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnUsers.IconColor = System.Drawing.Color.White;
            this.btnUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsers.IconSize = 24;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(0, 265);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnUsers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUsers.Size = new System.Drawing.Size(256, 55);
            this.btnUsers.TabIndex = 15;
            this.btnUsers.Text = "User";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // pnlMasterDataSubmenu
            // 
            this.pnlMasterDataSubmenu.Controls.Add(this.btnCargoData);
            this.pnlMasterDataSubmenu.Controls.Add(this.btnShipData);
            this.pnlMasterDataSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMasterDataSubmenu.Location = new System.Drawing.Point(0, 155);
            this.pnlMasterDataSubmenu.Name = "pnlMasterDataSubmenu";
            this.pnlMasterDataSubmenu.Size = new System.Drawing.Size(256, 110);
            this.pnlMasterDataSubmenu.TabIndex = 2;
            // 
            // btnCargoData
            // 
            this.btnCargoData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCargoData.FlatAppearance.BorderSize = 0;
            this.btnCargoData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargoData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargoData.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnCargoData.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.btnCargoData.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnCargoData.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCargoData.IconSize = 24;
            this.btnCargoData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargoData.Location = new System.Drawing.Point(0, 55);
            this.btnCargoData.Name = "btnCargoData";
            this.btnCargoData.Padding = new System.Windows.Forms.Padding(42, 0, 20, 0);
            this.btnCargoData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCargoData.Size = new System.Drawing.Size(256, 55);
            this.btnCargoData.TabIndex = 14;
            this.btnCargoData.Text = "Cargo";
            this.btnCargoData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargoData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCargoData.UseVisualStyleBackColor = true;
            // 
            // btnShipData
            // 
            this.btnShipData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShipData.FlatAppearance.BorderSize = 0;
            this.btnShipData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShipData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShipData.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnShipData.IconChar = FontAwesome.Sharp.IconChar.Ship;
            this.btnShipData.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnShipData.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShipData.IconSize = 24;
            this.btnShipData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShipData.Location = new System.Drawing.Point(0, 0);
            this.btnShipData.Name = "btnShipData";
            this.btnShipData.Padding = new System.Windows.Forms.Padding(42, 0, 20, 0);
            this.btnShipData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnShipData.Size = new System.Drawing.Size(256, 55);
            this.btnShipData.TabIndex = 13;
            this.btnShipData.Text = "Ship";
            this.btnShipData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShipData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShipData.UseVisualStyleBackColor = true;
            // 
            // btnMasterData
            // 
            this.btnMasterData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMasterData.FlatAppearance.BorderSize = 0;
            this.btnMasterData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasterData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasterData.ForeColor = System.Drawing.Color.White;
            this.btnMasterData.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnMasterData.IconColor = System.Drawing.Color.White;
            this.btnMasterData.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMasterData.IconSize = 24;
            this.btnMasterData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasterData.Location = new System.Drawing.Point(0, 100);
            this.btnMasterData.Name = "btnMasterData";
            this.btnMasterData.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnMasterData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMasterData.Size = new System.Drawing.Size(256, 55);
            this.btnMasterData.TabIndex = 1;
            this.btnMasterData.Text = "Master Data";
            this.btnMasterData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasterData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMasterData.UseVisualStyleBackColor = true;
            this.btnMasterData.Click += new System.EventHandler(this.btnMasterData_Click);
            // 
            // pnlUserPic
            // 
            this.pnlUserPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.pnlUserPic.Controls.Add(this.userPic);
            this.pnlUserPic.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserPic.Location = new System.Drawing.Point(0, 0);
            this.pnlUserPic.Name = "pnlUserPic";
            this.pnlUserPic.Size = new System.Drawing.Size(256, 100);
            this.pnlUserPic.TabIndex = 0;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.viButton2);
            this.pnlContent.Controls.Add(this.viButton1);
            this.pnlContent.Controls.Add(this.viTextBox2);
            this.pnlContent.Controls.Add(this.viTextBox1);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(256, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1092, 721);
            this.pnlContent.TabIndex = 1;
            // 
            // viButton2
            // 
            this.viButton2.BackColor = System.Drawing.SystemColors.Control;
            this.viButton2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.viButton2.BorderColor = System.Drawing.Color.DodgerBlue;
            this.viButton2.BorderRadius = 40;
            this.viButton2.BorderSize = 1;
            this.viButton2.FlatAppearance.BorderSize = 0;
            this.viButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.viButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.viButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viButton2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.viButton2.Location = new System.Drawing.Point(117, 100);
            this.viButton2.Name = "viButton2";
            this.viButton2.Size = new System.Drawing.Size(150, 40);
            this.viButton2.TabIndex = 5;
            this.viButton2.Text = "viButton2";
            this.viButton2.TextColor = System.Drawing.Color.DodgerBlue;
            this.viButton2.UseVisualStyleBackColor = false;
            // 
            // viButton1
            // 
            this.viButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.viButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.viButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.viButton1.BorderRadius = 15;
            this.viButton1.BorderSize = 1;
            this.viButton1.FlatAppearance.BorderSize = 0;
            this.viButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viButton1.ForeColor = System.Drawing.Color.White;
            this.viButton1.Location = new System.Drawing.Point(267, 383);
            this.viButton1.Name = "viButton1";
            this.viButton1.Size = new System.Drawing.Size(150, 40);
            this.viButton1.TabIndex = 4;
            this.viButton1.Text = "LOGIN";
            this.viButton1.TextColor = System.Drawing.Color.White;
            this.viButton1.UseVisualStyleBackColor = false;
            // 
            // viTextBox2
            // 
            this.viTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.viTextBox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.viTextBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.viTextBox2.BorderRadius = 10;
            this.viTextBox2.BorderSize = 2;
            this.viTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.viTextBox2.Location = new System.Drawing.Point(216, 318);
            this.viTextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.viTextBox2.Multiline = false;
            this.viTextBox2.Name = "viTextBox2";
            this.viTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.viTextBox2.PasswordChar = true;
            this.viTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.viTextBox2.PlaceholderText = "Password";
            this.viTextBox2.Size = new System.Drawing.Size(250, 35);
            this.viTextBox2.TabIndex = 3;
            this.viTextBox2.Texts = "";
            this.viTextBox2.UnderlinedStyle = false;
            // 
            // viTextBox1
            // 
            this.viTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.viTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.viTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.viTextBox1.BorderRadius = 10;
            this.viTextBox1.BorderSize = 2;
            this.viTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.viTextBox1.Location = new System.Drawing.Point(216, 265);
            this.viTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.viTextBox1.Multiline = false;
            this.viTextBox1.Name = "viTextBox1";
            this.viTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.viTextBox1.PasswordChar = false;
            this.viTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.viTextBox1.PlaceholderText = "Username";
            this.viTextBox1.Size = new System.Drawing.Size(250, 35);
            this.viTextBox1.TabIndex = 2;
            this.viTextBox1.Texts = "";
            this.viTextBox1.UnderlinedStyle = false;
            // 
            // userPic
            // 
            this.userPic.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.userPic.BorderColor = System.Drawing.Color.RoyalBlue;
            this.userPic.BorderColor2 = System.Drawing.Color.HotPink;
            this.userPic.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.userPic.BorderSize = 1;
            this.userPic.GradientAngle = 50F;
            this.userPic.Image = global::SSInstructor.Properties.Resources.user;
            this.userPic.Location = new System.Drawing.Point(11, 11);
            this.userPic.Name = "userPic";
            this.userPic.Size = new System.Drawing.Size(75, 75);
            this.userPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPic.TabIndex = 1;
            this.userPic.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSInstructor";
            this.pnlMainMenu.ResumeLayout(false);
            this.pnlUserSubmenu.ResumeLayout(false);
            this.pnlMasterDataSubmenu.ResumeLayout(false);
            this.pnlUserPic.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.Panel pnlUserPic;
        private FontAwesome.Sharp.IconButton btnMasterData;
        private System.Windows.Forms.Panel pnlMasterDataSubmenu;
        private FontAwesome.Sharp.IconButton btnShipData;
        private FontAwesome.Sharp.IconButton btnCargoData;
        private FontAwesome.Sharp.IconButton btnUsers;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnClientList;
        private FontAwesome.Sharp.IconButton btnReport;
        private FontAwesome.Sharp.IconButton btnScenario;
        private System.Windows.Forms.Panel pnlUserSubmenu;
        private FontAwesome.Sharp.IconButton btnAccount;
        private FontAwesome.Sharp.IconButton btnTrainee;
        private FontAwesome.Sharp.IconButton btnInstructor;
        private System.Windows.Forms.Panel pnlContent;
        private ViControls.ViTextBox viTextBox1;
        private ViControls.ViTextBox viTextBox2;
        private ViControls.CircularPicture userPic;
        private ViControls.ViButton viButton1;
        private ViControls.ViButton viButton2;
    }
}

