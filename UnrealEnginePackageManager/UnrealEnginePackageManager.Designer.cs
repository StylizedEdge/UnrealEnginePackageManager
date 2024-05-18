namespace UnrealEnginePackageManager
{
    partial class UnrealEnginePackageManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnrealEnginePackageManager));
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createContentPackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uContentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unrealPackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uContentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.managePacksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUEPackageManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devSupportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button3 = new System.Windows.Forms.Button();
            this.InstallButton = new System.Windows.Forms.Button();
            this.pkgName = new System.Windows.Forms.Label();
            this.PackageOption = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deletePackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openInFileExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UninstallButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.UnrealContent = new System.Windows.Forms.TableLayoutPanel();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pkgDescription = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pkgUnrealEngineVersion = new System.Windows.Forms.Label();
            this.pkgSize = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.DevWebsite = new System.Windows.Forms.LinkLabel();
            this.DevName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FilesInThePack = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.UnrealPackage = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.PackageOption.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createContentPackToolStripMenuItem,
            this.installToolStripMenuItem,
            this.managePacksToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // createContentPackToolStripMenuItem
            // 
            this.createContentPackToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uContentToolStripMenuItem,
            this.unrealPackageToolStripMenuItem});
            this.createContentPackToolStripMenuItem.Image = global::UnrealEnginePackageManager.Properties.Resources.icons8_new_button_192px;
            this.createContentPackToolStripMenuItem.Name = "createContentPackToolStripMenuItem";
            this.createContentPackToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createContentPackToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createContentPackToolStripMenuItem.Text = "New";
            // 
            // uContentToolStripMenuItem
            // 
            this.uContentToolStripMenuItem.Name = "uContentToolStripMenuItem";
            this.uContentToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.uContentToolStripMenuItem.Text = ".UContent";
            this.uContentToolStripMenuItem.ToolTipText = "packages that the user will install in his engine and will always remain in his F" +
    "eature Content ";
            this.uContentToolStripMenuItem.Click += new System.EventHandler(this.createContentPackToolStripMenuItem_Click);
            // 
            // unrealPackageToolStripMenuItem
            // 
            this.unrealPackageToolStripMenuItem.Name = "unrealPackageToolStripMenuItem";
            this.unrealPackageToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.unrealPackageToolStripMenuItem.Text = ".UnrealPackage";
            this.unrealPackageToolStripMenuItem.ToolTipText = "package that the user will click on it from the file explorer and it will be inst" +
    "alled directly in the projects.";
            this.unrealPackageToolStripMenuItem.Click += new System.EventHandler(this.unrealPackageToolStripMenuItem_Click);
            // 
            // installToolStripMenuItem
            // 
            this.installToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uContentToolStripMenuItem1});
            this.installToolStripMenuItem.Name = "installToolStripMenuItem";
            this.installToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.installToolStripMenuItem.Text = "Install";
            // 
            // uContentToolStripMenuItem1
            // 
            this.uContentToolStripMenuItem1.Name = "uContentToolStripMenuItem1";
            this.uContentToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.uContentToolStripMenuItem1.Text = ".UnrealPackage";
            this.uContentToolStripMenuItem1.Click += new System.EventHandler(this.uContentToolStripMenuItem1_Click);
            // 
            // managePacksToolStripMenuItem
            // 
            this.managePacksToolStripMenuItem.Image = global::UnrealEnginePackageManager.Properties.Resources.icons8_counterclockwise_arrows_192px_1;
            this.managePacksToolStripMenuItem.Name = "managePacksToolStripMenuItem";
            this.managePacksToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.managePacksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.managePacksToolStripMenuItem.Text = "Refrensh List";
            this.managePacksToolStripMenuItem.Click += new System.EventHandler(this.managePacksToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = global::UnrealEnginePackageManager.Properties.Resources.icons8_cl_button_192px;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.menuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1171, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(174, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 27);
            this.button3.TabIndex = 12;
            this.button3.Text = "Delete from disk";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // InstallButton
            // 
            this.InstallButton.BackColor = System.Drawing.Color.White;
            this.InstallButton.Enabled = false;
            this.InstallButton.ForeColor = System.Drawing.Color.Black;
            this.InstallButton.Location = new System.Drawing.Point(376, 3);
            this.InstallButton.Name = "InstallButton";
            this.InstallButton.Size = new System.Drawing.Size(294, 27);
            this.InstallButton.TabIndex = 10;
            this.InstallButton.Text = "Install";
            this.InstallButton.UseVisualStyleBackColor = false;
            this.InstallButton.Click += new System.EventHandler(this.InstallPackageContent_Click);
            // 
            // pkgName
            // 
            this.pkgName.AutoSize = true;
            this.pkgName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pkgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkgName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.pkgName.Location = new System.Drawing.Point(0, 0);
            this.pkgName.Name = "pkgName";
            this.pkgName.Size = new System.Drawing.Size(125, 20);
            this.pkgName.TabIndex = 13;
            this.pkgName.Text = "Package Name :";
            // 
            // PackageOption
            // 
            this.PackageOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletePackageToolStripMenuItem,
            this.openInFileExplorerToolStripMenuItem,
            this.devCheckToolStripMenuItem});
            this.PackageOption.Name = "PackageOption";
            this.PackageOption.Size = new System.Drawing.Size(184, 70);
            // 
            // deletePackageToolStripMenuItem
            // 
            this.deletePackageToolStripMenuItem.Name = "deletePackageToolStripMenuItem";
            this.deletePackageToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.deletePackageToolStripMenuItem.Text = "Delete package";
            // 
            // openInFileExplorerToolStripMenuItem
            // 
            this.openInFileExplorerToolStripMenuItem.Name = "openInFileExplorerToolStripMenuItem";
            this.openInFileExplorerToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.openInFileExplorerToolStripMenuItem.Text = "Open In File Explorer";
            // 
            // devCheckToolStripMenuItem
            // 
            this.devCheckToolStripMenuItem.Name = "devCheckToolStripMenuItem";
            this.devCheckToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.devCheckToolStripMenuItem.Text = "Dev Check";
            // 
            // UninstallButton
            // 
            this.UninstallButton.BackColor = System.Drawing.SystemColors.Control;
            this.UninstallButton.Enabled = false;
            this.UninstallButton.ForeColor = System.Drawing.Color.Black;
            this.UninstallButton.Location = new System.Drawing.Point(274, 3);
            this.UninstallButton.Name = "UninstallButton";
            this.UninstallButton.Size = new System.Drawing.Size(96, 27);
            this.UninstallButton.TabIndex = 11;
            this.UninstallButton.Text = "Unistall";
            this.UninstallButton.UseVisualStyleBackColor = false;
            this.UninstallButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.tabControl2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 646);
            this.panel1.TabIndex = 16;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(498, 646);
            this.tabControl2.TabIndex = 16;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.UnrealContent);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(490, 620);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Unreal Content";
            // 
            // UnrealContent
            // 
            this.UnrealContent.AutoScroll = true;
            this.UnrealContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UnrealContent.ColumnCount = 1;
            this.UnrealContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.45045F));
            this.UnrealContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnrealContent.Location = new System.Drawing.Point(3, 3);
            this.UnrealContent.Name = "UnrealContent";
            this.UnrealContent.RowCount = 1;
            this.UnrealContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UnrealContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 614F));
            this.UnrealContent.Size = new System.Drawing.Size(484, 614);
            this.UnrealContent.TabIndex = 15;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage5.Controls.Add(this.UnrealPackage);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(490, 620);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Unreal packages";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.InstallButton);
            this.flowLayoutPanel1.Controls.Add(this.UninstallButton);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 612);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(673, 34);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.pkgName);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(498, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(673, 646);
            this.panel2.TabIndex = 17;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(673, 592);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pkgDescription);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(665, 566);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Description";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pkgDescription
            // 
            this.pkgDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pkgDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pkgDescription.Location = new System.Drawing.Point(3, 3);
            this.pkgDescription.Name = "pkgDescription";
            this.pkgDescription.ReadOnly = true;
            this.pkgDescription.Size = new System.Drawing.Size(659, 560);
            this.pkgDescription.TabIndex = 11;
            this.pkgDescription.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.pkgUnrealEngineVersion);
            this.tabPage2.Controls.Add(this.pkgSize);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(665, 566);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Files";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Unreal Version";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Package Size";
            // 
            // pkgUnrealEngineVersion
            // 
            this.pkgUnrealEngineVersion.AutoSize = true;
            this.pkgUnrealEngineVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkgUnrealEngineVersion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pkgUnrealEngineVersion.Location = new System.Drawing.Point(217, 0);
            this.pkgUnrealEngineVersion.Name = "pkgUnrealEngineVersion";
            this.pkgUnrealEngineVersion.Size = new System.Drawing.Size(12, 17);
            this.pkgUnrealEngineVersion.TabIndex = 9;
            this.pkgUnrealEngineVersion.Text = ".";
            // 
            // pkgSize
            // 
            this.pkgSize.AutoSize = true;
            this.pkgSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkgSize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pkgSize.Location = new System.Drawing.Point(217, 20);
            this.pkgSize.Name = "pkgSize";
            this.pkgSize.Size = new System.Drawing.Size(12, 17);
            this.pkgSize.TabIndex = 11;
            this.pkgSize.Text = ".";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.DevWebsite);
            this.tabPage3.Controls.Add(this.DevName);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.FilesInThePack);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(665, 566);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "More";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dev Website";
            // 
            // DevWebsite
            // 
            this.DevWebsite.AutoSize = true;
            this.DevWebsite.Location = new System.Drawing.Point(105, 34);
            this.DevWebsite.Name = "DevWebsite";
            this.DevWebsite.Size = new System.Drawing.Size(37, 13);
            this.DevWebsite.TabIndex = 3;
            this.DevWebsite.TabStop = true;
            this.DevWebsite.Text = "_____";
            this.DevWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DevWebsite_LinkClicked);
            // 
            // DevName
            // 
            this.DevName.AutoSize = true;
            this.DevName.Location = new System.Drawing.Point(105, 11);
            this.DevName.Name = "DevName";
            this.DevName.Size = new System.Drawing.Size(37, 13);
            this.DevName.TabIndex = 2;
            this.DevName.Text = "_____";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Package Made By";
            // 
            // FilesInThePack
            // 
            this.FilesInThePack.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FilesInThePack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilesInThePack.Location = new System.Drawing.Point(0, 0);
            this.FilesInThePack.Name = "FilesInThePack";
            this.FilesInThePack.Size = new System.Drawing.Size(665, 566);
            this.FilesInThePack.TabIndex = 0;
            this.FilesInThePack.Text = "";
            // 
            // UnrealPackage
            // 
            this.UnrealPackage.AutoScroll = true;
            this.UnrealPackage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UnrealPackage.ColumnCount = 1;
            this.UnrealPackage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.45045F));
            this.UnrealPackage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnrealPackage.Location = new System.Drawing.Point(3, 3);
            this.UnrealPackage.Name = "UnrealPackage";
            this.UnrealPackage.RowCount = 1;
            this.UnrealPackage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UnrealPackage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 614F));
            this.UnrealPackage.Size = new System.Drawing.Size(484, 614);
            this.UnrealPackage.TabIndex = 16;
            // 
            // UnrealEnginePackageManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1171, 670);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UnrealEnginePackageManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unreal Engine Package Creator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PackageOption.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button InstallButton;
        private System.Windows.Forms.Label pkgName;
        private System.Windows.Forms.Button UninstallButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip PackageOption;
        private System.Windows.Forms.ToolStripMenuItem deletePackageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openInFileExplorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devCheckToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel UnrealContent;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label pkgUnrealEngineVersion;
        private System.Windows.Forms.Label pkgSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox pkgDescription;
        private System.Windows.Forms.ToolStripMenuItem uContentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unrealPackageToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RichTextBox FilesInThePack;
        private System.Windows.Forms.ToolStripMenuItem installToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uContentToolStripMenuItem1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label DevName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel DevWebsite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel UnrealPackage;
    }
}

