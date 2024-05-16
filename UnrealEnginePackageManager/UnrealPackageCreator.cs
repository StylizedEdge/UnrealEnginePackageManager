using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnrealEnginePackageManager
{
    public partial class UnrealPackageCreator : Form
    {
        string PreferenceData;
        Dictionary<string, string> preferenceRawData;
        public UnrealPackageCreator()
        {
            InitializeComponent();


            PreferenceData = Book_Files.GetFileInFolder("Preferences.dll", Book_Files.ImportantFolders.Resources);
            preferenceRawData = Book_Files.LoadParameters(PreferenceData);
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
            if (!string.IsNullOrEmpty(filespackText.Text) && !string.IsNullOrEmpty(PackagePathText.Text))
            {
                string zipFilePath = Path.Combine(preferenceRawData["PKGCreationDirectory"], "test.Unrealpackage");
                Book_Rar.CompressFilesWithPassword(new string[] { SourceFiles }, zipFilePath);

                // Wait until all files are extracted
                while (!Book_Rar.AreAllFilesExtracted(zipFilePath, preferenceRawData["PKGCreationDirectory"]))
                {
                    // You can optionally add a delay here to avoid excessive CPU usage
                    // Thread.Sleep(100); // Sleep for 100 milliseconds
                }

                // All files have been extracted
                MessageBox.Show("Extraction completed!");
                Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (File.Exists(PreferenceData))
            {
                PackagePathText.Text = preferenceRawData["PKGCreationDirectory"];
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
