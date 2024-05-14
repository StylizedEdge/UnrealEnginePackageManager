namespace UnrealEnginePackageManager
{
    partial class UnrealEnginePackageManager_Core
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnrealEnginePackageManager_Core));
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createContentPackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managePacksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUEPackageManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devSupportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.previewPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pkgUnrealEngineVersion = new System.Windows.Forms.Label();
            this.pkgSize = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pkgDescription = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pkgName = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.InstallPackageContent = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createContentPackToolStripMenuItem,
            this.managePacksToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // createContentPackToolStripMenuItem
            // 
            this.createContentPackToolStripMenuItem.Image = global::UnrealEnginePackageManager.Properties.Resources.icons8_new_button_192px;
            this.createContentPackToolStripMenuItem.Name = "createContentPackToolStripMenuItem";
            this.createContentPackToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createContentPackToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.createContentPackToolStripMenuItem.Text = "Create Content Pack";
            this.createContentPackToolStripMenuItem.Click += new System.EventHandler(this.createContentPackToolStripMenuItem_Click);
            // 
            // managePacksToolStripMenuItem
            // 
            this.managePacksToolStripMenuItem.Image = global::UnrealEnginePackageManager.Properties.Resources.icons8_counterclockwise_arrows_192px_1;
            this.managePacksToolStripMenuItem.Name = "managePacksToolStripMenuItem";
            this.managePacksToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.managePacksToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.managePacksToolStripMenuItem.Text = "Refrensh List";
            this.managePacksToolStripMenuItem.Click += new System.EventHandler(this.managePacksToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = global::UnrealEnginePackageManager.Properties.Resources.icons8_cl_button_192px;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Image = global::UnrealEnginePackageManager.Properties.Resources.icons8_settings_400px;
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUEPackageManagerToolStripMenuItem,
            this.devSupportToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutUEPackageManagerToolStripMenuItem
            // 
            this.aboutUEPackageManagerToolStripMenuItem.Image = global::UnrealEnginePackageManager.Properties.Resources.icons8_question_mark_192px;
            this.aboutUEPackageManagerToolStripMenuItem.Name = "aboutUEPackageManagerToolStripMenuItem";
            this.aboutUEPackageManagerToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.aboutUEPackageManagerToolStripMenuItem.Text = "About UE Package Manager";
            this.aboutUEPackageManagerToolStripMenuItem.Click += new System.EventHandler(this.aboutUEPackageManagerToolStripMenuItem_Click);
            // 
            // devSupportToolStripMenuItem
            // 
            this.devSupportToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.devSupportToolStripMenuItem.Image = global::UnrealEnginePackageManager.Properties.Resources.icons8_donate_480px;
            this.devSupportToolStripMenuItem.Name = "devSupportToolStripMenuItem";
            this.devSupportToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.devSupportToolStripMenuItem.Text = "Dev Support!";
            this.devSupportToolStripMenuItem.Click += new System.EventHandler(this.devSupportToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(469, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // previewPanel
            // 
            this.previewPanel.AutoScroll = true;
            this.previewPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.previewPanel.Location = new System.Drawing.Point(0, 24);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(469, 332);
            this.previewPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Package installed state";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(135, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "_____";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "UE Version";
            // 
            // pkgUnrealEngineVersion
            // 
            this.pkgUnrealEngineVersion.AutoSize = true;
            this.pkgUnrealEngineVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkgUnrealEngineVersion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pkgUnrealEngineVersion.Location = new System.Drawing.Point(135, 425);
            this.pkgUnrealEngineVersion.Name = "pkgUnrealEngineVersion";
            this.pkgUnrealEngineVersion.Size = new System.Drawing.Size(48, 17);
            this.pkgUnrealEngineVersion.TabIndex = 5;
            this.pkgUnrealEngineVersion.Text = "_____";
            // 
            // pkgSize
            // 
            this.pkgSize.AutoSize = true;
            this.pkgSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkgSize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pkgSize.Location = new System.Drawing.Point(135, 450);
            this.pkgSize.Name = "pkgSize";
            this.pkgSize.Size = new System.Drawing.Size(48, 17);
            this.pkgSize.TabIndex = 7;
            this.pkgSize.Text = "_____";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Package Size";
            // 
            // pkgDescription
            // 
            this.pkgDescription.AutoSize = true;
            this.pkgDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pkgDescription.Location = new System.Drawing.Point(135, 473);
            this.pkgDescription.Name = "pkgDescription";
            this.pkgDescription.Size = new System.Drawing.Size(19, 91);
            this.pkgDescription.TabIndex = 9;
            this.pkgDescription.Text = "....\r\n....\r\n....\r\n....\r\n....\r\n....\r\n....\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 473);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Package Description";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(58, 565);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 42);
            this.button2.TabIndex = 11;
            this.button2.Text = "Unistall";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pkgName
            // 
            this.pkgName.AutoSize = true;
            this.pkgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkgName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.pkgName.Location = new System.Drawing.Point(8, 368);
            this.pkgName.Name = "pkgName";
            this.pkgName.Size = new System.Drawing.Size(34, 20);
            this.pkgName.TabIndex = 13;
            this.pkgName.Text = "-----";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.BackgroundImage = global::UnrealEnginePackageManager.Properties.Resources.icons8_wastebasket_192px;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.ForeColor = System.Drawing.Color.Maroon;
            this.button3.Location = new System.Drawing.Point(12, 565);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 42);
            this.button3.TabIndex = 12;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // InstallPackageContent
            // 
            this.InstallPackageContent.BackColor = System.Drawing.Color.White;
            this.InstallPackageContent.ForeColor = System.Drawing.Color.Maroon;
            this.InstallPackageContent.Image = global::UnrealEnginePackageManager.Properties.Resources.icons8_software_installer_50px;
            this.InstallPackageContent.Location = new System.Drawing.Point(163, 565);
            this.InstallPackageContent.Name = "InstallPackageContent";
            this.InstallPackageContent.Size = new System.Drawing.Size(294, 42);
            this.InstallPackageContent.TabIndex = 10;
            this.InstallPackageContent.UseVisualStyleBackColor = false;
            this.InstallPackageContent.Click += new System.EventHandler(this.InstallPackageContent_Click);
            // 
            // UnrealEnginePackageManager_Core
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(469, 619);
            this.Controls.Add(this.pkgName);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.InstallPackageContent);
            this.Controls.Add(this.pkgDescription);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pkgSize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pkgUnrealEngineVersion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.previewPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UnrealEnginePackageManager_Core";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unreal Engine Package Creator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createContentPackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managePacksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUEPackageManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devSupportToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.FlowLayoutPanel previewPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label pkgUnrealEngineVersion;
        private System.Windows.Forms.Label pkgSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label pkgDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button InstallPackageContent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label pkgName;
    }
}

