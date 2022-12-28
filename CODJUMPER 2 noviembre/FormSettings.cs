using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace CODJUMPER_2_noviembre
{
    public partial class FormSettings : Form
    {
        public static string databasefolder;
        public static string filepath;
        public static string filepathdtb;

        public static string database;
        public static string databasecustoms1folder;
        public static string databasecustoms2folder;
        public static string databasecustoms3folder;
        public static string databasecustoms4folder;
        public static string databasecustoms5folder;

        public static string devmapdefaultcheckbox;
        public static string devmapdefaultstate;
        public static string cfgdefaultname;
        public static string cfgdefaultargument;
        public static string cfgdefaultstate;
        public static string linedevmapdefaultcheckbox;
        public static string linedevmapdefaultstate;
        public static string linecfgdefaultargument;
        public static string linecfgdefaultstate;
        public static string databasesettings;
        public string pathstringdefault;

        public static string devmappromodcheckbox;
        public static string devmappromodstate;
        public static string cfgpromodname;
        public static string cfgpromodargument;
        public static string cfgpromodstate;
        public static string linedevmappromodcheckbox;
        public static string linedevmappromodstate;
        public static string linecfgpromodargument;
        public static string linecfgpromodstate;
        public string pathstringpromod;

        public static string devmapcodjumpercheckbox;
        public static string devmapcodjumperstate;
        public static string cfgcodjumpername;
        public static string cfgcodjumperargument;
        public static string cfgcodjumperstate;
        public static string linedevmapcodjumpercheckbox;
        public static string linedevmapcodjumperstate;
        public static string linecfgcodjumperargument;
        public static string linecfgcodjumperstate;
        public string pathstringcodjumper;
        public FormSettings()
        {
            InitializeComponent();

            lblfilepath.Text = filepathdtb;

            devmapdefaultcheckbox = "+map ";
            devmapdefaultstate = "disabled";
            devmappromodcheckbox = "+map ";
            devmappromodstate = "disabled";
            devmapcodjumpercheckbox = "+map ";
            devmapcodjumperstate = "disabled";
        }

        private void btnsettingsfilepath_Click(object sender, EventArgs e)
        {
            databasefolder = "database";
            Directory.CreateDirectory("database");
            databasesettings = Path.Combine(databasefolder, "dtbsettings");
            Directory.CreateDirectory(databasesettings);
            databasecustoms1folder = Path.Combine(databasefolder, "dtbcustoms1");
            Directory.CreateDirectory(databasecustoms1folder);
            databasecustoms2folder = Path.Combine(databasefolder, "dtbcustoms2");
            Directory.CreateDirectory(databasecustoms2folder);
            databasecustoms3folder = Path.Combine(databasefolder, "dtbcustoms3");
            Directory.CreateDirectory(databasecustoms3folder);
            databasecustoms4folder = Path.Combine(databasefolder, "dtbcustoms4");
            Directory.CreateDirectory(databasecustoms4folder);
            databasecustoms5folder = Path.Combine(databasefolder, "dtbcustoms5");
            Directory.CreateDirectory(databasecustoms5folder);


            OpenFileDialog ofdfilepath = new OpenFileDialog();
            ofdfilepath.Title = "Select your Call of Duy 4 Multiplayer executable";
            ofdfilepath.InitialDirectory = @"C:\";
            ofdfilepath.DefaultExt = ".exe";
            ofdfilepath.Filter = "executable (*.exe)|*.exe";
            if (ofdfilepath.ShowDialog() == DialogResult.OK)
            {
                filepath = ofdfilepath.FileName;
            }
            using (StreamWriter swfilepath = new StreamWriter("./database/dtbfilepath.txt"))
            {
                swfilepath.WriteLine(filepath);
                swfilepath.Close();
            }
            var txtdtbfilepath = ("./database/dtbfilepath.txt");
            using (var srdtbpathfile = new StreamReader(txtdtbfilepath))
            {
                filepathdtb = srdtbpathfile.ReadLine();
                
            }

        }

        private void chboxsettingsdefaultdevmap_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxsettingsdefaultdevmap.Checked == true)
            {
                devmapdefaultcheckbox = "+devmap ";
                devmapdefaultstate = "enabled";
            }
            if (chboxsettingsdefaultdevmap.Checked == false)
            {
                devmapdefaultcheckbox = "+map ";
                devmapdefaultstate = "disabled";
            }

        }

        private void btnsettingssavedefault_Click(object sender, EventArgs e)
        {
            cfgdefaultname = txtboxsettingsdefaultcfg.Text.ToString();

            if (cfgdefaultname != "")
            {
                cfgdefaultargument = "+exec " + cfgdefaultname + ".cfg ";
                cfgdefaultstate = cfgdefaultname;
            }
            else
            {
                cfgdefaultargument = "";
                cfgdefaultstate = "";
            }

            using (StreamWriter swdtbdefault = new StreamWriter("./database/dtbsettings/dtbdefault.txt"))
            {
                swdtbdefault.WriteLine(devmapdefaultcheckbox);
                swdtbdefault.WriteLine(devmapdefaultstate);
                swdtbdefault.WriteLine(cfgdefaultargument);
                swdtbdefault.WriteLine(cfgdefaultstate);
                swdtbdefault.Close();
            }
            var dtbdefaultpath = ("./database/dtbsettings/dtbdefault.txt");
            using (var srdtbdefault = new StreamReader(dtbdefaultpath))
            {
                linedevmapdefaultcheckbox = srdtbdefault.ReadLine();
                linedevmapdefaultstate = srdtbdefault.ReadLine();
                linecfgdefaultargument = srdtbdefault.ReadLine();
                linecfgdefaultstate = srdtbdefault.ReadLine();
            }
        }

        private void chboxsettingsdefaultpromod_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxsettingsdefaultpromod.Checked == true)
            {
                devmappromodcheckbox = "+devmap ";
                devmappromodstate = "enabled";
            }
            if (chboxsettingsdefaultpromod.Checked == false)
            {
                devmappromodcheckbox = "+map ";
                devmappromodstate = "disabled";
            }
        }

        private void btnsettingssavepromod_Click(object sender, EventArgs e)
        {
            cfgpromodname = txtboxsettingspromodcfg.Text.ToString();

            if (cfgpromodname != "")
            {
                cfgpromodargument = "+exec " + cfgpromodname + ".cfg ";
                cfgpromodstate = cfgpromodname;
            }
            else
            {
                cfgpromodargument = "";
                cfgpromodstate = "";
            }

            using (StreamWriter swdtbpromod = new StreamWriter("./database/dtbsettings/dtbpromod.txt"))
            {
                swdtbpromod.WriteLine(devmappromodcheckbox);
                swdtbpromod.WriteLine(devmappromodstate);
                swdtbpromod.WriteLine(cfgpromodargument);
                swdtbpromod.WriteLine(cfgpromodstate);
                swdtbpromod.Close();
            }
            var dtbpromodpath = ("./database/dtbsettings/dtbpromod.txt");
            using (var srdtbpromod = new StreamReader(dtbpromodpath))
            {
                linedevmappromodcheckbox = srdtbpromod.ReadLine();
                linedevmappromodstate = srdtbpromod.ReadLine();
                linecfgpromodargument = srdtbpromod.ReadLine();
                linecfgpromodstate = srdtbpromod.ReadLine();
            }
        }

        private void chboxsettingscodjumperdevmap_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxsettingscodjumperdevmap.Checked == true)
            {
                devmapcodjumpercheckbox = "+devmap ";
                devmapcodjumperstate = "enabled";
            }
            if (chboxsettingscodjumperdevmap.Checked == false)
            {
                devmapcodjumpercheckbox = "+map ";
                devmapcodjumperstate = "disabled";
            }
        }

        private void btnsettingssavecodjumper_Click(object sender, EventArgs e)
        {
            cfgcodjumpername = txtboxsettingscodjumpercfg.Text.ToString();

            if (cfgcodjumpername != "")
            {
                cfgcodjumperargument = "+exec " + cfgcodjumpername + ".cfg ";
                cfgcodjumperstate = cfgcodjumpername;
            }
            else
            {
                cfgcodjumperargument = "";
                cfgcodjumperstate = "";
            }

            using (StreamWriter swdtbcodjumper = new StreamWriter("./database/dtbsettings/dtbcodjumper.txt"))
            {
                swdtbcodjumper.WriteLine(devmapcodjumpercheckbox);
                swdtbcodjumper.WriteLine(devmapcodjumperstate);
                swdtbcodjumper.WriteLine(cfgcodjumperargument);
                swdtbcodjumper.WriteLine(cfgcodjumperstate);
                swdtbcodjumper.Close();
            }
            var dtbcodjumperpath = ("./database/dtbsettings/dtbcodjumper.txt");
            using (var srdtbcodjumper = new StreamReader(dtbcodjumperpath))
            {
                linedevmapcodjumpercheckbox = srdtbcodjumper.ReadLine();
                linedevmapcodjumperstate = srdtbcodjumper.ReadLine();
                linecfgcodjumperargument = srdtbcodjumper.ReadLine();
                linecfgcodjumperstate = srdtbcodjumper.ReadLine();
            }
        }

        private void btnsettingsdefaultinfo_Click(object sender, EventArgs e)
        {
          FormSettingsInfoDefault show = new FormSettingsInfoDefault();
            show.ShowDialog();
        }

        private void btnsettingspromodinfo_Click(object sender, EventArgs e)
        {
            FormSettingsInfoPromod show = new FormSettingsInfoPromod();
            show.ShowDialog();
        }

        private void btnsettingscodjumperinfo_Click(object sender, EventArgs e)
        {
            FormSettingsInfoCoDJumper show = new FormSettingsInfoCoDJumper();
            show.ShowDialog();
        }
    }
    
}
