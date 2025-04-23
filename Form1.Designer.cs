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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnOpenSimFolderInShell = new System.Windows.Forms.Button();
			this.btnExportCertegraDatabase = new System.Windows.Forms.Button();
			this.btnOpenSimulatorFolder = new System.Windows.Forms.Button();
			this.btnCopyCertegraToSim = new System.Windows.Forms.Button();
			this.btnStopSimulator = new System.Windows.Forms.Button();
			this.btnStartSimulator = new System.Windows.Forms.Button();
			this.btnBuildSimulatorDebug = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtOverlayPortNumber = new System.Windows.Forms.TextBox();
			this.btnStartOverlayOnly = new System.Windows.Forms.Button();
			this.btnStopOverlay = new System.Windows.Forms.Button();
			this.btnOverlayResetWorklistData = new System.Windows.Forms.Button();
			this.btnOverlayStartHelp = new System.Windows.Forms.Button();
			this.btnOverlayStartFullStack = new System.Windows.Forms.Button();
			this.gbpOrion = new System.Windows.Forms.GroupBox();
			this.btnStopOrion = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPortNumber = new System.Windows.Forms.TextBox();
			this.btnStartOrionUI = new System.Windows.Forms.Button();
			this.btnStartOrionApi = new System.Windows.Forms.Button();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.gbpOrion.SuspendLayout();
			this.SuspendLayout();
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
			this.groupBox2.Location = new System.Drawing.Point(10, 102);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox2.Size = new System.Drawing.Size(354, 271);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = " MRXP dev setup";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(194, 106);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(148, 17);
			this.label3.TabIndex = 8;
			this.label3.Text = "Open simulator folder:";
			// 
			// btnOpenSimFolderInShell
			// 
			this.btnOpenSimFolderInShell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOpenSimFolderInShell.Location = new System.Drawing.Point(268, 124);
			this.btnOpenSimFolderInShell.Margin = new System.Windows.Forms.Padding(2);
			this.btnOpenSimFolderInShell.Name = "btnOpenSimFolderInShell";
			this.btnOpenSimFolderInShell.Size = new System.Drawing.Size(75, 54);
			this.btnOpenSimFolderInShell.TabIndex = 7;
			this.btnOpenSimFolderInShell.Text = "cmd shell";
			this.btnOpenSimFolderInShell.UseVisualStyleBackColor = true;
			this.btnOpenSimFolderInShell.Click += new System.EventHandler(this.btnOpenSimFolderInShell_Click);
			// 
			// btnExportCertegraDatabase
			// 
			this.btnExportCertegraDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExportCertegraDatabase.Location = new System.Drawing.Point(185, 193);
			this.btnExportCertegraDatabase.Margin = new System.Windows.Forms.Padding(2);
			this.btnExportCertegraDatabase.Name = "btnExportCertegraDatabase";
			this.btnExportCertegraDatabase.Size = new System.Drawing.Size(158, 73);
			this.btnExportCertegraDatabase.TabIndex = 6;
			this.btnExportCertegraDatabase.Text = "create new Certegra db";
			this.btnExportCertegraDatabase.UseVisualStyleBackColor = true;
			this.btnExportCertegraDatabase.Click += new System.EventHandler(this.btnExportCertegraDatabase_Click);
			// 
			// btnOpenSimulatorFolder
			// 
			this.btnOpenSimulatorFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOpenSimulatorFolder.Location = new System.Drawing.Point(185, 124);
			this.btnOpenSimulatorFolder.Margin = new System.Windows.Forms.Padding(2);
			this.btnOpenSimulatorFolder.Name = "btnOpenSimulatorFolder";
			this.btnOpenSimulatorFolder.Size = new System.Drawing.Size(75, 54);
			this.btnOpenSimulatorFolder.TabIndex = 5;
			this.btnOpenSimulatorFolder.Text = "Explorer";
			this.btnOpenSimulatorFolder.UseVisualStyleBackColor = true;
			this.btnOpenSimulatorFolder.Click += new System.EventHandler(this.btnOpenSimulatorFolder_Click);
			// 
			// btnCopyCertegraToSim
			// 
			this.btnCopyCertegraToSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCopyCertegraToSim.Location = new System.Drawing.Point(185, 18);
			this.btnCopyCertegraToSim.Margin = new System.Windows.Forms.Padding(2);
			this.btnCopyCertegraToSim.Name = "btnCopyCertegraToSim";
			this.btnCopyCertegraToSim.Size = new System.Drawing.Size(158, 73);
			this.btnCopyCertegraToSim.TabIndex = 3;
			this.btnCopyCertegraToSim.Text = "Copy Certegra binaries to simulator dir";
			this.btnCopyCertegraToSim.UseVisualStyleBackColor = true;
			this.btnCopyCertegraToSim.Click += new System.EventHandler(this.btnCopyCertegraToSim_Click);
			// 
			// btnStopSimulator
			// 
			this.btnStopSimulator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStopSimulator.Location = new System.Drawing.Point(7, 193);
			this.btnStopSimulator.Margin = new System.Windows.Forms.Padding(2);
			this.btnStopSimulator.Name = "btnStopSimulator";
			this.btnStopSimulator.Size = new System.Drawing.Size(158, 73);
			this.btnStopSimulator.TabIndex = 2;
			this.btnStopSimulator.Text = "Stop simulator (debug)";
			this.btnStopSimulator.UseVisualStyleBackColor = true;
			this.btnStopSimulator.Click += new System.EventHandler(this.btnStopSimulator_Click);
			// 
			// btnStartSimulator
			// 
			this.btnStartSimulator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStartSimulator.Location = new System.Drawing.Point(7, 106);
			this.btnStartSimulator.Margin = new System.Windows.Forms.Padding(2);
			this.btnStartSimulator.Name = "btnStartSimulator";
			this.btnStartSimulator.Size = new System.Drawing.Size(158, 73);
			this.btnStartSimulator.TabIndex = 1;
			this.btnStartSimulator.Text = "Start simulator (debug)";
			this.btnStartSimulator.UseVisualStyleBackColor = true;
			this.btnStartSimulator.Click += new System.EventHandler(this.btnStartSimulator_Click);
			// 
			// btnBuildSimulatorDebug
			// 
			this.btnBuildSimulatorDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuildSimulatorDebug.Location = new System.Drawing.Point(7, 18);
			this.btnBuildSimulatorDebug.Margin = new System.Windows.Forms.Padding(2);
			this.btnBuildSimulatorDebug.Name = "btnBuildSimulatorDebug";
			this.btnBuildSimulatorDebug.Size = new System.Drawing.Size(158, 73);
			this.btnBuildSimulatorDebug.TabIndex = 0;
			this.btnBuildSimulatorDebug.Text = "Buid simulator debug";
			this.btnBuildSimulatorDebug.UseVisualStyleBackColor = true;
			this.btnBuildSimulatorDebug.Click += new System.EventHandler(this.btnBuildSimulatorDebug_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(14, 34);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(468, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "FYI: File && registry paths / values can be modified in app.config";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtOverlayPortNumber);
			this.groupBox1.Controls.Add(this.btnStartOverlayOnly);
			this.groupBox1.Controls.Add(this.btnStopOverlay);
			this.groupBox1.Controls.Add(this.btnOverlayResetWorklistData);
			this.groupBox1.Location = new System.Drawing.Point(369, 102);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(176, 271);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Overlay Apps";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 196);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Enter Port #";
			// 
			// txtOverlayPortNumber
			// 
			this.txtOverlayPortNumber.Location = new System.Drawing.Point(8, 219);
			this.txtOverlayPortNumber.Name = "txtOverlayPortNumber";
			this.txtOverlayPortNumber.Size = new System.Drawing.Size(59, 20);
			this.txtOverlayPortNumber.TabIndex = 6;
			this.txtOverlayPortNumber.Text = "9200";
			this.txtOverlayPortNumber.UseWaitCursor = true;
			this.txtOverlayPortNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOverlayPortNumber_KeyPress);
			// 
			// btnStartOverlayOnly
			// 
			this.btnStartOverlayOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStartOverlayOnly.Location = new System.Drawing.Point(7, 18);
			this.btnStartOverlayOnly.Margin = new System.Windows.Forms.Padding(2);
			this.btnStartOverlayOnly.Name = "btnStartOverlayOnly";
			this.btnStartOverlayOnly.Size = new System.Drawing.Size(158, 73);
			this.btnStartOverlayOnly.TabIndex = 6;
			this.btnStartOverlayOnly.Text = "Start Overlay Only";
			this.btnStartOverlayOnly.UseVisualStyleBackColor = true;
			this.btnStartOverlayOnly.Click += new System.EventHandler(this.btnStartOverlayOnly_Click);
			// 
			// btnStopOverlay
			// 
			this.btnStopOverlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
			this.btnStopOverlay.Location = new System.Drawing.Point(91, 193);
			this.btnStopOverlay.Margin = new System.Windows.Forms.Padding(2);
			this.btnStopOverlay.Name = "btnStopOverlay";
			this.btnStopOverlay.Size = new System.Drawing.Size(74, 73);
			this.btnStopOverlay.TabIndex = 5;
			this.btnStopOverlay.Text = "Stop Overlay Only";
			this.btnStopOverlay.UseVisualStyleBackColor = true;
			this.btnStopOverlay.Click += new System.EventHandler(this.btnStopOverlay_Click);
			// 
			// btnOverlayResetWorklistData
			// 
			this.btnOverlayResetWorklistData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOverlayResetWorklistData.Location = new System.Drawing.Point(7, 106);
			this.btnOverlayResetWorklistData.Margin = new System.Windows.Forms.Padding(2);
			this.btnOverlayResetWorklistData.Name = "btnOverlayResetWorklistData";
			this.btnOverlayResetWorklistData.Size = new System.Drawing.Size(158, 73);
			this.btnOverlayResetWorklistData.TabIndex = 3;
			this.btnOverlayResetWorklistData.Text = "Reset Worklist Data";
			this.btnOverlayResetWorklistData.UseVisualStyleBackColor = true;
			this.btnOverlayResetWorklistData.Click += new System.EventHandler(this.btnOverlayResetWorklistData_Click);
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
			this.btnOverlayStartFullStack.Location = new System.Drawing.Point(499, 11);
			this.btnOverlayStartFullStack.Margin = new System.Windows.Forms.Padding(2);
			this.btnOverlayStartFullStack.Name = "btnOverlayStartFullStack";
			this.btnOverlayStartFullStack.Size = new System.Drawing.Size(197, 73);
			this.btnOverlayStartFullStack.TabIndex = 1;
			this.btnOverlayStartFullStack.Text = "Start full stack";
			this.btnOverlayStartFullStack.UseVisualStyleBackColor = true;
			this.btnOverlayStartFullStack.Click += new System.EventHandler(this.btnOverlayStartFullStack_Click);
			// 
			// gbpOrion
			// 
			this.gbpOrion.Controls.Add(this.btnStopOrion);
			this.gbpOrion.Controls.Add(this.label4);
			this.gbpOrion.Controls.Add(this.txtPortNumber);
			this.gbpOrion.Controls.Add(this.btnStartOrionUI);
			this.gbpOrion.Controls.Add(this.btnStartOrionApi);
			this.gbpOrion.Location = new System.Drawing.Point(549, 102);
			this.gbpOrion.Margin = new System.Windows.Forms.Padding(2);
			this.gbpOrion.Name = "gbpOrion";
			this.gbpOrion.Padding = new System.Windows.Forms.Padding(2);
			this.gbpOrion.Size = new System.Drawing.Size(176, 271);
			this.gbpOrion.TabIndex = 6;
			this.gbpOrion.TabStop = false;
			this.gbpOrion.Text = "IM Apps";
			// 
			// btnStopOrion
			// 
			this.btnStopOrion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
			this.btnStopOrion.Location = new System.Drawing.Point(91, 193);
			this.btnStopOrion.Margin = new System.Windows.Forms.Padding(2);
			this.btnStopOrion.Name = "btnStopOrion";
			this.btnStopOrion.Size = new System.Drawing.Size(74, 73);
			this.btnStopOrion.TabIndex = 4;
			this.btnStopOrion.Text = "Stop Orion";
			this.btnStopOrion.UseVisualStyleBackColor = true;
			this.btnStopOrion.Click += new System.EventHandler(this.btnStopOrion_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(5, 196);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Enter Port #";
			// 
			// txtPortNumber
			// 
			this.txtPortNumber.Location = new System.Drawing.Point(8, 219);
			this.txtPortNumber.Name = "txtPortNumber";
			this.txtPortNumber.Size = new System.Drawing.Size(59, 20);
			this.txtPortNumber.TabIndex = 4;
			this.txtPortNumber.Text = "4200";
			this.txtPortNumber.UseWaitCursor = true;
			this.txtPortNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPortNumber_KeyPress);
			// 
			// btnStartOrionUI
			// 
			this.btnStartOrionUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStartOrionUI.Location = new System.Drawing.Point(7, 106);
			this.btnStartOrionUI.Margin = new System.Windows.Forms.Padding(2);
			this.btnStartOrionUI.Name = "btnStartOrionUI";
			this.btnStartOrionUI.Size = new System.Drawing.Size(158, 73);
			this.btnStartOrionUI.TabIndex = 3;
			this.btnStartOrionUI.Text = "Start Orion UI";
			this.btnStartOrionUI.UseVisualStyleBackColor = true;
			this.btnStartOrionUI.Click += new System.EventHandler(this.btnStartOrionUI_Click);
			// 
			// btnStartOrionApi
			// 
			this.btnStartOrionApi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStartOrionApi.Location = new System.Drawing.Point(7, 18);
			this.btnStartOrionApi.Margin = new System.Windows.Forms.Padding(2);
			this.btnStartOrionApi.Name = "btnStartOrionApi";
			this.btnStartOrionApi.Size = new System.Drawing.Size(158, 73);
			this.btnStartOrionApi.TabIndex = 1;
			this.btnStartOrionApi.Text = "Start Orion API";
			this.btnStartOrionApi.UseVisualStyleBackColor = true;
			this.btnStartOrionApi.Click += new System.EventHandler(this.btnStartOrionApi_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(746, 388);
			this.Controls.Add(this.gbpOrion);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnOverlayStartHelp);
			this.Controls.Add(this.btnOverlayStartFullStack);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WFS-MR-FLEX-DevSetup";
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.gbpOrion.ResumeLayout(false);
			this.gbpOrion.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStopSimulator;
        private System.Windows.Forms.Button btnStartSimulator;
        private System.Windows.Forms.Button btnBuildSimulatorDebug;
        private System.Windows.Forms.Button btnCopyCertegraToSim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExportCertegraDatabase;
        private System.Windows.Forms.Button btnOpenSimulatorFolder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOverlayStartHelp;
        private System.Windows.Forms.Button btnOverlayStartFullStack;
        private System.Windows.Forms.Button btnOverlayResetWorklistData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpenSimFolderInShell;
        private System.Windows.Forms.GroupBox gbpOrion;
        private System.Windows.Forms.Button btnStartOrionUI;
        private System.Windows.Forms.Button btnStartOrionApi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPortNumber;
        private System.Windows.Forms.Button btnStopOrion;
		private System.Windows.Forms.Button btnStopOverlay;
		private System.Windows.Forms.Button btnStartOverlayOnly;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtOverlayPortNumber;
	}
}

