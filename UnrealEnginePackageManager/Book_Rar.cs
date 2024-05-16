// Ignore Spelling: Rar Json

namespace UnrealEnginePackageManager
{
    using Ionic.Zip;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using SharpCompress.Archives.Zip;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Windows.Forms;

    public class Book_Rar
    {
        public static void ExtractRar(string rarFilePath, string destinationPath)
        {
            // Ensure the destination directory exists
            if (!Directory.Exists(destinationPath))
            {
                Directory.CreateDirectory(destinationPath);
            }

            // Open the RAR archive and extract all entries
            using (var archive = ZipFile.Read(rarFilePath))
            {
                foreach (var entry in archive)
                {
                    if (entry.IsDirectory)
                    {
                        // Create empty directories in the destination path
                        string dirPath = Path.Combine(destinationPath, entry.FileName);
                        Directory.CreateDirectory(dirPath);
                    }
                    else
                    {
                        // Extract files and ensure parent directories are created
                        string outputFilePath = Path.Combine(destinationPath, entry.FileName);
                        Directory.CreateDirectory(Path.GetDirectoryName(outputFilePath));

                        entry.Extract(destinationPath, ExtractExistingFileAction.OverwriteSilently);
                    }
                }
            }
        }

        public static void CreateZip(string[] sourcePaths, string zipFilePath)
        {
            using (ZipFile zip = new ZipFile())
            {
                foreach (var sourcePath in sourcePaths)
                {
                    // Ensure the source directory exists
                    if (!Directory.Exists(sourcePath))
                    {
                        throw new DirectoryNotFoundException($"Source directory not found: {sourcePath}");
                    }

                    // Add all files and directories from the source path to the ZIP archive
                    foreach (var file in Directory.EnumerateFiles(sourcePath, "*", SearchOption.AllDirectories))
                    {
                        try
                        {
                            // Check if the file is in use by another process
                            using (FileStream fs = File.Open(file, FileMode.Open, FileAccess.Read, FileShare.None))
                            {
                                // If the file is not in use, add it to the ZIP archive
                                string relativePath = Book_Files.GetRelativePath(sourcePath, file);
                                zip.AddFile(file, relativePath);
                            }
                        }
                        catch (IOException ex)
                        {
                            // Handle the case where the file is in use by another process
                            Console.WriteLine($"Error: Unable to add '{file}' to the ZIP archive. File is in use by another process.");
                            Console.WriteLine($"IOException: {ex.Message}");
                            // You can choose to skip this file or handle it differently based on your requirements
                        }
                    }

                    // Optionally, delete the source directory after adding all files to the archive
                    // Directory.Delete(sourcePath, true);
                }

                // Save the ZIP archive to the specified file path
                zip.Save(zipFilePath);
            }
        }

        public static void ExtractFileFromRar(string rarFilePath, string destinationPath, string fileName)
        {
            // Open the RAR archive
            using (var archive = ZipArchive.Open(rarFilePath))
            {
                var entry = archive.Entries.FirstOrDefault(e => e.Key.Equals(fileName, StringComparison.OrdinalIgnoreCase));
                if (entry != null)
                {
                    // Ensure the destination directory exists
                    if (!Directory.Exists(destinationPath))
                    {
                        Directory.CreateDirectory(destinationPath);
                    }

                    // Extract the file
                    string outputFilePath = Path.Combine(destinationPath, entry.Key);
                    using (var entryStream = entry.OpenEntryStream())
                    using (var outputStream = File.Create(outputFilePath))
                    {
                        entryStream.CopyTo(outputStream);
                    }
                }
                else
                {
                    throw new FileNotFoundException($"File '{fileName}' not found in the RAR archive.");
                }
            }
        }

        public static List<string> ListFilesInArchive(string archiveFilePath)
        {
            List<string> fileList = new List<string>();

            // Open the archive
            using (var archive = ZipArchive.Open(archiveFilePath))
            {
                foreach (var entry in archive.Entries)
                {
                    fileList.Add(entry.Key);
                }
            }

            return fileList;
        }

        // Function to compress files with password
        public static void CompressFilesWithPassword(string[] filePaths, string zipFilePath)
        {
            using (ZipFile zip = new ZipFile())
            {
                // Set encryption method and password for the zip file
                zip.Encryption = EncryptionAlgorithm.WinZipAes256;
                zip.Password = "181944841827";

                // Add files to the zip archive
                foreach (string filePath in filePaths)
                {
                    if (File.Exists(filePath))
                    {
                        zip.AddFile(filePath, "");
                    }
                    else if (Directory.Exists(filePath))
                    {
                        zip.AddDirectory(filePath, Path.GetFileName(filePath));
                    }
                    else
                    {
                        throw new FileNotFoundException($"File or directory not found: {filePath}");
                    }
                }

                // Save the zip file
                zip.Save(zipFilePath);
            }
        }

        //Function to extract files
        public static void ExtractFilesWithPassword(string zipFilePath, string extractPath)
        {
            using (ZipFile zip = ZipFile.Read(zipFilePath))
            {
                // Set password for the zip file
                zip.Password = "181944841827";

                // Extract files to the specified directory
                foreach (ZipEntry entry in zip)
                {
                    entry.Extract(extractPath, ExtractExistingFileAction.OverwriteSilently);
                }
            }
        }
        public static bool AreAllFilesExtracted(string zipFilePath, string DestPath)
        {
            // Check if all files are extracted by verifying their existence
            string extractionPath = Path.Combine(DestPath, "ExtractionFolder");
            if (Directory.Exists(extractionPath))
            {
                // Get all files in the extraction folder
                string[] extractedFiles = Directory.GetFiles(extractionPath, "*", SearchOption.AllDirectories);

                // Get the count of files in the zip archive
                using (ZipFile zip = ZipFile.Read(zipFilePath))
                {
                    int totalFilesInArchive = zip.Count;

                    // Check if all files have been extracted
                    return extractedFiles.Length >= totalFilesInArchive;
                }
            }
            else
            {
                // Extraction folder does not exist yet, so not all files are extracted
                return false;
            }
        }
    }
}
