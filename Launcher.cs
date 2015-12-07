using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.ComponentModel;
using System.IO.Compression;
using System.Drawing;
using System.Security.Cryptography;

namespace Launcher {
    public partial class Launcher : Form {
        
        string _gameExe = "spaceshooter.exe";
        string _fileVersion = "game.version";
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


        public Launcher() {
            InitializeComponent();
            _gameExe = Application.StartupPath + "/game/" + _gameExe;
            _fileVersion = Application.StartupPath + "/game/" + _fileVersion;
            // Timer for drawing ProgressBar UI
            _renderTimer = new Timer();
            _renderTimer.Interval = 10;
            _renderTimer.Tick += _renderTimer_Tick;
        }

        private void Launcher_Load(object sender, EventArgs e) {

            // Check and save current version
            if (File.Exists(_fileVersion)) {
                _currentVersion = File.ReadAllText(_fileVersion);
            }

            // Connect with server to get serverVersion
            WebRequest webReq = WebRequest.Create(_serverURL);
            WebResponse webRes = webReq.GetResponse();
            StreamReader StrReader = new StreamReader(webRes.GetResponseStream());
            _serverVersion = StrReader.ReadToEnd();

            Console.WriteLine(_serverVersion);

            // Check if your version is outdated or not
            if (_serverVersion != _currentVersion) {
                Console.WriteLine("There is a new version available!");
                Download();
            } else {
                Console.WriteLine("You are Up-To-Date!");
                playButton.Enabled = true;
            }
        }

        // Download new version
        private void Download() {
            _renderTimer.Start();
            _fileToDownload = _serverPatchURL + _serverVersion + ".zip";
            _downloadedFile = Application.StartupPath + "/game/" + _serverVersion + ".zip";

            Console.WriteLine("Starting download...");

            // Download ZIP from server
            WebClient client = new WebClient();
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgression);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadComplete);
            client.DownloadFileAsync(new Uri(_fileToDownload), _downloadedFile);
        }

        private void DownloadProgression(object sender, DownloadProgressChangedEventArgs e) {
            _progressValue = e.ProgressPercentage;
            _byteIndex = e.BytesReceived;
            _bytesTotal = e.TotalBytesToReceive;
        }

        private void DownloadComplete(object sender, AsyncCompletedEventArgs e) {
            Console.WriteLine("Download Completed");
            // Update local version number
            _currentVersion = _serverVersion;
            File.WriteAllText(_fileVersion, _currentVersion);

            // Update UI
            UpdateUI();

            // Extract downloaded ZIP
            progressLabel.Text = "Extracting Files...";
            ZipFile.ExtractToDirectory(_downloadedFile, Application.StartupPath + "/game/");
            progressLabel.Text = "Update Complete";
            
            // Remove ZIP after Extracting
            File.Delete(_downloadedFile);
            _renderTimer.Stop();
        }

        private void CheckFiles() {
            _fileToDownload = _serverPatchURL + _serverVersion + ".zip";
            string zipFileLoc = Application.StartupPath + "/temp.zip";
            
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

            if (md5.ComputeHash(streamClient) == md5.ComputeHash(streamServer)) {
                Console.WriteLine("Hashes are the same - Files up to date!");
                return true;
            } else {
                Console.WriteLine("Hashes are different, Files Out-Dated");
                return false;
            }

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
