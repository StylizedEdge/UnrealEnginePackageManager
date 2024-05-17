namespace UnrealEnginePackageManager
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using System.Management;

    public class Book_Unreal
    {
        public static string GetUnrealEngineProjectPath()
        {
            // Array of potential Unreal Engine process names
            string[] unrealProcessNames = { "UE4Editor", "UnrealEditor", "UE5Editor" }; // Add more names as needed

            Process unrealProcess = null;

            foreach (var processName in unrealProcessNames)
            {
                unrealProcess = Process.GetProcessesByName(processName).FirstOrDefault();
                if (unrealProcess != null)
                    break;
            }

            if (unrealProcess == null)
            {
                throw new Exception("Unreal Engine process not found.");
            }

            // Get command line arguments of the Unreal Engine process
            var commandLineArgs = GetCommandLineArgs(unrealProcess);

            // Find the .uproject file path in the command line arguments
            var projectPath = commandLineArgs.FirstOrDefault(arg => arg.EndsWith(".uproject", StringComparison.OrdinalIgnoreCase));

            if (projectPath == null)
            {
                throw new Exception("Project path not found in Unreal Engine process command line arguments.");
            }

            return projectPath;
        }

        private static string[] GetCommandLineArgs(Process process)
        {
            var commandLine = GetCommandLine(process);
            return commandLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }


        public static string GetCommandLine(Process process)
        {
            using (var searcher = new ManagementObjectSearcher($"SELECT CommandLine FROM Win32_Process WHERE ProcessId = {process.Id}"))
            {
                var results = searcher.Get().Cast<ManagementObject>().FirstOrDefault();
                return results?["CommandLine"]?.ToString() ?? string.Empty;
            }
        }

        public static string ExtractProjectPath(string commandLine)
        {
            var commandLineArgs = commandLine.Split(new[] { '"' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var arg in commandLineArgs)
            {
                if (arg.Trim().EndsWith(".uproject", StringComparison.OrdinalIgnoreCase))
                {
                    return arg.Trim();
                }
            }
            return string.Empty;
        }
    }
}