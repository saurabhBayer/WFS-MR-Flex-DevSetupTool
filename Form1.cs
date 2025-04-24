using System;
using System.Configuration;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace WfsMrFlexSetup
{
    public partial class Form1 : Form
    {
        private const string VERSION = "2.1";

        private string currentMode = null;

        private readonly string REGISTRY_PATH_CURRENTINJECTOR = ConfigurationManager.AppSettings["registryPathCurrentInjector"];
        private readonly string REGISTRY_KEY_CURRENTINJECTOR = ConfigurationManager.AppSettings["registryKeyCurrentInjector"];

        private readonly string REGISTRY_PATH_DISTROS = ConfigurationManager.AppSettings["registryPathDistros"];
        private readonly string REGISTRY_DISTRO_KEY_SII = ConfigurationManager.AppSettings["registryKeyDistrosSII"];
        private readonly string REGISTRY_DISTRO_VALUE_SII = ConfigurationManager.AppSettings["registryKeyDistrosSIIValue"];
        private readonly string REGISTRY_DISTRO_KEY_MRXP = ConfigurationManager.AppSettings["registryKeyDistrosMrxp"];
        private readonly string REGISTRY_DISTRO_VALUE_MRXP = ConfigurationManager.AppSettings["registryKeyDistrosMrxpValue"];

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
            execProgressbar.Visible = false;
            this.btnSwitchMode.Enabled = Convert.ToBoolean(MiscDirectory = ConfigurationManager.AppSettings["modeSwitchFeature"]);
            this.gbpOrion.Enabled = Convert.ToBoolean(MiscDirectory = ConfigurationManager.AppSettings["orionServerFeature"]);
            this.gbpOverlay.Enabled = Convert.ToBoolean(MiscDirectory = ConfigurationManager.AppSettings["overlayFeature"]);
            this.Text = $"WFS-MR-FLEX-DevSetup (ver {VERSION})";
            RefreshCurrentMode();
        }

        private void RefreshCurrentMode()
        {
            currentMode = Utils.GetRegistryValue(REGISTRY_PATH_CURRENTINJECTOR, REGISTRY_KEY_CURRENTINJECTOR);

            labelCurrentMode.Text = currentMode;
            btnSwitchMode.Text = $"{SWITCH_MODE_BTN_LABEL} {GetOppositeMode()}";

            RefreshValuesFromAppConfig();
        }

        private string GetOppositeMode()
        {
            if (currentMode == Modes.MODE_SR)
                return Modes.MODE_MRXP;
            else if (currentMode == Modes.MODE_MRXP)
                return Modes.MODE_SR;
            else
                return Modes.MODE_SR;
        }

        /// <summary>
        /// Depending on value of this.currentMode, pull the appropriate values from app.config and update my class members
        /// </summary>
        private void RefreshValuesFromAppConfig()
        {
            if (currentMode == Modes.MODE_SR)
            {
                MiscDirectory = ConfigurationManager.AppSettings["s2MiscDirectory"];
                BuildSimulatorDebug = ConfigurationManager.AppSettings["s2BuildSimDebug"];
                SimulatorDirectory = ConfigurationManager.AppSettings["s2SimulatorDirectory"];
                StartSimDebug = ConfigurationManager.AppSettings["s2StartSimDebug"];
                StopSimDebug = ConfigurationManager.AppSettings["s2StopSimDebug"];
            }
            else if (currentMode == Modes.MODE_MRXP)
            {
                MiscDirectory = ConfigurationManager.AppSettings["mrxpMiscDirectory"];
                BuildSimulatorDebug = ConfigurationManager.AppSettings["mrxpBuildSimDebug"];
                SimulatorDirectory = ConfigurationManager.AppSettings["mrxpSimulatorDirectory"];
                StartSimDebug = ConfigurationManager.AppSettings["mrxpStartSimDebug"];
                StopSimDebug = ConfigurationManager.AppSettings["mrxpStopSimDebug"];
            }
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
                MessageBox.Show($"file does not exist: {INJECTOR_ADAPTER_APPCONFIG_PATH}", "WARN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void UpdateProgress(int percent)
        {
            RunOnUiThread(() => execProgressbar.Value = percent);
        }

        private void RunOnUiThread(Action action)
        {
            if (InvokeRequired)
            {
                Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void FullStackProgramsInit()
        {

            UpdateProgress(0);
            // worklist simulator
            string risSimStart = ConfigurationManager.AppSettings["overlayRisSimulatorStart"];
            string risSimDirectory = ConfigurationManager.AppSettings["overlayRisSimulatorFolder"];
            Utils.RunProcess(risSimStart, risSimDirectory, false, false, false);
            UpdateProgress(25);
            // ui-manager (socket IO server)
            string uiMgrStart = ConfigurationManager.AppSettings["overlayUiManagerStart"];
            string overlaySourceDir = ConfigurationManager.AppSettings["overlaySourceDirectory"];
            Utils.RunProcess(uiMgrStart, overlaySourceDir, false, false, false);
            UpdateProgress(50);
            // Node.js shell and ng serve
            string startNodeJsAndNgServe = ConfigurationManager.AppSettings["overlayStartNodeJsAndNgServe"]
                .Replace("_doubleampersand_", "&&").Replace("OVERLAY_PORT_VAL", Convert.ToString(txtOverlayPortNumber.Text));
            Utils.RunProcess(startNodeJsAndNgServe, string.Empty, false, false, false);
            UpdateProgress(75);
            // POC full stack
            Utils.RunProcess(StartSimDebug, SimulatorDirectory, false, false, true);
            UpdateProgress(100);
        }

        private void InvokeExecOnThread(Thread _thread)
        {
            try
            {
                execProgressbar.Visible = true;

                _thread.IsBackground = true;
                _thread.Start();
                while (_thread.IsAlive)
                    Application.DoEvents();
            }
            catch (ThreadAbortException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                execProgressbar.Visible = false;
                while (_thread.IsAlive)
                    _thread.Abort();
                _thread = null;
            }
        }

        private void BuildPOCSimulatorDebug()
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
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartPOCSimulator()
        {
            try
            {
                Utils.RunProcess(StartSimDebug, SimulatorDirectory);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StopPOCSimulator()
        {
            try
            {
                Utils.RunProcess(StopSimDebug, SimulatorDirectory);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitNewCertegraDatabase()
        {
            Utils.RunProcess(this.CERTEGRA_DBSCHEMAEXPOTER, this.CERTEGRA_DIRECTORY);
        }

        private void ResetWorklistData()
        {
            try
            {
                string risSimDirectory = ConfigurationManager.AppSettings["overlayRisSimulatorFolder"];
                string risSimPurge = ConfigurationManager.AppSettings["overlayRisSimulatorPurge"];
                string risSimCreate = ConfigurationManager.AppSettings["overlayRisSimulatorCreate"];
                UpdateProgress(25);
                Utils.RunProcess(risSimPurge, risSimDirectory, false, false);
                UpdateProgress(60);
                Utils.RunProcess(risSimCreate, risSimDirectory, false, true);
                UpdateProgress(100);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SwitchPOCMode()
        {
            try
            {
                string newMode = GetOppositeMode();

                // 1. update file: Certegra.InjectorAdapter.Service.exe.config
                if (UpdateInjectorAdapterAppConfig(newMode))
                {
                    // 2. update registry keys
                    string deleteDistroKey = null, createDistroKey = null, distroValue = null;
                    if (newMode == Modes.MODE_SR)
                    {
                        deleteDistroKey = REGISTRY_DISTRO_KEY_MRXP;
                        createDistroKey = REGISTRY_DISTRO_KEY_SII;
                        distroValue = REGISTRY_DISTRO_VALUE_SII;
                    }
                    else
                    {
                        deleteDistroKey = REGISTRY_DISTRO_KEY_SII;
                        createDistroKey = REGISTRY_DISTRO_KEY_MRXP;
                        distroValue = REGISTRY_DISTRO_VALUE_MRXP;
                    }

                    UpdateProgress(25);
                    Utils.DeleteRegistryKey(REGISTRY_PATH_DISTROS, deleteDistroKey);
                    Utils.CreateRegistryKey(REGISTRY_PATH_DISTROS, createDistroKey);
                    Utils.SetRegistryValue($"{REGISTRY_PATH_DISTROS}\\{createDistroKey}", "Description", distroValue);
                    Utils.SetRegistryValue(REGISTRY_PATH_CURRENTINJECTOR, REGISTRY_KEY_CURRENTINJECTOR, newMode);
                    UpdateProgress(60);
                    // 3. export new certegra database
                    Utils.RunProcess(CERTEGRA_DBSCHEMAEXPOTER, CERTEGRA_DIRECTORY);
                    UpdateProgress(100);
                }


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region  button clicks

        private void btnBuildSimulatorDebug_Click(object sender, EventArgs e)
        {
            var _thread = new Thread(new ThreadStart(BuildPOCSimulatorDebug));
            InvokeExecOnThread(_thread);
        }

        private void btnStartSimulator_Click(object sender, EventArgs e)
        {
            var _thread = new Thread(new ThreadStart(StartPOCSimulator));
            InvokeExecOnThread(_thread);
        }

        private void btnStopSimulator_Click(object sender, EventArgs e)
        {
            var _thread = new Thread(new ThreadStart(StopPOCSimulator));
            InvokeExecOnThread(_thread);
        }

        private void btnCopyCertegraToSim_Click(object sender, EventArgs e)
        {
            try
            {
                CopyCertegraToSimDirectory();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
            var _thread = new Thread(new ThreadStart(InitNewCertegraDatabase));
            InvokeExecOnThread(_thread);
        }

        private void btnOverlayStartFullStack_Click(object sender, EventArgs e)
        {
            var _thread = new Thread(new ThreadStart(FullStackProgramsInit));
            InvokeExecOnThread(_thread);
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
            var _thread = new Thread(new ThreadStart(ResetWorklistData));
            InvokeExecOnThread(_thread);
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

        private void btnSwitchMode_Click(object sender, EventArgs e)
        {
            //var _thread = new Thread(new ThreadStart(SwitchPOCMode));
            //InvokeExecOnThread(_thread);

            //// update labels
            //RefreshCurrentMode();

            // Initialize Timer
            tmrSwitcher = new System.Windows.Forms.Timer
            {
                Interval = counter
            };

            tmrSwitcher.Tick -= tmrSwitcher_Tick;
            tmrSwitcher.Tick += tmrSwitcher_Tick; 
            tmrSwitcher.Start();
            Application.DoEvents();
            btnSwitchMode.Enabled = false;
            Application.DoEvents();
        }

        private void btnOverlayFolder_Click(object sender, EventArgs e)
        {
            string overlayDirectory = ConfigurationManager.AppSettings["overlaySourceDirectory"];
            Utils.RunProcess(overlayDirectory, string.Empty, useShell: true, showCompletedPopup: false);
        }

        private void btnOverlayShell_Click(object sender, EventArgs e)
        {
            string overlayDirectory = ConfigurationManager.AppSettings["overlaySourceDirectory"];
            Utils.RunProcess(
               "cmd.exe",
               overlayDirectory,
               showCompletedPopup: false,
               waitForExit: false,
               combineWorkingDirectoryWithFilename: false);
        }

        private void btnOrionExplorer_Click(object sender, EventArgs e)
        {
            string orionDirectory = ConfigurationManager.AppSettings["orionSourceDirectory"];
            Utils.RunProcess(orionDirectory, string.Empty, useShell: true, showCompletedPopup: false);
        }

        private void btnOrionCmdShell_Click(object sender, EventArgs e)
        {
            string orionDirectory = ConfigurationManager.AppSettings["orionSourceDirectory"];
            Utils.RunProcess(
               "cmd.exe",
               orionDirectory,
               showCompletedPopup: false,
               waitForExit: false,
               combineWorkingDirectoryWithFilename: false);
        }

        private void btnWorklistSimulator_Click(object sender, EventArgs e)
        {
            // worklist simulator
            string risSimStart = ConfigurationManager.AppSettings["overlayRisSimulatorStart"];
            string risSimDirectory = ConfigurationManager.AppSettings["overlayRisSimulatorFolder"];
            Utils.RunProcess(risSimStart, risSimDirectory, false, false, false);
        }

        private void btnElectronMode_Click(object sender, EventArgs e)
        {
            Utils.KillByPort(Convert.ToInt32(txtOverlayPortNumber.Text), true);
            Utils.KillByPort(3005, true);

            Utils.KillByPort(3003, true);
            Utils.KillByPort(Convert.ToInt32(txtPortNumber.Text), true);

            // ui-manager (socket IO server)
            string uiMgrStart = ConfigurationManager.AppSettings["overlayUiManagerStart"];
            string overlaySourceDir = ConfigurationManager.AppSettings["overlaySourceDirectory"];
            Utils.RunProcess(uiMgrStart, overlaySourceDir, false, false, false);

            // Node.js shell and ng serve
            string startNodeJsAndNgServe = ConfigurationManager.AppSettings["overlayStartElectron"]
                .Replace("_doubleampersand_", "&&");
            Utils.RunProcess(startNodeJsAndNgServe, string.Empty, false, false, false);
        }

        #endregion
        private int counter = 240;
        private int intervalTime = 0;
        private void tmrSwitcher_Tick(object sender, EventArgs e)
        {
            counter--;
            Application.DoEvents();
            btnSwitchMode.Text = $"{SWITCH_MODE_BTN_LABEL} {GetOppositeMode()}" + " (" + counter + ")";
            if (counter == intervalTime)
            {
                Application.DoEvents();
                btnSwitchMode.Enabled = true;
                btnSwitchMode.Text = $"{SWITCH_MODE_BTN_LABEL} {GetOppositeMode()}";
                tmrSwitcher.Stop();
            }
            
        }
    }
}
