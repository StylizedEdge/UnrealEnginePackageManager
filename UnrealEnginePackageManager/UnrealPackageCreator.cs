using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnrealEnginePackageManager
{
    public partial class UnrealPackageCreator : Form
    {
        string PreferenceData;
        Dictionary<string, string> preferenceRawData;


        private BackgroundWorker backgroundWorker;
        public UnrealPackageCreator()
        {
            InitializeComponent();


            PreferenceData = Book_Files.GetFileInFolder("Preferences.dll", Book_Files.ImportantFolders.Resources);
            preferenceRawData = Book_Files.LoadParameters(PreferenceData);


            // Initialize the background worker
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
        }





        string SourceFiles = "";


        private void UEVersions_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Method intentionally left empty.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Method intentionally left empty.
        }

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

        private void CreatePackageButton(object sender, EventArgs e)
        {
            if (Directory.Exists(Path.Combine(preferenceRawData["EnginesPath"], preferenceRawData["SelectedVersionPath"])))
            {
                string packageListFilePath = Book_Files.GetFileInFolder("PackageList.txt", Book_Files.ImportantFolders.Packages);
                Dictionary<string, string> packageNames = Book_Files.LoadParameters(packageListFilePath);

                Book_Files.AddPackage(packageNames, packnameText.Text, packageListFilePath);
                CreatePackage();
            }
            else
            {
                MessageBox.Show("Unreal Engine version Selected \nisn't installed, Check the settings");
                Close();
            }
        }

        private void CreatePackage()
        {
            if (!string.IsNullOrEmpty(filespackText.Text) && !string.IsNullOrEmpty(PackagePathText.Text))
            {
                // Start the background worker
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int totalDuration = 10000; // Total duration in milliseconds (example: 10 seconds)
            int interval = 100; // Interval in milliseconds for each progress update
            string zipFilePath = Path.Combine(preferenceRawData["PackageCreationDirectory"], packnameText.Text + ".UnrealPackage");

            // Simulate the file creation if it doesn't already exist
            if (!File.Exists(zipFilePath))
            {
                Book_Rar.CompressFilesWithPassword(new string[] { SourceFiles }, zipFilePath);
            }

            int elapsed = 0;
            while (elapsed < totalDuration)
            {
                // Calculate progress percentage
                int progress = (int)((elapsed / (float)totalDuration) * 100);
                backgroundWorker.ReportProgress(progress);

                // Check if the file exists
                if (File.Exists(zipFilePath))
                {
                    // Report progress as 100% if the file exists and break the loop
                    backgroundWorker.ReportProgress(100);
                    break;
                }

                // Wait for the interval
                Thread.Sleep(interval);
                elapsed += interval;
            }

            // Ensure the progress reaches 100% at the end
            if (elapsed >= totalDuration)
            {
                backgroundWorker.ReportProgress(100);
            }

            // Store the result
            e.Result = "Package creation completed!";
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            this.copyPercentageLabel.Text = $"Progress: {e.ProgressPercentage}%";
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show(e.Result.ToString());
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (File.Exists(PreferenceData))
            {
                PackagePathText.Text = preferenceRawData["PackageCreationDirectory"];
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
