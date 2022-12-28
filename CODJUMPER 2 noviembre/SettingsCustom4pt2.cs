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
    public partial class SettingsCustom4pt2 : Form
    {
        // strings C4B7
        public string C4B7devmapcheckbox;
        public string C4B7devmapstate;
        public string C4B7cfgname;
        public string C4B7cfgargument;
        public string C4B7cfgstate;
        public string databaseC4B7path;
        public static string lineC4B7devmapcheckbox;
        public static string lineC4B7devmapstate;
        public static string lineC4B7cfgargument;
        public static string lineC4B7cfgstate;
        public static string C4B7mapname;
        public static string C4B7mapnamefixed;
        public static string lineC4B7mapname;
        public static string lineC4B7mapnamefixed;

        // strings C4B8
        public string C4B8devmapcheckbox;
        public string C4B8devmapstate;
        public string C4B8cfgname;
        public string C4B8cfgargument;
        public string C4B8cfgstate;
        public string databaseC4B8path;
        public static string lineC4B8devmapcheckbox;
        public static string lineC4B8devmapstate;
        public static string lineC4B8cfgargument;
        public static string lineC4B8cfgstate;
        public static string C4B8mapname;
        public static string C4B8mapnamefixed;
        public static string lineC4B8mapname;
        public static string lineC4B8mapnamefixed;

        // strings C4B9
        public string C4B9devmapcheckbox;
        public string C4B9devmapstate;
        public string C4B9cfgname;
        public string C4B9cfgargument;
        public string C4B9cfgstate;
        public string databaseC4B9path;
        public static string lineC4B9devmapcheckbox;
        public static string lineC4B9devmapstate;
        public static string lineC4B9cfgargument;
        public static string lineC4B9cfgstate;
        public static string C4B9mapname;
        public static string C4B9mapnamefixed;
        public static string lineC4B9mapname;
        public static string lineC4B9mapnamefixed;

        // strings C4B10
        public string C4B10devmapcheckbox;
        public string C4B10devmapstate;
        public string C4B10cfgname;
        public string C4B10cfgargument;
        public string C4B10cfgstate;
        public string databaseC4B10path;
        public static string lineC4B10devmapcheckbox;
        public static string lineC4B10devmapstate;
        public static string lineC4B10cfgargument;
        public static string lineC4B10cfgstate;
        public static string C4B10mapname;
        public static string C4B10mapnamefixed;
        public static string lineC4B10mapname;
        public static string lineC4B10mapnamefixed;

        // strings C4B11
        public string C4B11devmapcheckbox;
        public string C4B11devmapstate;
        public string C4B11cfgname;
        public string C4B11cfgargument;
        public string C4B11cfgstate;
        public string databaseC4B11path;
        public static string lineC4B11devmapcheckbox;
        public static string lineC4B11devmapstate;
        public static string lineC4B11cfgargument;
        public static string lineC4B11cfgstate;
        public static string C4B11mapname;
        public static string C4B11mapnamefixed;
        public static string lineC4B11mapname;
        public static string lineC4B11mapnamefixed;

        // strings C4B12
        public string C4B12devmapcheckbox;
        public string C4B12devmapstate;
        public string C4B12cfgname;
        public string C4B12cfgargument;
        public string C4B12cfgstate;
        public string databaseC4B12path;
        public static string lineC4B12devmapcheckbox;
        public static string lineC4B12devmapstate;
        public static string lineC4B12cfgargument;
        public static string lineC4B12cfgstate;
        public static string C4B12mapname;
        public static string C4B12mapnamefixed;
        public static string lineC4B12mapname;
        public static string lineC4B12mapnamefixed;
        public SettingsCustom4pt2()
        {
            InitializeComponent();

            C4B7devmapcheckbox = "+map ";
            C4B7devmapstate = "disabled";
            C4B8devmapcheckbox = "+map ";
            C4B8devmapstate = "disabled";
            C4B9devmapcheckbox = "+map ";
            C4B9devmapstate = "disabled";
            C4B10devmapcheckbox = "+map ";
            C4B10devmapstate = "disabled";
            C4B11devmapcheckbox = "+map ";
            C4B11devmapstate = "disabled";
            C4B12devmapcheckbox = "+map ";
            C4B12devmapstate = "disabled";
        }

        // C4B7
        private void C4B7devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C4B7devmap.Checked == true)
            {
                C4B7devmapcheckbox = "+devmap ";
                C4B7devmapstate = "enabled";
            }
            if (C4B7devmap.Checked == false)
            {
                C4B7devmapcheckbox = "+map ";
                C4B7devmapstate = "disabled";
            }
        }

        private void C4B7save_Click(object sender, EventArgs e)
        {
            C4B7cfgname = C4B7cfg.Text.ToString();

            if (C4B7cfgname != "")
            {
                C4B7cfgargument = "+exec " + C4B7cfgname + ".cfg ";
                C4B7cfgstate = C4B7cfgname;
            }
            else
            {
                C4B7cfgargument = "";
                C4B7cfgstate = "";
            }

            C4B7mapname = C4B7map.Text.ToString();

            if (C4B7mapname.Contains("mp_"))
            {
                string C4B7mapnameaux = C4B7mapname;
                C4B7mapnamefixed = C4B7mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC4B7 = new StreamWriter("./database/dtbcustoms4/C4B7.txt"))
            {
                swdtbC4B7.WriteLine(C4B7devmapcheckbox);
                swdtbC4B7.WriteLine(C4B7devmapstate);
                swdtbC4B7.WriteLine(C4B7cfgargument);
                swdtbC4B7.WriteLine(C4B7cfgstate);
                swdtbC4B7.WriteLine(C4B7mapname);
                swdtbC4B7.WriteLine(C4B7mapnamefixed);
                swdtbC4B7.Close();
            }
            databaseC4B7path = ("./database/dtbcustoms4/C4B7.txt");

            using (var srdtbC4B7 = new StreamReader(databaseC4B7path))
            {
                lineC4B7devmapcheckbox = srdtbC4B7.ReadLine();
                lineC4B7devmapstate = srdtbC4B7.ReadLine();
                lineC4B7cfgargument = srdtbC4B7.ReadLine();
                lineC4B7cfgstate = srdtbC4B7.ReadLine();
                lineC4B7mapname = srdtbC4B7.ReadLine();
                lineC4B7mapnamefixed = srdtbC4B7.ReadLine();
            }
        }

        private void C4B7info_Click(object sender, EventArgs e)
        {
            c4start7info show = new c4start7info();
            show.ShowDialog();
        }

        // C4B8
        private void C4B8devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C4B8devmap.Checked == true)
            {
                C4B8devmapcheckbox = "+devmap ";
                C4B8devmapstate = "enabled";
            }
            if (C4B8devmap.Checked == false)
            {
                C4B8devmapcheckbox = "+map ";
                C4B8devmapstate = "disabled";
            }
        }

        private void C4B8save_Click(object sender, EventArgs e)
        {
            C4B8cfgname = C4B8cfg.Text.ToString();

            if (C4B8cfgname != "")
            {
                C4B8cfgargument = "+exec " + C4B8cfgname + ".cfg ";
                C4B8cfgstate = C4B8cfgname;
            }
            else
            {
                C4B8cfgargument = "";
                C4B8cfgstate = "";
            }

            C4B8mapname = C4B8map.Text.ToString();

            if (C4B8mapname.Contains("mp_"))
            {
                string C4B8mapnameaux = C4B8mapname;
                C4B8mapnamefixed = C4B8mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC4B8 = new StreamWriter("./database/dtbcustoms4/C4B8.txt"))
            {
                swdtbC4B8.WriteLine(C4B8devmapcheckbox);
                swdtbC4B8.WriteLine(C4B8devmapstate);
                swdtbC4B8.WriteLine(C4B8cfgargument);
                swdtbC4B8.WriteLine(C4B8cfgstate);
                swdtbC4B8.WriteLine(C4B8mapname);
                swdtbC4B8.WriteLine(C4B8mapnamefixed);
                swdtbC4B8.Close();
            }
            databaseC4B8path = ("./database/dtbcustoms4/C4B8.txt");

            using (var srdtbC4B8 = new StreamReader(databaseC4B8path))
            {
                lineC4B8devmapcheckbox = srdtbC4B8.ReadLine();
                lineC4B8devmapstate = srdtbC4B8.ReadLine();
                lineC4B8cfgargument = srdtbC4B8.ReadLine();
                lineC4B8cfgstate = srdtbC4B8.ReadLine();
                lineC4B8mapname = srdtbC4B8.ReadLine();
                lineC4B8mapnamefixed = srdtbC4B8.ReadLine();
            }
        }

        private void C4B8info_Click(object sender, EventArgs e)
        {
            c4start8info show = new c4start8info();
            show.ShowDialog();
        }

        // C4B9
        private void C4B9devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C4B9devmap.Checked == true)
            {
                C4B9devmapcheckbox = "+devmap ";
                C4B9devmapstate = "enabled";
            }
            if (C4B9devmap.Checked == false)
            {
                C4B9devmapcheckbox = "+map ";
                C4B9devmapstate = "disabled";
            }
        }

        private void C4B9save_Click(object sender, EventArgs e)
        {
            C4B9cfgname = C4B9cfg.Text.ToString();

            if (C4B9cfgname != "")
            {
                C4B9cfgargument = "+exec " + C4B9cfgname + ".cfg ";
                C4B9cfgstate = C4B9cfgname;
            }
            else
            {
                C4B9cfgargument = "";
                C4B9cfgstate = "";
            }

            C4B9mapname = C4B9map.Text.ToString();

            if (C4B9mapname.Contains("mp_"))
            {
                string C4B9mapnameaux = C4B9mapname;
                C4B9mapnamefixed = C4B9mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC4B9 = new StreamWriter("./database/dtbcustoms4/C4B9.txt"))
            {
                swdtbC4B9.WriteLine(C4B9devmapcheckbox);
                swdtbC4B9.WriteLine(C4B9devmapstate);
                swdtbC4B9.WriteLine(C4B9cfgargument);
                swdtbC4B9.WriteLine(C4B9cfgstate);
                swdtbC4B9.WriteLine(C4B9mapname);
                swdtbC4B9.WriteLine(C4B9mapnamefixed);
                swdtbC4B9.Close();
            }
            databaseC4B9path = ("./database/dtbcustoms4/C4B9.txt");

            using (var srdtbC4B9 = new StreamReader(databaseC4B9path))
            {
                lineC4B9devmapcheckbox = srdtbC4B9.ReadLine();
                lineC4B9devmapstate = srdtbC4B9.ReadLine();
                lineC4B9cfgargument = srdtbC4B9.ReadLine();
                lineC4B9cfgstate = srdtbC4B9.ReadLine();
                lineC4B9mapname = srdtbC4B9.ReadLine();
                lineC4B9mapnamefixed = srdtbC4B9.ReadLine();
            }
        }

        private void C4B9info_Click(object sender, EventArgs e)
        {
            c4start9info show = new c4start9info();
            show.ShowDialog();
        }

        // C4B10
        private void C4B10devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C4B10devmap.Checked == true)
            {
                C4B10devmapcheckbox = "+devmap ";
                C4B10devmapstate = "enabled";
            }
            if (C4B10devmap.Checked == false)
            {
                C4B10devmapcheckbox = "+map ";
                C4B10devmapstate = "disabled";
            }
        }

        private void C4B10save_Click(object sender, EventArgs e)
        {
            C4B10cfgname = C4B10cfg.Text.ToString();

            if (C4B10cfgname != "")
            {
                C4B10cfgargument = "+exec " + C4B10cfgname + ".cfg ";
                C4B10cfgstate = C4B10cfgname;
            }
            else
            {
                C4B10cfgargument = "";
                C4B10cfgstate = "";
            }

            C4B10mapname = C4B10map.Text.ToString();

            if (C4B10mapname.Contains("mp_"))
            {
                string C4B10mapnameaux = C4B10mapname;
                C4B10mapnamefixed = C4B10mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC4B10 = new StreamWriter("./database/dtbcustoms4/C4B10.txt"))
            {
                swdtbC4B10.WriteLine(C4B10devmapcheckbox);
                swdtbC4B10.WriteLine(C4B10devmapstate);
                swdtbC4B10.WriteLine(C4B10cfgargument);
                swdtbC4B10.WriteLine(C4B10cfgstate);
                swdtbC4B10.WriteLine(C4B10mapname);
                swdtbC4B10.WriteLine(C4B10mapnamefixed);
                swdtbC4B10.Close();
            }
            databaseC4B10path = ("./database/dtbcustoms4/C4B10.txt");

            using (var srdtbC4B10 = new StreamReader(databaseC4B10path))
            {
                lineC4B10devmapcheckbox = srdtbC4B10.ReadLine();
                lineC4B10devmapstate = srdtbC4B10.ReadLine();
                lineC4B10cfgargument = srdtbC4B10.ReadLine();
                lineC4B10cfgstate = srdtbC4B10.ReadLine();
                lineC4B10mapname = srdtbC4B10.ReadLine();
                lineC4B10mapnamefixed = srdtbC4B10.ReadLine();
            }
        }

        private void C4B10info_Click(object sender, EventArgs e)
        {
            c4start10info show = new c4start10info();
            show.ShowDialog();
        }

        // C4B11
        private void C4B11devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C4B11devmap.Checked == true)
            {
                C4B11devmapcheckbox = "+devmap ";
                C4B11devmapstate = "enabled";
            }
            if (C4B11devmap.Checked == false)
            {
                C4B11devmapcheckbox = "+map ";
                C4B11devmapstate = "disabled";
            }
        }

        private void C4B11save_Click(object sender, EventArgs e)
        {
            C4B11cfgname = C4B11cfg.Text.ToString();

            if (C4B11cfgname != "")
            {
                C4B11cfgargument = "+exec " + C4B11cfgname + ".cfg ";
                C4B11cfgstate = C4B11cfgname;
            }
            else
            {
                C4B11cfgargument = "";
                C4B11cfgstate = "";
            }

            C4B11mapname = C4B11map.Text.ToString();

            if (C4B11mapname.Contains("mp_"))
            {
                string C4B11mapnameaux = C4B11mapname;
                C4B11mapnamefixed = C4B11mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC4B11 = new StreamWriter("./database/dtbcustoms4/C4B11.txt"))
            {
                swdtbC4B11.WriteLine(C4B11devmapcheckbox);
                swdtbC4B11.WriteLine(C4B11devmapstate);
                swdtbC4B11.WriteLine(C4B11cfgargument);
                swdtbC4B11.WriteLine(C4B11cfgstate);
                swdtbC4B11.WriteLine(C4B11mapname);
                swdtbC4B11.WriteLine(C4B11mapnamefixed);
                swdtbC4B11.Close();
            }
            databaseC4B11path = ("./database/dtbcustoms4/C4B11.txt");

            using (var srdtbC4B11 = new StreamReader(databaseC4B11path))
            {
                lineC4B11devmapcheckbox = srdtbC4B11.ReadLine();
                lineC4B11devmapstate = srdtbC4B11.ReadLine();
                lineC4B11cfgargument = srdtbC4B11.ReadLine();
                lineC4B11cfgstate = srdtbC4B11.ReadLine();
                lineC4B11mapname = srdtbC4B11.ReadLine();
                lineC4B11mapnamefixed = srdtbC4B11.ReadLine();
            }
        }

        private void C4B11info_Click(object sender, EventArgs e)
        {
            c4start11info show = new c4start11info();
            show.ShowDialog();
        }

        // C4B12
        private void C4B12devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C4B12devmap.Checked == true)
            {
                C4B12devmapcheckbox = "+devmap ";
                C4B12devmapstate = "enabled";
            }
            if (C4B12devmap.Checked == false)
            {
                C4B12devmapcheckbox = "+map ";
                C4B12devmapstate = "disabled";
            }
        }

        private void C4B12save_Click(object sender, EventArgs e)
        {
            C4B12cfgname = C4B12cfg.Text.ToString();

            if (C4B12cfgname != "")
            {
                C4B12cfgargument = "+exec " + C4B12cfgname + ".cfg ";
                C4B12cfgstate = C4B12cfgname;
            }
            else
            {
                C4B12cfgargument = "";
                C4B12cfgstate = "";
            }

            C4B12mapname = C4B12map.Text.ToString();

            if (C4B12mapname.Contains("mp_"))
            {
                string C4B12mapnameaux = C4B12mapname;
                C4B12mapnamefixed = C4B12mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC4B12 = new StreamWriter("./database/dtbcustoms4/C4B12.txt"))
            {
                swdtbC4B12.WriteLine(C4B12devmapcheckbox);
                swdtbC4B12.WriteLine(C4B12devmapstate);
                swdtbC4B12.WriteLine(C4B12cfgargument);
                swdtbC4B12.WriteLine(C4B12cfgstate);
                swdtbC4B12.WriteLine(C4B12mapname);
                swdtbC4B12.WriteLine(C4B12mapnamefixed);
                swdtbC4B12.Close();
            }
            databaseC4B12path = ("./database/dtbcustoms4/C4B12.txt");

            using (var srdtbC4B12 = new StreamReader(databaseC4B12path))
            {
                lineC4B12devmapcheckbox = srdtbC4B12.ReadLine();
                lineC4B12devmapstate = srdtbC4B12.ReadLine();
                lineC4B12cfgargument = srdtbC4B12.ReadLine();
                lineC4B12cfgstate = srdtbC4B12.ReadLine();
                lineC4B12mapname = srdtbC4B12.ReadLine();
                lineC4B12mapnamefixed = srdtbC4B12.ReadLine();
            }
        }

        private void C4B12info_Click(object sender, EventArgs e)
        {
            c4start12info show = new c4start12info();
            show.ShowDialog();
        }
    }
}
