using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace Launcher {
    public partial class Launcher : Form {

        string _gameExe = "spaceshooter.exe";
        string _fileVersion = "game.version";
        string _currentVersion = "";
        string _serverURL = "http://localhost/GetVersion.php";
        string _serverPatchURL = "http://localhost/patches/";

        public Launcher() {
            InitializeComponent();
            _gameExe = Application.StartupPath + "/" + _gameExe;
            _fileVersion = Application.StartupPath + "/" + _fileVersion;
        }

        private void Launcher_Load(object sender, EventArgs e) {
            // On Load
            
            // Check and save current version
            if (File.Exists(_fileVersion)) {
                _currentVersion = File.ReadAllText(_fileVersion);
            }

            // Connect with server and get serverVersion
            WebRequest webReq = WebRequest.Create(_serverURL);
            WebResponse webRes = webReq.GetResponse();
            StreamReader StrReader = new StreamReader(webRes.GetResponseStream());
            string serverVersion = StrReader.ReadToEnd();

            Console.WriteLine(serverVersion);

            // Check if your version is outdated or not
            if (serverVersion != _currentVersion) {
                Console.WriteLine("There is a new version!");
                webReq = WebRequest.Create(_serverPatchURL);
                webRes = webReq.GetResponse();
                StrReader = new StreamReader(webRes.GetResponseStream());
                // Download files
            } else {
                Console.WriteLine("You are Up-To-Date!");
                playButton.Enabled = true;
            }
            

            /*
            _versionInfo = FileVersionInfo.GetVersionInfo(_gameExe);
            string version = _versionInfo.ProductVersion;
            Console.WriteLine(version);
            */
        }

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
        }

        
    }
}
