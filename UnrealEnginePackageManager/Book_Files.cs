// Ignore Spelling: Rar Json

namespace UnrealEnginePackageManager
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;

    public class Book_Files
    {
        public enum ImportantFolders
        {
            Resources,
            Packages
        }

        public static string GetFileInFolder(string SelectedFile, ImportantFolders Folders)
        {
            // Get the current working directory (usually the bin/Debug/ folder)
            string currentDirectory = Environment.CurrentDirectory;
            string resourcesFolderPath = "";
            switch (Folders)
            {
                case ImportantFolders.Resources:
                    // Construct the path to the resources folder
                    resourcesFolderPath = Path.Combine(currentDirectory, "Resources");
                    break;
                case ImportantFolders.Packages:
                    // Construct the path to the resources folder
                    resourcesFolderPath = Path.Combine(currentDirectory, "Packages");
                    break;
                default:
                    break;
            }

            // Ensure the resources folder exists
            if (!Directory.Exists(resourcesFolderPath))
            {
                throw new DirectoryNotFoundException("Resources folder not found.");
            }

            // Construct the path to the ContentPack.rar file
            string contentPackPath = Path.Combine(resourcesFolderPath, SelectedFile);

            if (!File.Exists(contentPackPath))
            {
                throw new FileNotFoundException($"{SelectedFile} not found in Resources folder.");
            }

            return contentPackPath;
        }

        public static string GetFolderInFolder(string folderName, ImportantFolders parentFolder)
        {
            // Get the current working directory (usually the bin/Debug/ folder)
            string currentDirectory = Environment.CurrentDirectory;
            string parentFolderPath = "";
            switch (parentFolder)
            {
                case ImportantFolders.Resources:
                    // Construct the path to the parent resources folder
                    parentFolderPath = Path.Combine(currentDirectory, "Resources");
                    break;
                case ImportantFolders.Packages:
                    // Construct the path to the parent packages folder
                    parentFolderPath = Path.Combine(currentDirectory, "Packages");
                    break;
                default:
                    break;
            }

            // Ensure the parent folder exists
            if (!Directory.Exists(parentFolderPath))
            {
                throw new DirectoryNotFoundException($"{parentFolder} folder not found.");
            }

            // Construct the path to the specified folder within the parent folder
            string folderPath = Path.Combine(parentFolderPath, folderName);

            // Ensure the specified folder exists
            if (!Directory.Exists(folderPath))
            {
                throw new DirectoryNotFoundException($"{folderName} folder not found in {parentFolder} folder.");
            }

            return folderPath;
        }

        public static bool IsFolderEmpty(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                throw new DirectoryNotFoundException($"The folder '{folderPath}' does not exist.");
            }

            var files = Directory.GetFiles(folderPath);
            var directories = Directory.GetDirectories(folderPath);

            return files.Length == 0 && directories.Length == 0;
        }

        public static void RenameFolder(string oldFolderPath, string newFolderPath)
        {
            if (!Directory.Exists(oldFolderPath))
            {
                throw new DirectoryNotFoundException($"Folder '{oldFolderPath}' does not exist.");
            }

            if (Directory.Exists(newFolderPath))
            {
                throw new IOException($"A folder already exists at '{newFolderPath}'.");
            }

            // Get the parent directory of the old folder
            string parentDirectory = Directory.GetParent(oldFolderPath).FullName;

            // Construct the new folder path with the desired name
            string newFolderFullPath = Path.Combine(parentDirectory, newFolderPath);

            // Rename the old folder to the new folder path
            Directory.Move(oldFolderPath, newFolderFullPath);
        }

        public static void CopyFolder(string sourceFolderPath, string destinationFolderPath)
        {
            if (!Directory.Exists(sourceFolderPath))
            {
                throw new DirectoryNotFoundException($"Source folder '{sourceFolderPath}' does not exist.");
            }

            // Ensure the destination folder exists
            if (!Directory.Exists(destinationFolderPath))
            {
                Directory.CreateDirectory(destinationFolderPath);
            }

            // Copy all files from the source to the destination
            foreach (var file in Directory.GetFiles(sourceFolderPath, "*", SearchOption.AllDirectories))
            {
                string relativePath = GetRelativePath(sourceFolderPath, file);
                string destinationFilePath = Path.Combine(destinationFolderPath, relativePath);

                // Ensure parent directories exist
                Directory.CreateDirectory(Path.GetDirectoryName(destinationFilePath));

                File.Copy(file, destinationFilePath, overwrite: true);
            }
        }

        public static string GetRelativePath(string fromPath, string toPath)
        {
            // Ensure both paths are absolute
            if (!Path.IsPathRooted(fromPath) || !Path.IsPathRooted(toPath))
            {
                throw new ArgumentException("Both paths must be absolute.");
            }

            // Normalize the paths to remove any trailing slashes or redundant components
            fromPath = Path.GetFullPath(fromPath);
            toPath = Path.GetFullPath(toPath);

            // Split the paths into segments
            string[] fromSegments = fromPath.Split(Path.DirectorySeparatorChar);
            string[] toSegments = toPath.Split(Path.DirectorySeparatorChar);

            // Find the common root
            int commonRootIndex = 0;
            while (commonRootIndex < fromSegments.Length && commonRootIndex < toSegments.Length &&
                   fromSegments[commonRootIndex].Equals(toSegments[commonRootIndex], StringComparison.OrdinalIgnoreCase))
            {
                commonRootIndex++;
            }

            // Build the relative path
            string relativePath = string.Empty;

            // Add ".." for each additional segment in the 'from' path
            for (int i = commonRootIndex; i < fromSegments.Length; i++)
            {
                relativePath = Path.Combine(relativePath, "..");
            }

            // Add the remaining segments from the 'to' path
            for (int i = commonRootIndex; i < toSegments.Length; i++)
            {
                relativePath = Path.Combine(relativePath, toSegments[i]);
            }

            return relativePath;
        }

        public static void WriteText(string filePath, string text)
        {
            try
            {
                // Writes the specified content to the file
                File.WriteAllText(filePath, text);
                System.Console.WriteLine($"Content written to {filePath}");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public static void RenameFile(string oldFilePath, string newFilePath)
        {
            if (!File.Exists(oldFilePath))
            {
                throw new FileNotFoundException($"File '{oldFilePath}' does not exist.");
            }

            if (File.Exists(newFilePath))
            {
                throw new IOException($"A file already exists at '{newFilePath}'.");
            }

            File.Move(oldFilePath, newFilePath);
        }

        public static void CopyFile(string sourceFilePath, string destinationFilePath, bool overwrite = false)
        {
            if (!File.Exists(sourceFilePath))
            {
                throw new FileNotFoundException($"Source file '{sourceFilePath}' does not exist.");
            }

            // Ensure the parent directories for the destination file exist
            Directory.CreateDirectory(Path.GetDirectoryName(destinationFilePath));

            // Copy the file, with optional overwrite
            File.Copy(sourceFilePath, destinationFilePath, overwrite);

            System.Console.WriteLine($"File copied to '{destinationFilePath}'.");
        }

        public static void OpenGetPath(string path)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.ValidateNames = false;
                openFileDialog.CheckFileExists = false; // Avoid validation
                openFileDialog.CheckPathExists = true;
                openFileDialog.FileName = "Get Pack Files Folder"; // A trick to select folders

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected path (folder) and display it in the textbox
                    path = System.IO.Path.GetDirectoryName(openFileDialog.FileName);
                }
            }
        }

        public static List<string> FindInstalledUnrealEngineVersions()
        {
            List<string> unrealEnginePaths = new List<string>();

            // Default Epic Games installation path on Windows
            string epicGamesPath = "C:\\Program Files\\Epic Games";

            if (Directory.Exists(epicGamesPath))
            {
                // Get all subdirectories in the Epic Games path
                string[] subdirectories = Directory.GetDirectories(epicGamesPath);
                unrealEnginePaths.AddRange(from subdirectory in subdirectories// Check if the subdirectory name matches typical Unreal Engine versioning (e.g., "UE_4.25", "UE_5.0")
                                           where subdirectory.Contains("UE_")
                                           select subdirectory);
            }

            return unrealEnginePaths;
        }

        public static long GetPackageSize(string folderPath)
        {
            DirectoryInfo directory = new DirectoryInfo(folderPath);
            long packageSize = directory.EnumerateFiles("*.*", SearchOption.AllDirectories).Sum(file => file.Length);
            return packageSize;
        }

        public static double GetPackageSizeInMegabytes(string folderPath)
        {
            long packageSize = GetPackageSize(folderPath);
            return Math.Round(packageSize / (1024.0 * 1024.0), 1); // Convert bytes to megabytes and round to 1 decimal place
        }

        public static double GetPackageSizeInGigabytes(string folderPath)
        {
            double packageSizeInMegabytes = GetPackageSizeInMegabytes(folderPath);
            return Math.Round(packageSizeInMegabytes / 1024.0, 1); // Convert megabytes to gigabytes and round to 1 decimal place
        }

        public static long GetFileSize(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            return fileInfo.Length;
        }

        public static double GetFileSizeInMegabytes(string filePath)
        {
            long fileSize = GetFileSize(filePath);
            return Math.Round(fileSize / (1024.0 * 1024.0), 1); // Convert bytes to megabytes and round to 1 decimal place
        }

        public static double GetFileSizeInGigabytes(string filePath)
        {
            double fileSizeInMegabytes = GetFileSizeInMegabytes(filePath);
            return Math.Round(fileSizeInMegabytes / 1024.0, 1); // Convert megabytes to gigabytes and round to 1 decimal place
        }

        public static void SaveParameters(string filePath, Dictionary<string, string> parameters)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var entry in parameters)
                {
                    writer.WriteLine($"{entry.Key}={entry.Value}");
                }
            }

            System.Console.WriteLine($"Parameters saved to {filePath}.");
        }

        public static Dictionary<string, string> LoadParameters(string filePath)
        {
            var parameters = new Dictionary<string, string>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Skip empty lines or lines without an equal sign
                    if (string.IsNullOrWhiteSpace(line) || !line.Contains("="))
                    {
                        continue;
                    }

                    var parts = line.Split(new char[] { '=' }, 2);

                    if (parts.Length == 2)
                    {
                        parameters[parts[0].Trim()] = parts[1].Trim();
                    }
                }
            }

            System.Console.WriteLine($"Parameters loaded from {filePath}.");
            return parameters;
        }

        public static void WriteParameters(Dictionary<string, string> parameters, string filePath)
        {
            try
            {
                // Create a new StreamWriter to write to the file
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Write each parameter as a key-value pair
                    foreach (var parameter in parameters)
                    {
                        writer.WriteLine($"{parameter.Key}={parameter.Value}");
                    }
                }
            }
            catch (IOException ex)
            {
                // Handle file access errors
                Console.WriteLine($"Error writing parameters to file: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle other types of errors
                Console.WriteLine($"Error writing parameters to file: {ex.Message}");
            }
        }

        public static void UpdatePackageInstallationState(string packageName, bool installed)
        {
            // Get the path to the Preferences file
            string preferencesFilePath = Book_Files.GetFileInFolder("PackagesPreferences.txt", Book_Files.ImportantFolders.Packages);

            if (preferencesFilePath != null)
            {
                try
                {
                    // Load Preferences
                    Dictionary<string, string> preferences = Book_Files.LoadParameters(preferencesFilePath);

                    // Check if the package already exists in preferences
                    if (!preferences.ContainsKey(packageName))
                    {
                        // Get the highest package number already present in the list
                        int highestPackageNumber = preferences.Keys.Select(key => int.TryParse(key.Split('=')[0], out int packageNumber) ? packageNumber : 0).Max();

                        // Increment the package number for the new package
                        int newPackageNumber = highestPackageNumber + 1;

                        // Add the new package to the preferences with the next available package number
                        preferences[$"{newPackageNumber}={packageName}"] = "";

                        // Update the installation state for the package
                        preferences[$"{packageName}.InstalledInEngineState"] = installed.ToString();

                        // Write updated Preferences back to file
                        Book_Files.WriteParameters(preferences, preferencesFilePath);
                        Console.WriteLine($"Package '{packageName}' added to the package list with number '{newPackageNumber}'.");
                    }
                    else
                    {
                        // Update the installation state for the existing package
                        preferences[$"{packageName}.InstalledInEngineState"] = installed.ToString();

                        // Write updated Preferences back to file
                        Book_Files.WriteParameters(preferences, preferencesFilePath);
                        Console.WriteLine($"Package '{packageName}' installation state updated.");
                    }
                }
                catch (Exception ex)
                {
                    // Handle errors
                    Console.WriteLine($"Error updating package installation state: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Preferences file not found.");
            }
        }

        public static string GetManifestFilePath(string packageName, string PackageFolder)
        {
            string packageFolderPath = Path.Combine(PackageFolder, packageName);
            return Path.Combine(packageFolderPath, "ContentSettings", "manifest.json");
        }

        public static JObject LoadManifestJson(string filePath)
        {
            if (File.Exists(filePath))
            {
                string jsonContent = File.ReadAllText(filePath);
                return JObject.Parse(jsonContent);
            }
            else
            {
                // Return an empty JObject if the file doesn't exist
                return new JObject();
            }
        }

        public static void SaveManifestJson(string filePath, JObject manifestJson)
        {
            string jsonString = manifestJson.ToString(Formatting.Indented);
            File.WriteAllText(filePath, jsonString);
        }

        public static void UpdatePackageManifest(int packageId, string packageName, string packageFolder)
        {
            // Assuming you have a method to load and update the package manifest
            string manifestFilePath = GetManifestFilePath(packageName, packageFolder);
            JObject manifestJson = LoadManifestJson(manifestFilePath);

            // Update the package ID in the manifest
            manifestJson["PackageID"] = packageId;

            // Save the updated manifest JSON back to the file
            SaveManifestJson(manifestFilePath, manifestJson);
        }

        public static void AddPackage(Dictionary<string, string> packageNames, string packageName, string PackageListPath, string packageFolderPath)
        {
            // Find the next available package number
            int nextPackageNumber = 1;
            if (packageNames.Count > 0)
            {
                nextPackageNumber = packageNames.Keys.Select(key => int.Parse(key)).Max() + 1;
            }

            // Add the new package to the package list
            packageNames[nextPackageNumber.ToString()] = packageName;
            SaveParameters(PackageListPath, packageNames);

            // Update the manifest for the new package
            UpdatePackageManifest(nextPackageNumber, packageName, packageFolderPath);
        }

        public static void RemovePackage(Dictionary<string, string> packageNames, int packageNumber, string packageFolderPath)
        {
            // Remove the package from the package list
            string packageNumberStr = packageNumber.ToString();
            if (packageNames.ContainsKey(packageNumberStr))
            {
                packageNames.Remove(packageNumberStr);

                // Update the keys of the remaining packages
                int newKey = 1;
                foreach (var kvp in packageNames.ToList())
                {
                    if (kvp.Key != newKey.ToString())
                    {
                        packageNames[newKey.ToString()] = kvp.Value;
                        packageNames.Remove(kvp.Key);
                    }
                    newKey++;
                }

                // Update the manifests for all packages
                foreach (var kvp in packageNames)
                {
                    UpdatePackageManifest(int.Parse(kvp.Key), kvp.Value, packageFolderPath);
                }
            }
            else
            {
                System.Console.WriteLine("Package does not exist in the package list.");
            }
        }

        public static void CopyFolderWithProgress(BackgroundWorker worker, string sourceFolderPath, string destinationFolderPath, int totalDurationInSeconds)
        {
            // Create the destination folder
            Directory.CreateDirectory(destinationFolderPath);

            // Copy the source folder itself
            string sourceFolderName = new DirectoryInfo(sourceFolderPath).Name;
            string destinationFolderFullPath = Path.Combine(destinationFolderPath, sourceFolderName);
            Directory.CreateDirectory(destinationFolderFullPath);

            // Get all files and subfolders in the source folder
            string[] allItems = Directory.GetFileSystemEntries(sourceFolderPath, "*", SearchOption.AllDirectories);
            int totalItems = allItems.Length;

            // Calculate the delay required to make the total copy process last approximately 10 seconds
            int delayPerItem = ((totalDurationInSeconds * 1000) / totalItems);

            for (int i = 0; i < totalItems; i++)
            {
                if (worker.CancellationPending)
                {
                    break;
                }

                string sourceItemPath = allItems[i];
                string relativePath = Book_Files.GetRelativePath(sourceFolderPath, sourceItemPath);
                string destinationItemPath = Path.Combine(destinationFolderFullPath, relativePath);

                if (File.Exists(sourceItemPath))
                {
                    // Copy the file
                    File.Copy(sourceItemPath, destinationItemPath, overwrite: true);
                }
                else if (Directory.Exists(sourceItemPath))
                {
                    // Create the directory
                    Directory.CreateDirectory(destinationItemPath);
                }

                // Introduce a delay to simulate slower copying
                Thread.Sleep(delayPerItem);

                // Report progress
                int progressPercentage = ((i + 1) * 100) / totalItems;
                worker.ReportProgress(progressPercentage, relativePath);
            }
        }

        public static bool AreFilesDoneCopying(string sourceFolderPath, string destinationFolderPath)
        {
            // Get all files and subfolders in the source folder
            string[] allItems = Directory.GetFileSystemEntries(sourceFolderPath, "*", SearchOption.AllDirectories);

            // Check if all files exist in the destination folder
            foreach (string sourceItemPath in allItems)
            {
                string relativePath = Book_Files.GetRelativePath(sourceFolderPath, sourceItemPath);
                string destinationItemPath = Path.Combine(destinationFolderPath, relativePath);

                if (!File.Exists(destinationItemPath) && !Directory.Exists(destinationItemPath))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
