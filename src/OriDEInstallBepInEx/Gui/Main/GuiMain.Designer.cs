namespace OriDEInstallBepInEx
{
    partial class GuiMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuiMain));
            this.Install = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Reinstall = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Install
            // 
            this.Install.Location = new System.Drawing.Point(100, 200);
            this.Install.Name = "Install";
            this.Install.Size = new System.Drawing.Size(100, 100);
            this.Install.TabIndex = 0;
            this.Install.Text = "安装";
            this.Install.UseVisualStyleBackColor = true;
            this.Install.Click += new System.EventHandler(this.Install_Click);
            // 
            // Remove
            // 
            this.Remove.Enabled = false;
            this.Remove.Location = new System.Drawing.Point(700, 200);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(100, 100);
            this.Remove.TabIndex = 1;
            this.Remove.Text = "卸载";
            this.Remove.UseVisualStyleBackColor = true;
            // 
            // Reinstall
            // 
            this.Reinstall.Enabled = false;
            this.Reinstall.Location = new System.Drawing.Point(400, 200);
            this.Reinstall.Name = "Reinstall";
            this.Reinstall.Size = new System.Drawing.Size(100, 100);
            this.Reinstall.TabIndex = 2;
            this.Reinstall.Text = "重新安装";
            this.Reinstall.UseVisualStyleBackColor = true;
            // 
            // About
            // 
            this.About.Location = new System.Drawing.Point(1000, 200);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(100, 100);
            this.About.TabIndex = 3;
            this.About.Text = "关于";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // GuiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.About);
            this.Controls.Add(this.Reinstall);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Install);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GuiMain";
            this.Text = "Ori DE Install BepInEx";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GuiMain_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Button Install;
        private Button Remove;
        private Button Reinstall;
        private Button About;
    }
}