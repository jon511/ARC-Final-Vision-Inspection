namespace ARC_Final_Vision_Inspection
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveJobAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pLCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plcSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plcConnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraConnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualTriggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liveModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showSpreadsheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearStation1CountersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearStation2CountersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllCountersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxMainDisplay = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.secondaryResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.secondaryResultValue3Label = new System.Windows.Forms.Label();
            this.secondaryResultValue2Label = new System.Windows.Forms.Label();
            this.secondaryResultValue1Label = new System.Windows.Forms.Label();
            this.mainResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.mainResultValue3Label = new System.Windows.Forms.Label();
            this.mainResultValue2Label = new System.Windows.Forms.Label();
            this.mainResultValue1Label = new System.Windows.Forms.Label();
            this.secondarySerialNumberLabel = new System.Windows.Forms.Label();
            this.mainSerialNumberLabel = new System.Windows.Forms.Label();
            this.secondaryPartCountGroupBox = new System.Windows.Forms.GroupBox();
            this.secondaryPartCountTotalLabel = new System.Windows.Forms.Label();
            this.secondaryPartCountRejectLabel = new System.Windows.Forms.Label();
            this.secondaryPartCountGoodLabel = new System.Windows.Forms.Label();
            this.plcMainMessageDisplayTextBox = new System.Windows.Forms.TextBox();
            this.mainPartCountGroupBox = new System.Windows.Forms.GroupBox();
            this.mainPartCountTotalLabel = new System.Windows.Forms.Label();
            this.mainPartCountGoodLabel = new System.Windows.Forms.Label();
            this.mainPartCountRejectLabel = new System.Windows.Forms.Label();
            this.plcSecondaryMessageTextBox = new System.Windows.Forms.TextBox();
            this.mainMessageLabel = new System.Windows.Forms.Label();
            this.secondaryMessageLabel = new System.Windows.Forms.Label();
            this.labelCameraStatus = new System.Windows.Forms.Label();
            this.groupBoxImageDisplay = new System.Windows.Forms.GroupBox();
            this.cvsInSightDisplay1 = new Cognex.InSight.Controls.Display.CvsInSightDisplay();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelPlcStatus = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBoxMainDisplay.SuspendLayout();
            this.secondaryResultsGroupBox.SuspendLayout();
            this.mainResultsGroupBox.SuspendLayout();
            this.secondaryPartCountGroupBox.SuspendLayout();
            this.mainPartCountGroupBox.SuspendLayout();
            this.groupBoxImageDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.cameraToolStripMenuItem,
            this.manualControlsToolStripMenuItem,
            this.countersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1118, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openJobToolStripMenuItem,
            this.saveJobToolStripMenuItem,
            this.saveJobAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openJobToolStripMenuItem
            // 
            this.openJobToolStripMenuItem.Name = "openJobToolStripMenuItem";
            this.openJobToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.openJobToolStripMenuItem.Text = "Open Job";
            // 
            // saveJobToolStripMenuItem
            // 
            this.saveJobToolStripMenuItem.Name = "saveJobToolStripMenuItem";
            this.saveJobToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.saveJobToolStripMenuItem.Text = "Save Job";
            // 
            // saveJobAsToolStripMenuItem
            // 
            this.saveJobAsToolStripMenuItem.Name = "saveJobAsToolStripMenuItem";
            this.saveJobAsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.saveJobAsToolStripMenuItem.Text = "Save Job As";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pLCToolStripMenuItem,
            this.insightToolStripMenuItem,
            this.logInToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // pLCToolStripMenuItem
            // 
            this.pLCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plcSettingsToolStripMenuItem,
            this.plcConnectToolStripMenuItem});
            this.pLCToolStripMenuItem.Name = "pLCToolStripMenuItem";
            this.pLCToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.pLCToolStripMenuItem.Text = "PLC";
            // 
            // plcSettingsToolStripMenuItem
            // 
            this.plcSettingsToolStripMenuItem.Name = "plcSettingsToolStripMenuItem";
            this.plcSettingsToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.plcSettingsToolStripMenuItem.Text = "Settings";
            this.plcSettingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem1_Click);
            // 
            // plcConnectToolStripMenuItem
            // 
            this.plcConnectToolStripMenuItem.Name = "plcConnectToolStripMenuItem";
            this.plcConnectToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.plcConnectToolStripMenuItem.Text = "Connect";
            this.plcConnectToolStripMenuItem.Click += new System.EventHandler(this.plcConnectToolStripMenuItem_Click);
            // 
            // insightToolStripMenuItem
            // 
            this.insightToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cameraSettingsToolStripMenuItem,
            this.cameraConnectToolStripMenuItem});
            this.insightToolStripMenuItem.Name = "insightToolStripMenuItem";
            this.insightToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.insightToolStripMenuItem.Text = "Insight";
            // 
            // cameraSettingsToolStripMenuItem
            // 
            this.cameraSettingsToolStripMenuItem.Name = "cameraSettingsToolStripMenuItem";
            this.cameraSettingsToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.cameraSettingsToolStripMenuItem.Text = "Settings";
            this.cameraSettingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem2_Click);
            // 
            // cameraConnectToolStripMenuItem
            // 
            this.cameraConnectToolStripMenuItem.Name = "cameraConnectToolStripMenuItem";
            this.cameraConnectToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.cameraConnectToolStripMenuItem.Text = "Connect";
            this.cameraConnectToolStripMenuItem.Click += new System.EventHandler(this.cameraConnectToolStripMenuItem_Click);
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.logInToolStripMenuItem.Text = "Log In";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // cameraToolStripMenuItem
            // 
            this.cameraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlineToolStripMenuItem,
            this.manualTriggerToolStripMenuItem,
            this.liveModeToolStripMenuItem,
            this.showSpreadsheetToolStripMenuItem});
            this.cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            this.cameraToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.cameraToolStripMenuItem.Text = "Camera";
            // 
            // onlineToolStripMenuItem
            // 
            this.onlineToolStripMenuItem.Name = "onlineToolStripMenuItem";
            this.onlineToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.onlineToolStripMenuItem.Text = "Online";
            // 
            // manualTriggerToolStripMenuItem
            // 
            this.manualTriggerToolStripMenuItem.Name = "manualTriggerToolStripMenuItem";
            this.manualTriggerToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.manualTriggerToolStripMenuItem.Text = "Manual Trigger";
            // 
            // liveModeToolStripMenuItem
            // 
            this.liveModeToolStripMenuItem.Name = "liveModeToolStripMenuItem";
            this.liveModeToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.liveModeToolStripMenuItem.Text = "Live Mode";
            // 
            // showSpreadsheetToolStripMenuItem
            // 
            this.showSpreadsheetToolStripMenuItem.Name = "showSpreadsheetToolStripMenuItem";
            this.showSpreadsheetToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.showSpreadsheetToolStripMenuItem.Text = "Show Spreadsheet";
            // 
            // manualControlsToolStripMenuItem
            // 
            this.manualControlsToolStripMenuItem.Name = "manualControlsToolStripMenuItem";
            this.manualControlsToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.manualControlsToolStripMenuItem.Text = "Manual Controls";
            this.manualControlsToolStripMenuItem.Click += new System.EventHandler(this.manualControlsToolStripMenuItem_Click);
            // 
            // countersToolStripMenuItem
            // 
            this.countersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearStation1CountersToolStripMenuItem,
            this.clearStation2CountersToolStripMenuItem,
            this.clearAllCountersToolStripMenuItem});
            this.countersToolStripMenuItem.Name = "countersToolStripMenuItem";
            this.countersToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.countersToolStripMenuItem.Text = "Counters";
            // 
            // clearStation1CountersToolStripMenuItem
            // 
            this.clearStation1CountersToolStripMenuItem.Name = "clearStation1CountersToolStripMenuItem";
            this.clearStation1CountersToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.clearStation1CountersToolStripMenuItem.Text = "Clear Station 1 Counters";
            this.clearStation1CountersToolStripMenuItem.Click += new System.EventHandler(this.clearStation1CountersToolStripMenuItem_Click);
            // 
            // clearStation2CountersToolStripMenuItem
            // 
            this.clearStation2CountersToolStripMenuItem.Name = "clearStation2CountersToolStripMenuItem";
            this.clearStation2CountersToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.clearStation2CountersToolStripMenuItem.Text = "Clear Station 2 Counters";
            this.clearStation2CountersToolStripMenuItem.Click += new System.EventHandler(this.clearStation2CountersToolStripMenuItem_Click);
            // 
            // clearAllCountersToolStripMenuItem
            // 
            this.clearAllCountersToolStripMenuItem.Name = "clearAllCountersToolStripMenuItem";
            this.clearAllCountersToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.clearAllCountersToolStripMenuItem.Text = "Clear All Counters";
            this.clearAllCountersToolStripMenuItem.Click += new System.EventHandler(this.clearAllCountersToolStripMenuItem_Click);
            // 
            // groupBoxMainDisplay
            // 
            this.groupBoxMainDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMainDisplay.Controls.Add(this.button1);
            this.groupBoxMainDisplay.Controls.Add(this.secondaryResultsGroupBox);
            this.groupBoxMainDisplay.Controls.Add(this.mainResultsGroupBox);
            this.groupBoxMainDisplay.Controls.Add(this.secondarySerialNumberLabel);
            this.groupBoxMainDisplay.Controls.Add(this.mainSerialNumberLabel);
            this.groupBoxMainDisplay.Controls.Add(this.secondaryPartCountGroupBox);
            this.groupBoxMainDisplay.Controls.Add(this.plcMainMessageDisplayTextBox);
            this.groupBoxMainDisplay.Controls.Add(this.mainPartCountGroupBox);
            this.groupBoxMainDisplay.Controls.Add(this.plcSecondaryMessageTextBox);
            this.groupBoxMainDisplay.Controls.Add(this.mainMessageLabel);
            this.groupBoxMainDisplay.Controls.Add(this.secondaryMessageLabel);
            this.groupBoxMainDisplay.Location = new System.Drawing.Point(0, 27);
            this.groupBoxMainDisplay.Name = "groupBoxMainDisplay";
            this.groupBoxMainDisplay.Size = new System.Drawing.Size(1118, 216);
            this.groupBoxMainDisplay.TabIndex = 42;
            this.groupBoxMainDisplay.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(986, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // secondaryResultsGroupBox
            // 
            this.secondaryResultsGroupBox.Controls.Add(this.secondaryResultValue3Label);
            this.secondaryResultsGroupBox.Controls.Add(this.secondaryResultValue2Label);
            this.secondaryResultsGroupBox.Controls.Add(this.secondaryResultValue1Label);
            this.secondaryResultsGroupBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondaryResultsGroupBox.Location = new System.Drawing.Point(602, 161);
            this.secondaryResultsGroupBox.Name = "secondaryResultsGroupBox";
            this.secondaryResultsGroupBox.Size = new System.Drawing.Size(510, 49);
            this.secondaryResultsGroupBox.TabIndex = 34;
            this.secondaryResultsGroupBox.TabStop = false;
            this.secondaryResultsGroupBox.Text = "Station 2 Results";
            // 
            // secondaryResultValue3Label
            // 
            this.secondaryResultValue3Label.AutoSize = true;
            this.secondaryResultValue3Label.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondaryResultValue3Label.Location = new System.Drawing.Point(354, 21);
            this.secondaryResultValue3Label.Name = "secondaryResultValue3Label";
            this.secondaryResultValue3Label.Size = new System.Drawing.Size(150, 18);
            this.secondaryResultValue3Label.TabIndex = 2;
            this.secondaryResultValue3Label.Text = "High Limit: 235.02";
            this.secondaryResultValue3Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // secondaryResultValue2Label
            // 
            this.secondaryResultValue2Label.AutoSize = true;
            this.secondaryResultValue2Label.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondaryResultValue2Label.Location = new System.Drawing.Point(187, 21);
            this.secondaryResultValue2Label.Name = "secondaryResultValue2Label";
            this.secondaryResultValue2Label.Size = new System.Drawing.Size(120, 18);
            this.secondaryResultValue2Label.TabIndex = 1;
            this.secondaryResultValue2Label.Text = "Actual: 235.02";
            this.secondaryResultValue2Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // secondaryResultValue1Label
            // 
            this.secondaryResultValue1Label.AutoSize = true;
            this.secondaryResultValue1Label.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondaryResultValue1Label.Location = new System.Drawing.Point(7, 21);
            this.secondaryResultValue1Label.Name = "secondaryResultValue1Label";
            this.secondaryResultValue1Label.Size = new System.Drawing.Size(146, 18);
            this.secondaryResultValue1Label.TabIndex = 0;
            this.secondaryResultValue1Label.Text = "Low Limit: 235.02";
            this.secondaryResultValue1Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mainResultsGroupBox
            // 
            this.mainResultsGroupBox.Controls.Add(this.mainResultValue3Label);
            this.mainResultsGroupBox.Controls.Add(this.mainResultValue2Label);
            this.mainResultsGroupBox.Controls.Add(this.mainResultValue1Label);
            this.mainResultsGroupBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainResultsGroupBox.Location = new System.Drawing.Point(79, 161);
            this.mainResultsGroupBox.Name = "mainResultsGroupBox";
            this.mainResultsGroupBox.Size = new System.Drawing.Size(510, 49);
            this.mainResultsGroupBox.TabIndex = 33;
            this.mainResultsGroupBox.TabStop = false;
            this.mainResultsGroupBox.Text = "Station 1 Results";
            // 
            // mainResultValue3Label
            // 
            this.mainResultValue3Label.AutoSize = true;
            this.mainResultValue3Label.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainResultValue3Label.Location = new System.Drawing.Point(354, 21);
            this.mainResultValue3Label.Name = "mainResultValue3Label";
            this.mainResultValue3Label.Size = new System.Drawing.Size(150, 18);
            this.mainResultValue3Label.TabIndex = 2;
            this.mainResultValue3Label.Text = "High Limit: 235.02";
            this.mainResultValue3Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mainResultValue2Label
            // 
            this.mainResultValue2Label.AutoSize = true;
            this.mainResultValue2Label.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainResultValue2Label.Location = new System.Drawing.Point(187, 21);
            this.mainResultValue2Label.Name = "mainResultValue2Label";
            this.mainResultValue2Label.Size = new System.Drawing.Size(120, 18);
            this.mainResultValue2Label.TabIndex = 1;
            this.mainResultValue2Label.Text = "Actual: 235.02";
            this.mainResultValue2Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mainResultValue1Label
            // 
            this.mainResultValue1Label.AutoSize = true;
            this.mainResultValue1Label.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainResultValue1Label.Location = new System.Drawing.Point(7, 21);
            this.mainResultValue1Label.Name = "mainResultValue1Label";
            this.mainResultValue1Label.Size = new System.Drawing.Size(146, 18);
            this.mainResultValue1Label.TabIndex = 0;
            this.mainResultValue1Label.Text = "Low Limit: 235.02";
            this.mainResultValue1Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // secondarySerialNumberLabel
            // 
            this.secondarySerialNumberLabel.AutoSize = true;
            this.secondarySerialNumberLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondarySerialNumberLabel.Location = new System.Drawing.Point(611, 19);
            this.secondarySerialNumberLabel.Name = "secondarySerialNumberLabel";
            this.secondarySerialNumberLabel.Size = new System.Drawing.Size(106, 16);
            this.secondarySerialNumberLabel.TabIndex = 37;
            this.secondarySerialNumberLabel.Text = "Serial Number: ";
            // 
            // mainSerialNumberLabel
            // 
            this.mainSerialNumberLabel.AutoSize = true;
            this.mainSerialNumberLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainSerialNumberLabel.Location = new System.Drawing.Point(180, 16);
            this.mainSerialNumberLabel.Name = "mainSerialNumberLabel";
            this.mainSerialNumberLabel.Size = new System.Drawing.Size(106, 16);
            this.mainSerialNumberLabel.TabIndex = 38;
            this.mainSerialNumberLabel.Text = "Serial Number: ";
            // 
            // secondaryPartCountGroupBox
            // 
            this.secondaryPartCountGroupBox.Controls.Add(this.secondaryPartCountTotalLabel);
            this.secondaryPartCountGroupBox.Controls.Add(this.secondaryPartCountRejectLabel);
            this.secondaryPartCountGroupBox.Controls.Add(this.secondaryPartCountGoodLabel);
            this.secondaryPartCountGroupBox.Location = new System.Drawing.Point(693, 102);
            this.secondaryPartCountGroupBox.Name = "secondaryPartCountGroupBox";
            this.secondaryPartCountGroupBox.Size = new System.Drawing.Size(344, 37);
            this.secondaryPartCountGroupBox.TabIndex = 40;
            this.secondaryPartCountGroupBox.TabStop = false;
            // 
            // secondaryPartCountTotalLabel
            // 
            this.secondaryPartCountTotalLabel.AutoSize = true;
            this.secondaryPartCountTotalLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondaryPartCountTotalLabel.Location = new System.Drawing.Point(232, 13);
            this.secondaryPartCountTotalLabel.Name = "secondaryPartCountTotalLabel";
            this.secondaryPartCountTotalLabel.Size = new System.Drawing.Size(103, 13);
            this.secondaryPartCountTotalLabel.TabIndex = 2;
            this.secondaryPartCountTotalLabel.Text = "Total Parts: 0000";
            // 
            // secondaryPartCountRejectLabel
            // 
            this.secondaryPartCountRejectLabel.AutoSize = true;
            this.secondaryPartCountRejectLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondaryPartCountRejectLabel.Location = new System.Drawing.Point(115, 13);
            this.secondaryPartCountRejectLabel.Name = "secondaryPartCountRejectLabel";
            this.secondaryPartCountRejectLabel.Size = new System.Drawing.Size(111, 13);
            this.secondaryPartCountRejectLabel.TabIndex = 1;
            this.secondaryPartCountRejectLabel.Text = "Reject Parts: 0000";
            // 
            // secondaryPartCountGoodLabel
            // 
            this.secondaryPartCountGoodLabel.AutoSize = true;
            this.secondaryPartCountGoodLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondaryPartCountGoodLabel.Location = new System.Drawing.Point(6, 13);
            this.secondaryPartCountGoodLabel.Name = "secondaryPartCountGoodLabel";
            this.secondaryPartCountGoodLabel.Size = new System.Drawing.Size(103, 13);
            this.secondaryPartCountGoodLabel.TabIndex = 0;
            this.secondaryPartCountGoodLabel.Text = "Good Parts: 0000";
            // 
            // plcMainMessageDisplayTextBox
            // 
            this.plcMainMessageDisplayTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plcMainMessageDisplayTextBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plcMainMessageDisplayTextBox.Location = new System.Drawing.Point(180, 38);
            this.plcMainMessageDisplayTextBox.Multiline = true;
            this.plcMainMessageDisplayTextBox.Name = "plcMainMessageDisplayTextBox";
            this.plcMainMessageDisplayTextBox.ReadOnly = true;
            this.plcMainMessageDisplayTextBox.Size = new System.Drawing.Size(791, 58);
            this.plcMainMessageDisplayTextBox.TabIndex = 27;
            this.plcMainMessageDisplayTextBox.Text = "Ready For Part Load";
            this.plcMainMessageDisplayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mainPartCountGroupBox
            // 
            this.mainPartCountGroupBox.Controls.Add(this.mainPartCountTotalLabel);
            this.mainPartCountGroupBox.Controls.Add(this.mainPartCountGoodLabel);
            this.mainPartCountGroupBox.Controls.Add(this.mainPartCountRejectLabel);
            this.mainPartCountGroupBox.Location = new System.Drawing.Point(223, 102);
            this.mainPartCountGroupBox.Name = "mainPartCountGroupBox";
            this.mainPartCountGroupBox.Size = new System.Drawing.Size(344, 37);
            this.mainPartCountGroupBox.TabIndex = 39;
            this.mainPartCountGroupBox.TabStop = false;
            // 
            // mainPartCountTotalLabel
            // 
            this.mainPartCountTotalLabel.AutoSize = true;
            this.mainPartCountTotalLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPartCountTotalLabel.Location = new System.Drawing.Point(232, 13);
            this.mainPartCountTotalLabel.Name = "mainPartCountTotalLabel";
            this.mainPartCountTotalLabel.Size = new System.Drawing.Size(103, 13);
            this.mainPartCountTotalLabel.TabIndex = 2;
            this.mainPartCountTotalLabel.Text = "Total Parts: 0000";
            // 
            // mainPartCountGoodLabel
            // 
            this.mainPartCountGoodLabel.AutoSize = true;
            this.mainPartCountGoodLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPartCountGoodLabel.Location = new System.Drawing.Point(6, 13);
            this.mainPartCountGoodLabel.Name = "mainPartCountGoodLabel";
            this.mainPartCountGoodLabel.Size = new System.Drawing.Size(103, 13);
            this.mainPartCountGoodLabel.TabIndex = 0;
            this.mainPartCountGoodLabel.Text = "Good Parts: 0000";
            // 
            // mainPartCountRejectLabel
            // 
            this.mainPartCountRejectLabel.AutoSize = true;
            this.mainPartCountRejectLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPartCountRejectLabel.Location = new System.Drawing.Point(115, 13);
            this.mainPartCountRejectLabel.Name = "mainPartCountRejectLabel";
            this.mainPartCountRejectLabel.Size = new System.Drawing.Size(111, 13);
            this.mainPartCountRejectLabel.TabIndex = 1;
            this.mainPartCountRejectLabel.Text = "Reject Parts: 0000";
            // 
            // plcSecondaryMessageTextBox
            // 
            this.plcSecondaryMessageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plcSecondaryMessageTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.plcSecondaryMessageTextBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plcSecondaryMessageTextBox.Location = new System.Drawing.Point(321, 38);
            this.plcSecondaryMessageTextBox.Multiline = true;
            this.plcSecondaryMessageTextBox.Name = "plcSecondaryMessageTextBox";
            this.plcSecondaryMessageTextBox.ReadOnly = true;
            this.plcSecondaryMessageTextBox.Size = new System.Drawing.Size(791, 58);
            this.plcSecondaryMessageTextBox.TabIndex = 28;
            this.plcSecondaryMessageTextBox.Text = "Ready For Part Load";
            this.plcSecondaryMessageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mainMessageLabel
            // 
            this.mainMessageLabel.AutoSize = true;
            this.mainMessageLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMessageLabel.Location = new System.Drawing.Point(341, 16);
            this.mainMessageLabel.Name = "mainMessageLabel";
            this.mainMessageLabel.Size = new System.Drawing.Size(126, 19);
            this.mainMessageLabel.TabIndex = 36;
            this.mainMessageLabel.Text = "Station 1 Title";
            this.mainMessageLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // secondaryMessageLabel
            // 
            this.secondaryMessageLabel.AutoSize = true;
            this.secondaryMessageLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondaryMessageLabel.Location = new System.Drawing.Point(723, 16);
            this.secondaryMessageLabel.Name = "secondaryMessageLabel";
            this.secondaryMessageLabel.Size = new System.Drawing.Size(126, 19);
            this.secondaryMessageLabel.TabIndex = 35;
            this.secondaryMessageLabel.Text = "Station 2 Title";
            this.secondaryMessageLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCameraStatus
            // 
            this.labelCameraStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCameraStatus.AutoSize = true;
            this.labelCameraStatus.BackColor = System.Drawing.SystemColors.Control;
            this.labelCameraStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCameraStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCameraStatus.Location = new System.Drawing.Point(97, 515);
            this.labelCameraStatus.Name = "labelCameraStatus";
            this.labelCameraStatus.Size = new System.Drawing.Size(94, 15);
            this.labelCameraStatus.TabIndex = 41;
            this.labelCameraStatus.Text = "Not Connected";
            // 
            // groupBoxImageDisplay
            // 
            this.groupBoxImageDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxImageDisplay.Controls.Add(this.cvsInSightDisplay1);
            this.groupBoxImageDisplay.Controls.Add(this.pictureBox2);
            this.groupBoxImageDisplay.Controls.Add(this.pictureBox1);
            this.groupBoxImageDisplay.Location = new System.Drawing.Point(0, 249);
            this.groupBoxImageDisplay.Name = "groupBoxImageDisplay";
            this.groupBoxImageDisplay.Size = new System.Drawing.Size(1118, 260);
            this.groupBoxImageDisplay.TabIndex = 44;
            this.groupBoxImageDisplay.TabStop = false;
            // 
            // cvsInSightDisplay1
            // 
            this.cvsInSightDisplay1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cvsInSightDisplay1.AutoConnectString = "10.50.201.201,admin";
            this.cvsInSightDisplay1.DefaultTextScaleMode = Cognex.InSight.Controls.Display.CvsInSightDisplay.TextScaleModeType.Proportional;
            this.cvsInSightDisplay1.DialogIcon = null;
            this.cvsInSightDisplay1.Location = new System.Drawing.Point(304, 20);
            this.cvsInSightDisplay1.Name = "cvsInSightDisplay1";
            this.cvsInSightDisplay1.Size = new System.Drawing.Size(640, 240);
            this.cvsInSightDisplay1.TabIndex = 45;
            this.cvsInSightDisplay1.ResultsChanged += new System.EventHandler(this.cvsInSightDisplay1_ResultsChanged);
            this.cvsInSightDisplay1.ConnectCompleted += new Cognex.InSight.CvsConnectCompletedEventHandler(this.cvsInSightDisplay1_ConnectCompleted);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1006, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 515);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Camera Status:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 517);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "PLC Status:";
            // 
            // labelPlcStatus
            // 
            this.labelPlcStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPlcStatus.AutoSize = true;
            this.labelPlcStatus.BackColor = System.Drawing.SystemColors.Control;
            this.labelPlcStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPlcStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlcStatus.Location = new System.Drawing.Point(298, 517);
            this.labelPlcStatus.Name = "labelPlcStatus";
            this.labelPlcStatus.Size = new System.Drawing.Size(94, 15);
            this.labelPlcStatus.TabIndex = 47;
            this.labelPlcStatus.Text = "Not Connected";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 537);
            this.Controls.Add(this.labelPlcStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCameraStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxImageDisplay);
            this.Controls.Add(this.groupBoxMainDisplay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "ARC Final Inspection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxMainDisplay.ResumeLayout(false);
            this.groupBoxMainDisplay.PerformLayout();
            this.secondaryResultsGroupBox.ResumeLayout(false);
            this.secondaryResultsGroupBox.PerformLayout();
            this.mainResultsGroupBox.ResumeLayout(false);
            this.mainResultsGroupBox.PerformLayout();
            this.secondaryPartCountGroupBox.ResumeLayout(false);
            this.secondaryPartCountGroupBox.PerformLayout();
            this.mainPartCountGroupBox.ResumeLayout(false);
            this.mainPartCountGroupBox.PerformLayout();
            this.groupBoxImageDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openJobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveJobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveJobAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxMainDisplay;
        private System.Windows.Forms.GroupBox secondaryResultsGroupBox;
        private System.Windows.Forms.Label secondaryResultValue3Label;
        private System.Windows.Forms.Label secondaryResultValue2Label;
        private System.Windows.Forms.Label secondaryResultValue1Label;
        private System.Windows.Forms.GroupBox mainResultsGroupBox;
        private System.Windows.Forms.Label mainResultValue3Label;
        private System.Windows.Forms.Label mainResultValue2Label;
        private System.Windows.Forms.Label mainResultValue1Label;
        private System.Windows.Forms.Label secondarySerialNumberLabel;
        private System.Windows.Forms.Label mainSerialNumberLabel;
        private System.Windows.Forms.GroupBox secondaryPartCountGroupBox;
        private System.Windows.Forms.Label secondaryPartCountTotalLabel;
        private System.Windows.Forms.Label secondaryPartCountRejectLabel;
        private System.Windows.Forms.Label secondaryPartCountGoodLabel;
        private System.Windows.Forms.TextBox plcMainMessageDisplayTextBox;
        private System.Windows.Forms.GroupBox mainPartCountGroupBox;
        private System.Windows.Forms.Label mainPartCountTotalLabel;
        private System.Windows.Forms.Label mainPartCountGoodLabel;
        private System.Windows.Forms.Label mainPartCountRejectLabel;
        private System.Windows.Forms.TextBox plcSecondaryMessageTextBox;
        private System.Windows.Forms.Label mainMessageLabel;
        private System.Windows.Forms.Label secondaryMessageLabel;
        private System.Windows.Forms.GroupBox groupBoxImageDisplay;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pLCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plcSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plcConnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraConnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualTriggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liveModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showSpreadsheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualControlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearStation1CountersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearStation2CountersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllCountersToolStripMenuItem;
        private Cognex.InSight.Controls.Display.CvsInSightDisplay cvsInSightDisplay1;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.Label labelCameraStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPlcStatus;
        private System.Windows.Forms.Button button1;
    }
}

