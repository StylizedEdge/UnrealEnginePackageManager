using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Input;
using static UnrealEnginePackageManager.MethodBook;

namespace UnrealEnginePackageManager
{
    public partial class UnrealEnginePackageManager_Core : Form
    {
        string UEpath = "C:\\Program Files\\Epic Games\\UE_4.27";
        string PreferenceFileName = "Preferences.dll";
        List<Package> packages = new List<Package>();


        public UnrealEnginePackageManager_Core()
        {
            InitializeComponent();

            //Load Preferences
            // Load the parameters from the text file
            Dictionary<string, string> loadedParameters = MethodBook.LoadParameters(MethodBook.GetFileInFolder(PreferenceFileName, MethodBook.ImportantFolders.Resources));

            // Display the loaded parameters
            foreach (KeyValuePair<string, string> param in loadedParameters)
            {
                Console.WriteLine(param.Value);
            }
            // Check for deleted packages
            CheckDeletedPackages();

            // Load Package List
            LoadPackages();
        }




        #region Load package Function
        private void LoadPackages()
        {
            // Get the path to the package list file
            string packageListFilePath = MethodBook.GetFileInFolder("PackageList.txt", ImportantFolders.Packages);
            if (packageListFilePath != null)
                Console.WriteLine("Package List Scanned");


            // Read the package list file to get the names of all packages
            Dictionary<string, string> packageNames = MethodBook.LoadParameters(packageListFilePath);

            if (packageNames != null)
            {
                foreach (var package in packageNames)
                {
                    Console.WriteLine(package.Value);


                    // Get the package name and folder path
                    string packageName = package.Value; // Extract package name from packageEntry.Value
                    string packageFolderPath = MethodBook.GetFolderInFolder("Packages", ImportantFolders.Packages);

                    Console.WriteLine("Packages are located in");
                    Console.WriteLine(packageFolderPath);
                    Console.WriteLine("package Manifest of  >>  " + packageName + " Located in \n");
                    Console.WriteLine(packageFolderPath + "\\" + packageName + "\\" + "ContentSettings\\");


                    // Get the path to the JSON file containing package information
                    string jsonFilePath = Path.Combine(packageFolderPath, $"{packageName}\\ContentSettings", "manifest.json");

                    Console.WriteLine(jsonFilePath);

                    if (File.Exists(jsonFilePath))
                    {
                        Console.WriteLine("Package Manifest Detect", Color.Green);

                        // Read the JSON content from the file
                        string jsonContent = File.ReadAllText(jsonFilePath);

                        // Parse JSON content
                        JObject packageJson = JObject.Parse(jsonContent);

                        // Extract package information
                        string name = packageJson["Name"][0]["Text"].Value<string>();
                        string version = packageJson["Version"].Value<string>();
                        string description = packageJson["Description"][0]["Text"].Value<string>();


                        string thumbnail = "";
                        if (packageJson.ContainsKey("Thumbnail") && packageJson["Thumbnail"].Type == JTokenType.String)
                        {
                            thumbnail = packageJson["Thumbnail"].Value<string>();
                        }
                        // Construct the full path to the thumbnail image
                        string fullThumbnailPath = Path.Combine(packageFolderPath, $"{packageName}\\ContentSettings", "Media", thumbnail);

                        string UeVersion = packageJson["UEVersion"].Value<string>();



                        // Create a new Package object with the extracted information
                        Package pack = new Package
                        {
                            Name = name,
                            Description = description,
                            Thumbnail = fullThumbnailPath,
                            Version = version,
                            UEVersion = UeVersion
                        };

                        // Initialize the list to store the loaded packages
                        packages = new List<Package>
                        {
                            // Add the package to the list
                            pack
                        };
                        Console.WriteLine("Buttons Initialized");
                        CreatePackageButtons();
                    }

                    if (packages.Count == 0)
                    {
                        Console.WriteLine("Package list is empty");
                    }

                }
            }


        }
        #endregion

        #region Create package Function

        private void CreatePackageButtons()
        {
            if (packages.Count != 0)
            {
                foreach (var package in packages)
                {
                    Button button = new Button();
                    if (File.Exists(package.Thumbnail))
                    {
                        button.BackgroundImage = Image.FromFile(package.Thumbnail); // Load the thumbnail image
                        Console.WriteLine("Thumbnail Detected");
                    }
                    else
                    {
                        Console.WriteLine(package.Name + " Thumbnail missing");
                    }
                    button.BackColor = System.Drawing.Color.Silver;
                    button.Cursor = System.Windows.Forms.Cursors.Hand;
                    button.Dock = System.Windows.Forms.DockStyle.Top;
                    button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                    button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    button.ForeColor = System.Drawing.SystemColors.ControlText;
                    button.Location = new System.Drawing.Point(3, 3);
                    button.Name = package.Name;
                    button.Size = new System.Drawing.Size(120, 120);
                    button.TabIndex = 0;
                    button.Text = package.Name;
                    button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                    button.UseVisualStyleBackColor = false;


                    button.BackgroundImageLayout = ImageLayout.Stretch;
                    button.Dock = DockStyle.Top;
                    button.Name = package.Name; // Assign the package name to the button name
                    button.Size = new Size(120, 120);
                    button.Text = package.Name;
                    button.TextAlign = ContentAlignment.BottomCenter;
                    button.UseVisualStyleBackColor = true;


                    button.Click += (sender, e) => Button_Click(package); // Assign click event handler
                    previewPanel.Controls.Add(button);
                }
            }
        }

        #endregion

        Package selectedPackage;
        private void Button_Click(Package package)
        {
            // Handle button click event
            string packageFolderPath = Path.Combine(MethodBook.GetFolderInFolder("Packages", ImportantFolders.Packages), package.Name);
            double packageSizeMb = MethodBook.GetPackageSizeInMegabytes(packageFolderPath);
            double packageSizeGb = MethodBook.GetPackageSizeInGigabytes(packageFolderPath);
            selectedPackage = package;

            if (selectedPackage != null)
            {
                pkgName.Text = package.Name;
                pkgSize.Text = $"{packageSizeMb} MB (   {packageSizeGb}GB)";
                pkgDescription.Text = package.Description;
                pkgUnrealEngineVersion.Text = package.UEVersion;
            }
            else
            {
                pkgName.Text = null;
                pkgSize.Text = null;
                pkgDescription.Text = null;
                pkgUnrealEngineVersion.Text = null;
            }

            Console.WriteLine("Selected Package is " + package.Name, Color.White);
        }



        private void createContentPackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PackageCreator PackageCreatorWindow = new PackageCreator();
            PackageCreatorWindow.Show();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preferences preferences = new Preferences();
            preferences.Show();
        }

        private void devSupportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.artstation.com/stylizededge/");
        }

        private void aboutUEPackageManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UnrealEPC Version 1.0 \n" +
                "Hey there, i'm happy you using this small tool\n" +
                "It was just annoying to always migrate my files with 2 big\n" +
                "projects hanging there since it be cossuming my PC strenght 😭\n" +
                "Check my Artstation for more Update\n" +
                "Thanks");
        }



        private void ReinstallButton_Click(object sender, EventArgs e)
        {
            // Handle reinstall button click event for the selected package
            if (selectedPackage != null)
            {
                // Implement reinstall logic here
                Console.WriteLine($"Reinstalling package '{selectedPackage.Name}'...");
            }
        }

        private void InstallUnrealButton_Click(object sender, EventArgs e)
        {
            // Handle install in Unreal Engine button click event for the selected package
            if (selectedPackage != null)
            {
                // Implement install in Unreal Engine logic here
                Console.WriteLine($"Installing package '{selectedPackage.Name}' in Unreal Engine...");
            }
        }

        private void RefreshPackageButtons()
        {
            previewPanel.Controls.Clear();
            // Load Package List
            LoadPackages();
            CreatePackageButtons();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedPackage != null)
            {
                string packageFolderPath = Path.Combine(MethodBook.GetFolderInFolder("Packages", ImportantFolders.Packages), selectedPackage.Name);

                // Display a confirmation dialog
                DialogResult result = MessageBox.Show($"Are you sure you want to delete the package '{selectedPackage.Name}'?" +
                    $"Automatic restart will occur", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check if the user confirmed the deletion
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Console.WriteLine($"Package '{selectedPackage.Name}' deleted.");
                        // Attempt to delete the package folder
                        DeletePackage(packageFolderPath);
                        if (selectedPackage != null)
                            selectedPackage.Thumbnail = null;

                        // Remove the package from the list and update UI
                        packages.Remove(selectedPackage);
                        RefreshPackageButtons();
                        UpdatePackageList();
                    }
                    catch (IOException ex)
                    {
                        // Handle file access errors
                        Console.WriteLine($"Error deleting package '{selectedPackage.Name}': {ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        // Handle other types of errors
                        Console.WriteLine($"Error deleting package '{selectedPackage.Name}': {ex.Message}");
                    }
                }
            }
            else
            {
                Console.Write("No Selected Package to delete");
            }
        }




        /* private void DeletePackage(string folderPath)
                {
                    selectedPackage = null;

                    if (Directory.Exists(folderPath))
                    {
                        try
                        {
                            // Attempt to delete the package folder
                            Directory.Delete(folderPath, true);
                            Console.WriteLine($"Package folder '{folderPath}' deleted.");

                            // Remove the package from the list
                            Package deletedPackage = packages.Find(p => Path.Combine(MethodBook.GetFolderInFolder("Packages", MethodBook.ImportantFolders.Packages), p.Name) == folderPath);
                            if (deletedPackage != null)
                            {
                                packages.Remove(deletedPackage);
                                Console.WriteLine($"Package '{deletedPackage.Name}' removed from the list.");
                            }

                            // Update the packageList.txt
                            string packageListFilePath = MethodBook.GetFileInFolder("PackageList.txt", MethodBook.ImportantFolders.Packages);
                            Dictionary<string, string> packageNames = MethodBook.LoadParameters(packageListFilePath);
                            string packageName = deletedPackage.Name;
                            packageNames = packageNames.Where(x => x.Value != packageName).ToDictionary(x => x.Key, x => x.Value);
                            MethodBook.WriteParameters(packageNames, packageListFilePath);
                            Console.WriteLine("Package list updated.");

                            // Find the package number corresponding to the deleted package name
                            string packageNumberStr = packageNames.FirstOrDefault(x => x.Value == deletedPackage.Name).Key.ToString();

                            // If package number is found, remove the package from the package manifests
                            if (!string.IsNullOrEmpty(packageNumberStr))
                            {
                                RemovePackage(packageNames, int.Parse(packageNumberStr));
                            }
                            else
                            {
                                Console.WriteLine("Package number not found for the deleted package name.");
                            }
                            string packageFolderPath = Path.Combine(MethodBook.GetFolderInFolder("Packages", ImportantFolders.Packages), selectedPackage.Name);

                            // Close the application before restarting
                            Application.Exit();

                            //LauchUnrealEngine Path
                            string deleteThis = $"{packageFolderPath}";
                            Process.Start(deleteThis);
                        }
                        catch (IOException ex)
                        {
                            // Handle file access errors
                            Console.WriteLine($"Error deleting package folder '{folderPath}': {ex.Message}");
                        }
                        catch (Exception ex)
                        {
                            // Handle other types of errors
                            Console.WriteLine($"Error deleting package folder '{folderPath}': {ex.Message}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Package folder '{folderPath}' not found.");
                    }
                }

         */


        private void DeletePackage(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                Console.WriteLine($"Package folder '{folderPath}' not found.");
                return;
            }

            try
            {
                // Attempt to delete the package folder and all its contents
                Directory.Delete(folderPath, true);
                Console.WriteLine($"Package folder '{folderPath}' deleted.");

                // Remove the package from the list
                Package deletedPackage = packages.FirstOrDefault(p => Path.Combine(MethodBook.GetFolderInFolder("Packages", MethodBook.ImportantFolders.Packages), p.Name) == folderPath);
                if (deletedPackage != null)
                {
                    packages.Remove(deletedPackage);
                    Console.WriteLine($"Package '{deletedPackage.Name}' removed from the list.");
                }

                // Update the packageList.txt
                string packageListFilePath = MethodBook.GetFileInFolder("PackageList.txt", MethodBook.ImportantFolders.Packages);
                Dictionary<string, string> packageNames = MethodBook.LoadParameters(packageListFilePath);
                string packageName = deletedPackage?.Name;
                if (!string.IsNullOrEmpty(packageName))
                {
                    packageNames = packageNames.Where(x => x.Value != packageName).ToDictionary(x => x.Key, x => x.Value);
                    MethodBook.WriteParameters(packageNames, packageListFilePath);
                    Console.WriteLine("Package list updated.");

                    // Find the package number corresponding to the deleted package name
                    string packageNumberStr = packageNames.FirstOrDefault(x => x.Value == deletedPackage.Name).Key;
                    if (!string.IsNullOrEmpty(packageNumberStr))
                    {
                        // If package number is found, remove the package from the package manifests
                        RemovePackage(packageNames, int.Parse(packageNumberStr));
                    }
                    else
                    {
                        Console.WriteLine("Package number not found for the deleted package name.");
                    }
                }

                // Close the application before restarting
                Application.Exit();
                Application.Restart();

                // Launch Unreal Engine (assuming you want to start it after deleting the package)
                Process.Start(folderPath);
            }
            catch (Exception ex)
            {
                // Handle errors
                Console.WriteLine($"Error deleting package folder '{folderPath}': {ex.Message}");
            }
        }







        private void managePacksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshPackageButtons();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Wanna close UEPM?", "Close UEPM", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void InstallPackageContent_Click(object sender, EventArgs e)
        {
            if (selectedPackage != null)
            {
                // Get the path to the package folder
                string packageFolderPath = Path.Combine(MethodBook.GetFolderInFolder("Packages", ImportantFolders.Packages), selectedPackage.Name);
                string featurePacksFiles = Path.Combine(packageFolderPath, "FeaturePacks");
                string featuresDestination = Path.Combine(UEpath, "FeaturePacks");

                string samplesFolder = Path.Combine(packageFolderPath, "Samples", selectedPackage.Name);
                string destinationPath = Path.Combine(UEpath, "Samples", selectedPackage.Name);


                Console.WriteLine($"{packageFolderPath} will be installed in \n {UEpath}");
                /*
                try
                {
                    // Copy files from FeaturePacks to destination
                    MethodBook.CopyFile(featurePacksFiles, featuresDestination);
                    SConsole.WriteLine($"Copied '{selectedPackage}.upackage' to '{featuresDestination}'.");

                    // Copy files from Samples to destination
                    MethodBook.CopyFolder(samplesFolder, destinationPath);
                    SConsole.WriteLine($"Copied '{selectedPackage}.SamplePackage' to '{destinationPath}'.");


                    // Update package installation state in Preferences
                    UpdatePackageInstallationState(selectedPackage.Name, true);
                }
                catch (Exception ex)
                {
                    // Handle errors
                    SConsole.WriteLine($"Error installing package content: {ex.Message}");
                }

                */
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            UninstallPackageFromEngine(selectedPackage);
        }

        private void UninstallPackageFromEngine(Package package)
        {
            if (package != null)
            {
                // Get the paths to the FeaturePacks and Samples in the engine directory
                string featurePacksPath = Path.Combine(UEpath, "FeaturePacks", package.Name);
                string samplesPath = Path.Combine(UEpath, "Samples", package.Name);

                try
                {
                    // Delete FeaturePacks folder
                    if (Directory.Exists(featurePacksPath))
                    {
                        Directory.Delete(featurePacksPath, true);
                        Console.WriteLine($"FeaturePacks folder for package '{package.Name}' deleted from the engine.");
                    }

                    // Delete Samples folder
                    if (Directory.Exists(samplesPath))
                    {
                        Directory.Delete(samplesPath, true);
                        Console.WriteLine($"Samples folder for package '{package.Name}' deleted from the engine.");
                    }

                    // Update package installation state in Preferences
                    UpdatePackageInstallationState(package.Name, false);
                }
                catch (Exception ex)
                {
                    // Handle errors
                    Console.WriteLine($"Error uninstalling package from engine: {ex.Message}");
                }
            }
        }
        private void CheckDeletedPackages()
        {
            // Get the path to the package list file
            string packageListFilePath = MethodBook.GetFileInFolder("PackageList.txt", MethodBook.ImportantFolders.Packages);

            if (packageListFilePath != null)
            {
                try
                {
                    // Read the package list file to get the names of all packages
                    Dictionary<string, string> packageNames = MethodBook.LoadParameters(packageListFilePath);

                    // Create a list to store package numbers to be removed
                    List<string> packagesToRemove = new List<string>();

                    // Iterate through each package name
                    foreach (var kvp in packageNames)
                    {
                        string packageFolderPath = Path.Combine(MethodBook.GetFolderInFolder("Packages", ImportantFolders.Packages), kvp.Value);

                        // Check if the package folder exists
                        if (!Directory.Exists(packageFolderPath))
                        {
                            // Package folder does not exist, mark it for removal
                            packagesToRemove.Add(kvp.Key);
                            Console.WriteLine($"Deleted package '{kvp.Value}' removed from the package list.");
                        }
                    }

                    // Remove deleted packages from the packageNames dictionary
                    foreach (string packageNumber in packagesToRemove)
                    {
                        packageNames.Remove(packageNumber);
                    }

                    // Write the updated package list back to the file
                    MethodBook.WriteParameters(packageNames, packageListFilePath);

                    // Remove the deleted packages from the package manifests
                    foreach (string packageNumber in packagesToRemove)
                    {
                        RemovePackage(packageNames, int.Parse(packageNumber));
                    }

                    Console.WriteLine("Package list updated.");
                }
                catch (IOException ex)
                {
                    // Handle file access errors
                    Console.WriteLine($"Error updating package list: {ex.Message}");
                }
                catch (Exception ex)
                {
                    // Handle other types of errors
                    Console.WriteLine($"Error updating package list: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Package list file not found.");
            }
        }

        private void UpdatePackageList()
        {
            // Get the path to the package list file
            string packageListFilePath = MethodBook.GetFileInFolder("PackageList.txt", MethodBook.ImportantFolders.Packages);

            if (packageListFilePath != null)
            {
                try
                {
                    // Read the package list file to get the names of all packages
                    Dictionary<string, string> packageNames = MethodBook.LoadParameters(packageListFilePath);

                    // Remove the deleted package from the package list if selectedPackage is not null
                    if (selectedPackage != null && packageNames.ContainsKey(selectedPackage.Name))
                    {
                        packageNames.Remove(selectedPackage.Name);
                        // Write the updated package list back to the file
                        MethodBook.WriteParameters(packageNames, packageListFilePath);
                        Console.WriteLine("Package list updated.");

                        // Save the updated package list to the file
                        MethodBook.SaveParameters(packageListFilePath, packageNames);

                        Console.WriteLine("Package list updated.");
                    }

                    // Write the updated package list back to the file
                    MethodBook.WriteParameters(packageNames, packageListFilePath);
                }
                catch (IOException ex)
                {
                    // Handle file access errors
                    Console.WriteLine($"Error updating package list: {ex.Message}");
                }
                catch (Exception ex)
                {
                    // Handle other types of errors
                    Console.WriteLine($"Error updating package list: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Package list file not found.");
            }
        }

    }

    public class Package
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public string Thumbnail { get; set; }
        public string Version { get; set; }
        public string UEVersion { get; set; }
        // Add more properties as needed
    }




}
