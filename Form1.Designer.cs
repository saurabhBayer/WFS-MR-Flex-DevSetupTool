namespace WfsMrFlexSetup
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label2 = new System.Windows.Forms.Label();
			this.btnOverlayStartHelp = new System.Windows.Forms.Button();
			this.btnOverlayStartFullStack = new System.Windows.Forms.Button();
			this.groupBoxMode = new System.Windows.Forms.GroupBox();
			this.btnSwitchMode = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.labelCurrentMode = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tabcontrolPOC = new System.Windows.Forms.TabControl();
			this.tabPOC = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnOpenSimFolderInShell = new System.Windows.Forms.Button();
			this.btnExportCertegraDatabase = new System.Windows.Forms.Button();
			this.btnOpenSimulatorFolder = new System.Windows.Forms.Button();
			this.btnCopyCertegraToSim = new System.Windows.Forms.Button();
			this.btnStopSimulator = new System.Windows.Forms.Button();
			this.btnStartSimulator = new System.Windows.Forms.Button();
			this.btnBuildSimulatorDebug = new System.Windows.Forms.Button();
			this.tabOverlay = new System.Windows.Forms.TabPage();
			this.gbpOverlay = new System.Windows.Forms.GroupBox();
			this.btnElectronMode = new System.Windows.Forms.Button();
			this.btnOverlayShell = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.btnOverlayFolder = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtOverlayPortNumber = new System.Windows.Forms.TextBox();
			this.btnStartOverlayOnly = new System.Windows.Forms.Button();
			this.btnStopOverlay = new System.Windows.Forms.Button();
			this.tabOrion = new System.Windows.Forms.TabPage();
			this.gbpOrion = new System.Windows.Forms.GroupBox();
			this.btnOrionCmdShell = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.btnOrionExplorer = new System.Windows.Forms.Button();
			this.btnStopOrion = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPortNumber = new System.Windows.Forms.TextBox();
			this.btnStartOrionUI = new System.Windows.Forms.Button();
			this.btnStartOrionApi = new System.Windows.Forms.Button();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnWorklistSimulator = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.execProgressbar = new System.Windows.Forms.ProgressBar();
			this.tmrSwitcher = new System.Windows.Forms.Timer(this.components);
			this.groupBoxMode.SuspendLayout();
			this.tabcontrolPOC.SuspendLayout();
			this.tabPOC.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tabOverlay.SuspendLayout();
			this.gbpOverlay.SuspendLayout();
			this.tabOrion.SuspendLayout();
			this.gbpOrion.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
			this.label2.Location = new System.Drawing.Point(12, 63);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(480, 18);
			this.label2.TabIndex = 4;
			this.label2.Text = "FYI: File && registry paths / values can be modified in app.config";
			// 
			// btnOverlayStartHelp
			// 
			this.btnOverlayStartHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOverlayStartHelp.Location = new System.Drawing.Point(702, 52);
			this.btnOverlayStartHelp.Margin = new System.Windows.Forms.Padding(2);
			this.btnOverlayStartHelp.Name = "btnOverlayStartHelp";
			this.btnOverlayStartHelp.Size = new System.Drawing.Size(33, 31);
			this.btnOverlayStartHelp.TabIndex = 2;
			this.btnOverlayStartHelp.Text = "?";
			this.btnOverlayStartHelp.UseVisualStyleBackColor = true;
			this.btnOverlayStartHelp.Click += new System.EventHandler(this.btnOverlayStartHelp_Click);
			// 
			// btnOverlayStartFullStack
			// 
			this.btnOverlayStartFullStack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOverlayStartFullStack.Location = new System.Drawing.Point(538, 11);
			this.btnOverlayStartFullStack.Margin = new System.Windows.Forms.Padding(2);
			this.btnOverlayStartFullStack.Name = "btnOverlayStartFullStack";
			this.btnOverlayStartFullStack.Size = new System.Drawing.Size(158, 73);
			this.btnOverlayStartFullStack.TabIndex = 1;
			this.btnOverlayStartFullStack.Text = "Start full stack";
			this.btnOverlayStartFullStack.UseVisualStyleBackColor = true;
			this.btnOverlayStartFullStack.Click += new System.EventHandler(this.btnOverlayStartFullStack_Click);
			// 
			// groupBoxMode
			// 
			this.groupBoxMode.Controls.Add(this.btnSwitchMode);
			this.groupBoxMode.Controls.Add(this.label5);
			this.groupBoxMode.Controls.Add(this.labelCurrentMode);
			this.groupBoxMode.Location = new System.Drawing.Point(10, 7);
			this.groupBoxMode.Margin = new System.Windows.Forms.Padding(2);
			this.groupBoxMode.Name = "groupBoxMode";
			this.groupBoxMode.Padding = new System.Windows.Forms.Padding(2);
			this.groupBoxMode.Size = new System.Drawing.Size(515, 54);
			this.groupBoxMode.TabIndex = 7;
			this.groupBoxMode.TabStop = false;
			// 
			// btnSwitchMode
			// 
			this.btnSwitchMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSwitchMode.Location = new System.Drawing.Point(290, 17);
			this.btnSwitchMode.Margin = new System.Windows.Forms.Padding(2);
			this.btnSwitchMode.Name = "btnSwitchMode";
			this.btnSwitchMode.Size = new System.Drawing.Size(216, 26);
			this.btnSwitchMode.TabIndex = 2;
			this.btnSwitchMode.Text = "Switch mode";
			this.btnSwitchMode.UseVisualStyleBackColor = true;
			this.btnSwitchMode.Click += new System.EventHandler(this.btnSwitchMode_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 22);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(111, 17);
			this.label5.TabIndex = 0;
			this.label5.Text = "Current mode:";
			// 
			// labelCurrentMode
			// 
			this.labelCurrentMode.AutoSize = true;
			this.labelCurrentMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCurrentMode.Location = new System.Drawing.Point(140, 22);
			this.labelCurrentMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelCurrentMode.Name = "labelCurrentMode";
			this.labelCurrentMode.Size = new System.Drawing.Size(104, 17);
			this.labelCurrentMode.TabIndex = 1;
			this.labelCurrentMode.Text = "(flex or mrxp)";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Firebrick;
			this.label6.Location = new System.Drawing.Point(10, 82);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(243, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "[ default project files root path is set to C:\\Source ]";
			// 
			// tabcontrolPOC
			// 
			this.tabcontrolPOC.Controls.Add(this.tabPOC);
			this.tabcontrolPOC.Controls.Add(this.tabOverlay);
			this.tabcontrolPOC.Controls.Add(this.tabOrion);
			this.tabcontrolPOC.Controls.Add(this.tabPage1);
			this.tabcontrolPOC.Location = new System.Drawing.Point(10, 98);
			this.tabcontrolPOC.Name = "tabcontrolPOC";
			this.tabcontrolPOC.SelectedIndex = 0;
			this.tabcontrolPOC.Size = new System.Drawing.Size(725, 306);
			this.tabcontrolPOC.TabIndex = 9;
			// 
			// tabPOC
			// 
			this.tabPOC.Controls.Add(this.groupBox2);
			this.tabPOC.Location = new System.Drawing.Point(4, 22);
			this.tabPOC.Name = "tabPOC";
			this.tabPOC.Padding = new System.Windows.Forms.Padding(3);
			this.tabPOC.Size = new System.Drawing.Size(717, 280);
			this.tabPOC.TabIndex = 0;
			this.tabPOC.Text = " MRXP / Flex Dev Setup";
			this.tabPOC.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.btnOpenSimFolderInShell);
			this.groupBox2.Controls.Add(this.btnExportCertegraDatabase);
			this.groupBox2.Controls.Add(this.btnOpenSimulatorFolder);
			this.groupBox2.Controls.Add(this.btnCopyCertegraToSim);
			this.groupBox2.Controls.Add(this.btnStopSimulator);
			this.groupBox2.Controls.Add(this.btnStartSimulator);
			this.groupBox2.Controls.Add(this.btnBuildSimulatorDebug);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(3, 3);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox2.Size = new System.Drawing.Size(711, 274);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(461, 101);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(148, 17);
			this.label3.TabIndex = 8;
			this.label3.Text = "Open simulator folder:";
			// 
			// btnOpenSimFolderInShell
			// 
			this.btnOpenSimFolderInShell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOpenSimFolderInShell.Location = new System.Drawing.Point(550, 124);
			this.btnOpenSimFolderInShell.Margin = new System.Windows.Forms.Padding(2);
			this.btnOpenSimFolderInShell.Name = "btnOpenSimFolderInShell";
			this.btnOpenSimFolderInShell.Size = new System.Drawing.Size(129, 54);
			this.btnOpenSimFolderInShell.TabIndex = 7;
			this.btnOpenSimFolderInShell.Text = "cmd shell";
			this.btnOpenSimFolderInShell.UseVisualStyleBackColor = true;
			this.btnOpenSimFolderInShell.Click += new System.EventHandler(this.btnOpenSimFolderInShell_Click);
			// 
			// btnExportCertegraDatabase
			// 
			this.btnExportCertegraDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExportCertegraDatabase.Location = new System.Drawing.Point(389, 192);
			this.btnExportCertegraDatabase.Margin = new System.Windows.Forms.Padding(2);
			this.btnExportCertegraDatabase.Name = "btnExportCertegraDatabase";
			this.btnExportCertegraDatabase.Size = new System.Drawing.Size(290, 73);
			this.btnExportCertegraDatabase.TabIndex = 6;
			this.btnExportCertegraDatabase.Text = "create new Certegra db";
			this.btnExportCertegraDatabase.UseVisualStyleBackColor = true;
			this.btnExportCertegraDatabase.Click += new System.EventHandler(this.btnExportCertegraDatabase_Click);
			// 
			// btnOpenSimulatorFolder
			// 
			this.btnOpenSimulatorFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOpenSimulatorFolder.Location = new System.Drawing.Point(389, 124);
			this.btnOpenSimulatorFolder.Margin = new System.Windows.Forms.Padding(2);
			this.btnOpenSimulatorFolder.Name = "btnOpenSimulatorFolder";
			this.btnOpenSimulatorFolder.Size = new System.Drawing.Size(129, 54);
			this.btnOpenSimulatorFolder.TabIndex = 5;
			this.btnOpenSimulatorFolder.Text = "Explorer";
			this.btnOpenSimulatorFolder.UseVisualStyleBackColor = true;
			this.btnOpenSimulatorFolder.Click += new System.EventHandler(this.btnOpenSimulatorFolder_Click);
			// 
			// btnCopyCertegraToSim
			// 
			this.btnCopyCertegraToSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCopyCertegraToSim.Location = new System.Drawing.Point(389, 17);
			this.btnCopyCertegraToSim.Margin = new System.Windows.Forms.Padding(2);
			this.btnCopyCertegraToSim.Name = "btnCopyCertegraToSim";
			this.btnCopyCertegraToSim.Size = new System.Drawing.Size(290, 73);
			this.btnCopyCertegraToSim.TabIndex = 3;
			this.btnCopyCertegraToSim.Text = "Copy Certegra binaries to simulator dir";
			this.btnCopyCertegraToSim.UseVisualStyleBackColor = true;
			this.btnCopyCertegraToSim.Click += new System.EventHandler(this.btnCopyCertegraToSim_Click);
			// 
			// btnStopSimulator
			// 
			this.btnStopSimulator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStopSimulator.Location = new System.Drawing.Point(30, 188);
			this.btnStopSimulator.Margin = new System.Windows.Forms.Padding(2);
			this.btnStopSimulator.Name = "btnStopSimulator";
			this.btnStopSimulator.Size = new System.Drawing.Size(267, 73);
			this.btnStopSimulator.TabIndex = 2;
			this.btnStopSimulator.Text = "Stop simulator (debug)";
			this.btnStopSimulator.UseVisualStyleBackColor = true;
			this.btnStopSimulator.Click += new System.EventHandler(this.btnStopSimulator_Click);
			// 
			// btnStartSimulator
			// 
			this.btnStartSimulator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStartSimulator.Location = new System.Drawing.Point(30, 101);
			this.btnStartSimulator.Margin = new System.Windows.Forms.Padding(2);
			this.btnStartSimulator.Name = "btnStartSimulator";
			this.btnStartSimulator.Size = new System.Drawing.Size(267, 73);
			this.btnStartSimulator.TabIndex = 1;
			this.btnStartSimulator.Text = "Start simulator (debug)";
			this.btnStartSimulator.UseVisualStyleBackColor = true;
			this.btnStartSimulator.Click += new System.EventHandler(this.btnStartSimulator_Click);
			// 
			// btnBuildSimulatorDebug
			// 
			this.btnBuildSimulatorDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuildSimulatorDebug.Location = new System.Drawing.Point(30, 13);
			this.btnBuildSimulatorDebug.Margin = new System.Windows.Forms.Padding(2);
			this.btnBuildSimulatorDebug.Name = "btnBuildSimulatorDebug";
			this.btnBuildSimulatorDebug.Size = new System.Drawing.Size(267, 73);
			this.btnBuildSimulatorDebug.TabIndex = 0;
			this.btnBuildSimulatorDebug.Text = "Buid simulator debug";
			this.btnBuildSimulatorDebug.UseVisualStyleBackColor = true;
			this.btnBuildSimulatorDebug.Click += new System.EventHandler(this.btnBuildSimulatorDebug_Click);
			// 
			// tabOverlay
			// 
			this.tabOverlay.Controls.Add(this.gbpOverlay);
			this.tabOverlay.Location = new System.Drawing.Point(4, 22);
			this.tabOverlay.Name = "tabOverlay";
			this.tabOverlay.Padding = new System.Windows.Forms.Padding(3);
			this.tabOverlay.Size = new System.Drawing.Size(717, 280);
			this.tabOverlay.TabIndex = 1;
			this.tabOverlay.Text = "Overlay Apps";
			this.tabOverlay.UseVisualStyleBackColor = true;
			// 
			// gbpOverlay
			// 
			this.gbpOverlay.Controls.Add(this.btnElectronMode);
			this.gbpOverlay.Controls.Add(this.btnOverlayShell);
			this.gbpOverlay.Controls.Add(this.label7);
			this.gbpOverlay.Controls.Add(this.btnOverlayFolder);
			this.gbpOverlay.Controls.Add(this.label1);
			this.gbpOverlay.Controls.Add(this.txtOverlayPortNumber);
			this.gbpOverlay.Controls.Add(this.btnStartOverlayOnly);
			this.gbpOverlay.Controls.Add(this.btnStopOverlay);
			this.gbpOverlay.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbpOverlay.Location = new System.Drawing.Point(3, 3);
			this.gbpOverlay.Margin = new System.Windows.Forms.Padding(2);
			this.gbpOverlay.Name = "gbpOverlay";
			this.gbpOverlay.Padding = new System.Windows.Forms.Padding(2);
			this.gbpOverlay.Size = new System.Drawing.Size(711, 274);
			this.gbpOverlay.TabIndex = 6;
			this.gbpOverlay.TabStop = false;
			this.gbpOverlay.Text = "Overlay Apps";
			// 
			// btnElectronMode
			// 
			this.btnElectronMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnElectronMode.Location = new System.Drawing.Point(346, 142);
			this.btnElectronMode.Margin = new System.Windows.Forms.Padding(2);
			this.btnElectronMode.Name = "btnElectronMode";
			this.btnElectronMode.Size = new System.Drawing.Size(220, 73);
			this.btnElectronMode.TabIndex = 11;
			this.btnElectronMode.Text = "Start Overlay in Electron Mode";
			this.btnElectronMode.UseVisualStyleBackColor = true;
			this.btnElectronMode.Click += new System.EventHandler(this.btnElectronMode_Click);
			// 
			// btnOverlayShell
			// 
			this.btnOverlayShell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOverlayShell.Location = new System.Drawing.Point(503, 61);
			this.btnOverlayShell.Margin = new System.Windows.Forms.Padding(2);
			this.btnOverlayShell.Name = "btnOverlayShell";
			this.btnOverlayShell.Size = new System.Drawing.Size(129, 54);
			this.btnOverlayShell.TabIndex = 10;
			this.btnOverlayShell.Text = "cmd shell";
			this.btnOverlayShell.UseVisualStyleBackColor = true;
			this.btnOverlayShell.Click += new System.EventHandler(this.btnOverlayShell_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(420, 40);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(140, 17);
			this.label7.TabIndex = 9;
			this.label7.Text = "Open Overlay folder:";
			// 
			// btnOverlayFolder
			// 
			this.btnOverlayFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOverlayFolder.Location = new System.Drawing.Point(346, 60);
			this.btnOverlayFolder.Margin = new System.Windows.Forms.Padding(2);
			this.btnOverlayFolder.Name = "btnOverlayFolder";
			this.btnOverlayFolder.Size = new System.Drawing.Size(129, 54);
			this.btnOverlayFolder.TabIndex = 8;
			this.btnOverlayFolder.Text = "Explorer";
			this.btnOverlayFolder.UseVisualStyleBackColor = true;
			this.btnOverlayFolder.Click += new System.EventHandler(this.btnOverlayFolder_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(41, 227);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Enter Overlay UI Port #";
			// 
			// txtOverlayPortNumber
			// 
			this.txtOverlayPortNumber.Cursor = System.Windows.Forms.Cursors.Hand;
			this.txtOverlayPortNumber.Location = new System.Drawing.Point(200, 224);
			this.txtOverlayPortNumber.Name = "txtOverlayPortNumber";
			this.txtOverlayPortNumber.Size = new System.Drawing.Size(59, 20);
			this.txtOverlayPortNumber.TabIndex = 6;
			this.txtOverlayPortNumber.Text = "9200";
			this.txtOverlayPortNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOverlayPortNumber_KeyPress);
			// 
			// btnStartOverlayOnly
			// 
			this.btnStartOverlayOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStartOverlayOnly.Location = new System.Drawing.Point(39, 41);
			this.btnStartOverlayOnly.Margin = new System.Windows.Forms.Padding(2);
			this.btnStartOverlayOnly.Name = "btnStartOverlayOnly";
			this.btnStartOverlayOnly.Size = new System.Drawing.Size(220, 73);
			this.btnStartOverlayOnly.TabIndex = 6;
			this.btnStartOverlayOnly.Text = "Start Overlay Only";
			this.btnStartOverlayOnly.UseVisualStyleBackColor = true;
			this.btnStartOverlayOnly.Click += new System.EventHandler(this.btnStartOverlayOnly_Click);
			// 
			// btnStopOverlay
			// 
			this.btnStopOverlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
			this.btnStopOverlay.Location = new System.Drawing.Point(39, 142);
			this.btnStopOverlay.Margin = new System.Windows.Forms.Padding(2);
			this.btnStopOverlay.Name = "btnStopOverlay";
			this.btnStopOverlay.Size = new System.Drawing.Size(220, 73);
			this.btnStopOverlay.TabIndex = 5;
			this.btnStopOverlay.Text = "Stop Overlay Only";
			this.btnStopOverlay.UseVisualStyleBackColor = true;
			this.btnStopOverlay.Click += new System.EventHandler(this.btnStopOverlay_Click);
			// 
			// tabOrion
			// 
			this.tabOrion.Controls.Add(this.gbpOrion);
			this.tabOrion.Location = new System.Drawing.Point(4, 22);
			this.tabOrion.Name = "tabOrion";
			this.tabOrion.Padding = new System.Windows.Forms.Padding(3);
			this.tabOrion.Size = new System.Drawing.Size(717, 280);
			this.tabOrion.TabIndex = 2;
			this.tabOrion.Text = "IM Server Apps";
			this.tabOrion.UseVisualStyleBackColor = true;
			// 
			// gbpOrion
			// 
			this.gbpOrion.Controls.Add(this.btnOrionCmdShell);
			this.gbpOrion.Controls.Add(this.label8);
			this.gbpOrion.Controls.Add(this.btnOrionExplorer);
			this.gbpOrion.Controls.Add(this.btnStopOrion);
			this.gbpOrion.Controls.Add(this.label4);
			this.gbpOrion.Controls.Add(this.txtPortNumber);
			this.gbpOrion.Controls.Add(this.btnStartOrionUI);
			this.gbpOrion.Controls.Add(this.btnStartOrionApi);
			this.gbpOrion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbpOrion.Location = new System.Drawing.Point(3, 3);
			this.gbpOrion.Margin = new System.Windows.Forms.Padding(2);
			this.gbpOrion.Name = "gbpOrion";
			this.gbpOrion.Padding = new System.Windows.Forms.Padding(2);
			this.gbpOrion.Size = new System.Drawing.Size(711, 274);
			this.gbpOrion.TabIndex = 7;
			this.gbpOrion.TabStop = false;
			// 
			// btnOrionCmdShell
			// 
			this.btnOrionCmdShell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOrionCmdShell.Location = new System.Drawing.Point(493, 152);
			this.btnOrionCmdShell.Margin = new System.Windows.Forms.Padding(2);
			this.btnOrionCmdShell.Name = "btnOrionCmdShell";
			this.btnOrionCmdShell.Size = new System.Drawing.Size(129, 54);
			this.btnOrionCmdShell.TabIndex = 13;
			this.btnOrionCmdShell.Text = "cmd shell";
			this.btnOrionCmdShell.UseVisualStyleBackColor = true;
			this.btnOrionCmdShell.Click += new System.EventHandler(this.btnOrionCmdShell_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(410, 131);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(126, 17);
			this.label8.TabIndex = 12;
			this.label8.Text = "Open Orion folder:";
			// 
			// btnOrionExplorer
			// 
			this.btnOrionExplorer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOrionExplorer.Location = new System.Drawing.Point(336, 151);
			this.btnOrionExplorer.Margin = new System.Windows.Forms.Padding(2);
			this.btnOrionExplorer.Name = "btnOrionExplorer";
			this.btnOrionExplorer.Size = new System.Drawing.Size(129, 54);
			this.btnOrionExplorer.TabIndex = 11;
			this.btnOrionExplorer.Text = "Explorer";
			this.btnOrionExplorer.UseVisualStyleBackColor = true;
			this.btnOrionExplorer.Click += new System.EventHandler(this.btnOrionExplorer_Click);
			// 
			// btnStopOrion
			// 
			this.btnStopOrion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
			this.btnStopOrion.Location = new System.Drawing.Point(371, 45);
			this.btnStopOrion.Margin = new System.Windows.Forms.Padding(2);
			this.btnStopOrion.Name = "btnStopOrion";
			this.btnStopOrion.Size = new System.Drawing.Size(230, 73);
			this.btnStopOrion.TabIndex = 4;
			this.btnStopOrion.Text = "Stop Orion";
			this.btnStopOrion.UseVisualStyleBackColor = true;
			this.btnStopOrion.Click += new System.EventHandler(this.btnStopOrion_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(48, 230);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Enter Port #";
			// 
			// txtPortNumber
			// 
			this.txtPortNumber.Cursor = System.Windows.Forms.Cursors.Hand;
			this.txtPortNumber.Location = new System.Drawing.Point(127, 227);
			this.txtPortNumber.Name = "txtPortNumber";
			this.txtPortNumber.Size = new System.Drawing.Size(59, 20);
			this.txtPortNumber.TabIndex = 4;
			this.txtPortNumber.Text = "4200";
			this.txtPortNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPortNumber_KeyPress);
			// 
			// btnStartOrionUI
			// 
			this.btnStartOrionUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStartOrionUI.Location = new System.Drawing.Point(47, 133);
			this.btnStartOrionUI.Margin = new System.Windows.Forms.Padding(2);
			this.btnStartOrionUI.Name = "btnStartOrionUI";
			this.btnStartOrionUI.Size = new System.Drawing.Size(230, 73);
			this.btnStartOrionUI.TabIndex = 3;
			this.btnStartOrionUI.Text = "Start Orion UI";
			this.btnStartOrionUI.UseVisualStyleBackColor = true;
			this.btnStartOrionUI.Click += new System.EventHandler(this.btnStartOrionUI_Click);
			// 
			// btnStartOrionApi
			// 
			this.btnStartOrionApi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStartOrionApi.Location = new System.Drawing.Point(47, 45);
			this.btnStartOrionApi.Margin = new System.Windows.Forms.Padding(2);
			this.btnStartOrionApi.Name = "btnStartOrionApi";
			this.btnStartOrionApi.Size = new System.Drawing.Size(230, 73);
			this.btnStartOrionApi.TabIndex = 1;
			this.btnStartOrionApi.Text = "Start Orion API";
			this.btnStartOrionApi.UseVisualStyleBackColor = true;
			this.btnStartOrionApi.Click += new System.EventHandler(this.btnStartOrionApi_Click);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(717, 280);
			this.tabPage1.TabIndex = 3;
			this.tabPage1.Text = "DCMTK WorkList";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnWorklistSimulator);
			this.groupBox1.Controls.Add(this.button5);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(711, 274);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			// 
			// btnWorklistSimulator
			// 
			this.btnWorklistSimulator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnWorklistSimulator.Location = new System.Drawing.Point(376, 36);
			this.btnWorklistSimulator.Margin = new System.Windows.Forms.Padding(2);
			this.btnWorklistSimulator.Name = "btnWorklistSimulator";
			this.btnWorklistSimulator.Size = new System.Drawing.Size(294, 73);
			this.btnWorklistSimulator.TabIndex = 4;
			this.btnWorklistSimulator.Text = "Run Worklist Simulator";
			this.btnWorklistSimulator.UseVisualStyleBackColor = true;
			this.btnWorklistSimulator.Click += new System.EventHandler(this.btnWorklistSimulator_Click);
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(14, 36);
			this.button5.Margin = new System.Windows.Forms.Padding(2);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(294, 73);
			this.button5.TabIndex = 3;
			this.button5.Text = "Reset Worklist Data";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.btnOverlayResetWorklistData_Click);
			// 
			// execProgressbar
			// 
			this.execProgressbar.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.execProgressbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.execProgressbar.Location = new System.Drawing.Point(406, 97);
			this.execProgressbar.Name = "execProgressbar";
			this.execProgressbar.Size = new System.Drawing.Size(322, 15);
			this.execProgressbar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.execProgressbar.TabIndex = 10;
			this.execProgressbar.Visible = false;
			// 
			// tmrSwitcher
			// 
			this.tmrSwitcher.Tick += new System.EventHandler(this.tmrSwitcher_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(749, 411);
			this.Controls.Add(this.execProgressbar);
			this.Controls.Add(this.tabcontrolPOC);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.groupBoxMode);
			this.Controls.Add(this.btnOverlayStartHelp);
			this.Controls.Add(this.btnOverlayStartFullStack);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WFS-MR-FLEX-DevSetup";
			this.groupBoxMode.ResumeLayout(false);
			this.groupBoxMode.PerformLayout();
			this.tabcontrolPOC.ResumeLayout(false);
			this.tabPOC.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.tabOverlay.ResumeLayout(false);
			this.gbpOverlay.ResumeLayout(false);
			this.gbpOverlay.PerformLayout();
			this.tabOrion.ResumeLayout(false);
			this.gbpOrion.ResumeLayout(false);
			this.gbpOrion.PerformLayout();
			this.tabPage1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOverlayStartHelp;
        private System.Windows.Forms.Button btnOverlayStartFullStack;
		private System.Windows.Forms.GroupBox groupBoxMode;
		private System.Windows.Forms.Button btnSwitchMode;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label labelCurrentMode;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TabControl tabcontrolPOC;
		private System.Windows.Forms.TabPage tabPOC;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnOpenSimFolderInShell;
		private System.Windows.Forms.Button btnExportCertegraDatabase;
		private System.Windows.Forms.Button btnOpenSimulatorFolder;
		private System.Windows.Forms.Button btnCopyCertegraToSim;
		private System.Windows.Forms.Button btnStopSimulator;
		private System.Windows.Forms.Button btnStartSimulator;
		private System.Windows.Forms.Button btnBuildSimulatorDebug;
		private System.Windows.Forms.TabPage tabOverlay;
		private System.Windows.Forms.GroupBox gbpOverlay;
		private System.Windows.Forms.Button btnOverlayFolder;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtOverlayPortNumber;
		private System.Windows.Forms.Button btnStartOverlayOnly;
		private System.Windows.Forms.Button btnStopOverlay;
		private System.Windows.Forms.TabPage tabOrion;
		private System.Windows.Forms.GroupBox gbpOrion;
		private System.Windows.Forms.Button btnStopOrion;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPortNumber;
		private System.Windows.Forms.Button btnStartOrionUI;
		private System.Windows.Forms.Button btnStartOrionApi;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnOverlayShell;
		private System.Windows.Forms.Button btnOrionCmdShell;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnOrionExplorer;
		private System.Windows.Forms.Button btnWorklistSimulator;
		private System.Windows.Forms.ProgressBar execProgressbar;
		private System.Windows.Forms.Button btnElectronMode;
		private System.Windows.Forms.Timer tmrSwitcher;
	}
}

