using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CODJUMPER_2_noviembre
{
    public partial class SettingsCustom3pt2 : Form
    {
        // strings C3B7
        public string C3B7devmapcheckbox;
        public string C3B7devmapstate;
        public string C3B7cfgname;
        public string C3B7cfgargument;
        public string C3B7cfgstate;
        public string databaseC3B7path;
        public static string lineC3B7devmapcheckbox;
        public static string lineC3B7devmapstate;
        public static string lineC3B7cfgargument;
        public static string lineC3B7cfgstate;
        public static string C3B7mapname;
        public static string C3B7mapnamefixed;
        public static string lineC3B7mapname;
        public static string lineC3B7mapnamefixed;

        // strings C3B8
        public string C3B8devmapcheckbox;
        public string C3B8devmapstate;
        public string C3B8cfgname;
        public string C3B8cfgargument;
        public string C3B8cfgstate;
        public string databaseC3B8path;
        public static string lineC3B8devmapcheckbox;
        public static string lineC3B8devmapstate;
        public static string lineC3B8cfgargument;
        public static string lineC3B8cfgstate;
        public static string C3B8mapname;
        public static string C3B8mapnamefixed;
        public static string lineC3B8mapname;
        public static string lineC3B8mapnamefixed;

        // strings C3B9
        public string C3B9devmapcheckbox;
        public string C3B9devmapstate;
        public string C3B9cfgname;
        public string C3B9cfgargument;
        public string C3B9cfgstate;
        public string databaseC3B9path;
        public static string lineC3B9devmapcheckbox;
        public static string lineC3B9devmapstate;
        public static string lineC3B9cfgargument;
        public static string lineC3B9cfgstate;
        public static string C3B9mapname;
        public static string C3B9mapnamefixed;
        public static string lineC3B9mapname;
        public static string lineC3B9mapnamefixed;

        // strings C3B10
        public string C3B10devmapcheckbox;
        public string C3B10devmapstate;
        public string C3B10cfgname;
        public string C3B10cfgargument;
        public string C3B10cfgstate;
        public string databaseC3B10path;
        public static string lineC3B10devmapcheckbox;
        public static string lineC3B10devmapstate;
        public static string lineC3B10cfgargument;
        public static string lineC3B10cfgstate;
        public static string C3B10mapname;
        public static string C3B10mapnamefixed;
        public static string lineC3B10mapname;
        public static string lineC3B10mapnamefixed;

        // strings C3B11
        public string C3B11devmapcheckbox;
        public string C3B11devmapstate;
        public string C3B11cfgname;
        public string C3B11cfgargument;
        public string C3B11cfgstate;
        public string databaseC3B11path;
        public static string lineC3B11devmapcheckbox;
        public static string lineC3B11devmapstate;
        public static string lineC3B11cfgargument;
        public static string lineC3B11cfgstate;
        public static string C3B11mapname;
        public static string C3B11mapnamefixed;
        public static string lineC3B11mapname;
        public static string lineC3B11mapnamefixed;

        // strings C3B12
        public string C3B12devmapcheckbox;
        public string C3B12devmapstate;
        public string C3B12cfgname;
        public string C3B12cfgargument;
        public string C3B12cfgstate;
        public string databaseC3B12path;
        public static string lineC3B12devmapcheckbox;
        public static string lineC3B12devmapstate;
        public static string lineC3B12cfgargument;
        public static string lineC3B12cfgstate;
        public static string C3B12mapname;
        public static string C3B12mapnamefixed;
        public static string lineC3B12mapname;
        public static string lineC3B12mapnamefixed;
        public SettingsCustom3pt2()
        {
            InitializeComponent();

            C3B7devmapcheckbox = "+map ";
            C3B7devmapstate = "disabled";
            C3B8devmapcheckbox = "+map ";
            C3B8devmapstate = "disabled";
            C3B9devmapcheckbox = "+map ";
            C3B9devmapstate = "disabled";
            C3B10devmapcheckbox = "+map ";
            C3B10devmapstate = "disabled";
            C3B11devmapcheckbox = "+map ";
            C3B11devmapstate = "disabled";
            C3B12devmapcheckbox = "+map ";
            C3B12devmapstate = "disabled";
        }

        // C3B7
        private void C3B7devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C3B7devmap.Checked == true)
            {
                C3B7devmapcheckbox = "+devmap ";
                C3B7devmapstate = "enabled";
            }
            if (C3B7devmap.Checked == false)
            {
                C3B7devmapcheckbox = "+map ";
                C3B7devmapstate = "disabled";
            }
        }

        private void C3B7save_Click(object sender, EventArgs e)
        {
            C3B7cfgname = C3B7cfg.Text.ToString();

            if (C3B7cfgname != "")
            {
                C3B7cfgargument = "+exec " + C3B7cfgname + ".cfg ";
                C3B7cfgstate = C3B7cfgname;
            }
            else
            {
                C3B7cfgargument = "";
                C3B7cfgstate = "";
            }

            C3B7mapname = C3B7map.Text.ToString();

            if (C3B7mapname.Contains("mp_"))
            {
                string C3B7mapnameaux = C3B7mapname;
                C3B7mapnamefixed = C3B7mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC3B7 = new StreamWriter("./database/dtbcustoms3/C3B7.txt"))
            {
                swdtbC3B7.WriteLine(C3B7devmapcheckbox);
                swdtbC3B7.WriteLine(C3B7devmapstate);
                swdtbC3B7.WriteLine(C3B7cfgargument);
                swdtbC3B7.WriteLine(C3B7cfgstate);
                swdtbC3B7.WriteLine(C3B7mapname);
                swdtbC3B7.WriteLine(C3B7mapnamefixed);
                swdtbC3B7.Close();
            }
            databaseC3B7path = ("./database/dtbcustoms3/C3B7.txt");

            using (var srdtbC3B7 = new StreamReader(databaseC3B7path))
            {
                lineC3B7devmapcheckbox = srdtbC3B7.ReadLine();
                lineC3B7devmapstate = srdtbC3B7.ReadLine();
                lineC3B7cfgargument = srdtbC3B7.ReadLine();
                lineC3B7cfgstate = srdtbC3B7.ReadLine();
                lineC3B7mapname = srdtbC3B7.ReadLine();
                lineC3B7mapnamefixed = srdtbC3B7.ReadLine();
            }
        }

        private void C3B7info_Click(object sender, EventArgs e)
        {
            c3start7info show = new c3start7info();
            show.ShowDialog();
        }

        // C3B8
        private void C3B8devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C3B8devmap.Checked == true)
            {
                C3B8devmapcheckbox = "+devmap ";
                C3B8devmapstate = "enabled";
            }
            if (C3B8devmap.Checked == false)
            {
                C3B8devmapcheckbox = "+map ";
                C3B8devmapstate = "disabled";
            }
        }

        private void C3B8save_Click(object sender, EventArgs e)
        {
            C3B8cfgname = C3B8cfg.Text.ToString();

            if (C3B8cfgname != "")
            {
                C3B8cfgargument = "+exec " + C3B8cfgname + ".cfg ";
                C3B8cfgstate = C3B8cfgname;
            }
            else
            {
                C3B8cfgargument = "";
                C3B8cfgstate = "";
            }

            C3B8mapname = C3B8map.Text.ToString();

            if (C3B8mapname.Contains("mp_"))
            {
                string C3B8mapnameaux = C3B8mapname;
                C3B8mapnamefixed = C3B8mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC3B8 = new StreamWriter("./database/dtbcustoms3/C3B8.txt"))
            {
                swdtbC3B8.WriteLine(C3B8devmapcheckbox);
                swdtbC3B8.WriteLine(C3B8devmapstate);
                swdtbC3B8.WriteLine(C3B8cfgargument);
                swdtbC3B8.WriteLine(C3B8cfgstate);
                swdtbC3B8.WriteLine(C3B8mapname);
                swdtbC3B8.WriteLine(C3B8mapnamefixed);
                swdtbC3B8.Close();
            }
            databaseC3B8path = ("./database/dtbcustoms3/C3B8.txt");

            using (var srdtbC3B8 = new StreamReader(databaseC3B8path))
            {
                lineC3B8devmapcheckbox = srdtbC3B8.ReadLine();
                lineC3B8devmapstate = srdtbC3B8.ReadLine();
                lineC3B8cfgargument = srdtbC3B8.ReadLine();
                lineC3B8cfgstate = srdtbC3B8.ReadLine();
                lineC3B8mapname = srdtbC3B8.ReadLine();
                lineC3B8mapnamefixed = srdtbC3B8.ReadLine();
            }
        }

        private void C3B8info_Click(object sender, EventArgs e)
        {
            c3start8info show = new c3start8info();
            show.ShowDialog();
        }

        // C3B9
        private void C3B9devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C3B9devmap.Checked == true)
            {
                C3B9devmapcheckbox = "+devmap ";
                C3B9devmapstate = "enabled";
            }
            if (C3B9devmap.Checked == false)
            {
                C3B9devmapcheckbox = "+map ";
                C3B9devmapstate = "disabled";
            }
        }

        private void C3B9save_Click(object sender, EventArgs e)
        {
            C3B9cfgname = C3B9cfg.Text.ToString();

            if (C3B9cfgname != "")
            {
                C3B9cfgargument = "+exec " + C3B9cfgname + ".cfg ";
                C3B9cfgstate = C3B9cfgname;
            }
            else
            {
                C3B9cfgargument = "";
                C3B9cfgstate = "";
            }

            C3B9mapname = C3B9map.Text.ToString();

            if (C3B9mapname.Contains("mp_"))
            {
                string C3B9mapnameaux = C3B9mapname;
                C3B9mapnamefixed = C3B9mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC3B9 = new StreamWriter("./database/dtbcustoms3/C3B9.txt"))
            {
                swdtbC3B9.WriteLine(C3B9devmapcheckbox);
                swdtbC3B9.WriteLine(C3B9devmapstate);
                swdtbC3B9.WriteLine(C3B9cfgargument);
                swdtbC3B9.WriteLine(C3B9cfgstate);
                swdtbC3B9.WriteLine(C3B9mapname);
                swdtbC3B9.WriteLine(C3B9mapnamefixed);
                swdtbC3B9.Close();
            }
            databaseC3B9path = ("./database/dtbcustoms3/C3B9.txt");

            using (var srdtbC3B9 = new StreamReader(databaseC3B9path))
            {
                lineC3B9devmapcheckbox = srdtbC3B9.ReadLine();
                lineC3B9devmapstate = srdtbC3B9.ReadLine();
                lineC3B9cfgargument = srdtbC3B9.ReadLine();
                lineC3B9cfgstate = srdtbC3B9.ReadLine();
                lineC3B9mapname = srdtbC3B9.ReadLine();
                lineC3B9mapnamefixed = srdtbC3B9.ReadLine();
            }
        }

        private void C3B9info_Click(object sender, EventArgs e)
        {
            c3start9info show = new c3start9info();
            show.ShowDialog();
        }


        // C3B10
        private void C3B10devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C3B10devmap.Checked == true)
            {
                C3B10devmapcheckbox = "+devmap ";
                C3B10devmapstate = "enabled";
            }
            if (C3B10devmap.Checked == false)
            {
                C3B10devmapcheckbox = "+map ";
                C3B10devmapstate = "disabled";
            }
        }

        private void C3B10save_Click(object sender, EventArgs e)
        {
            C3B10cfgname = C3B10cfg.Text.ToString();

            if (C3B10cfgname != "")
            {
                C3B10cfgargument = "+exec " + C3B10cfgname + ".cfg ";
                C3B10cfgstate = C3B10cfgname;
            }
            else
            {
                C3B10cfgargument = "";
                C3B10cfgstate = "";
            }

            C3B10mapname = C3B10map.Text.ToString();

            if (C3B10mapname.Contains("mp_"))
            {
                string C3B10mapnameaux = C3B10mapname;
                C3B10mapnamefixed = C3B10mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC3B10 = new StreamWriter("./database/dtbcustoms3/C3B10.txt"))
            {
                swdtbC3B10.WriteLine(C3B10devmapcheckbox);
                swdtbC3B10.WriteLine(C3B10devmapstate);
                swdtbC3B10.WriteLine(C3B10cfgargument);
                swdtbC3B10.WriteLine(C3B10cfgstate);
                swdtbC3B10.WriteLine(C3B10mapname);
                swdtbC3B10.WriteLine(C3B10mapnamefixed);
                swdtbC3B10.Close();
            }
            databaseC3B10path = ("./database/dtbcustoms3/C3B10.txt");

            using (var srdtbC3B10 = new StreamReader(databaseC3B10path))
            {
                lineC3B10devmapcheckbox = srdtbC3B10.ReadLine();
                lineC3B10devmapstate = srdtbC3B10.ReadLine();
                lineC3B10cfgargument = srdtbC3B10.ReadLine();
                lineC3B10cfgstate = srdtbC3B10.ReadLine();
                lineC3B10mapname = srdtbC3B10.ReadLine();
                lineC3B10mapnamefixed = srdtbC3B10.ReadLine();
            }
        }

        private void C3B10info_Click(object sender, EventArgs e)
        {
            c3start10info show = new c3start10info();
            show.ShowDialog();
        }


        // C3B11
        private void C3B11devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C3B11devmap.Checked == true)
            {
                C3B11devmapcheckbox = "+devmap ";
                C3B11devmapstate = "enabled";
            }
            if (C3B11devmap.Checked == false)
            {
                C3B11devmapcheckbox = "+map ";
                C3B11devmapstate = "disabled";
            }
        }

        private void C3B11save_Click(object sender, EventArgs e)
        {
            C3B11cfgname = C3B11cfg.Text.ToString();

            if (C3B11cfgname != "")
            {
                C3B11cfgargument = "+exec " + C3B11cfgname + ".cfg ";
                C3B11cfgstate = C3B11cfgname;
            }
            else
            {
                C3B11cfgargument = "";
                C3B11cfgstate = "";
            }

            C3B11mapname = C3B11map.Text.ToString();

            if (C3B11mapname.Contains("mp_"))
            {
                string C3B11mapnameaux = C3B11mapname;
                C3B11mapnamefixed = C3B11mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC3B11 = new StreamWriter("./database/dtbcustoms3/C3B11.txt"))
            {
                swdtbC3B11.WriteLine(C3B11devmapcheckbox);
                swdtbC3B11.WriteLine(C3B11devmapstate);
                swdtbC3B11.WriteLine(C3B11cfgargument);
                swdtbC3B11.WriteLine(C3B11cfgstate);
                swdtbC3B11.WriteLine(C3B11mapname);
                swdtbC3B11.WriteLine(C3B11mapnamefixed);
                swdtbC3B11.Close();
            }
            databaseC3B11path = ("./database/dtbcustoms3/C3B11.txt");

            using (var srdtbC3B11 = new StreamReader(databaseC3B11path))
            {
                lineC3B11devmapcheckbox = srdtbC3B11.ReadLine();
                lineC3B11devmapstate = srdtbC3B11.ReadLine();
                lineC3B11cfgargument = srdtbC3B11.ReadLine();
                lineC3B11cfgstate = srdtbC3B11.ReadLine();
                lineC3B11mapname = srdtbC3B11.ReadLine();
                lineC3B11mapnamefixed = srdtbC3B11.ReadLine();
            }
        }

        private void C3B11info_Click(object sender, EventArgs e)
        {
            c3start11info show = new c3start11info();
            show.ShowDialog();
        }

        // C3B12
        private void C3B12devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C3B12devmap.Checked == true)
            {
                C3B12devmapcheckbox = "+devmap ";
                C3B12devmapstate = "enabled";
            }
            if (C3B12devmap.Checked == false)
            {
                C3B12devmapcheckbox = "+map ";
                C3B12devmapstate = "disabled";
            }
        }

        private void C3B12save_Click(object sender, EventArgs e)
        {
            C3B12cfgname = C3B12cfg.Text.ToString();

            if (C3B12cfgname != "")
            {
                C3B12cfgargument = "+exec " + C3B12cfgname + ".cfg ";
                C3B12cfgstate = C3B12cfgname;
            }
            else
            {
                C3B12cfgargument = "";
                C3B12cfgstate = "";
            }

            C3B12mapname = C3B12map.Text.ToString();

            if (C3B12mapname.Contains("mp_"))
            {
                string C1B12mapnameaux = C3B12mapname;
                C3B12mapnamefixed = C1B12mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC3B12 = new StreamWriter("./database/dtbcustoms3/C3B12.txt"))
            {
                swdtbC3B12.WriteLine(C3B12devmapcheckbox);
                swdtbC3B12.WriteLine(C3B12devmapstate);
                swdtbC3B12.WriteLine(C3B12cfgargument);
                swdtbC3B12.WriteLine(C3B12cfgstate);
                swdtbC3B12.WriteLine(C3B12mapname);
                swdtbC3B12.WriteLine(C3B12mapnamefixed);
                swdtbC3B12.Close();
            }
            databaseC3B12path = ("./database/dtbcustoms3/C3B12.txt");

            using (var srdtbC3B12 = new StreamReader(databaseC3B12path))
            {
                lineC3B12devmapcheckbox = srdtbC3B12.ReadLine();
                lineC3B12devmapstate = srdtbC3B12.ReadLine();
                lineC3B12cfgargument = srdtbC3B12.ReadLine();
                lineC3B12cfgstate = srdtbC3B12.ReadLine();
                lineC3B12mapname = srdtbC3B12.ReadLine();
                lineC3B12mapnamefixed = srdtbC3B12.ReadLine();
            }
        }

        private void C3B12info_Click(object sender, EventArgs e)
        {
            c3start12info show = new c3start12info();
            show.ShowDialog();
        }
    }
}
