using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.ComponentModel;
using System.Security.Cryptography;
using System.IO.Compression;
using System.Collections.Generic;
using ExtendedZipFiles;

// Boy Voesten
// TODO: 
//      Replace hardcoded file paths / strings
//      Improve MD5 Repair file comparison (checksum?)

namespace Launcher {
    public partial class Launcher : Form {
        
        private string _gameExe         = "spaceshooter.exe";
        private string _gameDir         = Application.StartupPath + @"\game\";
        private string _versionFile     = "game.version";
        private string _currentVersion  = "0.0";
        private string _serverVersion;
        private string _serverURL       = "http://localhost/GetVersion.php";
        private string _serverPatchURL  = "http://localhost/patches/";
        private string _portfolio       = "http://boyvoesten.com/";
        private string _gameSie         = "http://boyvoesten.com/projects/steammachine.php";
        private string _github          = "https://github.com/221boy221/tower-defense";

        private string _fileToDownload;
        private string _downloadedFile;
        private Timer _renderTimer;
        private long _byteIndex;
        private long _bytesTotal;
        private int _progressValue;
        private string _serverMD5;
        private bool _UpdateAvailable = false;

        private Games.Game _currentGame;
        private List<Games.Game> _games = new List<Games.Game>();

        private void SetGames() {
            _games.Add(new Games.KingdomOfMadness());
            _gameExe = _games[1].Executable;
        }

        public Launcher() {
            InitializeComponent();

            

            _gameExe = _gameDir + _gameExe;
            _versionFile = _gameDir + _versionFile;
            // Timer for drawing ProgressBar UI
            _renderTimer = new Timer();
            _renderTimer.Interval = 10;
            _renderTimer.Tick += _renderTimer_Tick;
        }

        private void Launcher_Load(object sender, EventArgs e) {
            // Check and save current version
            if (File.Exists(_versionFile))
                _currentVersion = File.ReadAllText(_versionFile);
            
            // Get the latest version number
            GetServerVersion();

            // Compare client version with server version
            CheckForUpdates();
        }

        // Check if the client requires an update
        private void CheckForUpdates() {
            if (_currentVersion != _serverVersion) {
                progressLabel.Text = "There is a new version available!";
                Console.WriteLine(progressLabel.Text);
                _UpdateAvailable = true;
                playButton.Text = "Update";
            } else {
                progressLabel.Text = "All files are Up-To-Date";
                Console.WriteLine(progressLabel.Text);
                _UpdateAvailable = false;
                playButton.Text = "Play";
            }
            // After all the checks, turn the button on
            playButton.Enabled = true;
        }

        // Download new version
        private void Download() {
            _renderTimer.Start();
            _fileToDownload = _serverPatchURL + _serverVersion + ".zip";
            _downloadedFile = _gameDir + _serverVersion + ".zip";

            // In case there are leftovers from previous patches
            if (File.Exists(_downloadedFile))
                File.Delete(_downloadedFile);

            Console.WriteLine("Starting download...");

            // Download ZIP from server
            WebClient client = new WebClient();
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgression);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadComplete);
            client.DownloadFileAsync(new Uri(_fileToDownload), _downloadedFile);
        }

        // Update client feedback
        private void DownloadProgression(object sender, DownloadProgressChangedEventArgs e) {
            _progressValue = e.ProgressPercentage;
            _byteIndex = e.BytesReceived;
            _bytesTotal = e.TotalBytesToReceive;
        }

        // Done downloading
        private void DownloadComplete(object sender, AsyncCompletedEventArgs e) {
            Console.WriteLine("Download Completed");
            // Update client version number
            _currentVersion = _serverVersion;
            File.WriteAllText(_versionFile, _currentVersion);
            
            // Update UI
            UpdateUI();

            // Extract downloaded ZIP
            progressLabel.Text = "Extracting Files...";
            Compression.ImprovedExtractToDirectory(_downloadedFile, _gameDir, Compression.Overwrite.Always);
            progressLabel.Text = "Update Complete";
            
            // Remove ZIP after Extracting
            File.Delete(_downloadedFile);
            _renderTimer.Stop();
        }

        // Used to Repair the game files
        private void CheckFiles() {
            string clientZip = Application.StartupPath + "\\temp.zip";
            List<string> filesToZip = new List<string>();

            progressLabel.Text = "Repairing game files - This could take a while...";
            GetServerVersion();
            filesToZip.Add(_gameDir);

            try {
                ZipFile.CreateFromDirectory(_gameDir, clientZip);
                Console.WriteLine(clientZip);
                Console.WriteLine(filesToZip);
                //Compression.AddToArchive(clientZip, filesToZip);
            
            } catch (IOException) {
                MessageBox.Show("File is already in use. \nPlease close the game before repairing it.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Make sure to remove leftovers
                if (!File.Exists(clientZip))
                    return;
                File.Delete(clientZip);
                return;
            }

            Application.DoEvents();

            if (CompareMD5(clientZip)) {
                progressLabel.Text = "No missing files detected, everything is up-to-date.";
                return;
            }
                

            Console.WriteLine("Hash differs, download latest patch.");
            Download();
        }

        // Check if hashes are the same
        private bool CompareMD5(string clientZip) {
            MD5 md5 = MD5.Create();
            FileStream streamClient = File.OpenRead(clientZip);
            string clientHash = BitConverter.ToString(md5.ComputeHash(streamClient)).Replace("-", "").ToLower();

            Console.WriteLine("---------- COMPARE MD5 ----------");
            Console.WriteLine("Client: " + clientHash);
            Console.WriteLine("Server: " + _serverMD5);
            Console.WriteLine("---------------------------------");
            

            // Close & Clean up
            streamClient.Close();
            File.Delete(clientZip);

            return clientHash == _serverMD5;

        }

        // Gets the Version and MD5 of the latest patch
        private void GetServerVersion() {
            char[] ignoreChars = {'-'};
            string text;
            string[] data;

            WebRequest webReq = WebRequest.Create(_serverURL);
            WebResponse webRes = webReq.GetResponse();
            StreamReader StrReader = new StreamReader(webRes.GetResponseStream());
            text = StrReader.ReadToEnd();

            data = text.Split(ignoreChars);
            _serverVersion = data[1];
            _serverMD5 = data[2];

            Console.WriteLine("---------- SERVER INFO ----------");
            Console.WriteLine("Version: " + _serverVersion);
            Console.WriteLine("MD5: " + _serverMD5);
            Console.WriteLine("---------------------------------");
        }

        // Update UI
        private void _renderTimer_Tick(object sender, EventArgs e) {
            UpdateUI();
            Application.DoEvents();
        }

        private void UpdateUI() {
            progressLabel.Text = "Downloading... " + FormatBytes(_byteIndex) + " / " + FormatBytes(_bytesTotal);
            progressBar1.Value = _progressValue;
        }

        // To show the correct file sizes
        private string FormatBytes(long bytes) {
            float data = 0;
            string byteType = "";

            if (bytes >= 1024 * 1024 * 1024) {
                data = bytes / (1024 * 1024 * 1024);
                byteType = " GB";
            } else if (bytes >= 1024 * 1024) {
                data = bytes / (1024 * 1024);
                byteType = " MB";
            } else if (bytes >= 1024) {
                data = bytes / 1024f;
                byteType = " KB";
            } else {
                data = bytes;
                byteType = " Bytes";
            }

            return Math.Round(data, 3).ToString() + byteType;
        }


        // Clicks

        private void playButton_Click(object sender, EventArgs e) {
            // Download instead of play
            if (_UpdateAvailable) {
                Download();
                return;
            }

            // Play game
            Process.Start(_gameExe);
            Application.Exit();
        }
        private void portfolioButton_Click(object sender, EventArgs e) {
            // Open Portfolio
            Process.Start(_portfolio);
        }
        private void gameSiteButton_Click(object sender, EventArgs e) {
            // Open Game Website
            Process.Start(_gameSie);
        }
        private void githubButton_Click(object sender, EventArgs e) {
            // Open Source Code
            Process.Start(_github);
        }
        private void repairButton_Click(object sender, EventArgs e) {
            // Repair game files
            CheckFiles();
        }
    }
}
