using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WfsMrFlexSetup
{
    public static class Utils
    {

        /// <summary>
        /// Recursively copy a directory
        /// </summary>
        /// <remarks>
        /// https://docs.microsoft.com/en-us/dotnet/standard/io/how-to-copy-directories
        /// </remarks>
        /// <param name="sourceDirName"></param>
        /// <param name="destDirName"></param>
        /// <param name="copySubDirs"></param>
        public static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();

            // If the destination directory doesn't exist, create it.       
            Directory.CreateDirectory(destDirName);

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tempPath = Path.Combine(destDirName, file.Name);
                file.CopyTo(tempPath, true);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string tempPath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, tempPath, copySubDirs);
                }
            }
        }

        public static string GetRegistryValue(string path, string key)
        {
            string value = null;
            var localKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32);

            var openSubKey = localKey.OpenSubKey(path);
            if (openSubKey?.GetValue(key) != null)
                value = openSubKey.GetValue(key).ToString();

            return value;
        }

        public static void SetRegistryValue(string path, string key, string value)
        {
            RegistryView[] modes = new[] { RegistryView.Registry32, RegistryView.Registry64 };
            foreach (RegistryView view in modes)
            {
                var localKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, view);

                var openSubKey = localKey.OpenSubKey(path, RegistryKeyPermissionCheck.ReadWriteSubTree) ??
                                 localKey.CreateSubKey(path, RegistryKeyPermissionCheck.ReadWriteSubTree);

                openSubKey?.SetValue(key, value);
            }
        }

        public static void CreateRegistryKey(string path, string key)
        {
            RegistryView[] modes = new[] {RegistryView.Registry32, RegistryView.Registry64};
            foreach (RegistryView view in modes)
            {
                var localKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, view);

                var openSubKey = localKey.OpenSubKey(path, RegistryKeyPermissionCheck.ReadWriteSubTree) ??
                                 localKey.CreateSubKey(path, RegistryKeyPermissionCheck.ReadWriteSubTree);

                openSubKey.CreateSubKey(key);
            }
        }

        public static void DeleteRegistryKey(string path, string key)
        {
            try
            {
                RegistryView[] modes = new[] { RegistryView.Registry32, RegistryView.Registry64 };
                foreach (RegistryView view in modes)
                {
                    var localKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, view);

                    var openSubKey = localKey.OpenSubKey(path, RegistryKeyPermissionCheck.ReadWriteSubTree) ??
                                     localKey.CreateSubKey(path, RegistryKeyPermissionCheck.ReadWriteSubTree);

                    openSubKey?.DeleteSubKey(key);
                }
            }
            catch (System.ArgumentException)
            {
                // key does not exist, that's okay
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void RunProcess(string fileOrCommand, string workingDirectory, bool useShell = false, bool showCompletedPopup = true, bool waitForExit = true, bool combineWorkingDirectoryWithFilename = true)
        {
            try
            {
                // if spaces are present, everything after the first space is considered "arguments"
                string file = fileOrCommand;
                string args = string.Empty;
                int x = fileOrCommand.IndexOf(" ");
                if (x > -1)
                {
                    file = fileOrCommand.Substring(0, x);
                    args = fileOrCommand.Substring(x + 1);
                }
                
                var info = new ProcessStartInfo();
                info.FileName = combineWorkingDirectoryWithFilename ? Path.Combine(workingDirectory, file) : file;
                if (!string.IsNullOrEmpty(workingDirectory))
                    info.WorkingDirectory = workingDirectory;
                if (!string.IsNullOrEmpty(args))
                    info.Arguments = args;
                info.UseShellExecute = useShell;
                info.WindowStyle = ProcessWindowStyle.Normal;

                var process = Process.Start(info);
                if (waitForExit && process != null)
                {
                    process?.WaitForExit(Timeout.Infinite);
                    process?.WaitForExit(); // correctly waits for redirected I/O to finish

                    if (showCompletedPopup)
                        MessageBox.Show("Completed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool CheckForFile(string directory, string filename)
        {
            string fullpath = Path.Combine(directory, filename);

            return Directory.Exists(directory)
                   && File.Exists(fullpath);
        }
        public class PRC
        {
            public int PID { get; set; }
            public int Port { get; set; }
            public string Protocol { get; set; }
        }

        public static void KillByPort(int port, bool isSilent = false)
        {
            var processes = GetAllProcesses();
            if (processes.Any(p => p.Port == port))
                try
                {
                    Process.GetProcessById(processes.First(p => p.Port == port).PID).Kill();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            else
            {
                if(!isSilent)
                MessageBox.Show("No process to kill on this port!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static List<PRC> GetAllProcesses()
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = "netstat.exe",
                Arguments = "-a -n -o",
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            var result = new List<PRC>();

            try
            {
                using (var process = new Process { StartInfo = startInfo })
                {
                    process.Start();

                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();
                    process.WaitForExit();

                    if (process.ExitCode != 0)
                        throw new Exception($"netstat failed: {error}");

                    var lines = Regex.Split(output, "\r\n");

                    foreach (var line in lines)
                    {
                        if (string.IsNullOrWhiteSpace(line) || line.Trim().StartsWith("Proto"))
                            continue;

                        var parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        if (parts.Length < 5) continue;

                        string protocol = parts[0];
                        string localAddress = parts[1];
                        string pidStr = parts.Last();

                        // Handle IPv4 and IPv6 formats
                        string portStr = localAddress.Contains("]:")
                            ? localAddress.Split(new[] { "]:", "[" }, StringSplitOptions.RemoveEmptyEntries).Last()
                            : localAddress.Split(':').Last();

                        if (int.TryParse(portStr, out int port) && int.TryParse(pidStr, out int pid))
                        {
                            result.Add(new PRC
                            {
                                Protocol = protocol,
                                Port = port,
                                PID = pid
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while running netstat: {ex.Message}");
            }

            return result;
        }
    }
}
