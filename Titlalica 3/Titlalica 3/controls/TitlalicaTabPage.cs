using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Titlalica_3.util;

namespace Titlalica_3 {
    public partial class TitlalicaTabPage : UserControl {

        //each page has its own subtitles list
        private List<Subtitle> subs;
        public List<Subtitle> Subs {
            get { return subs; }
            set { subs = value;}
        }

        public TitlalicaTabPage() {
            InitializeComponent();
        }
    }
}
