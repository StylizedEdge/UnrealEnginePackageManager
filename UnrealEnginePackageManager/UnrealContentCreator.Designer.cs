﻿namespace UnrealEnginePackageManager
{
    partial class UnrealContentCreator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnrealContentCreator));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.packnameText = new System.Windows.Forms.TextBox();
            this.versiontext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tagText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.categorytext = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PackagePathText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.filespackText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pathassignedChecker = new System.Windows.Forms.CheckBox();
            this.pathemptyChecker = new System.Windows.Forms.CheckBox();
            this.systempFilesChecker = new System.Windows.Forms.CheckBox();
            this.CreatePackage = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.currentFileLabel = new System.Windows.Forms.Label();
            this.copyPercentageLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.UEVersions = new System.Windows.Forms.ComboBox();
            this.ScreenshotImage = new System.Windows.Forms.PictureBox();
            this.thumbnailImage = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Fullpath = new System.Windows.Forms.Label();
            this.DevName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.DevWebsite = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenshotImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editor Content Creator";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Package name";
            // 
            // packnameText
            // 
            this.packnameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.packnameText.Location = new System.Drawing.Point(119, 114);
            this.packnameText.Name = "packnameText";
            this.packnameText.Size = new System.Drawing.Size(410, 21);
            this.packnameText.TabIndex = 2;
            this.packnameText.Text = "name";
            // 
            // versiontext
            // 
            this.versiontext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.versiontext.Location = new System.Drawing.Point(119, 142);
            this.versiontext.Name = "versiontext";
            this.versiontext.Size = new System.Drawing.Size(122, 21);
            this.versiontext.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Package Version";
            // 
            // descriptionText
            // 
            this.descriptionText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionText.Location = new System.Drawing.Point(119, 170);
            this.descriptionText.Multiline = true;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionText.Size = new System.Drawing.Size(483, 70);
            this.descriptionText.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Package Description";
            // 
            // tagText
            // 
            this.tagText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tagText.Location = new System.Drawing.Point(119, 285);
            this.tagText.Name = "tagText";
            this.tagText.Size = new System.Drawing.Size(477, 21);
            this.tagText.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 14);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tags";
            // 
            // categorytext
            // 
            this.categorytext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.categorytext.Location = new System.Drawing.Point(119, 313);
            this.categorytext.Name = "categorytext";
            this.categorytext.Size = new System.Drawing.Size(477, 21);
            this.categorytext.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 14);
            this.label6.TabIndex = 9;
            this.label6.Text = "Category";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Media";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 14);
            this.label8.TabIndex = 13;
            this.label8.Text = "Thumbnail";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(224, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 14);
            this.label9.TabIndex = 15;
            this.label9.Text = "Screeshot";
            // 
            // PackagePathText
            // 
            this.PackagePathText.Enabled = false;
            this.PackagePathText.Location = new System.Drawing.Point(119, 41);
            this.PackagePathText.Name = "PackagePathText";
            this.PackagePathText.Size = new System.Drawing.Size(319, 21);
            this.PackagePathText.TabIndex = 17;
            this.toolTip1.SetToolTip(this.PackagePathText, "Please Assign in an empty folder");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(2, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 14);
            this.label10.TabIndex = 16;
            this.label10.Text = "Package Path";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Please I dont know";
            // 
            // filespackText
            // 
            this.filespackText.Enabled = false;
            this.filespackText.Location = new System.Drawing.Point(119, 565);
            this.filespackText.Name = "filespackText";
            this.filespackText.Size = new System.Drawing.Size(410, 21);
            this.filespackText.TabIndex = 36;
            this.toolTip1.SetToolTip(this.filespackText, "Please Assign in an empty folder");
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.button1.Location = new System.Drawing.Point(445, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 25);
            this.button1.TabIndex = 19;
            this.button1.Text = "Assign";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AssignPackageCreationPath);
            // 
            // pathassignedChecker
            // 
            this.pathassignedChecker.AutoCheck = false;
            this.pathassignedChecker.AutoSize = true;
            this.pathassignedChecker.Location = new System.Drawing.Point(119, 86);
            this.pathassignedChecker.Name = "pathassignedChecker";
            this.pathassignedChecker.Size = new System.Drawing.Size(98, 18);
            this.pathassignedChecker.TabIndex = 22;
            this.pathassignedChecker.Text = "Path Assigned";
            this.pathassignedChecker.UseVisualStyleBackColor = true;
            // 
            // pathemptyChecker
            // 
            this.pathemptyChecker.AutoCheck = false;
            this.pathemptyChecker.AutoSize = true;
            this.pathemptyChecker.Location = new System.Drawing.Point(275, 87);
            this.pathemptyChecker.Name = "pathemptyChecker";
            this.pathemptyChecker.Size = new System.Drawing.Size(84, 18);
            this.pathemptyChecker.TabIndex = 23;
            this.pathemptyChecker.Text = "Path Empty";
            this.pathemptyChecker.UseVisualStyleBackColor = true;
            // 
            // systempFilesChecker
            // 
            this.systempFilesChecker.AutoCheck = false;
            this.systempFilesChecker.AutoSize = true;
            this.systempFilesChecker.Location = new System.Drawing.Point(421, 87);
            this.systempFilesChecker.Name = "systempFilesChecker";
            this.systempFilesChecker.Size = new System.Drawing.Size(131, 18);
            this.systempFilesChecker.TabIndex = 24;
            this.systempFilesChecker.Text = "Files System PD_Rar";
            this.systempFilesChecker.UseVisualStyleBackColor = true;
            // 
            // CreatePackage
            // 
            this.CreatePackage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CreatePackage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.CreatePackage.Location = new System.Drawing.Point(12, 692);
            this.CreatePackage.Name = "CreatePackage";
            this.CreatePackage.Size = new System.Drawing.Size(192, 44);
            this.CreatePackage.TabIndex = 27;
            this.CreatePackage.Text = "Create Package";
            this.CreatePackage.UseVisualStyleBackColor = false;
            this.CreatePackage.Click += new System.EventHandler(this.CreateContentAndpackAllFiles);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(99, 448);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 14);
            this.label11.TabIndex = 28;
            this.label11.Text = "64x64";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(290, 534);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 14);
            this.label12.TabIndex = 29;
            this.label12.Text = "400x200";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(290, 548);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 14);
            this.label13.TabIndex = 30;
            this.label13.Text = "1000x500";
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.button5.Location = new System.Drawing.Point(521, 712);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 25);
            this.button5.TabIndex = 31;
            this.button5.Text = "Cancel";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.CancelPackageCreation);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(12, 618);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(579, 25);
            this.progressBar.TabIndex = 32;
            // 
            // currentFileLabel
            // 
            this.currentFileLabel.AutoSize = true;
            this.currentFileLabel.Location = new System.Drawing.Point(13, 646);
            this.currentFileLabel.Name = "currentFileLabel";
            this.currentFileLabel.Size = new System.Drawing.Size(31, 14);
            this.currentFileLabel.TabIndex = 33;
            this.currentFileLabel.Text = "........";
            // 
            // copyPercentageLabel
            // 
            this.copyPercentageLabel.AutoSize = true;
            this.copyPercentageLabel.Location = new System.Drawing.Point(13, 660);
            this.copyPercentageLabel.Name = "copyPercentageLabel";
            this.copyPercentageLabel.Size = new System.Drawing.Size(21, 14);
            this.copyPercentageLabel.TabIndex = 34;
            this.copyPercentageLabel.Text = "0%";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.button2.Location = new System.Drawing.Point(532, 563);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 25);
            this.button2.TabIndex = 37;
            this.button2.Text = "Assign";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GetUnrealMigratedFiles);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label14.Location = new System.Drawing.Point(2, 569);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 17);
            this.label14.TabIndex = 35;
            this.label14.Text = "Files Pack";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(256, 145);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 14);
            this.label15.TabIndex = 38;
            this.label15.Text = "Package Version";
            // 
            // UEVersions
            // 
            this.UEVersions.FormattingEnabled = true;
            this.UEVersions.Items.AddRange(new object[] {
            "UE_5.4",
            "UE_5.3",
            "UE_5.2",
            "UE_5.1",
            "UE_5.0",
            "UE_4.27",
            "UE_4.26"});
            this.UEVersions.Location = new System.Drawing.Point(377, 141);
            this.UEVersions.Name = "UEVersions";
            this.UEVersions.Size = new System.Drawing.Size(225, 22);
            this.UEVersions.TabIndex = 39;
            // 
            // ScreenshotImage
            // 
            this.ScreenshotImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ScreenshotImage.Image = global::UnrealEnginePackageManager.Properties.Resources._400x200;
            this.ScreenshotImage.Location = new System.Drawing.Point(293, 369);
            this.ScreenshotImage.Name = "ScreenshotImage";
            this.ScreenshotImage.Size = new System.Drawing.Size(300, 162);
            this.ScreenshotImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ScreenshotImage.TabIndex = 14;
            this.ScreenshotImage.TabStop = false;
            this.ScreenshotImage.Click += new System.EventHandler(this.SetScreenshotImage);
            // 
            // thumbnailImage
            // 
            this.thumbnailImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.thumbnailImage.Image = global::UnrealEnginePackageManager.Properties.Resources._64x64;
            this.thumbnailImage.Location = new System.Drawing.Point(99, 376);
            this.thumbnailImage.Name = "thumbnailImage";
            this.thumbnailImage.Size = new System.Drawing.Size(60, 65);
            this.thumbnailImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thumbnailImage.TabIndex = 12;
            this.thumbnailImage.TabStop = false;
            this.thumbnailImage.Click += new System.EventHandler(this.SetThumbnailImage);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.button3.Location = new System.Drawing.Point(535, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 25);
            this.button3.TabIndex = 40;
            this.button3.Text = "Assign";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AssignPackageName);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.button4.Location = new System.Drawing.Point(521, 38);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 25);
            this.button4.TabIndex = 41;
            this.button4.Text = "GetDefault";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.GetDefaultPath);
            // 
            // Fullpath
            // 
            this.Fullpath.AutoSize = true;
            this.Fullpath.Location = new System.Drawing.Point(18, 69);
            this.Fullpath.Name = "Fullpath";
            this.Fullpath.Size = new System.Drawing.Size(30, 14);
            this.Fullpath.TabIndex = 42;
            this.Fullpath.Text = "Path";
            // 
            // DevName
            // 
            this.DevName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DevName.Location = new System.Drawing.Point(119, 257);
            this.DevName.Name = "DevName";
            this.DevName.Size = new System.Drawing.Size(189, 21);
            this.DevName.TabIndex = 46;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(2, 261);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 14);
            this.label16.TabIndex = 45;
            this.label16.Text = "Dev";
            // 
            // DevWebsite
            // 
            this.DevWebsite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DevWebsite.Location = new System.Drawing.Point(407, 257);
            this.DevWebsite.Name = "DevWebsite";
            this.DevWebsite.Size = new System.Drawing.Size(189, 21);
            this.DevWebsite.TabIndex = 48;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(328, 261);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 14);
            this.label17.TabIndex = 47;
            this.label17.Text = "Website";
            // 
            // UnrealContentCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(608, 750);
            this.Controls.Add(this.DevWebsite);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.DevName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Fullpath);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.UEVersions);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.filespackText);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.copyPercentageLabel);
            this.Controls.Add(this.currentFileLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CreatePackage);
            this.Controls.Add(this.systempFilesChecker);
            this.Controls.Add(this.pathemptyChecker);
            this.Controls.Add(this.pathassignedChecker);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PackagePathText);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ScreenshotImage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.thumbnailImage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.categorytext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tagText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.versiontext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.packnameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(624, 789);
            this.MinimumSize = new System.Drawing.Size(624, 789);
            this.Name = "UnrealContentCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Unreal Content";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.ScreenshotImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox packnameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tagText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox categorytext;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox thumbnailImage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox ScreenshotImage;
        private System.Windows.Forms.TextBox PackagePathText;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox pathassignedChecker;
        private System.Windows.Forms.CheckBox pathemptyChecker;
        private System.Windows.Forms.CheckBox systempFilesChecker;
        private System.Windows.Forms.Button CreatePackage;
        private System.Windows.Forms.TextBox versiontext;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button5;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label currentFileLabel;
        private System.Windows.Forms.Label copyPercentageLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox filespackText;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox UEVersions;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label Fullpath;
        private System.Windows.Forms.TextBox DevName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox DevWebsite;
        private System.Windows.Forms.Label label17;
    }
}