using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.ComponentModel;
using System.IO.Compression;
using System.Drawing;
using System.Security.Cryptography;

// Boy Voesten
// TODO: 
//      Replace hardcoded file paths
//      Repair game function (with progressbar)
//      

namespace Launcher {
    public partial class Launcher : Form {
        
        string _gameExe = "spaceshooter.exe";
        string _versionFile = "game.version";
        string _currentVersion = "";
        string _serverVersion;
        string _serverURL = "http://localhost/GetVersion.php";
        string _serverPatchURL = "http://localhost/patches/";

        string _fileToDownload;
        string _downloadedFile;
        Timer _renderTimer;
        long _byteIndex;
        long _bytesTotal;
        int _progressValue;
        private string _serverMD5;
        private bool _UpdateAvailable = false;

        public Launcher() {
            InitializeComponent();
            _gameExe = Application.StartupPath + "/game/" + _gameExe;
            _versionFile = Application.StartupPath + "/game/" + _versionFile;
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
                progressLabel.Text = "You are Up-To-Date";
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
            _downloadedFile = Application.StartupPath + "/game/" + _serverVersion + ".zip";

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
            // FIX "ALREADY EXISTS" ERROR
            ZipFile.ExtractToDirectory(_downloadedFile, Application.StartupPath + "/game/");
            /*using (ZipFile zip = ZipFile.Read(pathBackup)) {
                zip.ExtractAll(Environment.CurrentDirectory, ExtractExistingFileAction.OverwriteSilently);
            }*/
            progressLabel.Text = "Update Complete";
            
            // Remove ZIP after Extracting
            File.Delete(_downloadedFile);
            _renderTimer.Stop();
        }

        // Used to Repair the game files
        private void CheckFiles() {
            _fileToDownload = _serverPatchURL + _serverVersion + ".zip";
            string zipFileLoc = Application.StartupPath + "/temp.zip";

            if (File.Exists(zipFileLoc))
                File.Delete(zipFileLoc);

            ZipFile.CreateFromDirectory(Application.StartupPath + "/game/", zipFileLoc);
            Application.DoEvents();

            CompareMD5(zipFileLoc, _fileToDownload);
        }

        // Check if hashes are the same
        // TODO: Fix issue, read INFO.TXT
        private bool CompareMD5(string client, string server) {

            MD5 md5 = MD5.Create();
            FileStream streamClient = File.OpenRead(client);
            FileStream streamServer = File.OpenRead(server);

            Console.WriteLine(md5.ComputeHash(streamClient).ToString());
            if (md5.ComputeHash(streamClient).ToString() == _serverMD5) {
                Console.WriteLine("Hashes are the same - Files up to date!");
                return true;
            } else {
                Console.WriteLine("Hashes are different, Files Out-Dated");
                return false;
            }

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

            Console.WriteLine("webText: " + text);
            Console.WriteLine("Server Version: " + _serverVersion);
            Console.WriteLine("Server MD5: " + _serverMD5);
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
            //Console.WriteLine("FormatBytes: " + bytes + " to " + data + byteType);
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
        private void forumButton_Click(object sender, EventArgs e) {
            // Open Forum
        }
        private void youtubeButton_Click(object sender, EventArgs e) {
            // Open YouTube
        }
        private void facebookButton_Click(object sender, EventArgs e) {
            // Open Facebook
            CheckFiles();
        }

    }
}
