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
    public partial class SettingsCustom5pt2 : Form
    {
        // strings C5B7
        public string C5B7devmapcheckbox;
        public string C5B7devmapstate;
        public string C5B7cfgname;
        public string C5B7cfgargument;
        public string C5B7cfgstate;
        public string databaseC5B7path;
        public static string lineC5B7devmapcheckbox;
        public static string lineC5B7devmapstate;
        public static string lineC5B7cfgargument;
        public static string lineC5B7cfgstate;
        public static string C5B7mapname;
        public static string C5B7mapnamefixed;
        public static string lineC5B7mapname;
        public static string lineC5B7mapnamefixed;

        // strings C5B8
        public string C5B8devmapcheckbox;
        public string C5B8devmapstate;
        public string C5B8cfgname;
        public string C5B8cfgargument;
        public string C5B8cfgstate;
        public string databaseC5B8path;
        public static string lineC5B8devmapcheckbox;
        public static string lineC5B8devmapstate;
        public static string lineC5B8cfgargument;
        public static string lineC5B8cfgstate;
        public static string C5B8mapname;
        public static string C5B8mapnamefixed;
        public static string lineC5B8mapname;
        public static string lineC5B8mapnamefixed;

        // strings C5B9
        public string C5B9devmapcheckbox;
        public string C5B9devmapstate;
        public string C5B9cfgname;
        public string C5B9cfgargument;
        public string C5B9cfgstate;
        public string databaseC5B9path;
        public static string lineC5B9devmapcheckbox;
        public static string lineC5B9devmapstate;
        public static string lineC5B9cfgargument;
        public static string lineC5B9cfgstate;
        public static string C5B9mapname;
        public static string C5B9mapnamefixed;
        public static string lineC5B9mapname;
        public static string lineC5B9mapnamefixed;

        // strings C5B10
        public string C5B10devmapcheckbox;
        public string C5B10devmapstate;
        public string C5B10cfgname;
        public string C5B10cfgargument;
        public string C5B10cfgstate;
        public string databaseC5B10path;
        public static string lineC5B10devmapcheckbox;
        public static string lineC5B10devmapstate;
        public static string lineC5B10cfgargument;
        public static string lineC5B10cfgstate;
        public static string C5B10mapname;
        public static string C5B10mapnamefixed;
        public static string lineC5B10mapname;
        public static string lineC5B10mapnamefixed;

        // strings C5B11
        public string C5B11devmapcheckbox;
        public string C5B11devmapstate;
        public string C5B11cfgname;
        public string C5B11cfgargument;
        public string C5B11cfgstate;
        public string databaseC5B11path;
        public static string lineC5B11devmapcheckbox;
        public static string lineC5B11devmapstate;
        public static string lineC5B11cfgargument;
        public static string lineC5B11cfgstate;
        public static string C5B11mapname;
        public static string C5B11mapnamefixed;
        public static string lineC5B11mapname;
        public static string lineC5B11mapnamefixed;

        // strings C5B12
        public string C5B12devmapcheckbox;
        public string C5B12devmapstate;
        public string C5B12cfgname;
        public string C5B12cfgargument;
        public string C5B12cfgstate;
        public string databaseC5B12path;
        public static string lineC5B12devmapcheckbox;
        public static string lineC5B12devmapstate;
        public static string lineC5B12cfgargument;
        public static string lineC5B12cfgstate;
        public static string C5B12mapname;
        public static string C5B12mapnamefixed;
        public static string lineC5B12mapname;
        public static string lineC5B12mapnamefixed;
        public SettingsCustom5pt2()
        {
            InitializeComponent();

            C5B7devmapcheckbox = "+map ";
            C5B7devmapstate = "disabled";
            C5B8devmapcheckbox = "+map ";
            C5B8devmapstate = "disabled";
            C5B9devmapcheckbox = "+map ";
            C5B9devmapstate = "disabled";
            C5B10devmapcheckbox = "+map ";
            C5B10devmapstate = "disabled";
            C5B11devmapcheckbox = "+map ";
            C5B11devmapstate = "disabled";
            C5B12devmapcheckbox = "+map ";
            C5B12devmapstate = "disabled";
        }

        // C5B7
        private void C5B7devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C5B7devmap.Checked == true)
            {
                C5B7devmapcheckbox = "+devmap ";
                C5B7devmapstate = "enabled";
            }
            if (C5B7devmap.Checked == false)
            {
                C5B7devmapcheckbox = "+map ";
                C5B7devmapstate = "disabled";
            }
        }

        private void C5B7save_Click(object sender, EventArgs e)
        {
            C5B7cfgname = C5B7cfg.Text.ToString();

            if (C5B7cfgname != "")
            {
                C5B7cfgargument = "+exec " + C5B7cfgname + ".cfg ";
                C5B7cfgstate = C5B7cfgname;
            }
            else
            {
                C5B7cfgargument = "";
                C5B7cfgstate = "";
            }

            C5B7mapname = C5B7map.Text.ToString();

            if (C5B7mapname.Contains("mp_"))
            {
                string C5B7mapnameaux = C5B7mapname;
                C5B7mapnamefixed = C5B7mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC5B7 = new StreamWriter("./database/dtbcustoms5/C5B7.txt"))
            {
                swdtbC5B7.WriteLine(C5B7devmapcheckbox);
                swdtbC5B7.WriteLine(C5B7devmapstate);
                swdtbC5B7.WriteLine(C5B7cfgargument);
                swdtbC5B7.WriteLine(C5B7cfgstate);
                swdtbC5B7.WriteLine(C5B7mapname);
                swdtbC5B7.WriteLine(C5B7mapnamefixed);
                swdtbC5B7.Close();
            }
            databaseC5B7path = ("./database/dtbcustoms5/C5B7.txt");

            using (var srdtbC5B7 = new StreamReader(databaseC5B7path))
            {
                lineC5B7devmapcheckbox = srdtbC5B7.ReadLine();
                lineC5B7devmapstate = srdtbC5B7.ReadLine();
                lineC5B7cfgargument = srdtbC5B7.ReadLine();
                lineC5B7cfgstate = srdtbC5B7.ReadLine();
                lineC5B7mapname = srdtbC5B7.ReadLine();
                lineC5B7mapnamefixed = srdtbC5B7.ReadLine();
            }
        }

        private void C5B7info_Click(object sender, EventArgs e)
        {
            c5start7info show = new c5start7info();
            show.ShowDialog();
        }

        // C5B8
        private void C5B8devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C5B8devmap.Checked == true)
            {
                C5B8devmapcheckbox = "+devmap ";
                C5B8devmapstate = "enabled";
            }
            if (C5B8devmap.Checked == false)
            {
                C5B8devmapcheckbox = "+map ";
                C5B8devmapstate = "disabled";
            }
        }

        private void C5B8save_Click(object sender, EventArgs e)
        {
            C5B8cfgname = C5B8cfg.Text.ToString();

            if (C5B8cfgname != "")
            {
                C5B8cfgargument = "+exec " + C5B8cfgname + ".cfg ";
                C5B8cfgstate = C5B8cfgname;
            }
            else
            {
                C5B8cfgargument = "";
                C5B8cfgstate = "";
            }

            C5B8mapname = C5B8map.Text.ToString();

            if (C5B8mapname.Contains("mp_"))
            {
                string C5B8mapnameaux = C5B8mapname;
                C5B8mapnamefixed = C5B8mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC5B8 = new StreamWriter("./database/dtbcustoms5/C5B8.txt"))
            {
                swdtbC5B8.WriteLine(C5B8devmapcheckbox);
                swdtbC5B8.WriteLine(C5B8devmapstate);
                swdtbC5B8.WriteLine(C5B8cfgargument);
                swdtbC5B8.WriteLine(C5B8cfgstate);
                swdtbC5B8.WriteLine(C5B8mapname);
                swdtbC5B8.WriteLine(C5B8mapnamefixed);
                swdtbC5B8.Close();
            }
            databaseC5B8path = ("./database/dtbcustoms5/C5B8.txt");

            using (var srdtbC5B8 = new StreamReader(databaseC5B8path))
            {
                lineC5B8devmapcheckbox = srdtbC5B8.ReadLine();
                lineC5B8devmapstate = srdtbC5B8.ReadLine();
                lineC5B8cfgargument = srdtbC5B8.ReadLine();
                lineC5B8cfgstate = srdtbC5B8.ReadLine();
                lineC5B8mapname = srdtbC5B8.ReadLine();
                lineC5B8mapnamefixed = srdtbC5B8.ReadLine();
            }
        }

        private void C5B8info_Click(object sender, EventArgs e)
        {
            c5start8info show = new c5start8info();
            show.ShowDialog();
        }

        // C5B9
        private void C5B9devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C5B9devmap.Checked == true)
            {
                C5B9devmapcheckbox = "+devmap ";
                C5B9devmapstate = "enabled";
            }
            if (C5B9devmap.Checked == false)
            {
                C5B9devmapcheckbox = "+map ";
                C5B9devmapstate = "disabled";
            }
        }

        private void C5B9save_Click(object sender, EventArgs e)
        {
            C5B9cfgname = C5B9cfg.Text.ToString();

            if (C5B9cfgname != "")
            {
                C5B9cfgargument = "+exec " + C5B9cfgname + ".cfg ";
                C5B9cfgstate = C5B9cfgname;
            }
            else
            {
                C5B9cfgargument = "";
                C5B9cfgstate = "";
            }

            C5B9mapname = C5B9map.Text.ToString();

            if (C5B9mapname.Contains("mp_"))
            {
                string C5B9mapnameaux = C5B9mapname;
                C5B9mapnamefixed = C5B9mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC5B9 = new StreamWriter("./database/dtbcustoms5/C5B9.txt"))
            {
                swdtbC5B9.WriteLine(C5B9devmapcheckbox);
                swdtbC5B9.WriteLine(C5B9devmapstate);
                swdtbC5B9.WriteLine(C5B9cfgargument);
                swdtbC5B9.WriteLine(C5B9cfgstate);
                swdtbC5B9.WriteLine(C5B9mapname);
                swdtbC5B9.WriteLine(C5B9mapnamefixed);
                swdtbC5B9.Close();
            }
            databaseC5B9path = ("./database/dtbcustoms5/C5B9.txt");

            using (var srdtbC5B9 = new StreamReader(databaseC5B9path))
            {
                lineC5B9devmapcheckbox = srdtbC5B9.ReadLine();
                lineC5B9devmapstate = srdtbC5B9.ReadLine();
                lineC5B9cfgargument = srdtbC5B9.ReadLine();
                lineC5B9cfgstate = srdtbC5B9.ReadLine();
                lineC5B9mapname = srdtbC5B9.ReadLine();
                lineC5B9mapnamefixed = srdtbC5B9.ReadLine();
            }
        }

        private void C5B9info_Click(object sender, EventArgs e)
        {
            c5start9info show = new c5start9info();
            show.ShowDialog();
        }

        // C5B10
        private void C5B10devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C5B10devmap.Checked == true)
            {
                C5B10devmapcheckbox = "+devmap ";
                C5B10devmapstate = "enabled";
            }
            if (C5B10devmap.Checked == false)
            {
                C5B10devmapcheckbox = "+map ";
                C5B10devmapstate = "disabled";
            }
        }

        private void C5B10save_Click(object sender, EventArgs e)
        {
            C5B10cfgname = C5B10cfg.Text.ToString();

            if (C5B10cfgname != "")
            {
                C5B10cfgargument = "+exec " + C5B10cfgname + ".cfg ";
                C5B10cfgstate = C5B10cfgname;
            }
            else
            {
                C5B10cfgargument = "";
                C5B10cfgstate = "";
            }

            C5B10mapname = C5B10map.Text.ToString();

            if (C5B10mapname.Contains("mp_"))
            {
                string C5B10mapnameaux = C5B10mapname;
                C5B10mapnamefixed = C5B10mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC5B10 = new StreamWriter("./database/dtbcustoms5/C5B10.txt"))
            {
                swdtbC5B10.WriteLine(C5B10devmapcheckbox);
                swdtbC5B10.WriteLine(C5B10devmapstate);
                swdtbC5B10.WriteLine(C5B10cfgargument);
                swdtbC5B10.WriteLine(C5B10cfgstate);
                swdtbC5B10.WriteLine(C5B10mapname);
                swdtbC5B10.WriteLine(C5B10mapnamefixed);
                swdtbC5B10.Close();
            }
            databaseC5B10path = ("./database/dtbcustoms5/C5B10.txt");

            using (var srdtbC5B10 = new StreamReader(databaseC5B10path))
            {
                lineC5B10devmapcheckbox = srdtbC5B10.ReadLine();
                lineC5B10devmapstate = srdtbC5B10.ReadLine();
                lineC5B10cfgargument = srdtbC5B10.ReadLine();
                lineC5B10cfgstate = srdtbC5B10.ReadLine();
                lineC5B10mapname = srdtbC5B10.ReadLine();
                lineC5B10mapnamefixed = srdtbC5B10.ReadLine();
            }
        }

        private void C5B10info_Click(object sender, EventArgs e)
        {
            c5start10info show = new c5start10info();
            show.ShowDialog();
        }

        // C5B11
        private void C5B11devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C5B11devmap.Checked == true)
            {
                C5B11devmapcheckbox = "+devmap ";
                C5B11devmapstate = "enabled";
            }
            if (C5B11devmap.Checked == false)
            {
                C5B11devmapcheckbox = "+map ";
                C5B11devmapstate = "disabled";
            }
        }

        private void C5B11save_Click(object sender, EventArgs e)
        {
            C5B11cfgname = C5B11cfg.Text.ToString();

            if (C5B11cfgname != "")
            {
                C5B11cfgargument = "+exec " + C5B11cfgname + ".cfg ";
                C5B11cfgstate = C5B11cfgname;
            }
            else
            {
                C5B11cfgargument = "";
                C5B11cfgstate = "";
            }

            C5B11mapname = C5B11map.Text.ToString();

            if (C5B11mapname.Contains("mp_"))
            {
                string C5B11mapnameaux = C5B11mapname;
                C5B11mapnamefixed = C5B11mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC5B11 = new StreamWriter("./database/dtbcustoms5/C5B11.txt"))
            {
                swdtbC5B11.WriteLine(C5B11devmapcheckbox);
                swdtbC5B11.WriteLine(C5B11devmapstate);
                swdtbC5B11.WriteLine(C5B11cfgargument);
                swdtbC5B11.WriteLine(C5B11cfgstate);
                swdtbC5B11.WriteLine(C5B11mapname);
                swdtbC5B11.WriteLine(C5B11mapnamefixed);
                swdtbC5B11.Close();
            }
            databaseC5B11path = ("./database/dtbcustoms5/C5B11.txt");

            using (var srdtbC5B11 = new StreamReader(databaseC5B11path))
            {
                lineC5B11devmapcheckbox = srdtbC5B11.ReadLine();
                lineC5B11devmapstate = srdtbC5B11.ReadLine();
                lineC5B11cfgargument = srdtbC5B11.ReadLine();
                lineC5B11cfgstate = srdtbC5B11.ReadLine();
                lineC5B11mapname = srdtbC5B11.ReadLine();
                lineC5B11mapnamefixed = srdtbC5B11.ReadLine();
            }
        }

        private void C5B11info_Click(object sender, EventArgs e)
        {
            c5start11info show = new c5start11info();
            show.ShowDialog();
        }

        // C5B12
        private void C5B12devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C5B12devmap.Checked == true)
            {
                C5B12devmapcheckbox = "+devmap ";
                C5B12devmapstate = "enabled";
            }
            if (C5B12devmap.Checked == false)
            {
                C5B12devmapcheckbox = "+map ";
                C5B12devmapstate = "disabled";
            }
        }

        private void C5B12save_Click(object sender, EventArgs e)
        {
            C5B12cfgname = C5B12cfg.Text.ToString();

            if (C5B12cfgname != "")
            {
                C5B12cfgargument = "+exec " + C5B12cfgname + ".cfg ";
                C5B12cfgstate = C5B12cfgname;
            }
            else
            {
                C5B12cfgargument = "";
                C5B12cfgstate = "";
            }

            C5B12mapname = C5B12map.Text.ToString();

            if (C5B12mapname.Contains("mp_"))
            {
                string C5B12mapnameaux = C5B12mapname;
                C5B12mapnamefixed = C5B12mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC5B12 = new StreamWriter("./database/dtbcustoms5/C5B12.txt"))
            {
                swdtbC5B12.WriteLine(C5B12devmapcheckbox);
                swdtbC5B12.WriteLine(C5B12devmapstate);
                swdtbC5B12.WriteLine(C5B12cfgargument);
                swdtbC5B12.WriteLine(C5B12cfgstate);
                swdtbC5B12.WriteLine(C5B12mapname);
                swdtbC5B12.WriteLine(C5B12mapnamefixed);
                swdtbC5B12.Close();
            }
            databaseC5B12path = ("./database/dtbcustoms5/C5B12.txt");

            using (var srdtbC5B12 = new StreamReader(databaseC5B12path))
            {
                lineC5B12devmapcheckbox = srdtbC5B12.ReadLine();
                lineC5B12devmapstate = srdtbC5B12.ReadLine();
                lineC5B12cfgargument = srdtbC5B12.ReadLine();
                lineC5B12cfgstate = srdtbC5B12.ReadLine();
                lineC5B12mapname = srdtbC5B12.ReadLine();
                lineC5B12mapnamefixed = srdtbC5B12.ReadLine();
            }
        }

        private void C5B12info_Click(object sender, EventArgs e)
        {
            c5start12info show = new c5start12info();
            show.ShowDialog();
        }
    }
}
