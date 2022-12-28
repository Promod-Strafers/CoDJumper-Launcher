using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CODJUMPER_2_noviembre
{
    public partial class FormInfo : Form
    {
        public FormInfo()
        {
            InitializeComponent();
        }

        private void cjwebsite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.codjumper.com/",
                UseShellExecute = true
            });
        }

        private void cjyoutube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.youtube.com/@CoDJumper",
                UseShellExecute = true
            });
        }

        private void cjsteam_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://steamcommunity.com/groups/codjumper",
                UseShellExecute = true
            });
        }

        private void cjtwitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://twitter.com/codjumper",
                UseShellExecute = true
            });
        }

        private void cjfacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.facebook.com/CoDJumper",
                UseShellExecute = true
            });
        }

        private void flgithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/Forest-Lab",
                UseShellExecute = true
            });
        }

        private void flyoutube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.youtube.com/channel/UCwxV7KknHPzr7EAGy4ruX5w",
                UseShellExecute = true
            });
        }

        private void flsteam1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://steamcommunity.com/id/scaN_88",
                UseShellExecute = true
            });
        }

        private void flsteam2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://steamcommunity.com/id/snipcout",
                UseShellExecute = true
            });
        }
    }
}
