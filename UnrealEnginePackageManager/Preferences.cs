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
        string UEpath = "C:\\Program Files\\Epic Games\\UE_4.27\\Engine\\Binaries\\Win64";
        string DefaultPackageCreationDirectory = MethodBook.GetFolderInFolder("Packages",MethodBook.ImportantFolders.Packages);


        string PreferencePath = "Preferences.dll";
        public Preferences()
        {
            InitializeComponent();

            // Load the parameters from the text file
            var loadedParameters = MethodBook.LoadParameters(MethodBook.GetFileInFolder(PreferencePath, MethodBook.ImportantFolders.Resources));

            Console.WriteLine("Preferences Loaded from file!");
            UEPathText.Text = loadedParameters["UnrealEnginePreferedVersionPath"];
            if (loadedParameters["PackageCreationDirectory"] != null)
            {
                pkgCreationDir.Text = loadedParameters["PackageCreationDirectory"];
            }
            else
            {
                pkgCreationDir.Text = DefaultPackageCreationDirectory;
            }
            Autopkg.Checked = Convert.ToBoolean(loadedParameters["AutoInstallPackages"]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Define some parameters to save
            var parametersToSave = new Dictionary<string, string>
        {
            { "UnrealEnginePreferedVersionPath", UEpath },
            { "AutoInstallPackages", Autopkg.Checked.ToString() },
            { "PackageCreationDirectory", pkgCreationDir.Text }
        };

            // Save the parameters to the text file
            MethodBook.SaveParameters(MethodBook.GetFileInFolder(PreferencePath, MethodBook.ImportantFolders.Resources), parametersToSave);
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
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
