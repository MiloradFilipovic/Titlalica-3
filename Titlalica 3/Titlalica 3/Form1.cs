using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Titlalica_3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            languageCB.SelectedIndex = 0;
            progressBar.Visible = false;
            for (int i = 0; i < 50; i++)
            {
                defaultTable.Rows.Add("1", "Batman The Dark Knight", "Batman.The.Dark.Knight.PROPPER.aXXo.740p", "1", "24");
                defaultTable.Rows.Add("1", "Batman The Dark Knight", "Batman.The.Dark.Knight.BRRip.Division.MultiSubs.14520p", "1", "N/A");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void defaultTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //CLICK NA SEARCH
        private void searchButton_Click(object sender, EventArgs e)
        {
            search("Batman");
        }

        //ENTER U TEXT BOX-u
        private void searchTF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search("Batman");
            }
        }

        public void search(String title)
        {
            MessageBox.Show("Trazim " + title + "!");
        }

    }
}
