﻿using System;
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
    public partial class UPackageInstaller : Form
    {
        //Variables
        UnrealEnginePackageManager manager;
        string filePath = "";
        string DesPAth = "";



        public UPackageInstaller()
        {
            InitializeComponent();

            this.button1.DragDrop += new DragEventHandler(button1_DragDrop);
            this.button1.DragDrop += new DragEventHandler(button1_DragEnter);

            this.button2.DragDrop += new DragEventHandler(button2_DragDrop);
            this.button2.DragDrop += new DragEventHandler(button2_DragEnter);


            manager = new UnrealEnginePackageManager();
        }

        private void button2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void button2_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
            {
                button2.Text = Path.GetFileNameWithoutExtension(s[i]);
                des.Text = "Destination :" + s[i];
                DesPAth = s[i];
            }
        }

        private void button1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void button1_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop,false);
            int i;
            for(i = 0; i < s.Length; i++)
            {
                filePath = s[i];
                double size = Book_Files.GetFileSizeInMegabytes(filePath);
                pkgSize.Text = "Package Size :" + size + "MB";
                button1.Text = Path.GetFileNameWithoutExtension(filePath);
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            // Open file dialog to select a .UnrealPackage file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "UnrealPackage files (*.UnrealPackage)|*.UnrealPackage|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.InitialDirectory = manager.PackageFolderPath;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                filePath = openFileDialog.FileName;

                if (File.Exists(filePath))
                {
                    double size = Book_Files.GetFileSizeInMegabytes(filePath);
                    pkgSize.Text = "Package Size :" + size + "MB";
                    button1.Text = Path.GetFileNameWithoutExtension(filePath);
                }
            }
        }

        public void QuickInstallation(string fPath)
        {
            filePath = fPath;
            double size = Book_Files.GetFileSizeInMegabytes(fPath);
            pkgSize.Text = "Package Size :" + size + "MB";
            button1.Text = Path.GetFileNameWithoutExtension(fPath);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    // Use dialog.SelectedPath to access the selected folder path
                    string selectedFolderPath = dialog.SelectedPath;
                    DesPAth = dialog.SelectedPath;
                    des.Text = "Destination :" +  selectedFolderPath;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Import
            if (Directory.Exists(DesPAth))
            {
                Book_Rar.ExtractFilesWithPassword(filePath, DesPAth);
                MessageBox.Show("Package Extracted!");
                Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DetectOpennedEditor();
        }

        private void DetectOpennedEditor()
        {
            var processes = Process.GetProcessesByName("UE4Editor");
            foreach (var process in processes)
            {
                string commandLine = Book_Unreal.GetCommandLine(process);
                MessageBox.Show($"Process ID: {process.Id}, Command Line: {commandLine}");

                // Extract the .uproject path from the command line
                string projectPath = Book_Unreal.ExtractProjectPath(commandLine);
                if (!string.IsNullOrEmpty(projectPath))
                {
                    // Derive the content directory path from the .uproject path
                    string contentPath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(projectPath), "Content");
                    // Display the results
                    MessageBox.Show($"Unreal Engine project path: {projectPath}\nContent directory: {contentPath}", "Project Path Detected");
                    // Use dialog.SelectedPath to access the selected folder path
                    string selectedFolderPath = contentPath;
                    button2.Text = Path.GetFileNameWithoutExtension(contentPath);
                    des.Text = "Destination :" + contentPath;
                    DesPAth = contentPath;


                    Console.Write(contentPath);
                    break; // Stop after finding the first valid project path
                }
            }

            if (processes == null)
            {
                MessageBox.Show("Open an Unreal project then try again!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Console.WriteLine(filePath);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Console.WriteLine(DesPAth);
        }
    }
}
