using System;
using Launcher.Server;

namespace Launcher.Games {
    class Game {

        // Default values, override them!
        protected string executable     = "placeholder.exe";
        protected string directory      = System.Windows.Forms.Application.StartupPath + @"\game\";
        protected string sourceURL      = "221boy221";
        // They all start at HostInfo.domain's root
        protected string websiteURL     = "";
        protected string serverURL      = "GetVersion.php";
        protected string serverPatchURL = "patches/";
        protected string newsfeed       = "placeholder.php";


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
                return HostInfo.domain + websiteURL;
            }
        }

        public string ServerURL {
            get {
                return HostInfo.domain + serverURL;
            }
        }

        public string ServerPatchURL {
            get {
                return HostInfo.domain + serverPatchURL;
            }
        }

        public string SourceURL {
            get {
                return HostInfo.github + sourceURL;
            }
        }

        public string Newsfeed {
            get {
                return HostInfo.domain + newsfeed;
            }
        }
    }
}
