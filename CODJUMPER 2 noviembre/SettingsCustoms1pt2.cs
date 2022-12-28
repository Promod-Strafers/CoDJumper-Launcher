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
    public partial class SettingsCustoms1pt2 : Form
    {
        // strings C1B7
        public string C1B7devmapcheckbox;
        public string C1B7devmapstate;
        public string C1B7cfgname;
        public string C1B7cfgargument;
        public string C1B7cfgstate;
        public string databaseC1B7path;
        public static string lineC1B7devmapcheckbox;
        public static string lineC1B7devmapstate;
        public static string lineC1B7cfgargument;
        public static string lineC1B7cfgstate;
        public static string C1B7mapname;
        public static string C1B7mapnamefixed;
        public static string lineC1B7mapname;
        public static string lineC1B7mapnamefixed;

        // strings C1B8
        public string C1B8devmapcheckbox;
        public string C1B8devmapstate;
        public string C1B8cfgname;
        public string C1B8cfgargument;
        public string C1B8cfgstate;
        public string databaseC1B8path;
        public static string lineC1B8devmapcheckbox;
        public static string lineC1B8devmapstate;
        public static string lineC1B8cfgargument;
        public static string lineC1B8cfgstate;
        public static string C1B8mapname;
        public static string C1B8mapnamefixed;
        public static string lineC1B8mapname;
        public static string lineC1B8mapnamefixed;

        // strings C1B9
        public string C1B9devmapcheckbox;
        public string C1B9devmapstate;
        public string C1B9cfgname;
        public string C1B9cfgargument;
        public string C1B9cfgstate;
        public string databaseC1B9path;
        public static string lineC1B9devmapcheckbox;
        public static string lineC1B9devmapstate;
        public static string lineC1B9cfgargument;
        public static string lineC1B9cfgstate;
        public static string C1B9mapname;
        public static string C1B9mapnamefixed;
        public static string lineC1B9mapname;
        public static string lineC1B9mapnamefixed;

        // strings C1B10
        public string C1B10devmapcheckbox;
        public string C1B10devmapstate;
        public string C1B10cfgname;
        public string C1B10cfgargument;
        public string C1B10cfgstate;
        public string databaseC1B10path;
        public static string lineC1B10devmapcheckbox;
        public static string lineC1B10devmapstate;
        public static string lineC1B10cfgargument;
        public static string lineC1B10cfgstate;
        public static string C1B10mapname;
        public static string C1B10mapnamefixed;
        public static string lineC1B10mapname;
        public static string lineC1B10mapnamefixed;

        // strings C1B11
        public string C1B11devmapcheckbox;
        public string C1B11devmapstate;
        public string C1B11cfgname;
        public string C1B11cfgargument;
        public string C1B11cfgstate;
        public string databaseC1B11path;
        public static string lineC1B11devmapcheckbox;
        public static string lineC1B11devmapstate;
        public static string lineC1B11cfgargument;
        public static string lineC1B11cfgstate;
        public static string C1B11mapname;
        public static string C1B11mapnamefixed;
        public static string lineC1B11mapname;
        public static string lineC1B11mapnamefixed;

        // strings C1B12
        public string C1B12devmapcheckbox;
        public string C1B12devmapstate;
        public string C1B12cfgname;
        public string C1B12cfgargument;
        public string C1B12cfgstate;
        public string databaseC1B12path;
        public static string lineC1B12devmapcheckbox;
        public static string lineC1B12devmapstate;
        public static string lineC1B12cfgargument;
        public static string lineC1B12cfgstate;
        public static string C1B12mapname;
        public static string C1B12mapnamefixed;
        public static string lineC1B12mapname;
        public static string lineC1B12mapnamefixed;
        public SettingsCustoms1pt2()
        {
            InitializeComponent();

            C1B7devmapcheckbox = "+map ";
            C1B7devmapstate = "disabled";
            C1B8devmapcheckbox = "+map ";
            C1B8devmapstate = "disabled";
            C1B9devmapcheckbox = "+map ";
            C1B9devmapstate = "disabled";
            C1B10devmapcheckbox = "+map ";
            C1B10devmapstate = "disabled";
            C1B11devmapcheckbox = "+map ";
            C1B11devmapstate = "disabled";
            C1B12devmapcheckbox = "+map ";
            C1B12devmapstate = "disabled";
        }

        // C1B7
        private void C1B7devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C1B7devmap.Checked == true)
            {
                C1B7devmapcheckbox = "+devmap ";
                C1B7devmapstate = "enabled";
            }
            if (C1B7devmap.Checked == false)
            {
                C1B7devmapcheckbox = "+map ";
                C1B7devmapstate = "disabled";
            }
        }

        private void C1B7save_Click(object sender, EventArgs e)
        {
            C1B7cfgname = C1B7cfg.Text.ToString();

            if (C1B7cfgname != "")
            {
                C1B7cfgargument = "+exec " + C1B7cfgname + ".cfg ";
                C1B7cfgstate = C1B7cfgname;
            }
            else
            {
                C1B7cfgargument = "";
                C1B7cfgstate = "";
            }

            C1B7mapname = C1B7map.Text.ToString();

            if (C1B7mapname.Contains("mp_"))
            {
                string C1B7mapnameaux = C1B7mapname;
                C1B7mapnamefixed = C1B7mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC1B7 = new StreamWriter("./database/dtbcustoms1/C1B7.txt"))
            {
                swdtbC1B7.WriteLine(C1B7devmapcheckbox);
                swdtbC1B7.WriteLine(C1B7devmapstate);
                swdtbC1B7.WriteLine(C1B7cfgargument);
                swdtbC1B7.WriteLine(C1B7cfgstate);
                swdtbC1B7.WriteLine(C1B7mapname);
                swdtbC1B7.WriteLine(C1B7mapnamefixed);
                swdtbC1B7.Close();
            }
            databaseC1B7path = ("./database/dtbcustoms1/C1B7.txt");

            using (var srdtbC1B7 = new StreamReader(databaseC1B7path))
            {
                lineC1B7devmapcheckbox = srdtbC1B7.ReadLine();
                lineC1B7devmapstate = srdtbC1B7.ReadLine();
                lineC1B7cfgargument = srdtbC1B7.ReadLine();
                lineC1B7cfgstate = srdtbC1B7.ReadLine();
                lineC1B7mapname = srdtbC1B7.ReadLine();
                lineC1B7mapnamefixed = srdtbC1B7.ReadLine();
            }
        }

        private void C1B7info_Click(object sender, EventArgs e)
        {
            c1start7info show = new c1start7info();
            show.ShowDialog();
        }

        // C1B8
        private void C1B8devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C1B8devmap.Checked == true)
            {
                C1B8devmapcheckbox = "+devmap ";
                C1B8devmapstate = "enabled";
            }
            if (C1B8devmap.Checked == false)
            {
                C1B8devmapcheckbox = "+map ";
                C1B8devmapstate = "disabled";
            }
        }

        private void C1B8save_Click(object sender, EventArgs e)
        {
            C1B8cfgname = C1B8cfg.Text.ToString();

            if (C1B8cfgname != "")
            {
                C1B8cfgargument = "+exec " + C1B8cfgname + ".cfg ";
                C1B8cfgstate = C1B8cfgname;
            }
            else
            {
                C1B8cfgargument = "";
                C1B8cfgstate = "";
            }

            C1B8mapname = C1B8map.Text.ToString();

            if (C1B8mapname.Contains("mp_"))
            {
                string C1B8mapnameaux = C1B8mapname;
                C1B8mapnamefixed = C1B8mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC1B8 = new StreamWriter("./database/dtbcustoms1/C1B8.txt"))
            {
                swdtbC1B8.WriteLine(C1B8devmapcheckbox);
                swdtbC1B8.WriteLine(C1B8devmapstate);
                swdtbC1B8.WriteLine(C1B8cfgargument);
                swdtbC1B8.WriteLine(C1B8cfgstate);
                swdtbC1B8.WriteLine(C1B8mapname);
                swdtbC1B8.WriteLine(C1B8mapnamefixed);
                swdtbC1B8.Close();
            }
            databaseC1B8path = ("./database/dtbcustoms1/C1B8.txt");

            using (var srdtbC1B8 = new StreamReader(databaseC1B8path))
            {
                lineC1B8devmapcheckbox = srdtbC1B8.ReadLine();
                lineC1B8devmapstate = srdtbC1B8.ReadLine();
                lineC1B8cfgargument = srdtbC1B8.ReadLine();
                lineC1B8cfgstate = srdtbC1B8.ReadLine();
                lineC1B8mapname = srdtbC1B8.ReadLine();
                lineC1B8mapnamefixed = srdtbC1B8.ReadLine();
            }
        }

        private void C1B8info_Click(object sender, EventArgs e)
        {
            c1start8info show = new c1start8info();
            show.ShowDialog();
        }

        // C1B9
        private void C1B9devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C1B9devmap.Checked == true)
            {
                C1B9devmapcheckbox = "+devmap ";
                C1B9devmapstate = "enabled";
            }
            if (C1B9devmap.Checked == false)
            {
                C1B9devmapcheckbox = "+map ";
                C1B9devmapstate = "disabled";
            }
        }

        private void C1B9save_Click(object sender, EventArgs e)
        {
            C1B9cfgname = C1B9cfg.Text.ToString();

            if (C1B9cfgname != "")
            {
                C1B9cfgargument = "+exec " + C1B9cfgname + ".cfg ";
                C1B9cfgstate = C1B9cfgname;
            }
            else
            {
                C1B9cfgargument = "";
                C1B9cfgstate = "";
            }

            C1B9mapname = C1B9map.Text.ToString();

            if (C1B9mapname.Contains("mp_"))
            {
                string C1B9mapnameaux = C1B9mapname;
                C1B9mapnamefixed = C1B9mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC1B9 = new StreamWriter("./database/dtbcustoms1/C1B9.txt"))
            {
                swdtbC1B9.WriteLine(C1B9devmapcheckbox);
                swdtbC1B9.WriteLine(C1B9devmapstate);
                swdtbC1B9.WriteLine(C1B9cfgargument);
                swdtbC1B9.WriteLine(C1B9cfgstate);
                swdtbC1B9.WriteLine(C1B9mapname);
                swdtbC1B9.WriteLine(C1B9mapnamefixed);
                swdtbC1B9.Close();
            }
            databaseC1B9path = ("./database/dtbcustoms1/C1B9.txt");

            using (var srdtbC1B9 = new StreamReader(databaseC1B9path))
            {
                lineC1B9devmapcheckbox = srdtbC1B9.ReadLine();
                lineC1B9devmapstate = srdtbC1B9.ReadLine();
                lineC1B9cfgargument = srdtbC1B9.ReadLine();
                lineC1B9cfgstate = srdtbC1B9.ReadLine();
                lineC1B9mapname = srdtbC1B9.ReadLine();
                lineC1B9mapnamefixed = srdtbC1B9.ReadLine();
            }
        }

        private void C1B9info_Click(object sender, EventArgs e)
        {
            c1start9info show = new c1start9info();
            show.ShowDialog();
        }

        // C1B10
        private void C1B10devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C1B10devmap.Checked == true)
            {
                C1B10devmapcheckbox = "+devmap ";
                C1B10devmapstate = "enabled";
            }
            if (C1B10devmap.Checked == false)
            {
                C1B10devmapcheckbox = "+map ";
                C1B10devmapstate = "disabled";
            }
        }

        private void C1B10save_Click(object sender, EventArgs e)
        {
            C1B10cfgname = C1B10cfg.Text.ToString();

            if (C1B10cfgname != "")
            {
                C1B10cfgargument = "+exec " + C1B10cfgname + ".cfg ";
                C1B10cfgstate = C1B10cfgname;
            }
            else
            {
                C1B10cfgargument = "";
                C1B10cfgstate = "";
            }

            C1B10mapname = C1B10map.Text.ToString();

            if (C1B10mapname.Contains("mp_"))
            {
                string C1B10mapnameaux = C1B10mapname;
                C1B10mapnamefixed = C1B10mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC1B10 = new StreamWriter("./database/dtbcustoms1/C1B10.txt"))
            {
                swdtbC1B10.WriteLine(C1B10devmapcheckbox);
                swdtbC1B10.WriteLine(C1B10devmapstate);
                swdtbC1B10.WriteLine(C1B10cfgargument);
                swdtbC1B10.WriteLine(C1B10cfgstate);
                swdtbC1B10.WriteLine(C1B10mapname);
                swdtbC1B10.WriteLine(C1B10mapnamefixed);
                swdtbC1B10.Close();
            }
            databaseC1B10path = ("./database/dtbcustoms1/C1B10.txt");

            using (var srdtbC1B10 = new StreamReader(databaseC1B10path))
            {
                lineC1B10devmapcheckbox = srdtbC1B10.ReadLine();
                lineC1B10devmapstate = srdtbC1B10.ReadLine();
                lineC1B10cfgargument = srdtbC1B10.ReadLine();
                lineC1B10cfgstate = srdtbC1B10.ReadLine();
                lineC1B10mapname = srdtbC1B10.ReadLine();
                lineC1B10mapnamefixed = srdtbC1B10.ReadLine();
            }
        }

        private void C1B10info_Click(object sender, EventArgs e)
        {
            c1start10info show = new c1start10info();
            show.ShowDialog();
        }

        // C1B11
        private void C1B11devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C1B11devmap.Checked == true)
            {
                C1B11devmapcheckbox = "+devmap ";
                C1B11devmapstate = "enabled";
            }
            if (C1B11devmap.Checked == false)
            {
                C1B11devmapcheckbox = "+map ";
                C1B11devmapstate = "disabled";
            }
        }

        private void C1B11save_Click(object sender, EventArgs e)
        {
            C1B11cfgname = C1B11cfg.Text.ToString();

            if (C1B11cfgname != "")
            {
                C1B11cfgargument = "+exec " + C1B11cfgname + ".cfg ";
                C1B11cfgstate = C1B11cfgname;
            }
            else
            {
                C1B11cfgargument = "";
                C1B11cfgstate = "";
            }

            C1B11mapname = C1B11map.Text.ToString();

            if (C1B11mapname.Contains("mp_"))
            {
                string C1B11mapnameaux = C1B11mapname;
                C1B11mapnamefixed = C1B11mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC1B11 = new StreamWriter("./database/dtbcustoms1/C1B11.txt"))
            {
                swdtbC1B11.WriteLine(C1B11devmapcheckbox);
                swdtbC1B11.WriteLine(C1B11devmapstate);
                swdtbC1B11.WriteLine(C1B11cfgargument);
                swdtbC1B11.WriteLine(C1B11cfgstate);
                swdtbC1B11.WriteLine(C1B11mapname);
                swdtbC1B11.WriteLine(C1B11mapnamefixed);
                swdtbC1B11.Close();
            }
            databaseC1B11path = ("./database/dtbcustoms1/C1B11.txt");

            using (var srdtbC1B11 = new StreamReader(databaseC1B11path))
            {
                lineC1B11devmapcheckbox = srdtbC1B11.ReadLine();
                lineC1B11devmapstate = srdtbC1B11.ReadLine();
                lineC1B11cfgargument = srdtbC1B11.ReadLine();
                lineC1B11cfgstate = srdtbC1B11.ReadLine();
                lineC1B11mapname = srdtbC1B11.ReadLine();
                lineC1B11mapnamefixed = srdtbC1B11.ReadLine();
            }
        }

        private void C1B11info_Click(object sender, EventArgs e)
        {
            c1start11info show = new c1start11info();
            show.ShowDialog();
        }

        // C1B12
        private void C1B12devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C1B12devmap.Checked == true)
            {
                C1B12devmapcheckbox = "+devmap ";
                C1B12devmapstate = "enabled";
            }
            if (C1B12devmap.Checked == false)
            {
                C1B12devmapcheckbox = "+map ";
                C1B12devmapstate = "disabled";
            }
        }

        private void C1B12save_Click(object sender, EventArgs e)
        {
            C1B12cfgname = C1B12cfg.Text.ToString();

            if (C1B12cfgname != "")
            {
                C1B12cfgargument = "+exec " + C1B12cfgname + ".cfg ";
                C1B12cfgstate = C1B12cfgname;
            }
            else
            {
                C1B12cfgargument = "";
                C1B12cfgstate = "";
            }

            C1B12mapname = C1B12map.Text.ToString();

            if (C1B12mapname.Contains("mp_"))
            {
                string C1B12mapnameaux = C1B12mapname;
                C1B12mapnamefixed = C1B12mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC1B12 = new StreamWriter("./database/dtbcustoms1/C1B12.txt"))
            {
                swdtbC1B12.WriteLine(C1B12devmapcheckbox);
                swdtbC1B12.WriteLine(C1B12devmapstate);
                swdtbC1B12.WriteLine(C1B12cfgargument);
                swdtbC1B12.WriteLine(C1B12cfgstate);
                swdtbC1B12.WriteLine(C1B12mapname);
                swdtbC1B12.WriteLine(C1B12mapnamefixed);
                swdtbC1B12.Close();
            }
            databaseC1B12path = ("./database/dtbcustoms1/C1B12.txt");

            using (var srdtbC1B12 = new StreamReader(databaseC1B12path))
            {
                lineC1B12devmapcheckbox = srdtbC1B12.ReadLine();
                lineC1B12devmapstate = srdtbC1B12.ReadLine();
                lineC1B12cfgargument = srdtbC1B12.ReadLine();
                lineC1B12cfgstate = srdtbC1B12.ReadLine();
                lineC1B12mapname = srdtbC1B12.ReadLine();
                lineC1B12mapnamefixed = srdtbC1B12.ReadLine();
            }
        }

        private void C1B12info_Click(object sender, EventArgs e)
        {
            c1start12info show = new c1start12info();
            show.ShowDialog();
        }
    }
}
