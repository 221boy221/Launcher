using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher.Games {
    class Game {

        protected string executable;
        protected string directory;
        protected string websiteURL;
        protected string serverURL;
        protected string serverPatchURL;
        protected string githubURL;


        // Getters

        public string Executable
        {
            get
            {
                return executable;
            }
        }

        public string Directory
        {
            get
            {
                return directory;
            }
        }

        public string WebsiteURL
        {
            get
            {
                return websiteURL;
            }
        }

        public string ServerURL
        {
            get
            {
                return serverURL;
            }
        }

        public string ServerPatchURL
        {
            get
            {
                return serverPatchURL;
            }
        }

        public string GithubURL
        {
            get
            {
                return githubURL;
            }
        }


    }
}
