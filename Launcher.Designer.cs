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
            this.gameSiteButton = new System.Windows.Forms.Button();
            this.progressLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GameButton_01 = new System.Windows.Forms.Button();
            this.GameButton_02 = new System.Windows.Forms.Button();
            this.GameButton_03 = new System.Windows.Forms.Button();
            this.GameButton_04 = new System.Windows.Forms.Button();
            this.GameButton_05 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.repairButton = new System.Windows.Forms.Button();
            this.githubButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.playButton.Enabled = false;
            this.playButton.Location = new System.Drawing.Point(814, 523);
            this.playButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(107, 48);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(134, 538);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(671, 33);
            this.progressBar1.TabIndex = 1;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(134, 72);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScrollBarsEnabled = false;
            this.webBrowser.Size = new System.Drawing.Size(785, 435);
            this.webBrowser.TabIndex = 2;
            this.webBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // gameSiteButton
            // 
            this.gameSiteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gameSiteButton.Location = new System.Drawing.Point(586, 16);
            this.gameSiteButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gameSiteButton.Name = "gameSiteButton";
            this.gameSiteButton.Size = new System.Drawing.Size(112, 34);
            this.gameSiteButton.TabIndex = 4;
            this.gameSiteButton.Text = "Game Website";
            this.gameSiteButton.UseVisualStyleBackColor = true;
            this.gameSiteButton.Click += new System.EventHandler(this.gameSiteButton_Click);
            // 
            // progressLabel
            // 
            this.progressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressLabel.AutoSize = true;
            this.progressLabel.BackColor = System.Drawing.Color.Transparent;
            this.progressLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressLabel.Location = new System.Drawing.Point(136, 522);
            this.progressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.progressLabel.MaximumSize = new System.Drawing.Size(475, 0);
            this.progressLabel.MinimumSize = new System.Drawing.Size(100, 0);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(121, 14);
            this.progressLabel.TabIndex = 6;
            this.progressLabel.Text = "All files are Up-To-Date";
            this.progressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GameButton_01
            // 
            this.GameButton_01.Location = new System.Drawing.Point(13, 72);
            this.GameButton_01.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GameButton_01.Name = "GameButton_01";
            this.GameButton_01.Size = new System.Drawing.Size(105, 95);
            this.GameButton_01.TabIndex = 7;
            this.GameButton_01.Text = "Kingdom Of Madness";
            this.GameButton_01.UseVisualStyleBackColor = true;
            this.GameButton_01.Click += new System.EventHandler(this.GameButton_01_Click);
            // 
            // GameButton_02
            // 
            this.GameButton_02.Location = new System.Drawing.Point(13, 173);
            this.GameButton_02.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GameButton_02.Name = "GameButton_02";
            this.GameButton_02.Size = new System.Drawing.Size(105, 95);
            this.GameButton_02.TabIndex = 8;
            this.GameButton_02.Text = "Space Shooter";
            this.GameButton_02.UseVisualStyleBackColor = true;
            this.GameButton_02.Click += new System.EventHandler(this.GameButton_02_Click);
            // 
            // GameButton_03
            // 
            this.GameButton_03.Location = new System.Drawing.Point(13, 274);
            this.GameButton_03.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GameButton_03.Name = "GameButton_03";
            this.GameButton_03.Size = new System.Drawing.Size(105, 95);
            this.GameButton_03.TabIndex = 9;
            this.GameButton_03.Text = "Placeholder";
            this.GameButton_03.UseVisualStyleBackColor = true;
            this.GameButton_03.Click += new System.EventHandler(this.GameButton_03_Click);
            // 
            // GameButton_04
            // 
            this.GameButton_04.Location = new System.Drawing.Point(13, 375);
            this.GameButton_04.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GameButton_04.Name = "GameButton_04";
            this.GameButton_04.Size = new System.Drawing.Size(105, 95);
            this.GameButton_04.TabIndex = 10;
            this.GameButton_04.Text = "Placeholder";
            this.GameButton_04.UseVisualStyleBackColor = true;
            this.GameButton_04.Click += new System.EventHandler(this.GameButton_04_Click);
            // 
            // GameButton_05
            // 
            this.GameButton_05.Location = new System.Drawing.Point(13, 476);
            this.GameButton_05.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GameButton_05.Name = "GameButton_05";
            this.GameButton_05.Size = new System.Drawing.Size(105, 95);
            this.GameButton_05.TabIndex = 11;
            this.GameButton_05.Text = "Placeholder";
            this.GameButton_05.UseVisualStyleBackColor = true;
            this.GameButton_05.Click += new System.EventHandler(this.GameButton_05_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.4704F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 379F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel1.Controls.Add(this.repairButton, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.githubButton, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.gameSiteButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(929, 66);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // repairButton
            // 
            this.repairButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.repairButton.Location = new System.Drawing.Point(833, 16);
            this.repairButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.repairButton.Name = "repairButton";
            this.repairButton.Size = new System.Drawing.Size(88, 34);
            this.repairButton.TabIndex = 5;
            this.repairButton.Text = "Repair";
            this.repairButton.UseVisualStyleBackColor = true;
            this.repairButton.Click += new System.EventHandler(this.repairButton_Click);
            // 
            // githubButton
            // 
            this.githubButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.githubButton.Location = new System.Drawing.Point(710, 16);
            this.githubButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.githubButton.Name = "githubButton";
            this.githubButton.Size = new System.Drawing.Size(109, 34);
            this.githubButton.TabIndex = 5;
            this.githubButton.Text = "Source Code";
            this.githubButton.UseVisualStyleBackColor = true;
            this.githubButton.Click += new System.EventHandler(this.githubButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::Launcher.Properties.Resources.header_logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(9, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 39);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(929, 587);
            this.Controls.Add(this.GameButton_05);
            this.Controls.Add(this.GameButton_04);
            this.Controls.Add(this.GameButton_03);
            this.Controls.Add(this.GameButton_02);
            this.Controls.Add(this.GameButton_01);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Launcher";
            this.Text = "Launcher v0.0.3";
            this.Load += new System.EventHandler(this.Launcher_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button gameSiteButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Button GameButton_01;
        private System.Windows.Forms.Button GameButton_02;
        private System.Windows.Forms.Button GameButton_03;
        private System.Windows.Forms.Button GameButton_04;
        private System.Windows.Forms.Button GameButton_05;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button githubButton;
        private System.Windows.Forms.Button repairButton;
    }
}

