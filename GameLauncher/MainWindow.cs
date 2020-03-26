using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Credits credits = new Credits();
            //credits.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
