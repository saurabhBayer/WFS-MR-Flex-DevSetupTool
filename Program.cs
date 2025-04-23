using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfsMrFlexSetup
{
    // version history
    // 1.0  late 2020   first working version, can switch between MR/CT, stop/start simulator
    // 1.1  early 2021  added "Create new Certegra db" and "Open simulator folder"
    // 1.2  july 2021   rebuilt from decompiled source (I lost the original, argh)
    //                  added "Start Full Stack" and "Reset Worklist Data"
    // 1.3  aug 2021    added button "open sim folder in shell"

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
