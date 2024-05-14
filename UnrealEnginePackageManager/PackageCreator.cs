using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Packaging;
using System.Threading;
using System.Windows.Forms;
using static UnrealEnginePackageManager.MethodBook;



namespace UnrealEnginePackageManager
{
    public partial class PackageCreator : Form
    {
        string selectedPath = "";
        string ThumbPath = "";
        string ScreenShotPath = "";

        string SamplesFilesPathContent = "";
        string SourceFiles = "";


        public PackageCreator()
        {
            InitializeComponent();

            this.backgroundWorker = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };

            this.backgroundWorker.DoWork += BackgroundWorker_DoWork;
            this.backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            this.backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
        }


        #region Files Transfer
        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;
            var args = e.Argument as string[];

            CopyFolderWithProgress(worker, SourceFiles, SamplesFilesPathContent, 4);
        }
        

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            this.copyPercentageLabel.Text = $"Copy progress: {e.ProgressPercentage}%";
            this.currentFileLabel.Text = $"Current file: {e.UserState}";


            //LauchUnrealEngine Path
            string CMDcommand = $"\"C:\\Program Files\\Epic Games\\UE_4.27\\Engine\\Binaries\\Win64\\UnrealPak.exe\" -Create=\"{selectedPath}\\{packnameText.Text}\\ContentToPack.txt\" \"{selectedPath}\\{packnameText.Text}\\FeaturePacks\\{packnameText.Text}.upack\"\n@pause";



            if (e.ProgressPercentage >= 96)
            {
                File.WriteAllText(Path.Combine(selectedPath, packnameText.Text, "UnrealComand.bat"), CMDcommand);
                Process.Start(Path.Combine(selectedPath, packnameText.Text, "UnrealComand.bat"));
                MessageBox.Show("AssetPack Created!");
                Close();
            }
            MethodBook.UpdatePackageInstallationState(packnameText.Text, false);
            if(AreFilesDoneCopying(SourceFiles, SamplesFilesPathContent) == true)
            {
                Console.WriteLine("Files Done Copying");
            }
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.copyPercentageLabel.Text = "Copy completed.";
            this.currentFileLabel.Text = string.Empty;
        }

        #endregion

        #region Extract ContentPack from Resource Folder
        private void button1_Click(object sender, EventArgs e)
        {
            string dir = MethodBook.GetFolderInFolder("Packages", MethodBook.ImportantFolders.Packages);
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.ValidateNames = false;
                openFileDialog.CheckFileExists = false; // Avoid validation
                openFileDialog.CheckPathExists = true;
                openFileDialog.FileName = "Select Pack folder"; // A trick to select folders
                openFileDialog.InitialDirectory = dir;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected path (folder) and display it in the text box
                    selectedPath = System.IO.Path.GetDirectoryName(openFileDialog.FileName);
                    PackagePathText.Text = selectedPath;


                    if (Directory.Exists(selectedPath))
                    {
                        pathassignedChecker.Checked = true;
                        pathemptyChecker.Checked = !MethodBook.IsFolderEmpty(selectedPath);

                        MethodBook.ExtractRar(GetFileInFolder("ContentPack.dll", MethodBook.ImportantFolders.Resources), selectedPath);

                        if (Directory.Exists(Path.Combine(selectedPath, packnameText.Text)))
                        {
                            systempFilesChecker.Checked = true;
                        }
                    }
                }
            }
        }
        #endregion

        #region Package Creation
        private void button4_Click(object sender, EventArgs e)
        {

            string packageListFilePath = MethodBook.GetFileInFolder("PackageList.txt", MethodBook.ImportantFolders.Packages);
            Dictionary<string, string> packageNames = MethodBook.LoadParameters(packageListFilePath);
            AddPackage(packageNames, packnameText.Text,packageListFilePath);
            
            CreatePack();
        }

        void CreatePack()
        {
            AssignPackageDestinationName();
        }


        void AssignPackageDestinationName()
        {
            //Assign the pack Folder
            if (packnameText.Text != null)
            {
                if (Directory.Exists(selectedPath + "\\" + packnameText.Text))
                {
                    AssignPackageJsonIni();

                    if (!backgroundWorker.IsBusy)
                    {
                        string sourceFolder = SourceFiles;
                        string destinationFolder = SamplesFilesPathContent;

                        // Pass the source and destination to the worker
                        backgroundWorker.RunWorkerAsync(new string[] { sourceFolder, destinationFolder });
                    }

                    string contentToPack = $"\"{selectedPath}\\{packnameText.Text}\\ContentSettings\\Config\\\"\r\n\"{selectedPath}\\{packnameText.Text}\\ContentSettings\\Media\\\"\r\n\"{selectedPath}\\{packnameText.Text}\\ContentSettings\\manifest.json\"";
                    File.WriteAllText(selectedPath + $"\\{packnameText.Text}\\ContentToPack.txt", contentToPack);
                }
            }
        }

        void AssignPackageJsonIni()
        {
            //Config.ini file
            MethodBook.WriteText(selectedPath + $"\\{packnameText.Text}\\ContentSettings\\Config\\config.ini", $"[AdditionalFilestoAdd]\n+Files=Samples\\{packnameText.Text}\\Content\\*.*");
            string filePath = selectedPath + $"\\{packnameText.Text}\\ContentSettings\\manifest.json";


            //Manifest Parameters
            // Read the JSON file
            string jsonContent = File.ReadAllText(filePath);

            // Parse the JSON content to a JObject
            JObject jsonObject = JObject.Parse(jsonContent);



            jsonObject["Version"] = versiontext.Text;
            jsonObject["UEVersion"] = UEVersions.Text;


            JObject newTag = new JObject
{
    { "Language", "eng" },
    { "Text", tagText.Text }
};

            JObject newName = new JObject
{
    { "Language", "eng" },
    { "Text", packnameText.Text }
};

            JObject newDescription = new JObject
{
    { "Language", "eng" },
    { "Text", descriptionText.Text }
};

            //New name
            ((JArray)jsonObject["Name"]).Clear();
            ((JArray)jsonObject["Name"]).Add(newName);

            //New Description
            ((JArray)jsonObject["Description"]).Clear();
            ((JArray)jsonObject["Description"]).Add(newDescription);


            //Search tag
            ((JArray)jsonObject["SearchTags"]).Clear();
            ((JArray)jsonObject["SearchTags"]).Add(newTag);

            //Category
            jsonObject["Category"] = categorytext.Text;

            //thumbnail
            if (ThumbPath != null)
            {
                jsonObject["Thumbnail"] = Path.GetFileName(ThumbdestinationPath);
            }


                //Screenshot
                ((JArray)jsonObject["Screenshots"]).Clear();
            ((JArray)jsonObject["Screenshots"]).Add(Path.GetFileName(ScreenshotdestinationPath));

            // Write the modified JSON back to the file
            File.WriteAllText(filePath, jsonObject.ToString());

        }



#endregion

        #region Thumbnail and Screenshots
        //Thumbnail button click function
        private void thumbnailImage_Click(object sender, EventArgs e)
        {
            // Create and configure the OpenFileDialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select an Image";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                // Show the file dialog and get the selected file
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Resize the selected image to 64x64
                    Image selectedImage = ResizeImage(Image.FromFile(openFileDialog.FileName), new Size(64, 64));

                    // Get the file name from the selected file path
                    string fileName = Path.GetFileName(openFileDialog.FileName);

                    // Save the resized image to the same directory as the selected file
                    string imagePath = Path.Combine(selectedPath, fileName);
                    selectedImage.Save(imagePath);

                    // Display the resized image in the thumbnail box
                    thumbnailImage.Image = selectedImage;

                    // Copy the resized image to the destination directory
                    ThumbdestinationPath  = Path.Combine(selectedPath, packnameText.Text, "ContentSettings", "Media", fileName);
                    MethodBook.CopyFile(imagePath, ThumbdestinationPath, false);

                    Console.WriteLine("Thumbnail File Selected, resized, and copied to the Working directory");
                }
            }
        }
        string ThumbdestinationPath;
        string ScreenshotdestinationPath;

        //Screenshot button click function

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Create and configure the OpenFileDialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select an Image";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                // Show the file dialog and get the selected file
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Resize the selected image to 64x64
                    Image selectedImage = ResizeImage(Image.FromFile(openFileDialog.FileName), new Size(400, 200));

                    // Get the file name from the selected file path
                    string fileName = Path.GetFileName(openFileDialog.FileName);

                    // Save the resized image to the same directory as the selected file
                    string imagePath = Path.Combine(selectedPath, fileName);
                    selectedImage.Save(imagePath);

                    // Display the resized image in the ScreenshotImage PictureBox
                    ScreenshotImage.Image = selectedImage;

                    // Construct the destination path for copying the image to the destination directory
                    ScreenshotdestinationPath = Path.Combine(selectedPath, packnameText.Text, "ContentSettings", "Media", fileName);

                    // Copy the resized image to the destination directory
                    MethodBook.CopyFile(imagePath, ScreenshotdestinationPath, false);

                    Console.WriteLine("Screen Shot Image Selected, resized, and copied to the Working directory");
                }
            }
        }
        #endregion

        #region Package Renaming process

        private void button5_Click(object sender, EventArgs e)
        {
            string packageFolderPath = Path.Combine(MethodBook.GetFolderInFolder("Packages", ImportantFolders.Packages), packnameText.Text);
            string DefaultContent = Path.Combine(MethodBook.GetFolderInFolder("Packages", ImportantFolders.Packages), "ContentPack");
            // Delete Samples folder
            if (Directory.Exists(packageFolderPath))
            {
                Directory.Delete(packageFolderPath, true);
                Console.WriteLine($"Package Creation Canceled, Temporary Files deleted");
            }else if(Directory.Exists(DefaultContent))
            {
                Directory.Delete(DefaultContent,true);
                Console.WriteLine("package Creation Canceled, temporary Files deleted");
            }
            this.Close();
        }

        string oldFolderPath;
        string newFolderPath;


        private void button2_Click(object sender, EventArgs e)
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
                    SourceFiles = System.IO.Path.GetDirectoryName(openFileDialog.FileName);
                    filespackText.Text = openFileDialog.FileName;
                    Console.WriteLine("Unreal Files selected");
                }
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
            // Define the old and new folder paths
            oldFolderPath = Path.Combine(selectedPath, "ContentPack");
            newFolderPath = Path.Combine(selectedPath, packnameText.Text);

            // Rename ContentPack folder if it exists
            if (Directory.Exists(oldFolderPath))
            {
                MethodBook.RenameFolder(oldFolderPath, newFolderPath);
                oldFolderPath = newFolderPath;
            }

            // Define the old and new paths for the Samples folder
            string samplesFolderOldPath = Path.Combine(selectedPath, "ContentPack", "Samples", "Pack_Name");
            string samplesFolderNewPath = Path.Combine(selectedPath, packnameText.Text, "Samples", packnameText.Text);

            // Rename the Samples folder if it exists
            if (Directory.Exists(samplesFolderOldPath))
            {
                samplesFolderOldPath = samplesFolderNewPath;
                MethodBook.RenameFolder(samplesFolderOldPath, samplesFolderNewPath);
            }else if(Directory.Exists(Path.Combine(selectedPath, packnameText.Text, "Samples", "Pack_Name")))
            {
                samplesFolderOldPath = samplesFolderNewPath;
                MethodBook.RenameFolder(Path.Combine(selectedPath, packnameText.Text, "Samples", "Pack_Name"), samplesFolderNewPath);
            }

            // Update the SamplesFilesPathContent
            // Log the new path
            Console.WriteLine(samplesFolderNewPath);
            Console.WriteLine("Old path is now the new path");
            SamplesFilesPathContent = Path.Combine(samplesFolderNewPath, "Content", "UEPackageManager");

            button3.Enabled = false;
            packnameText.Enabled = false;
        }
#endregion
    }
}
