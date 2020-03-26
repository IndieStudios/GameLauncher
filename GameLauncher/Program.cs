using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher
{
    static class Program
    {
        static void Main()
        {
            MainWindow mw = new MainWindow();
            mw.Text = "GameLauncher [UNLICENSED]";
            Application.EnableVisualStyles();
            Application.Run(mw);
        }
    }
}
