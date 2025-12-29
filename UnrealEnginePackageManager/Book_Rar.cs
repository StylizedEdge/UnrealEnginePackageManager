// Ignore Spelling: Rar Json
namespace UnrealEnginePackageManager
{
    using ICSharpCode.SharpZipLib.Zip;
    using ICSharpCode.SharpZipLib.Core;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Book_Rar  // Keep the name or rename to Book_Zip if you want 😏
    {
        private const string FixedPassword = "181944841827";

        public static void ExtractRar(string rarFilePath, string destinationPath)
        {
            if (!Directory.Exists(destinationPath))
                Directory.CreateDirectory(destinationPath);

            string fullDest = Path.GetFullPath(destinationPath);

            using (ZipFile zip = new ZipFile(rarFilePath))
            {
                foreach (ZipEntry entry in zip)
                {
                    if (entry.IsFile)
                    {
                        string targetPath = Path.Combine(destinationPath, entry.Name);
                        string fullTarget = Path.GetFullPath(targetPath);

                        if (!fullTarget.StartsWith(fullDest + Path.DirectorySeparatorChar))
                            throw new IOException($"Zip slip blocked: {entry.Name}");

                        Directory.CreateDirectory(Path.GetDirectoryName(fullTarget));

                        using (Stream input = zip.GetInputStream(entry))
                        using (FileStream output = File.Create(fullTarget))
                        {
                            input.CopyTo(output);
                        }
                    }
                }
            }
        }

        public static void CreateZip(string[] sourcePaths, string zipFilePath)
        {
            using (FileStream fs = File.Create(zipFilePath))
            using (ZipOutputStream zip = new ZipOutputStream(fs))
            {
                zip.SetLevel(9);
                byte[] buffer = new byte[4096];

                foreach (var sourcePath in sourcePaths)
                {
                    if (!Directory.Exists(sourcePath))
                        throw new DirectoryNotFoundException($"Source directory not found: {sourcePath}");

                    foreach (var file in Directory.EnumerateFiles(sourcePath, "*", SearchOption.AllDirectories))
                    {
                        try
                        {
                            using (FileStream test = File.Open(file, FileMode.Open, FileAccess.Read, FileShare.None)) { }
                        }
                        catch (IOException)
                        {
                            Console.WriteLine($"Skipping in-use file: {file}");
                            continue;
                        }

                        string relativePath = Book_Files.GetRelativePath(sourcePath, file);
                        ZipEntry entry = new ZipEntry(ZipEntry.CleanName(relativePath));
                        entry.DateTime = File.GetLastWriteTime(file);
                        zip.PutNextEntry(entry);

                        using (FileStream input = File.OpenRead(file))
                        {
                            StreamUtils.Copy(input, zip, buffer);
                        }

                        zip.CloseEntry();
                    }
                }
            }
        }

        public static void ExtractFileFromRar(string rarFilePath, string destinationPath, string fileName)
        {
            string fullDest = Path.GetFullPath(destinationPath);

            using (ZipFile zip = new ZipFile(rarFilePath))
            {
                ZipEntry entry = zip.GetEntry(fileName)
                    ?? zip.Cast<ZipEntry>().FirstOrDefault(e => string.Equals(e.Name, fileName, StringComparison.OrdinalIgnoreCase));

                if (entry == null)
                    throw new FileNotFoundException($"File '{fileName}' not found in archive.");

                string targetPath = Path.Combine(destinationPath, entry.Name);
                string fullTarget = Path.GetFullPath(targetPath);

                if (!fullTarget.StartsWith(fullDest + Path.DirectorySeparatorChar))
                    throw new IOException($"Zip slip blocked: {entry.Name}");

                Directory.CreateDirectory(Path.GetDirectoryName(fullTarget));

                using (Stream input = zip.GetInputStream(entry))
                using (FileStream output = File.Create(fullTarget))
                {
                    input.CopyTo(output);
                }
            }
        }

        public static List<string> ListFilesInArchive(string archiveFilePath)
        {
            List<string> fileList = new List<string>();

            using (ZipFile zip = new ZipFile(archiveFilePath))
            {
                foreach (ZipEntry entry in zip)
                {
                    fileList.Add(entry.Name);
                }
            }

            return fileList;
        }

        public static void CompressFilesWithPassword(string[] filePaths, string zipFilePath)
        {
            using (FileStream fs = File.Create(zipFilePath))
            using (ZipOutputStream zip = new ZipOutputStream(fs))
            {
                zip.SetLevel(9);
                zip.Password = FixedPassword;

                byte[] buffer = new byte[4096];

                foreach (string filePath in filePaths)
                {
                    if (File.Exists(filePath))
                    {
                        ZipEntry entry = new ZipEntry(Path.GetFileName(filePath));
                        entry.DateTime = File.GetLastWriteTime(filePath);
                        entry.AESKeySize = 256;  // Forces WinZip AES-256

                        zip.PutNextEntry(entry);

                        using (FileStream input = File.OpenRead(filePath))
                        {
                            StreamUtils.Copy(input, zip, buffer);
                        }

                        zip.CloseEntry();
                    }
                    else if (Directory.Exists(filePath))
                    {
                        string dirName = Path.GetFileName(filePath);
                        foreach (var file in Directory.EnumerateFiles(filePath, "*", SearchOption.AllDirectories))
                        {
                            string relative = dirName + "/" + Book_Files.GetRelativePath(filePath, file);
                            ZipEntry entry = new ZipEntry(ZipEntry.CleanName(relative));
                            entry.DateTime = File.GetLastWriteTime(file);
                            entry.AESKeySize = 256;

                            zip.PutNextEntry(entry);

                            using (FileStream input = File.OpenRead(file))
                            {
                                StreamUtils.Copy(input, zip, buffer);
                            }

                            zip.CloseEntry();
                        }
                    }
                    else
                    {
                        throw new FileNotFoundException($"Not found: {filePath}");
                    }
                }
            }
        }

        public static void ExtractFilesWithPassword(string zipFilePath, string extractPath)
        {
            if (!Directory.Exists(extractPath))
                Directory.CreateDirectory(extractPath);

            string fullDest = Path.GetFullPath(extractPath);

            using (ZipFile zip = new ZipFile(zipFilePath))
            {
                zip.Password = FixedPassword;

                foreach (ZipEntry entry in zip)
                {
                    if (entry.IsFile)
                    {
                        string targetPath = Path.Combine(extractPath, entry.Name);
                        string fullTarget = Path.GetFullPath(targetPath);

                        if (!fullTarget.StartsWith(fullDest + Path.DirectorySeparatorChar))
                            throw new IOException($"Zip slip blocked: {entry.Name}");

                        Directory.CreateDirectory(Path.GetDirectoryName(fullTarget));

                        using (Stream input = zip.GetInputStream(entry))
                        using (FileStream output = File.Create(fullTarget))
                        {
                            input.CopyTo(output);
                        }
                    }
                }
            }
        }

        public static bool AreAllFilesExtracted(string zipFilePath, string DestPath)
        {
            string extractionPath = Path.Combine(DestPath, "ExtractionFolder");
            if (!Directory.Exists(extractionPath))
                return false;

            using (ZipFile zip = new ZipFile(zipFilePath))
            {
                int totalInArchive = 0;
                foreach (ZipEntry entry in zip)
                {
                    if (entry.IsFile)
                        totalInArchive++;
                }
                int extractedCount = Directory.GetFiles(extractionPath, "*", SearchOption.AllDirectories).Length;
                return extractedCount >= totalInArchive;
            }
        }
    }
}