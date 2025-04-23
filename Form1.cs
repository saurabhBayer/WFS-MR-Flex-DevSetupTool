using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace WfsMrFlexSetup
{
    public partial class Form1 : Form
    {
        private const string VERSION = "1.0";

        private string currentMode = null;

        private readonly string REGISTRY_PATH_CURRENTINJECTOR = ConfigurationManager.AppSettings["registryPathCurrentInjector"];
        private readonly string REGISTRY_KEY_CURRENTINJECTOR = ConfigurationManager.AppSettings["registryKeyCurrentInjector"];

        private readonly string INJECTOR_ADAPTER_APPCONFIG_PATH
            = Path.Combine(ConfigurationManager.AppSettings["certegraDirectory"],
                ConfigurationManager.AppSettings["certegraInjectorAdapterAppConfig"]);

        private readonly string CERTEGRA_DIRECTORY = ConfigurationManager.AppSettings["certegraDirectory"];
        private readonly string CERTEGRA_SYSTEMROOT_SERVICE = ConfigurationManager.AppSettings["certegraSystemRootServiceExe"];

        private readonly string CERTEGRA_DBSCHEMAEXPOTER = ConfigurationManager.AppSettings["certegraDbSchemaExporter"];

        private const string SWITCH_MODE_BTN_LABEL = "Switch mode to";

        private string MiscDirectory = string.Empty;
        private string BuildSimulatorDebug = string.Empty;
        private string SimulatorDirectory = ConfigurationManager.AppSettings["mrxpSimulatorDirectory"];
        private string StartSimDebug = ConfigurationManager.AppSettings["mrxpStartSimDebug"];
        private string StopSimDebug = String.Empty;

        private bool busy = false;


        public Form1()
        {
            InitializeComponent();
            this.gbpOrion.Enabled = Convert.ToBoolean(MiscDirectory = ConfigurationManager.AppSettings["orionServerFeature"]);
            this.Text = $"WFS-MR-FLEX-DevSetup (ver {VERSION})";
            RefreshCurrentMode();
        }

        private void RefreshCurrentMode()
        {
            currentMode = Utils.GetRegistryValue(REGISTRY_PATH_CURRENTINJECTOR, REGISTRY_KEY_CURRENTINJECTOR);

            RefreshValuesFromAppConfig();
        }

        /// <summary>
        /// Depending on value of this.currentMode, pull the appropriate values from app.config and update my class members
        /// </summary>
        private void RefreshValuesFromAppConfig()
        { 

                MiscDirectory = ConfigurationManager.AppSettings["mrxpMiscDirectory"];
                BuildSimulatorDebug = ConfigurationManager.AppSettings["mrxpBuildSimDebug"];
                SimulatorDirectory = ConfigurationManager.AppSettings["mrxpSimulatorDirectory"];
                StartSimDebug = ConfigurationManager.AppSettings["mrxpStartSimDebug"];
                StopSimDebug = ConfigurationManager.AppSettings["mrxpStopSimDebug"];
        }

        private bool UpdateInjectorAdapterAppConfig(string newMode)
        {
            /*
                <!-- MRXperion Configuration -->
                <!-- <add key="ImplementationAssembly" value="Certegra.MRXperionAdapter.Library.dll" />  -->
                <!-- <add key="ImplementationClass" value="MEDRAD.Certegra.MRXperionAdapter.Library.MRXperionAdapterImp"/>-->


                <!-- Stellant II Configuration -->
                <!--<add key="ImplementationAssembly" value="Certegra.Stellant2Adapter.Library.dll" />-->
                <!--<add key="ImplementationClass" value="MEDRAD.Certegra.Stellant2Adapter.Library.Stellant2AdapterImp"/>-->
            */

            const string commentStart = "<!--";
            const string commentEnd = "-->";

            if (!File.Exists(INJECTOR_ADAPTER_APPCONFIG_PATH))
            {
                MessageBox.Show($"file does not exist: {INJECTOR_ADAPTER_APPCONFIG_PATH}");
                return false;
            }

            var lines = File.ReadAllLines(INJECTOR_ADAPTER_APPCONFIG_PATH);
            for (int i = 0; i < lines.Length; i++)
            {
                bool disableThisLine = false;
                bool enableThisLine = false;

                bool lineIsDisabled = lines[i].TrimStart().StartsWith("<!--");

                // MRXP line
                if (lines[i].Contains("value=\"Certegra.MRXperionAdapter.Library.dll\"")
                    || lines[i].Contains("value=\"MEDRAD.Certegra.MRXperionAdapter.Library.MRXperionAdapterImp\""))
                {
                    enableThisLine = (true && lineIsDisabled);
                }

                if (disableThisLine)
                    lines[i] = $"{commentStart} {lines[i]} {commentEnd}";
                if (enableThisLine)
                    lines[i] = lines[i].Replace(commentStart, string.Empty).Replace(commentEnd, String.Empty);
            }

            File.WriteAllLines(INJECTOR_ADAPTER_APPCONFIG_PATH, lines);

            return true;
        }

        private void CopyCertegraToSimDirectory()
        {
            if (!String.IsNullOrEmpty(SimulatorDirectory))
                Utils.DirectoryCopy(CERTEGRA_DIRECTORY, SimulatorDirectory, true);
        }


        #region  button clicks


        private void btnBuildSimulatorDebug_Click(object sender, EventArgs e)
        {
            try
            {
                Utils.RunProcess(BuildSimulatorDebug, MiscDirectory);

                // check if certegra binaries are missing, if so then copy them
                if (!Utils.CheckForFile(SimulatorDirectory, CERTEGRA_SYSTEMROOT_SERVICE))
                {
                    CopyCertegraToSimDirectory();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnStartSimulator_Click(object sender, EventArgs e)
        {
            try
            {
                Utils.RunProcess(StartSimDebug, SimulatorDirectory);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnStopSimulator_Click(object sender, EventArgs e)
        {
            try
            {
                Utils.RunProcess(StopSimDebug, SimulatorDirectory);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnCopyCertegraToSim_Click(object sender, EventArgs e)
        {
            try
            {
                CopyCertegraToSimDirectory();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        #endregion

        private void btnOpenSimulatorFolder_Click(object sender, EventArgs e)
        {
			Utils.RunProcess(this.SimulatorDirectory, string.Empty, useShell:true, showCompletedPopup:false);
        }

        private void btnOpenSimFolderInShell_Click(object sender, EventArgs e)
        {
            Utils.RunProcess(
                "cmd.exe", 
                this.SimulatorDirectory,
                showCompletedPopup:false, 
                waitForExit:false, 
                combineWorkingDirectoryWithFilename:false);
        }


        private void btnExportCertegraDatabase_Click(object sender, EventArgs e)
        {
			Utils.RunProcess(this.CERTEGRA_DBSCHEMAEXPOTER, this.CERTEGRA_DIRECTORY);
        }

        private void btnOverlayStartFullStack_Click(object sender, EventArgs e)
        {
            try
            {
                // worklist simulator
                string risSimStart = ConfigurationManager.AppSettings["overlayRisSimulatorStart"];
                string risSimDirectory = ConfigurationManager.AppSettings["overlayRisSimulatorFolder"];
                Utils.RunProcess(risSimStart, risSimDirectory, false, false, false);

                // ui-manager (socket IO server)
                string uiMgrStart = ConfigurationManager.AppSettings["overlayUiManagerStart"];
                string overlaySourceDir = ConfigurationManager.AppSettings["overlaySourceDirectory"];
                Utils.RunProcess(uiMgrStart, overlaySourceDir, false, false, false);

                // Node.js shell and ng serve
                string startNodeJsAndNgServe = ConfigurationManager.AppSettings["overlayStartNodeJsAndNgServe"]
                    .Replace("_doubleampersand_", "&&").Replace("OVERLAY_PORT_VAL", Convert.ToString(txtOverlayPortNumber.Text));
                Utils.RunProcess(startNodeJsAndNgServe, string.Empty, false, false, false);

                // POC full stack
                Utils.RunProcess(StartSimDebug, SimulatorDirectory, false, false, true);
            }
            catch (Exception ex)
            {

            }
        }

        private void btnOverlayStartHelp_Click(object sender, EventArgs e)
        {
            var sb = new System.Text.StringBuilder();
            sb.AppendLine("'Overlay: Start full stack' will start the following:");
            sb.AppendLine("1. Worklist simulator");
            sb.AppendLine("2. ui-manager (socket IO server)");
            sb.AppendLine("3. POC full stack with SRU simulator");
            sb.AppendLine("4. node.js shell --> ng serve -o");
            string text = sb.ToString();
            MessageBox.Show(text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOverlayResetWorklistData_Click(object sender, EventArgs e)
        {
            try
            {
                string risSimDirectory = ConfigurationManager.AppSettings["overlayRisSimulatorFolder"];
                string risSimPurge = ConfigurationManager.AppSettings["overlayRisSimulatorPurge"];
                string risSimCreate = ConfigurationManager.AppSettings["overlayRisSimulatorCreate"];

                Utils.RunProcess(risSimPurge, risSimDirectory, false, false);
                Utils.RunProcess(risSimCreate, risSimDirectory, false, true);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void btnStartOrionApi_Click(object sender, EventArgs e)
        {
            string startNodeJsAndNpmStart = ConfigurationManager.AppSettings["orionApiStart"]
    .Replace("_doubleampersand_", "&&");
            Utils.RunProcess(startNodeJsAndNpmStart, string.Empty, false, false, false);
        }

        private void btnStartOrionUI_Click(object sender, EventArgs e)
        {
            string startNodeJsAndNgServe = ConfigurationManager.AppSettings["orionUiStart"]
    .Replace("_doubleampersand_", "&&").Replace("PORT_VAL", txtPortNumber.Text);
            Utils.RunProcess(startNodeJsAndNgServe, string.Empty, false, false, false);
        }

        private void btnStopOverlay_Click(object sender, EventArgs e)
        {
            Utils.KillByPort(Convert.ToInt32(txtOverlayPortNumber.Text));
            Utils.KillByPort(3005);
        }

        private void btnStopOrion_Click(object sender, EventArgs e)
        {
            Utils.KillByPort(3003);
            Utils.KillByPort(Convert.ToInt32(txtPortNumber.Text));
        }

        private void btnStartOverlayOnly_Click(object sender, EventArgs e)
        {
            // ui-manager (socket IO server)
            string uiMgrStart = ConfigurationManager.AppSettings["overlayUiManagerStart"];
            string overlaySourceDir = ConfigurationManager.AppSettings["overlaySourceDirectory"];
            Utils.RunProcess(uiMgrStart, overlaySourceDir, false, false, false);

            // Node.js shell and ng serve
            string startNodeJsAndNgServe = ConfigurationManager.AppSettings["overlayStartNodeJsAndNgServe"]
                .Replace("_doubleampersand_", "&&").Replace("OVERLAY_PORT_VAL", Convert.ToString(txtOverlayPortNumber.Text));
            Utils.RunProcess(startNodeJsAndNgServe, string.Empty, false, false, false);

        }

        private void txtOverlayPortNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
           e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPortNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
