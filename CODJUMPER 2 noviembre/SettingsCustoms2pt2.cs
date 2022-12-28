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
    public partial class SettingsCustoms2pt2 : Form
    {
        // strings C2B7
        public string C2B7devmapcheckbox;
        public string C2B7devmapstate;
        public string C2B7cfgname;
        public string C2B7cfgargument;
        public string C2B7cfgstate;
        public string databaseC2B7path;
        public static string lineC2B7devmapcheckbox;
        public static string lineC2B7devmapstate;
        public static string lineC2B7cfgargument;
        public static string lineC2B7cfgstate;
        public static string C2B7mapname;
        public static string C2B7mapnamefixed;
        public static string lineC2B7mapname;
        public static string lineC2B7mapnamefixed;

        // strings C2B8
        public string C2B8devmapcheckbox;
        public string C2B8devmapstate;
        public string C2B8cfgname;
        public string C2B8cfgargument;
        public string C2B8cfgstate;
        public string databaseC2B8path;
        public static string lineC2B8devmapcheckbox;
        public static string lineC2B8devmapstate;
        public static string lineC2B8cfgargument;
        public static string lineC2B8cfgstate;
        public static string C2B8mapname;
        public static string C2B8mapnamefixed;
        public static string lineC2B8mapname;
        public static string lineC2B8mapnamefixed;

        // strings C2B9
        public string C2B9devmapcheckbox;
        public string C2B9devmapstate;
        public string C2B9cfgname;
        public string C2B9cfgargument;
        public string C2B9cfgstate;
        public string databaseC2B9path;
        public static string lineC2B9devmapcheckbox;
        public static string lineC2B9devmapstate;
        public static string lineC2B9cfgargument;
        public static string lineC2B9cfgstate;
        public static string C2B9mapname;
        public static string C2B9mapnamefixed;
        public static string lineC2B9mapname;
        public static string lineC2B9mapnamefixed;

        // strings C2B10
        public string C2B10devmapcheckbox;
        public string C2B10devmapstate;
        public string C2B10cfgname;
        public string C2B10cfgargument;
        public string C2B10cfgstate;
        public string databaseC2B10path;
        public static string lineC2B10devmapcheckbox;
        public static string lineC2B10devmapstate;
        public static string lineC2B10cfgargument;
        public static string lineC2B10cfgstate;
        public static string C2B10mapname;
        public static string C2B10mapnamefixed;
        public static string lineC2B10mapname;
        public static string lineC2B10mapnamefixed;

        // strings C2B11
        public string C2B11devmapcheckbox;
        public string C2B11devmapstate;
        public string C2B11cfgname;
        public string C2B11cfgargument;
        public string C2B11cfgstate;
        public string databaseC2B11path;
        public static string lineC2B11devmapcheckbox;
        public static string lineC2B11devmapstate;
        public static string lineC2B11cfgargument;
        public static string lineC2B11cfgstate;
        public static string C2B11mapname;
        public static string C2B11mapnamefixed;
        public static string lineC2B11mapname;
        public static string lineC2B11mapnamefixed;

        // strings C2B12
        public string C2B12devmapcheckbox;
        public string C2B12devmapstate;
        public string C2B12cfgname;
        public string C2B12cfgargument;
        public string C2B12cfgstate;
        public string databaseC2B12path;
        public static string lineC2B12devmapcheckbox;
        public static string lineC2B12devmapstate;
        public static string lineC2B12cfgargument;
        public static string lineC2B12cfgstate;
        public static string C2B12mapname;
        public static string C2B12mapnamefixed;
        public static string lineC2B12mapname;
        public static string lineC2B12mapnamefixed;
        public SettingsCustoms2pt2()
        {
            InitializeComponent();

            C2B7devmapcheckbox = "+map ";
            C2B7devmapstate = "disabled";
            C2B8devmapcheckbox = "+map ";
            C2B8devmapstate = "disabled";
            C2B9devmapcheckbox = "+map ";
            C2B9devmapstate = "disabled";
            C2B10devmapcheckbox = "+map ";
            C2B10devmapstate = "disabled";
            C2B11devmapcheckbox = "+map ";
            C2B11devmapstate = "disabled";
            C2B12devmapcheckbox = "+map ";
            C2B12devmapstate = "disabled";
        }

        // C2B7
        private void C2B7devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C2B7devmap.Checked == true)
            {
                C2B7devmapcheckbox = "+devmap ";
                C2B7devmapstate = "enabled";
            }
            if (C2B7devmap.Checked == false)
            {
                C2B7devmapcheckbox = "+map ";
                C2B7devmapstate = "disabled";
            }
        }

        private void C2B7save_Click(object sender, EventArgs e)
        {
            C2B7cfgname = C2B7cfg.Text.ToString();

            if (C2B7cfgname != "")
            {
                C2B7cfgargument = "+exec " + C2B7cfgname + ".cfg ";
                C2B7cfgstate = C2B7cfgname;
            }
            else
            {
                C2B7cfgargument = "";
                C2B7cfgstate = "";
            }

            C2B7mapname = C2B7map.Text.ToString();

            if (C2B7mapname.Contains("mp_"))
            {
                string C2B7mapnameaux = C2B7mapname;
                C2B7mapnamefixed = C2B7mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC2B7 = new StreamWriter("./database/dtbcustoms2/C2B7.txt"))
            {
                swdtbC2B7.WriteLine(C2B7devmapcheckbox);
                swdtbC2B7.WriteLine(C2B7devmapstate);
                swdtbC2B7.WriteLine(C2B7cfgargument);
                swdtbC2B7.WriteLine(C2B7cfgstate);
                swdtbC2B7.WriteLine(C2B7mapname);
                swdtbC2B7.WriteLine(C2B7mapnamefixed);
                swdtbC2B7.Close();
            }
            databaseC2B7path = ("./database/dtbcustoms2/C2B7.txt");

            using (var srdtbC2B7 = new StreamReader(databaseC2B7path))
            {
                lineC2B7devmapcheckbox = srdtbC2B7.ReadLine();
                lineC2B7devmapstate = srdtbC2B7.ReadLine();
                lineC2B7cfgargument = srdtbC2B7.ReadLine();
                lineC2B7cfgstate = srdtbC2B7.ReadLine();
                lineC2B7mapname = srdtbC2B7.ReadLine();
                lineC2B7mapnamefixed = srdtbC2B7.ReadLine();
            }
        }

        private void C2B7info_Click(object sender, EventArgs e)
        {
            c2start7info show = new c2start7info();
            show.ShowDialog();
        }

        // C2B8
        private void C2B8devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C2B8devmap.Checked == true)
            {
                C2B8devmapcheckbox = "+devmap ";
                C2B8devmapstate = "enabled";
            }
            if (C2B8devmap.Checked == false)
            {
                C2B8devmapcheckbox = "+map ";
                C2B8devmapstate = "disabled";
            }
        }

        // C2B8
        private void C2B8save_Click(object sender, EventArgs e)
        {
            C2B8cfgname = C2B8cfg.Text.ToString();

            if (C2B8cfgname != "")
            {
                C2B8cfgargument = "+exec " + C2B8cfgname + ".cfg ";
                C2B8cfgstate = C2B8cfgname;
            }
            else
            {
                C2B8cfgargument = "";
                C2B8cfgstate = "";
            }

            C2B8mapname = C2B8map.Text.ToString();

            if (C2B8mapname.Contains("mp_"))
            {
                string C2B8mapnameaux = C2B8mapname;
                C2B8mapnamefixed = C2B8mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC2B8 = new StreamWriter("./database/dtbcustoms2/C2B8.txt"))
            {
                swdtbC2B8.WriteLine(C2B8devmapcheckbox);
                swdtbC2B8.WriteLine(C2B8devmapstate);
                swdtbC2B8.WriteLine(C2B8cfgargument);
                swdtbC2B8.WriteLine(C2B8cfgstate);
                swdtbC2B8.WriteLine(C2B8mapname);
                swdtbC2B8.WriteLine(C2B8mapnamefixed);
                swdtbC2B8.Close();
            }
            databaseC2B8path = ("./database/dtbcustoms2/C2B8.txt");

            using (var srdtbC2B8 = new StreamReader(databaseC2B8path))
            {
                lineC2B8devmapcheckbox = srdtbC2B8.ReadLine();
                lineC2B8devmapstate = srdtbC2B8.ReadLine();
                lineC2B8cfgargument = srdtbC2B8.ReadLine();
                lineC2B8cfgstate = srdtbC2B8.ReadLine();
                lineC2B8mapname = srdtbC2B8.ReadLine();
                lineC2B8mapnamefixed = srdtbC2B8.ReadLine();
            }
        }

        private void C2B8info_Click(object sender, EventArgs e)
        {
            c2start8info show = new c2start8info();
            show.ShowDialog();
        }

        // C2B9
        private void C2B9devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C2B9devmap.Checked == true)
            {
                C2B9devmapcheckbox = "+devmap ";
                C2B9devmapstate = "enabled";
            }
            if (C2B9devmap.Checked == false)
            {
                C2B9devmapcheckbox = "+map ";
                C2B9devmapstate = "disabled";
            }
        }

        private void C2B9save_Click(object sender, EventArgs e)
        {
            C2B9cfgname = C2B9cfg.Text.ToString();

            if (C2B9cfgname != "")
            {
                C2B9cfgargument = "+exec " + C2B9cfgname + ".cfg ";
                C2B9cfgstate = C2B9cfgname;
            }
            else
            {
                C2B9cfgargument = "";
                C2B9cfgstate = "";
            }

            C2B9mapname = C2B9map.Text.ToString();

            if (C2B9mapname.Contains("mp_"))
            {
                string C2B9mapnameaux = C2B9mapname;
                C2B9mapnamefixed = C2B9mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC2B9 = new StreamWriter("./database/dtbcustoms2/C2B9.txt"))
            {
                swdtbC2B9.WriteLine(C2B9devmapcheckbox);
                swdtbC2B9.WriteLine(C2B9devmapstate);
                swdtbC2B9.WriteLine(C2B9cfgargument);
                swdtbC2B9.WriteLine(C2B9cfgstate);
                swdtbC2B9.WriteLine(C2B9mapname);
                swdtbC2B9.WriteLine(C2B9mapnamefixed);
                swdtbC2B9.Close();
            }
            databaseC2B9path = ("./database/dtbcustoms2/C2B9.txt");

            using (var srdtbC2B9 = new StreamReader(databaseC2B9path))
            {
                lineC2B9devmapcheckbox = srdtbC2B9.ReadLine();
                lineC2B9devmapstate = srdtbC2B9.ReadLine();
                lineC2B9cfgargument = srdtbC2B9.ReadLine();
                lineC2B9cfgstate = srdtbC2B9.ReadLine();
                lineC2B9mapname = srdtbC2B9.ReadLine();
                lineC2B9mapnamefixed = srdtbC2B9.ReadLine();
            }
        }

        private void C2B9info_Click(object sender, EventArgs e)
        {
            c2start9info show = new c2start9info();
            show.ShowDialog();
        }

        // C2B10
        private void C2B10devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C2B10devmap.Checked == true)
            {
                C2B10devmapcheckbox = "+devmap ";
                C2B10devmapstate = "enabled";
            }
            if (C2B10devmap.Checked == false)
            {
                C2B10devmapcheckbox = "+map ";
                C2B10devmapstate = "disabled";
            }
        }

        private void C2B10save_Click(object sender, EventArgs e)
        {
            C2B10cfgname = C2B10cfg.Text.ToString();

            if (C2B10cfgname != "")
            {
                C2B10cfgargument = "+exec " + C2B10cfgname + ".cfg ";
                C2B10cfgstate = C2B10cfgname;
            }
            else
            {
                C2B10cfgargument = "";
                C2B10cfgstate = "";
            }

            C2B10mapname = C2B10map.Text.ToString();

            if (C2B10mapname.Contains("mp_"))
            {
                string C2B10mapnameaux = C2B10mapname;
                C2B10mapnamefixed = C2B10mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC2B10 = new StreamWriter("./database/dtbcustoms2/C2B10.txt"))
            {
                swdtbC2B10.WriteLine(C2B10devmapcheckbox);
                swdtbC2B10.WriteLine(C2B10devmapstate);
                swdtbC2B10.WriteLine(C2B10cfgargument);
                swdtbC2B10.WriteLine(C2B10cfgstate);
                swdtbC2B10.WriteLine(C2B10mapname);
                swdtbC2B10.WriteLine(C2B10mapnamefixed);
                swdtbC2B10.Close();
            }
            databaseC2B10path = ("./database/dtbcustoms2/C2B10.txt");

            using (var srdtbC2B10 = new StreamReader(databaseC2B10path))
            {
                lineC2B10devmapcheckbox = srdtbC2B10.ReadLine();
                lineC2B10devmapstate = srdtbC2B10.ReadLine();
                lineC2B10cfgargument = srdtbC2B10.ReadLine();
                lineC2B10cfgstate = srdtbC2B10.ReadLine();
                lineC2B10mapname = srdtbC2B10.ReadLine();
                lineC2B10mapnamefixed = srdtbC2B10.ReadLine();
            }
        }

        private void C2B10info_Click(object sender, EventArgs e)
        {
            c2start10info show = new c2start10info();
            show.ShowDialog();
        }

        // C2B11
        private void C2B11devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C2B11devmap.Checked == true)
            {
                C2B11devmapcheckbox = "+devmap ";
                C2B11devmapstate = "enabled";
            }
            if (C2B11devmap.Checked == false)
            {
                C2B11devmapcheckbox = "+map ";
                C2B11devmapstate = "disabled";
            }
        }

        private void C2B11save_Click(object sender, EventArgs e)
        {
            C2B11cfgname = C2B11cfg.Text.ToString();

            if (C2B11cfgname != "")
            {
                C2B11cfgargument = "+exec " + C2B11cfgname + ".cfg ";
                C2B11cfgstate = C2B11cfgname;
            }
            else
            {
                C2B11cfgargument = "";
                C2B11cfgstate = "";
            }

            C2B11mapname = C2B11map.Text.ToString();

            if (C2B11mapname.Contains("mp_"))
            {
                string C2B11mapnameaux = C2B11mapname;
                C2B11mapnamefixed = C2B11mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC2B11 = new StreamWriter("./database/dtbcustoms2/C2B11.txt"))
            {
                swdtbC2B11.WriteLine(C2B11devmapcheckbox);
                swdtbC2B11.WriteLine(C2B11devmapstate);
                swdtbC2B11.WriteLine(C2B11cfgargument);
                swdtbC2B11.WriteLine(C2B11cfgstate);
                swdtbC2B11.WriteLine(C2B11mapname);
                swdtbC2B11.WriteLine(C2B11mapnamefixed);
                swdtbC2B11.Close();
            }
            databaseC2B11path = ("./database/dtbcustoms2/C2B11.txt");

            using (var srdtbC2B11 = new StreamReader(databaseC2B11path))
            {
                lineC2B11devmapcheckbox = srdtbC2B11.ReadLine();
                lineC2B11devmapstate = srdtbC2B11.ReadLine();
                lineC2B11cfgargument = srdtbC2B11.ReadLine();
                lineC2B11cfgstate = srdtbC2B11.ReadLine();
                lineC2B11mapname = srdtbC2B11.ReadLine();
                lineC2B11mapnamefixed = srdtbC2B11.ReadLine();
            }
        }

        private void C2B11info_Click(object sender, EventArgs e)
        {
            c2start11info show = new c2start11info();
            show.ShowDialog();
        }

        // C2B12
        private void C2B12devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C2B12devmap.Checked == true)
            {
                C2B12devmapcheckbox = "+devmap ";
                C2B12devmapstate = "enabled";
            }
            if (C2B12devmap.Checked == false)
            {
                C2B12devmapcheckbox = "+map ";
                C2B12devmapstate = "disabled";
            }
        }

        private void C2B12save_Click(object sender, EventArgs e)
        {
            C2B12cfgname = C2B12cfg.Text.ToString();

            if (C2B12cfgname != "")
            {
                C2B12cfgargument = "+exec " + C2B12cfgname + ".cfg ";
                C2B12cfgstate = C2B12cfgname;
            }
            else
            {
                C2B12cfgargument = "";
                C2B12cfgstate = "";
            }

            C2B12mapname = C2B12map.Text.ToString();

            if (C2B12mapname.Contains("mp_"))
            {
                string C2B12mapnameaux = C2B12mapname;
                C2B12mapnamefixed = C2B12mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC2B12 = new StreamWriter("./database/dtbcustoms2/C2B12.txt"))
            {
                swdtbC2B12.WriteLine(C2B12devmapcheckbox);
                swdtbC2B12.WriteLine(C2B12devmapstate);
                swdtbC2B12.WriteLine(C2B12cfgargument);
                swdtbC2B12.WriteLine(C2B12cfgstate);
                swdtbC2B12.WriteLine(C2B12mapname);
                swdtbC2B12.WriteLine(C2B12mapnamefixed);
                swdtbC2B12.Close();
            }
            databaseC2B12path = ("./database/dtbcustoms2/C2B12.txt");

            using (var srdtbC2B12 = new StreamReader(databaseC2B12path))
            {
                lineC2B12devmapcheckbox = srdtbC2B12.ReadLine();
                lineC2B12devmapstate = srdtbC2B12.ReadLine();
                lineC2B12cfgargument = srdtbC2B12.ReadLine();
                lineC2B12cfgstate = srdtbC2B12.ReadLine();
                lineC2B12mapname = srdtbC2B12.ReadLine();
                lineC2B12mapnamefixed = srdtbC2B12.ReadLine();
            }
        }

        private void C2B12info_Click(object sender, EventArgs e)
        {
            c2start12info show = new c2start12info();
            show.ShowDialog();
        }
    }
}
