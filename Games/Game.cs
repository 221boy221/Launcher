using System;

namespace Launcher.Games {
    class Game {

        // Default values, override them!
        protected string executable     = "placeholder.exe";
        protected string directory      = System.Windows.Forms.Application.StartupPath + @"\game\";
        protected string websiteURL     = "http://boyvoesten.com/";
        protected string serverURL      = "http://localhost/GetVersion.php";
        protected string serverPatchURL = "http://localhost/patches/";
        protected string sourceURL      = "https://github.com/221boy221";
        protected string newsfeed       = "http://127.0.0.1/launcher/placeholder.php";


        // Getters

        public string Executable {
            get {
                return executable;
            }
        }

        public string Directory {
            get {
                return directory;
            }
        }

        public string WebsiteURL {
            get {
                return websiteURL;
            }
        }

        public string ServerURL {
            get {
                return serverURL;
            }
        }

        public string ServerPatchURL {
            get {
                return serverPatchURL;
            }
        }

        public string SourceURL {
            get {
                return sourceURL;
            }
        }

        public string Newsfeed {
            get {
                return newsfeed;
            }
        }
    }
}
