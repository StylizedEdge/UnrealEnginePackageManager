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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preferences));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Autopkg = new System.Windows.Forms.CheckBox();
            this.UEPathText = new System.Windows.Forms.TextBox();
            this.pkgCreationDir = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prefered UE Path";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(522, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Explore";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 513);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Apply";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "AutoInstall Packages after Creation?";
            // 
            // Autopkg
            // 
            this.Autopkg.AutoSize = true;
            this.Autopkg.Location = new System.Drawing.Point(210, 70);
            this.Autopkg.Name = "Autopkg";
            this.Autopkg.Size = new System.Drawing.Size(15, 14);
            this.Autopkg.TabIndex = 8;
            this.Autopkg.UseVisualStyleBackColor = true;
            // 
            // UEPathText
            // 
            this.UEPathText.Location = new System.Drawing.Point(209, 6);
            this.UEPathText.Name = "UEPathText";
            this.UEPathText.ReadOnly = true;
            this.UEPathText.Size = new System.Drawing.Size(307, 20);
            this.UEPathText.TabIndex = 9;
            // 
            // pkgCreationDir
            // 
            this.pkgCreationDir.Location = new System.Drawing.Point(209, 32);
            this.pkgCreationDir.Name = "pkgCreationDir";
            this.pkgCreationDir.ReadOnly = true;
            this.pkgCreationDir.Size = new System.Drawing.Size(307, 20);
            this.pkgCreationDir.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(522, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Explore";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Packages Creation Directory";
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 548);
            this.Controls.Add(this.pkgCreationDir);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UEPathText);
            this.Controls.Add(this.Autopkg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Autopkg;
        private System.Windows.Forms.TextBox UEPathText;
        private System.Windows.Forms.TextBox pkgCreationDir;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
    }
}