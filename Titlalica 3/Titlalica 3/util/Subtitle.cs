using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titlalica_3.util {
    public class Subtitle {

        String title;
        private String version;
        private int numberOfDiscs;
        private String fps;
        private String downloadURL;
        private String fileURL;
        private String format;

        public String Title {
            get { return title; }
            set { title = value; }
        }

        public String Version {
            get { return version; }
            set { version = value; }
        }

        public int NumberOfDiscs {
            get { return numberOfDiscs; }
            set { numberOfDiscs = value; }
        }

        public String FPS {
            get { return fps; }
            set { fps = value; }
        }

        public String DownloadURL {
            get { return downloadURL; }
            set { downloadURL = value; }
        }

        public String FileURL {
            get { return fileURL; }
            set { fileURL = value; }
        }

        public String Format {
            get { return format; }
            set { format = value; }
        }

        public Subtitle(String title, String version, String downloadURL, String FPS, int number) {
            this.title = title;
            this.version = version;
            this.downloadURL = downloadURL;
            this.fps = FPS;
            this.numberOfDiscs = number;
        }
    }
}