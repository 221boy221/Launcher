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
            this.components = new System.ComponentModel.Container();
            this.playButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.portfolioButton = new System.Windows.Forms.Button();
            this.gameSiteButton = new System.Windows.Forms.Button();
            this.githubButton = new System.Windows.Forms.Button();
            this.progressLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.repairButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playButton.Enabled = false;
            this.playButton.Location = new System.Drawing.Point(505, 417);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(107, 46);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar1.Location = new System.Drawing.Point(12, 432);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(487, 30);
            this.progressBar1.TabIndex = 1;
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(12, 56);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScrollBarsEnabled = false;
            this.webBrowser.Size = new System.Drawing.Size(600, 350);
            this.webBrowser.TabIndex = 2;
            this.webBrowser.Url = new System.Uri("http://127.0.0.1/launcher", System.UriKind.Absolute);
            // 
            // portfolioButton
            // 
            this.portfolioButton.Location = new System.Drawing.Point(12, 12);
            this.portfolioButton.Name = "portfolioButton";
            this.portfolioButton.Size = new System.Drawing.Size(111, 38);
            this.portfolioButton.TabIndex = 3;
            this.portfolioButton.Text = "Portfolio";
            this.portfolioButton.UseVisualStyleBackColor = true;
            this.portfolioButton.Click += new System.EventHandler(this.portfolioButton_Click);
            // 
            // gameSiteButton
            // 
            this.gameSiteButton.Location = new System.Drawing.Point(129, 12);
            this.gameSiteButton.Name = "gameSiteButton";
            this.gameSiteButton.Size = new System.Drawing.Size(111, 38);
            this.gameSiteButton.TabIndex = 4;
            this.gameSiteButton.Text = "Game Website";
            this.gameSiteButton.UseVisualStyleBackColor = true;
            this.gameSiteButton.Click += new System.EventHandler(this.gameSiteButton_Click);
            // 
            // githubButton
            // 
            this.githubButton.Location = new System.Drawing.Point(246, 12);
            this.githubButton.Name = "githubButton";
            this.githubButton.Size = new System.Drawing.Size(111, 38);
            this.githubButton.TabIndex = 5;
            this.githubButton.Text = "Source Code";
            this.githubButton.UseVisualStyleBackColor = true;
            this.githubButton.Click += new System.EventHandler(this.githubButton_Click);
            // 
            // progressLabel
            // 
            this.progressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressLabel.AutoSize = true;
            this.progressLabel.BackColor = System.Drawing.Color.Transparent;
            this.progressLabel.Location = new System.Drawing.Point(12, 416);
            this.progressLabel.MaximumSize = new System.Drawing.Size(475, 0);
            this.progressLabel.MinimumSize = new System.Drawing.Size(100, 0);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(116, 13);
            this.progressLabel.TabIndex = 6;
            this.progressLabel.Text = "All files are Up-To-Date";
            this.progressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // repairButton
            // 
            this.repairButton.Location = new System.Drawing.Point(501, 12);
            this.repairButton.Name = "repairButton";
            this.repairButton.Size = new System.Drawing.Size(111, 38);
            this.repairButton.TabIndex = 5;
            this.repairButton.Text = "Repair";
            this.repairButton.UseVisualStyleBackColor = true;
            this.repairButton.Click += new System.EventHandler(this.repairButton_Click);
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 474);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.repairButton);
            this.Controls.Add(this.githubButton);
            this.Controls.Add(this.gameSiteButton);
            this.Controls.Add(this.portfolioButton);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.playButton);
            this.Name = "Launcher";
            this.Text = "Launcher v0.0.2";
            this.Load += new System.EventHandler(this.Launcher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button portfolioButton;
        private System.Windows.Forms.Button gameSiteButton;
        private System.Windows.Forms.Button githubButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Button repairButton;
    }
}

