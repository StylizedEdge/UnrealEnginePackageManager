namespace UnrealEnginePackageManager
{
    partial class Preferences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preferences));
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Autopkg = new System.Windows.Forms.CheckBox();
            this.ContentDirectory = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.EnginesPath = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.UESelectedVersion = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PackageDirectory = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selected Unreal Engine Version";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 513);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Apply";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SaveAppliedSettings);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "AutoInstall Packages after Creation?";
            // 
            // Autopkg
            // 
            this.Autopkg.AutoSize = true;
            this.Autopkg.Location = new System.Drawing.Point(582, 204);
            this.Autopkg.Name = "Autopkg";
            this.Autopkg.Size = new System.Drawing.Size(15, 14);
            this.Autopkg.TabIndex = 8;
            this.Autopkg.UseVisualStyleBackColor = true;
            // 
            // ContentDirectory
            // 
            this.ContentDirectory.Location = new System.Drawing.Point(187, 83);
            this.ContentDirectory.Name = "ContentDirectory";
            this.ContentDirectory.ReadOnly = true;
            this.ContentDirectory.Size = new System.Drawing.Size(352, 20);
            this.ContentDirectory.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(545, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Get";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.GetContentCreationPath);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Content Creation Directory";
            // 
            // EnginesPath
            // 
            this.EnginesPath.Location = new System.Drawing.Point(187, 25);
            this.EnginesPath.Name = "EnginesPath";
            this.EnginesPath.ReadOnly = true;
            this.EnginesPath.Size = new System.Drawing.Size(352, 20);
            this.EnginesPath.TabIndex = 15;
            this.toolTip1.SetToolTip(this.EnginesPath, "Default is C:\\Program Files\\Epic Games");
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(545, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Get";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Engines Installation Path";
            this.toolTip1.SetToolTip(this.label4, "The folder where all Editor versions are installed");
            // 
            // UESelectedVersion
            // 
            this.UESelectedVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UESelectedVersion.FormattingEnabled = true;
            this.UESelectedVersion.Items.AddRange(new object[] {
            "UE_4.26",
            "UE_4.27",
            "UE_5.0",
            "UE_5.1",
            "UE_5.2",
            "UE_5.3",
            "UE_5.4"});
            this.UESelectedVersion.Location = new System.Drawing.Point(187, 56);
            this.UESelectedVersion.Name = "UESelectedVersion";
            this.UESelectedVersion.Size = new System.Drawing.Size(410, 21);
            this.UESelectedVersion.TabIndex = 16;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "UE_4.26",
            "UE_4.27",
            "UE_5.0",
            "UE_5.1",
            "UE_5.2",
            "UE_5.3",
            "UE_5.4"});
            this.comboBox2.Location = new System.Drawing.Point(187, 177);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(410, 21);
            this.comboBox2.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Extracted Package Temp folder";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Installing";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Packaging";
            // 
            // PackageDirectory
            // 
            this.PackageDirectory.Location = new System.Drawing.Point(187, 109);
            this.PackageDirectory.Name = "PackageDirectory";
            this.PackageDirectory.ReadOnly = true;
            this.PackageDirectory.Size = new System.Drawing.Size(352, 20);
            this.PackageDirectory.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(545, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Get";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GetPackageCreationPath);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Packages Creation Directory";
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 548);
            this.Controls.Add(this.PackageDirectory);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UESelectedVersion);
            this.Controls.Add(this.EnginesPath);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ContentDirectory);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Autopkg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(625, 587);
            this.MinimumSize = new System.Drawing.Size(625, 587);
            this.Name = "Preferences";
            this.Text = "Preferences";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Autopkg;
        private System.Windows.Forms.TextBox ContentDirectory;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EnginesPath;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox UESelectedVersion;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PackageDirectory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
    }
}