namespace UnrealEnginePackageManager
{
    partial class UnrealPackageCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnrealPackageCreator));
            this.button2 = new System.Windows.Forms.Button();
            this.filespackText = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PackagePathText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DevWebsite = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.DevName = new System.Windows.Forms.TextBox();
            this.UEVersions = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.categorytext = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tagText = new System.Windows.Forms.TextBox();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.versiontext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.packnameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.copyPercentageLabel = new System.Windows.Forms.Label();
            this.currentFileLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.button5 = new System.Windows.Forms.Button();
            this.CreatePackage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(541, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 23);
            this.button2.TabIndex = 40;
            this.button2.Text = "Assign";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // filespackText
            // 
            this.filespackText.Enabled = false;
            this.filespackText.Location = new System.Drawing.Point(128, 12);
            this.filespackText.Name = "filespackText";
            this.filespackText.Size = new System.Drawing.Size(410, 20);
            this.filespackText.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label14.Location = new System.Drawing.Point(11, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 17);
            this.label14.TabIndex = 38;
            this.label14.Text = "Files Pack";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(541, 39);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 23);
            this.button4.TabIndex = 45;
            this.button4.Text = "GetDefault";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "Assign";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PackagePathText
            // 
            this.PackagePathText.Enabled = false;
            this.PackagePathText.Location = new System.Drawing.Point(128, 42);
            this.PackagePathText.Name = "PackagePathText";
            this.PackagePathText.Size = new System.Drawing.Size(324, 20);
            this.PackagePathText.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(11, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Package Path";
            // 
            // DevWebsite
            // 
            this.DevWebsite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DevWebsite.Location = new System.Drawing.Point(416, 242);
            this.DevWebsite.Name = "DevWebsite";
            this.DevWebsite.Size = new System.Drawing.Size(189, 20);
            this.DevWebsite.TabIndex = 63;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(337, 245);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 62;
            this.label17.Text = "Website";
            // 
            // DevName
            // 
            this.DevName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DevName.Location = new System.Drawing.Point(128, 242);
            this.DevName.Name = "DevName";
            this.DevName.Size = new System.Drawing.Size(189, 20);
            this.DevName.TabIndex = 61;
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
            this.UEVersions.Location = new System.Drawing.Point(383, 136);
            this.UEVersions.Name = "UEVersions";
            this.UEVersions.Size = new System.Drawing.Size(225, 21);
            this.UEVersions.TabIndex = 59;
            this.UEVersions.SelectedIndexChanged += new System.EventHandler(this.UEVersions_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(265, 138);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 13);
            this.label15.TabIndex = 58;
            this.label15.Text = "Package Version";
            // 
            // categorytext
            // 
            this.categorytext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.categorytext.Location = new System.Drawing.Point(128, 294);
            this.categorytext.Name = "categorytext";
            this.categorytext.Size = new System.Drawing.Size(477, 20);
            this.categorytext.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Category";
            // 
            // tagText
            // 
            this.tagText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tagText.Location = new System.Drawing.Point(128, 268);
            this.tagText.Name = "tagText";
            this.tagText.Size = new System.Drawing.Size(477, 20);
            this.tagText.TabIndex = 55;
            // 
            // descriptionText
            // 
            this.descriptionText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionText.Location = new System.Drawing.Point(128, 161);
            this.descriptionText.Multiline = true;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionText.Size = new System.Drawing.Size(483, 65);
            this.descriptionText.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Package Description";
            // 
            // versiontext
            // 
            this.versiontext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.versiontext.Location = new System.Drawing.Point(128, 135);
            this.versiontext.Name = "versiontext";
            this.versiontext.Size = new System.Drawing.Size(122, 20);
            this.versiontext.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Package Version";
            // 
            // packnameText
            // 
            this.packnameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.packnameText.Location = new System.Drawing.Point(128, 109);
            this.packnameText.Name = "packnameText";
            this.packnameText.Size = new System.Drawing.Size(481, 20);
            this.packnameText.TabIndex = 50;
            this.packnameText.Text = "name";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Package name";
            // 
            // copyPercentageLabel
            // 
            this.copyPercentageLabel.AutoSize = true;
            this.copyPercentageLabel.Location = new System.Drawing.Point(12, 421);
            this.copyPercentageLabel.Name = "copyPercentageLabel";
            this.copyPercentageLabel.Size = new System.Drawing.Size(21, 13);
            this.copyPercentageLabel.TabIndex = 66;
            this.copyPercentageLabel.Text = "0%";
            // 
            // currentFileLabel
            // 
            this.currentFileLabel.AutoSize = true;
            this.currentFileLabel.Location = new System.Drawing.Point(12, 408);
            this.currentFileLabel.Name = "currentFileLabel";
            this.currentFileLabel.Size = new System.Drawing.Size(31, 13);
            this.currentFileLabel.TabIndex = 65;
            this.currentFileLabel.Text = "........";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(14, 382);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(591, 23);
            this.progressBar.TabIndex = 64;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(523, 467);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 68;
            this.button5.Text = "Cancel";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // CreatePackage
            // 
            this.CreatePackage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CreatePackage.Location = new System.Drawing.Point(14, 449);
            this.CreatePackage.Name = "CreatePackage";
            this.CreatePackage.Size = new System.Drawing.Size(192, 41);
            this.CreatePackage.TabIndex = 67;
            this.CreatePackage.Text = "Create Package";
            this.CreatePackage.UseVisualStyleBackColor = false;
            this.CreatePackage.Click += new System.EventHandler(this.CreatePackageButton);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Dev Name";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 70;
            this.label5.Text = "Tag";
            // 
            // UnrealPackageCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 500);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.CreatePackage);
            this.Controls.Add(this.copyPercentageLabel);
            this.Controls.Add(this.currentFileLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.DevWebsite);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.DevName);
            this.Controls.Add(this.UEVersions);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.categorytext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tagText);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.versiontext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.packnameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PackagePathText);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.filespackText);
            this.Controls.Add(this.label14);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(637, 539);
            this.MinimumSize = new System.Drawing.Size(637, 539);
            this.Name = "UnrealPackageCreator";
            this.Text = "Unreal Package Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox filespackText;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PackagePathText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox DevWebsite;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox DevName;
        private System.Windows.Forms.ComboBox UEVersions;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox categorytext;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tagText;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox versiontext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox packnameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label copyPercentageLabel;
        private System.Windows.Forms.Label currentFileLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button CreatePackage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}