using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace UnrealEnginePackageManager
{
    public partial class UnrealEnginePackageManager : Form
    {
        string UEpath;
        private Dictionary<string, string> PrefencesData;
        string ContentFolderPath;
        string PackageFolderPath;
        List<Content> contents = new List<Content>();
        List<Package> packages = new List<Package>();


        Content SelectedContent;
        Package SelectedPackage;
        

        public UnrealEnginePackageManager()
        {
            InitializeComponent();
            // Load the parameters from the text file
            PrefencesData = Book_Files.LoadParameters(Book_Files.GetFileInFolder("Preferences.dll", Book_Files.ImportantFolders.Resources));

            if(PrefencesData!= null)
            {
                ContentFolderPath = PrefencesData["ContentCreationDirectory"];
                PackageFolderPath = PrefencesData["PackageCreationDirectory"];

                UEpath = Path.Combine(PrefencesData["EnginesPath"], PrefencesData["SelectedVersionPath"]);
            }
            // Check for deleted packages
            CheckDeletedPackages();
            CheckDeletedContents();
            // Load Package List
            LoadContents();
            LoadPackages();
        }

        #region Content
        #region Load Content Function
        private void LoadContents()
        {
            // Get the path to the package list file
            string contentListFilePath = Book_Files.GetFileInFolder("ContentList.txt", Book_Files.ImportantFolders.Packages);

            // Read the package list file to get the names of all packages
            Dictionary<string, string> contentNames = Book_Files.LoadParameters(contentListFilePath);

            if (contentNames != null)
            {
                foreach (var content in contentNames)
                {
                    // Get the package name and folder path
                    string contentName = content.Value; // Extract package name from packageEntry.Value
                    string contentFolderPath = PrefencesData["ContentCreationDirectory"];

                    // Get the path to the JSON file containing package information
                    string jsonFilePath = Path.Combine(contentFolderPath, $"{contentName}\\ContentSettings", "manifest.json");

                    Console.WriteLine(jsonFilePath);

                    if (File.Exists(jsonFilePath))
                    {
                        Console.WriteLine("Content Manifest Detect");

                        // Read the JSON content from the file
                        string jsonContent = File.ReadAllText(jsonFilePath);

                        // Parse JSON content
                        JObject contentJson = JObject.Parse(jsonContent);

                        // Extract package information
                        string name = contentJson["Name"][0]["Text"].Value<string>();
                        string version = contentJson["Version"].Value<string>();

                        string description = contentJson["Description"][0]["Text"].Value<string>();


                        string thumbnail = "";
                        if (contentJson.ContainsKey("Thumbnail") && contentJson["Thumbnail"].Type == JTokenType.String)
                        {
                            thumbnail = contentJson["Thumbnail"].Value<string>();
                        }
                        // Construct the full path to the thumbnail image
                        string fullThumbnailPath = Path.Combine(contentFolderPath, $"{contentName}\\ContentSettings", "Media", thumbnail);

                        string UeVersion = contentJson["UEVersion"].Value<string>();

                        string devname = contentJson["Dev"].Value<string>();
                        string devwebsite = contentJson["DevWebsite"].Value<string>();


                        // Create a new Package object with the extracted information
                        Content m_content = new Content
                        {
                            Name = name,
                            Description = description,
                            Thumbnail = fullThumbnailPath,
                            Version = version,
                            UEVersion = UeVersion,
                            DevName = devname,
                            DevWebsite = devwebsite,
                        };

                        // Initialize the list to store the loaded packages
                        contents = new List<Content>
                        {
                            // Add the package to the list
                            m_content
                        };
                        Console.WriteLine("Buttons Initialized");
                        CreateContentButtons();
                    }

                    if (contents.Count == 0)
                    {
                        Console.WriteLine("Content list is empty");
                    }

                }
            }


        }
        #endregion

        #region Create Content Function

        private void CreateContentButtons()
        {
            if (contents.Count != 0)
            {
                foreach (var content in contents)
                {
                    Button button = new Button();
                    if (File.Exists(content.Thumbnail))
                    {
                        //Everything about button Image
                        button.Image = Image.FromFile(content.Thumbnail); // Load the thumbnail image
                        button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        Console.WriteLine("Thumbnail Detected");
                    }
                    else
                    {
                        Console.WriteLine(content.Name + " Thumbnail missing");
                    }
                    button.BackColor = System.Drawing.Color.Silver;
                    button.Cursor = System.Windows.Forms.Cursors.Hand;
                    button.Dock = System.Windows.Forms.DockStyle.Top;
                    button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                    button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    button.ForeColor = System.Drawing.SystemColors.ControlText;
                    button.Location = new System.Drawing.Point(3, 3);
                    button.Name = content.Name;
                    button.Size = new System.Drawing.Size(400, 50);
                    button.TabIndex = 0;
                    button.Text = content.Name;
                    button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                    button.UseVisualStyleBackColor = false;
                    button.Dock = DockStyle.Top;
                    button.Name = content.Name; // Assign the package name to the button name
                    button.Text = content.Name;
                    button.TextAlign = ContentAlignment.BottomCenter;
                    button.UseVisualStyleBackColor = true;



                    button.ContextMenuStrip = PackageOption;
                    button.Click += (sender, e) => ContentSelect_Click(content); // Assign click event handler
                    UnrealContent.Controls.Add(button);
                }
            }
        }

        #endregion


        private void ContentSelect_Click(Content content)
        {
            // Handle button click event
            string packageFolderPath = Path.Combine(PrefencesData["ContentCreationDirectory"], content.Name);
            double packageSizeMb = Book_Files.GetFolderSizeInMegabytes(packageFolderPath);
            double packageSizeGb = Book_Files.GetFolderSizeInGigabytes(packageFolderPath);
            SelectedContent = content;
            SelectedPackage = null;

            if (SelectedContent != null)
            {
                pkgName.Text = content.Name;
                pkgSize.Text = $"{packageSizeMb} MB (   {packageSizeGb}GB)";
                pkgDescription.Text = content.Description;
                pkgUnrealEngineVersion.Text = content.UEVersion;
                DevName.Text = content.DevName;
                DevWebsite.Text = content.DevWebsite;
            }
            else
            {
                pkgName.Text = null;
                pkgSize.Text = null;
                pkgDescription.Text = null;
                pkgUnrealEngineVersion.Text = null;
                DevName.Text = null;
                DevWebsite.Text = null;
            }

            Console.WriteLine("Selected Package is " + content.Name, Color.White);
            checkInstallation();
        }



        #endregion

        #region packages
        #region Load package Function
        private void LoadPackages()
        {
            // Get the path to the package list file
            string packageListFilePath = Book_Files.GetFileInFolder("PackageList.txt", Book_Files.ImportantFolders.Packages);

            // Read the package list file to get the names of all packages
            Dictionary<string, string> packageNames = Book_Files.LoadParameters(packageListFilePath);

            if (packageNames != null)
            {
                foreach (var package in packageNames)
                {
                    // Get the package name and folder path
                    string packageName = package.Value;

                    // Extract package information
                    string name = package.Value;

                    // Create a new Package object with the extracted information
                    Package pack = new Package
                    {
                        Name = name
                    };

                    // Initialize the list to store the loaded packages
                    packages = new List<Package>
                                {
                                    // Add the package to the list
                                    pack
                                };
                    Console.WriteLine("Buttons Initialized");
                    CreatePackageButtons();

                    if (contents.Count == 0)
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
            if (contents.Count != 0)
            {
                foreach (var package in packages)
                {
                    Button button = new Button();
                    button.BackColor = System.Drawing.Color.Silver;
                    button.Cursor = System.Windows.Forms.Cursors.Hand;
                    button.Dock = System.Windows.Forms.DockStyle.Top;
                    button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                    button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    button.ForeColor = System.Drawing.SystemColors.ControlText;
                    button.Location = new System.Drawing.Point(3, 3);
                    button.Name = package.Name;
                    button.Size = new System.Drawing.Size(400, 50);
                    button.TabIndex = 0;
                    button.Text = package.Name;
                    button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                    button.UseVisualStyleBackColor = false;
                    button.Dock = DockStyle.Top;
                    button.Name = package.Name; // Assign the package name to the button name
                    button.Text = package.Name;
                    button.TextAlign = ContentAlignment.BottomCenter;
                    button.UseVisualStyleBackColor = true;



                    button.ContextMenuStrip = PackageOption;
                    button.Click += (sender, e) => PackageSelect_Click(package); // Assign click event handler
                    UnrealPackage.Controls.Add(button);
                }
            }
        }


        #endregion


        private void PackageSelect_Click(Package package)
        {
            // Handle button click event
            string packageFolderPath = Path.Combine(PrefencesData["PackageCreationDirectory"], package.Name + ".UnrealPackage");
            double packageSizeMb = Book_Files.GetFileSizeInMegabytes(packageFolderPath);
            double packageSizeGb = Book_Files.GetFileSizeInGigabytes(packageFolderPath);
            SelectedPackage = package;
            SelectedContent = null;

            if (SelectedPackage != null)
            {
                pkgName.Text = package.Name;
                pkgSize.Text = $"{packageSizeMb} MB (   {packageSizeGb}GB)";
                pkgDescription.Text = "";
                pkgUnrealEngineVersion.Text = "";
                DevName.Text = "";
                DevWebsite.Text = "";
            }
            else
            {
                pkgName.Text = null;
                pkgSize.Text = null;
                pkgDescription.Text = null;
                pkgUnrealEngineVersion.Text = null;
                DevName.Text = null;
                DevWebsite.Text = null;
            }

            Console.WriteLine("Selected Package is " + package.Name, Color.White);
        }
        #endregion

        private void checkInstallation()
        {
            if (File.Exists(Path.Combine(UEpath, "FeaturePacks", SelectedContent.Name + ".upack"))  && Directory.Exists(Path.Combine(UEpath, "Samples", SelectedContent.Name)))
            {
                InstallButton.Text = "Already Installed";
                UninstallButton.Enabled = true;
                InstallButton.Enabled = false;
            }
            else
            {
                InstallButton.Text = "Install";
                UninstallButton.Enabled = false;
                InstallButton.Enabled = true;
            }
        }

        private void createContentPackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnrealContentCreator PackageCreatorWindow = new UnrealContentCreator();
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
            if (SelectedContent != null)
            {
                // Implement reinstall logic here
                Console.WriteLine($"Reinstalling package '{SelectedContent.Name}'...");
            }
        }

        private void InstallUnrealButton_Click(object sender, EventArgs e)
        {
            // Handle install in Unreal Engine button click event for the selected package
            if (SelectedContent != null)
            {
                // Implement install in Unreal Engine logic here
                Console.WriteLine($"Installing package '{SelectedContent.Name}' in Unreal Engine...");
            }
        }

        private void RefreshPackageButtons()
        {
            UnrealContent.Controls.Clear();
            UnrealPackage.Controls.Clear();
            // Load Content List
            LoadContents();
            CreateContentButtons();

            // Load Package List
            LoadPackages();
            CreatePackageButtons();
        }


        /*  private void button3_Click(object sender, EventArgs e)
                {
                    if (SelectedContent != null)
                    {
                        string contentFolderPath = Path.Combine(PrefencesData["ContentCreationDirectory"], SelectedContent.Name);

                        // Display a confirmation dialog
                        DialogResult result = MessageBox.Show($"Are you sure you want to delete the package '{SelectedContent.Name}'?" +
                            $"Automatic restart will occur", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        // Check if the user confirmed the deletion
                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                Console.WriteLine($"Package '{SelectedContent.Name}' deleted.");
                                // Attempt to delete the package folder
                                DeleteContent(contentFolderPath);
                                if (SelectedContent != null)
                                    SelectedContent.Thumbnail = null;

                                // Remove the package from the list and update UI
                                contents.Remove(SelectedContent);
                                RefreshPackageButtons();
                                UpdatePackageList();
                            }
                            catch (IOException ex)
                            {
                                // Handle file access errors
                                Console.WriteLine($"Error deleting package '{SelectedContent.Name}': {ex.Message}");
                            }
                            catch (Exception ex)
                            {
                                // Handle other types of errors
                                Console.WriteLine($"Error deleting package '{SelectedContent.Name}': {ex.Message}");
                            }
                        }
                    }
                    else
                    {
                        Console.Write("No Selected Package to delete");
                    }

                    if (SelectedPackage != null)
                    {
                        string packageFilePath = Path.Combine(PrefencesData["PackageCreationDirectory"], SelectedPackage.Name + ".UnrealPackage");

                        // Display a confirmation dialog
                        DialogResult result = MessageBox.Show($"Are you sure you want to delete the package '{SelectedPackage.Name}'?" +
                            $"Automatic restart will occur", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        // Check if the user confirmed the deletion
                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                Console.WriteLine($"Package '{SelectedPackage.Name}' deleted.");
                                // Attempt to delete the package folder
                                DeletePackage(packageFilePath);
                                // Remove the package from the list and update UI
                                packages.Remove(SelectedPackage);
                                RefreshPackageButtons();
                                UpdatePackageList();
                            }
                            catch (IOException ex)
                            {
                                // Handle file access errors
                                Console.WriteLine($"Error deleting package '{SelectedPackage.Name}': {ex.Message}");
                            }
                            catch (Exception ex)
                            {
                                // Handle other types of errors
                                Console.WriteLine($"Error deleting package '{SelectedPackage.Name}': {ex.Message}");
                            }
                        }
                    }
                    else
                    {
                        Console.Write("No Selected Package to delete");
                    }
                }

                private void DeleteContent(string folderPath)
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
                        Content deletedPackage = contents.FirstOrDefault(p => Path.Combine(ContentFolderPath, p.Name) == folderPath);
                        if (deletedPackage != null)
                        {
                            contents.Remove(deletedPackage);
                            Console.WriteLine($"Package '{deletedPackage.Name}' removed from the list.");
                        }

                        // Update the packageList.txt
                        string packageListFilePath = Book_Files.GetFileInFolder("ContentList.txt", Book_Files.ImportantFolders.Packages);
                        Dictionary<string, string> packageNames = Book_Files.LoadParameters(packageListFilePath);
                        string packageName = deletedPackage?.Name;
                        if (!string.IsNullOrEmpty(packageName))
                        {
                            packageNames = packageNames.Where(x => x.Value != packageName).ToDictionary(x => x.Key, x => x.Value);
                            Book_Files.WriteParameters(packageNames, packageListFilePath);
                            Console.WriteLine("Package list updated.");

                            // Find the package number corresponding to the deleted package name
                            string packageNumberStr = packageNames.FirstOrDefault(x => x.Value == deletedPackage.Name).Key;
                            if (!string.IsNullOrEmpty(packageNumberStr))
                            {
                                // If package number is found, remove the package from the package manifests
                                Book_Files.RemovePackage(packageNames, int.Parse(packageNumberStr), ContentFolderPath);
                            }
                            else
                            {
                                Console.WriteLine("Package number not found for the deleted package name.");
                            }
                        }

                        // Close the application before restarting
                        Application.Exit();
                        Application.Restart();

                    }
                    catch (Exception ex)
                    {
                        // Handle errors
                        Console.WriteLine($"Error deleting package folder '{folderPath}': {ex.Message}");
                    }
                }


                 private void DeletePackage(string filePath)
                        {
                            if (!File.Exists(filePath))
                            {
                                Console.WriteLine($"Package file '{filePath}' not found.");
                                return;
                            }

                            try
                            {
                                // Attempt to delete the package file
                                File.Delete(filePath);
                                Console.WriteLine($"Package file '{filePath}' deleted.");

                                // Remove the package from the list
                                Package deletedPackage = packages.FirstOrDefault(p => Path.Combine(PackageFolderPath, p.Name) == filePath);
                                if (deletedPackage != null)
                                {
                                    packages.Remove(deletedPackage);
                                    Console.WriteLine($"Package '{deletedPackage.Name}' removed from the list.");
                                }

                                // Update the packageList.txt
                                string packageListFilePath = Book_Files.GetFileInFolder("PackageList.txt", Book_Files.ImportantFolders.Packages);
                                Dictionary<string, string> packageNames = Book_Files.LoadParameters(packageListFilePath);
                                string packageName = deletedPackage?.Name;
                                if (!string.IsNullOrEmpty(packageName))
                                {
                                    packageNames = packageNames.Where(x => x.Value != packageName).ToDictionary(x => x.Key, x => x.Value);
                                    Book_Files.WriteParameters(packageNames, packageListFilePath);
                                    Console.WriteLine("Package list updated.");

                                    // Find the package number corresponding to the deleted package name
                                    string packageNumberStr = packageNames.FirstOrDefault(x => x.Value == deletedPackage.Name).Key;
                                    if (!string.IsNullOrEmpty(packageNumberStr))
                                    {
                                        // If package number is found, remove the package from the package manifests
                                        Book_Files.RemovePackage(packageNames, int.Parse(packageNumberStr), PackageFolderPath);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Package number not found for the deleted package name.");
                                    }
                                }

                                // Close the application before restarting
                                Application.Exit();
                                Application.Restart();

                            }
                            catch (Exception ex)
                            {
                                // Handle errors
                                Console.WriteLine($"Error deleting package folder '{filePath}': {ex.Message}");
                            }
                        }


         */


        private void button3_Click(object sender, EventArgs e)
        {
            if (SelectedContent != null)
            {
                string contentFolderPath = Path.Combine(PrefencesData["ContentCreationDirectory"], SelectedContent.Name);

                // Display a confirmation dialog
                DialogResult result = MessageBox.Show($"Are you sure you want to delete the package '{SelectedContent.Name}'? Automatic restart will occur.",
                                                      "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check if the user confirmed the deletion
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Console.WriteLine($"Package '{SelectedContent.Name}' deleted.");
                        // Attempt to delete the package folder
                        DeleteContent(contentFolderPath);

                        if (SelectedContent != null)
                            SelectedContent.Thumbnail = null;

                        // Remove the package from the list and update UI
                        contents.Remove(SelectedContent);
                        RefreshPackageButtons();
                        UpdateContentList();
                    }
                    catch (IOException ex)
                    {
                        // Handle file access errors
                        Console.WriteLine($"Error deleting package '{SelectedContent.Name}': {ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        // Handle other types of errors
                        Console.WriteLine($"Error deleting package '{SelectedContent.Name}': {ex.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No Selected Package to delete");
            }

            if (SelectedPackage != null)
            {
                string packageFilePath = Path.Combine(PrefencesData["PackageCreationDirectory"], SelectedPackage.Name + ".UnrealPackage");

                // Display a confirmation dialog
                DialogResult result = MessageBox.Show($"Are you sure you want to delete the package '{SelectedPackage.Name}'? Automatic restart will occur.",
                                                      "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check if the user confirmed the deletion
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Console.WriteLine($"Package '{SelectedPackage.Name}' deleted.");
                        // Attempt to delete the package folder
                        DeletePackage(packageFilePath);

                        // Remove the package from the list and update UI
                        packages.Remove(SelectedPackage);
                        RefreshPackageButtons();
                        UpdatePackageList();
                    }
                    catch (IOException ex)
                    {
                        // Handle file access errors
                        Console.WriteLine($"Error deleting package '{SelectedPackage.Name}': {ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        // Handle other types of errors
                        Console.WriteLine($"Error deleting package '{SelectedPackage.Name}': {ex.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No Selected Package to delete");
            }
        }

        private void DeleteContent(string folderPath)
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
                Content deletedPackage = contents.FirstOrDefault(p => Path.Combine(ContentFolderPath, p.Name) == folderPath);
                if (deletedPackage != null)
                {
                    contents.Remove(deletedPackage);
                    Console.WriteLine($"Package '{deletedPackage.Name}' removed from the list.");
                }

                // Update the ContentList.txt
                string contentListFilePath = Book_Files.GetFileInFolder("ContentList.txt", Book_Files.ImportantFolders.Packages);
                Dictionary<string, string> contentNames = Book_Files.LoadParameters(contentListFilePath);
                if (contentNames.ContainsValue(deletedPackage.Name))
                {
                    string keyToRemove = contentNames.FirstOrDefault(x => x.Value == deletedPackage.Name).Key;
                    if (!string.IsNullOrEmpty(keyToRemove))
                    {
                        contentNames.Remove(keyToRemove);
                        Book_Files.WriteParameters(contentNames, contentListFilePath);
                        Console.WriteLine("Content list updated.");

                        // Remove from package manifests if needed
                        Book_Files.RemovePackage(contentNames, int.Parse(keyToRemove), ContentFolderPath);
                // Close the application before restarting
                Application.Exit();
                Application.Restart();
                    }
                    else
                    {
                        Console.WriteLine("Package key not found for the deleted content name.");
                    }
                }

            }
            catch (Exception ex)
            {
                // Handle errors
                Console.WriteLine($"Error deleting package folder '{folderPath}': {ex.Message}");
            }
        }
        private void DeletePackage(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Package file '{filePath}' not found.");
                return;
            }

            try
            {
                // Attempt to delete the package file
                //File.Delete(filePath);
                Console.WriteLine($"Package file '{filePath}' deleted.");

                // Remove the package from the list
                Package deletedPackage = packages.FirstOrDefault(p => p.Name == Path.GetFileNameWithoutExtension(filePath));

                if (deletedPackage != null)
                {
                    packages.Remove(deletedPackage);
                    Console.WriteLine($"Package '{deletedPackage.Name}' removed from the list.");
                }

                // Update the PackageList.txt
                string packageListFilePath = Book_Files.GetFileInFolder("PackageList.txt", Book_Files.ImportantFolders.Packages);
                Dictionary<string, string> packageNames = Book_Files.LoadParameters(packageListFilePath);
                if (packageNames.ContainsValue(deletedPackage.Name))
                {
                    string keyToRemove = packageNames.FirstOrDefault(x => x.Value == deletedPackage.Name).Key;
                    if (!string.IsNullOrEmpty(keyToRemove))
                    {
                        packageNames.Remove(keyToRemove);
                        Book_Files.WriteParameters(packageNames, packageListFilePath);
                        Console.WriteLine("Package list updated.");

                        // Remove from package manifests if needed
                        Book_Files.RemovePackage(packageNames, int.Parse(keyToRemove), PackageFolderPath);


                        File.Delete(filePath);
                // Close the application before restarting
                Application.Exit();
                Application.Restart();
                    }
                    else
                    {
                        Console.WriteLine("Package key not found for the deleted package name.");
                    }
                }

            }
            catch (Exception ex)
            {
                // Handle errors
                Console.WriteLine($"Error deleting package folder '{filePath}': {ex.Message}");
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
            if (SelectedPackage!=null)
            {
                installPack();
            }

            if(SelectedContent != null)
            {
                installCont(SelectedContent);
            }
        }

        void installPack()
        {

        }
        void installCont(Content Sel)
        {
            if (Sel != null)
            {
                // Get the path to the package folder
                string featurePacksFile = Path.Combine(ContentFolderPath, Sel.Name, "FeaturePacks", Sel.Name + ".upack");
                string featuresDestination = Path.Combine(UEpath, "FeaturePacks", Sel.Name + ".upack");

                string samplesFolder = Path.Combine(ContentFolderPath, Sel.Name, "Samples", Sel.Name);
                string destinationPath = Path.Combine(UEpath, "Samples", Sel.Name);


                if (File.Exists(featurePacksFile) && Directory.Exists(destinationPath))
                {
                    MessageBox.Show($"{Sel.Name} ready Installed");
                }
                else
                {
                    Console.WriteLine($"{ContentFolderPath} will be installed in \n {UEpath}");
                    try
                    {
                        // Copy files from FeaturePacks to destination
                        Book_Files.CopyFile(featurePacksFile, featuresDestination);
                        Console.WriteLine($"Copied '{Sel}.upackage' to '{featuresDestination}'.");

                        // Copy files from Samples to destination
                        Book_Files.CopyFolder(samplesFolder, destinationPath);
                        Console.WriteLine($"Copied '{Sel}.SamplePackage' to '{destinationPath}'.");


                        // Update package installation state in Preferences
                        Book_Files.UpdatePackageInstallationState(Sel.Name, true);
                    }
                    catch (Exception ex)
                    {
                        // Handle errors
                        Console.WriteLine($"Error installing package content: {ex.Message}");
                    }
                }
                checkInstallation();
            }
        }






        private void button2_Click(object sender, EventArgs e)
        {
            UninstallPackageFromEngine(SelectedContent);
        }

        private void UninstallPackageFromEngine(Content package)
        {
            if (package != null)
            {
                // Get the paths to the FeaturePacks and Samples in the engine directory
                string featurePacksPath = Path.Combine(UEpath, "FeaturePacks", SelectedContent.Name + ".upack");
                string samplesPath = Path.Combine(UEpath, "Samples", SelectedContent.Name);
                try
                {
                    // Delete FeaturePacks folder
                    if (File.Exists(featurePacksPath))
                    {
                        File.Delete(featurePacksPath);
                        Console.WriteLine($"FeaturePacks file for package '{package.Name}' deleted from the engine.");
                    }

                    // Delete Samples folder
                    if (Directory.Exists(samplesPath))
                    {
                        Directory.Delete(samplesPath, true);
                        Console.WriteLine($"Samples folder for package '{package.Name}' deleted from the engine.");
                    }

                    // Update package installation state in Preferences
                    Book_Files.UpdatePackageInstallationState(package.Name, false);
                }
                catch (Exception ex)
                {
                    // Handle errors
                    Console.WriteLine($"Error uninstalling package from engine: {ex.Message}");
                }
                checkInstallation();
            }
        }


        private void CheckDeletedPackages()
        {
            // Get the path to the package list file
            string packageListFilePath = Book_Files.GetFileInFolder("PackageList.txt", Book_Files.ImportantFolders.Packages);

            if (packageListFilePath != null)
            {
                try
                {
                    // Read the package list file to get the names of all packages
                    Dictionary<string, string> packageNames = Book_Files.LoadParameters(packageListFilePath);

                    // Create a list to store package numbers to be removed
                    List<string> packagesToRemove = new List<string>();

                    // Iterate through each package name
                    foreach (var kvp in packageNames)
                    {
                        
                        string packageFolderPath = Path.Combine(PrefencesData["PackagetCreationDirectory"], kvp.Value);

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
                    Book_Files.WriteParameters(packageNames, packageListFilePath);

                    // Remove the deleted packages from the package manifests
                    foreach (string packageNumber in packagesToRemove)
                    {
                        Book_Files.RemovePackage(packageNames, int.Parse(packageNumber), ContentFolderPath);
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

        private void CheckDeletedContents()
        {
            // Get the path to the package list file
            string contentListFilePath = Book_Files.GetFileInFolder("ContentList.txt", Book_Files.ImportantFolders.Packages);

            if (contentListFilePath != null)
            {
                try
                {
                    // Read the package list file to get the names of all packages
                    Dictionary<string, string> contentNames = Book_Files.LoadParameters(contentListFilePath);

                    // Create a list to store package numbers to be removed
                    List<string> contentToRemove = new List<string>();

                    // Iterate through each package name
                    foreach (var kvp in contentNames)
                    {

                        string contentFolderPath = Path.Combine(PrefencesData["ContentCreationDirectory"], kvp.Value);

                        // Check if the package folder exists
                        if (!Directory.Exists(contentFolderPath))
                        {
                            // Package folder does not exist, mark it for removal
                            contentToRemove.Add(kvp.Key);
                            Console.WriteLine($"Deleted package '{kvp.Value}' removed from the package list.");
                        }
                    }

                    // Remove deleted packages from the packageNames dictionary
                    foreach (string contentNumber in contentToRemove)
                    {
                        contentNames.Remove(contentNumber);
                    }

                    // Write the updated package list back to the file
                    Book_Files.WriteParameters(contentNames, contentListFilePath);

                    // Remove the deleted packages from the package manifests
                    foreach (string contentNumber in contentToRemove)
                    {
                        Book_Files.RemovePackage(contentNames, int.Parse(contentNumber), PackageFolderPath);
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
        private void UpdateContentList()
        {
            // Get the path to the package list file
            string contentListFilePath = Book_Files.GetFileInFolder("ContentList.txt", Book_Files.ImportantFolders.Packages);

            if (contentListFilePath != null)
            {
                try
                {
                    // Read the package list file to get the names of all packages
                    Dictionary<string, string> contentNames = Book_Files.LoadParameters(contentListFilePath);

                    // Remove the deleted package from the package list if selectedPackage is not null
                    if (SelectedContent != null && contentNames.ContainsKey(SelectedContent.Name))
                    {
                        contentNames.Remove(SelectedContent.Name);
                        // Write the updated package list back to the file
                        Book_Files.WriteParameters(contentNames, contentListFilePath);
                        Console.WriteLine("Package list updated.");

                        // Save the updated package list to the file
                        Book_Files.SaveParameters(contentListFilePath, contentNames);

                        Console.WriteLine("Package list updated.");
                    }

                    // Write the updated package list back to the file
                    Book_Files.WriteParameters(contentNames, contentListFilePath);
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
            string packageListFilePath = Book_Files.GetFileInFolder("PackageList.txt", Book_Files.ImportantFolders.Packages);

            if (packageListFilePath != null)
            {
                try
                {
                    // Read the package list file to get the names of all packages
                    Dictionary<string, string> packageNames = Book_Files.LoadParameters(packageListFilePath);

                    // Remove the deleted package from the package list if selectedPackage is not null
                    if (SelectedContent != null && packageNames.ContainsKey(SelectedContent.Name))
                    {
                        packageNames.Remove(SelectedContent.Name);
                        // Write the updated package list back to the file
                        Book_Files.WriteParameters(packageNames, packageListFilePath);
                        Console.WriteLine("Package list updated.");

                        // Save the updated package list to the file
                        Book_Files.SaveParameters(packageListFilePath, packageNames);

                        Console.WriteLine("Package list updated.");
                    }

                    // Write the updated package list back to the file
                    Book_Files.WriteParameters(packageNames, packageListFilePath);
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




        private void uContentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UPackageInstaller uPackageInstaller = new UPackageInstaller();
            uPackageInstaller.Show();
        }

        private void unrealPackageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnrealPackageCreator unrealPackageCreator = new UnrealPackageCreator();
            unrealPackageCreator.Show();
        }

        private void DevWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(DevWebsite.Text);
        }
    }

    public class Content
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public string Thumbnail { get; set; }
        public string Version { get; set; }
        public string UEVersion { get; set; }
        public string DevName{ get; set; }
        public string DevWebsite { get; set; }
        // Add more properties as needed
    }

    public class Package
    {
        public string Name { get; set; }
    }




}
