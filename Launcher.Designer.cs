namespace Launcher {
    partial class Launcher {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.playButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.forumButton = new System.Windows.Forms.Button();
            this.youtubeButton = new System.Windows.Forms.Button();
            this.facebookButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playButton.Enabled = false;
            this.playButton.Location = new System.Drawing.Point(562, 424);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(107, 50);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 424);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(544, 50);
            this.progressBar1.TabIndex = 1;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(12, 56);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(657, 362);
            this.webBrowser.TabIndex = 2;
            // 
            // forumButton
            // 
            this.forumButton.Location = new System.Drawing.Point(12, 12);
            this.forumButton.Name = "forumButton";
            this.forumButton.Size = new System.Drawing.Size(111, 38);
            this.forumButton.TabIndex = 3;
            this.forumButton.Text = "Visit Forum";
            this.forumButton.UseVisualStyleBackColor = true;
            this.forumButton.Click += new System.EventHandler(this.forumButton_Click);
            // 
            // youtubeButton
            // 
            this.youtubeButton.Location = new System.Drawing.Point(129, 12);
            this.youtubeButton.Name = "youtubeButton";
            this.youtubeButton.Size = new System.Drawing.Size(111, 38);
            this.youtubeButton.TabIndex = 4;
            this.youtubeButton.Text = "YouTube";
            this.youtubeButton.UseVisualStyleBackColor = true;
            this.youtubeButton.Click += new System.EventHandler(this.youtubeButton_Click);
            // 
            // facebookButton
            // 
            this.facebookButton.Location = new System.Drawing.Point(246, 12);
            this.facebookButton.Name = "facebookButton";
            this.facebookButton.Size = new System.Drawing.Size(111, 38);
            this.facebookButton.TabIndex = 5;
            this.facebookButton.Text = "Facebook";
            this.facebookButton.UseVisualStyleBackColor = true;
            this.facebookButton.Click += new System.EventHandler(this.facebookButton_Click);
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 486);
            this.Controls.Add(this.facebookButton);
            this.Controls.Add(this.youtubeButton);
            this.Controls.Add(this.forumButton);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.playButton);
            this.Name = "Launcher";
            this.Text = "Launcher v0.0.1";
            this.Load += new System.EventHandler(this.Launcher_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button forumButton;
        private System.Windows.Forms.Button youtubeButton;
        private System.Windows.Forms.Button facebookButton;
    }
}

