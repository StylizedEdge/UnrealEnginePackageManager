// Ignore Spelling: Rar Json

namespace UnrealEnginePackageManager
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
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

    /// <summary>
    /// Defines the <see cref="Book_Files" />
    /// </summary>
    public class Book_Images
    {
        /// <summary>
        /// The AreFilesDoneCopying
        /// </summary>
        /// <param name="sourceFolderPath">The sourceFolderPath<see cref="string"/></param>
        /// <param name="destinationFolderPath">The destinationFolderPath<see cref="string"/></param>
        /// <returns>The <see cref="bool"/></returns>
        public static bool AreFilesDoneCopying(string sourceFolderPath, string destinationFolderPath)
        {
            // Get all files and subfolders in the source folder
            string[] allItems = Directory.GetFileSystemEntries(sourceFolderPath, "*", SearchOption.AllDirectories);

            // Check if all files exist in the destination folder
            foreach (string sourceItemPath in allItems)
            {
                string relativePath = Book_Files.GetRelativePath(sourceFolderPath, sourceItemPath);
                string destinationItemPath = Path.Combine(destinationFolderPath, relativePath);

                if (!File.Exists(destinationItemPath) && !Directory.Exists(destinationItemPath))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// The ResizeImage
        /// </summary>
        /// <param name="ImageToResize">The imgToResize<see cref="Image"/></param>
        /// <param name="size">The size<see cref="Size"/></param>
        /// <returns>The <see cref="Image"/></returns>
        public static Image ResizeImage(Image ImageToResize, Size size)
        {
            int sourceWidth = ImageToResize.Width;
            int sourceHeight = ImageToResize.Height;

            // Calculate the scaling factor for width and height
            float nPercent = Math.Min((float)size.Width / sourceWidth, (float)size.Height / sourceHeight);

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            // Create a new bitmap with the resized dimensions
            Bitmap b = new Bitmap(destWidth, destHeight);

            // Create a Graphics object from the bitmap
            using (Graphics g = Graphics.FromImage(b))
            {
                // Set the interpolation mode to high quality bicubic
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                // Draw the resized image onto the Graphics object
                g.DrawImage(ImageToResize, 0, 0, destWidth, destHeight);
            }

            return b;
        }

        /// <summary>
        /// The SaveResizedImage
        /// </summary>
        /// <param name="resizedImage">The resizedImage<see cref="Image"/></param>
        /// <param name="filePath">The filePath<see cref="string"/></param>
        public static void SaveResizedImage(Image resizedImage, string filePath)
        {
            // Save the resized image to the specified file path
            resizedImage.Save(filePath);
        }
    }
}


