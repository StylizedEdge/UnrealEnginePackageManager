using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnrealEnginePackageManager
{
    public partial class Preferences : Form
    {

        string DefaultPackageCreationDirectory = Book_Files.GetFolderInFolder("Packages",Book_Files.ImportantFolders.Packages);
        string PreferencePath = "Preferences.dll";
        public Preferences()
        {
            InitializeComponent();

            // Load the parameters from the text file
            var loadedParameters = Book_Files.LoadParameters(Book_Files.GetFileInFolder(PreferencePath, Book_Files.ImportantFolders.Resources));

            Console.WriteLine("Preferences Loaded from file!");

            EnginesPath.Text = loadedParameters["EnginesPath"];
            pkgCreationDir.Text = loadedParameters["PKGCreationDirectory"];
            UESelectedVersion.SelectedItem = loadedParameters["SelectedVersionPath"];
            if (loadedParameters["PackageCreationDirectory"] != null)
            {
                CntCreationDir.Text = loadedParameters["PackageCreationDirectory"];
            }
            else
            {
                CntCreationDir.Text = DefaultPackageCreationDirectory;
            }
            Autopkg.Checked = Convert.ToBoolean(loadedParameters["AutoInstallPackages"]);
        }

        //Apply All Settings
        private void SaveAppliedSettings(object sender, EventArgs e)
        {
            // Define some parameters to save
            var parametersToSave = new Dictionary<string, string>
        {
                {"EnginesPath","C:\\Program Files\\Epic Games\\" },
            { "SelectedVersionPath", UESelectedVersion.Text },
            { "AutoInstallPackages", Autopkg.Checked.ToString() },
            { "PackageCreationDirectory", CntCreationDir.Text },
            { "PKGCreationDirectory", pkgCreationDir.Text }
        };

            // Save the parameters to the text file
            Book_Files.SaveParameters(Book_Files.GetFileInFolder(PreferencePath, Book_Files.ImportantFolders.Resources), parametersToSave);
            Close();
        }


        private void GetContentCreationPath(object sender, EventArgs e)
        {
            string dir = Book_Files.GetFolderInFolder("Packages", Book_Files.ImportantFolders.Packages);
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.ValidateNames = false;
                openFileDialog.CheckFileExists = false; // Avoid validation
                openFileDialog.CheckPathExists = true;
                openFileDialog.FileName = "Select Pack folder"; // A trick to select folders
                openFileDialog.InitialDirectory = dir;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected path (folder) and display it in the textbox
                    string selectedPath = System.IO.Path.GetDirectoryName(openFileDialog.FileName);

                    if (Directory.Exists(selectedPath))
                    {
                        CntCreationDir.Text = selectedPath;
                    }
                }
            }
        }

        private void GetPackageCreationPath(object sender, EventArgs e)
        {
            string dir = Book_Files.GetFolderInFolder("Packages", Book_Files.ImportantFolders.Packages);
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.ValidateNames = false;
                openFileDialog.CheckFileExists = false; // Avoid validation
                openFileDialog.CheckPathExists = true;
                openFileDialog.FileName = "Select Pack folder"; // A trick to select folders
                openFileDialog.InitialDirectory = dir;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected path (folder) and display it in the textbox
                    string selectedPath = System.IO.Path.GetDirectoryName(openFileDialog.FileName);

                    if (Directory.Exists(selectedPath))
                    {
                        pkgCreationDir.Text = selectedPath;
                    }
                }
            }
        }
    }
}
