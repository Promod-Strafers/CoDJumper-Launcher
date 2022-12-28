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
    public partial class SettingsCustom3 : Form
    {
        // strings C3B1
        public string C3B1devmapcheckbox;
        public string C3B1devmapstate;
        public string C3B1cfgname;
        public string C3B1cfgargument;
        public string C3B1cfgstate;
        public string databaseC3B1path;
        public static string lineC3B1devmapcheckbox;
        public static string lineC3B1devmapstate;
        public static string lineC3B1cfgargument;
        public static string lineC3B1cfgstate;
        public static string C3B1mapname;
        public static string C3B1mapnamefixed;
        public static string lineC3B1mapname;
        public static string lineC3B1mapnamefixed;

        // strings C3B2
        public string C3B2devmapcheckbox;
        public string C3B2devmapstate;
        public string C3B2cfgname;
        public string C3B2cfgargument;
        public string C3B2cfgstate;
        public string databaseC3B2path;
        public static string lineC3B2devmapcheckbox;
        public static string lineC3B2devmapstate;
        public static string lineC3B2cfgargument;
        public static string lineC3B2cfgstate;
        public static string C3B2mapname;
        public static string C3B2mapnamefixed;
        public static string lineC3B2mapname;
        public static string lineC3B2mapnamefixed;

        // strings C3B3
        public string C3B3devmapcheckbox;
        public string C3B3devmapstate;
        public string C3B3cfgname;
        public string C3B3cfgargument;
        public string C3B3cfgstate;
        public string databaseC3B3path;
        public static string lineC3B3devmapcheckbox;
        public static string lineC3B3devmapstate;
        public static string lineC3B3cfgargument;
        public static string lineC3B3cfgstate;
        public static string C3B3mapname;
        public static string C3B3mapnamefixed;
        public static string lineC3B3mapname;
        public static string lineC3B3mapnamefixed;

        // strings C3B4
        public string C3B4devmapcheckbox;
        public string C3B4devmapstate;
        public string C3B4cfgname;
        public string C3B4cfgargument;
        public string C3B4cfgstate;
        public string databaseC3B4path;
        public static string lineC3B4devmapcheckbox;
        public static string lineC3B4devmapstate;
        public static string lineC3B4cfgargument;
        public static string lineC3B4cfgstate;
        public static string C3B4mapname;
        public static string C3B4mapnamefixed;
        public static string lineC3B4mapname;
        public static string lineC3B4mapnamefixed;

        // strings C3B5
        public string C3B5devmapcheckbox;
        public string C3B5devmapstate;
        public string C3B5cfgname;
        public string C3B5cfgargument;
        public string C3B5cfgstate;
        public string databaseC3B5path;
        public static string lineC3B5devmapcheckbox;
        public static string lineC3B5devmapstate;
        public static string lineC3B5cfgargument;
        public static string lineC3B5cfgstate;
        public static string C3B5mapname;
        public static string C3B5mapnamefixed;
        public static string lineC3B5mapname;
        public static string lineC3B5mapnamefixed;

        // strings C3B6
        public string C3B6devmapcheckbox;
        public string C3B6devmapstate;
        public string C3B6cfgname;
        public string C3B6cfgargument;
        public string C3B6cfgstate;
        public string databaseC3B6path;
        public static string lineC3B6devmapcheckbox;
        public static string lineC3B6devmapstate;
        public static string lineC3B6cfgargument;
        public static string lineC3B6cfgstate;
        public static string C3B6mapname;
        public static string C3B6mapnamefixed;
        public static string lineC3B6mapname;
        public static string lineC3B6mapnamefixed;
        public SettingsCustom3()
        {
            InitializeComponent();

            C3B1devmapcheckbox = "+map ";
            C3B1devmapstate = "disabled";
            C3B2devmapcheckbox = "+map ";
            C3B2devmapstate = "disabled";
            C3B3devmapcheckbox = "+map ";
            C3B3devmapstate = "disabled";
            C3B4devmapcheckbox = "+map ";
            C3B4devmapstate = "disabled";
            C3B5devmapcheckbox = "+map ";
            C3B5devmapstate = "disabled";
            C3B6devmapcheckbox = "+map ";
            C3B6devmapstate = "disabled";
        }

        // C3B1
        private void C3B1devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C3B1devmap.Checked == true)
            {
                C3B1devmapcheckbox = "+devmap ";
                C3B1devmapstate = "enabled";
            }
            if (C3B1devmap.Checked == false)
            {
                C3B1devmapcheckbox = "+map ";
                C3B1devmapstate = "disabled";
            }
        }

        private void C3B1save_Click(object sender, EventArgs e)
        {
            C3B1cfgname = C3B1cfg.Text.ToString();

            if (C3B1cfgname != "")
            {
                C3B1cfgargument = "+exec " + C3B1cfgname + ".cfg ";
                C3B1cfgstate = C3B1cfgname;
            }
            else
            {
                C3B1cfgargument = "";
                C3B1cfgstate = "";
            }

            C3B1mapname = C3B1map.Text.ToString();

            if (C3B1mapname.Contains("mp_"))
            {
                string C3B1mapnameaux = C3B1mapname;
                C3B1mapnamefixed = C3B1mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC3B1 = new StreamWriter("./database/dtbcustoms3/C3B1.txt"))
            {
                swdtbC3B1.WriteLine(C3B1devmapcheckbox);
                swdtbC3B1.WriteLine(C3B1devmapstate);
                swdtbC3B1.WriteLine(C3B1cfgargument);
                swdtbC3B1.WriteLine(C3B1cfgstate);
                swdtbC3B1.WriteLine(C3B1mapname);
                swdtbC3B1.WriteLine(C3B1mapnamefixed);
                swdtbC3B1.Close();
            }
            databaseC3B1path = ("./database/dtbcustoms3/C3B1.txt");

            using (var srdtbC3B1 = new StreamReader(databaseC3B1path))
            {
                lineC3B1devmapcheckbox = srdtbC3B1.ReadLine();
                lineC3B1devmapstate = srdtbC3B1.ReadLine();
                lineC3B1cfgargument = srdtbC3B1.ReadLine();
                lineC3B1cfgstate = srdtbC3B1.ReadLine();
                lineC3B1mapname = srdtbC3B1.ReadLine();
                lineC3B1mapnamefixed = srdtbC3B1.ReadLine();
            }
        }

        private void C3B1info_Click(object sender, EventArgs e)
        {
            c3start1info show = new c3start1info();
            show.ShowDialog();
        }

        // C3B2
        private void C3B2devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C3B2devmap.Checked == true)
            {
                C3B2devmapcheckbox = "+devmap ";
                C3B2devmapstate = "enabled";
            }
            if (C3B2devmap.Checked == false)
            {
                C3B2devmapcheckbox = "+map ";
                C3B2devmapstate = "disabled";
            }
        }

        private void C3B2save_Click(object sender, EventArgs e)
        {
            C3B2cfgname = C3B2cfg.Text.ToString();

            if (C3B2cfgname != "")
            {
                C3B2cfgargument = "+exec " + C3B2cfgname + ".cfg ";
                C3B2cfgstate = C3B2cfgname;
            }
            else
            {
                C3B2cfgargument = "";
                C3B2cfgstate = "";
            }

            C3B2mapname = C3B2map.Text.ToString();

            if (C3B2mapname.Contains("mp_"))
            {
                string C3B2mapnameaux = C3B2mapname;
                C3B2mapnamefixed = C3B2mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC3B2 = new StreamWriter("./database/dtbcustoms3/C3B2.txt"))
            {
                swdtbC3B2.WriteLine(C3B2devmapcheckbox);
                swdtbC3B2.WriteLine(C3B2devmapstate);
                swdtbC3B2.WriteLine(C3B2cfgargument);
                swdtbC3B2.WriteLine(C3B2cfgstate);
                swdtbC3B2.WriteLine(C3B2mapname);
                swdtbC3B2.WriteLine(C3B2mapnamefixed);
                swdtbC3B2.Close();
            }
            databaseC3B2path = ("./database/dtbcustoms3/C3B2.txt");

            using (var srdtbC3B2 = new StreamReader(databaseC3B2path))
            {
                lineC3B2devmapcheckbox = srdtbC3B2.ReadLine();
                lineC3B2devmapstate = srdtbC3B2.ReadLine();
                lineC3B2cfgargument = srdtbC3B2.ReadLine();
                lineC3B2cfgstate = srdtbC3B2.ReadLine();
                lineC3B2mapname = srdtbC3B2.ReadLine();
                lineC3B2mapnamefixed = srdtbC3B2.ReadLine();
            }
        }

        private void C3B2info_Click(object sender, EventArgs e)
        {
            c3start2info show = new c3start2info();
            show.ShowDialog();
        }

        // C3B3
        private void C3B3devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C3B3devmap.Checked == true)
            {
                C3B3devmapcheckbox = "+devmap ";
                C3B3devmapstate = "enabled";
            }
            if (C3B3devmap.Checked == false)
            {
                C3B3devmapcheckbox = "+map ";
                C3B3devmapstate = "disabled";
            }
        }

        private void C3B3save_Click(object sender, EventArgs e)
        {
            C3B3cfgname = C3B3cfg.Text.ToString();

            if (C3B3cfgname != "")
            {
                C3B3cfgargument = "+exec " + C3B3cfgname + ".cfg ";
                C3B3cfgstate = C3B3cfgname;
            }
            else
            {
                C3B3cfgargument = "";
                C3B3cfgstate = "";
            }

            C3B3mapname = C3B3map.Text.ToString();

            if (C3B3mapname.Contains("mp_"))
            {
                string C3B3mapnameaux = C3B3mapname;
                C3B3mapnamefixed = C3B3mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC3B3 = new StreamWriter("./database/dtbcustoms3/C3B3.txt"))
            {
                swdtbC3B3.WriteLine(C3B3devmapcheckbox);
                swdtbC3B3.WriteLine(C3B3devmapstate);
                swdtbC3B3.WriteLine(C3B3cfgargument);
                swdtbC3B3.WriteLine(C3B3cfgstate);
                swdtbC3B3.WriteLine(C3B3mapname);
                swdtbC3B3.WriteLine(C3B3mapnamefixed);
                swdtbC3B3.Close();
            }
            databaseC3B3path = ("./database/dtbcustoms3/C3B3.txt");

            using (var srdtbC3B3 = new StreamReader(databaseC3B3path))
            {
                lineC3B3devmapcheckbox = srdtbC3B3.ReadLine();
                lineC3B3devmapstate = srdtbC3B3.ReadLine();
                lineC3B3cfgargument = srdtbC3B3.ReadLine();
                lineC3B3cfgstate = srdtbC3B3.ReadLine();
                lineC3B3mapname = srdtbC3B3.ReadLine();
                lineC3B3mapnamefixed = srdtbC3B3.ReadLine();
            }
        }

        private void C3B3info_Click(object sender, EventArgs e)
        {
            c3start3info show = new c3start3info();
            show.ShowDialog();
        }

        // C3B4
        private void C3B4devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C3B4devmap.Checked == true)
            {
                C3B4devmapcheckbox = "+devmap ";
                C3B4devmapstate = "enabled";
            }
            if (C3B4devmap.Checked == false)
            {
                C3B4devmapcheckbox = "+map ";
                C3B4devmapstate = "disabled";
            }
        }

        private void C3B4save_Click(object sender, EventArgs e)
        {
            C3B4cfgname = C3B4cfg.Text.ToString();

            if (C3B4cfgname != "")
            {
                C3B4cfgargument = "+exec " + C3B4cfgname + ".cfg ";
                C3B4cfgstate = C3B4cfgname;
            }
            else
            {
                C3B4cfgargument = "";
                C3B4cfgstate = "";
            }

            C3B4mapname = C3B4map.Text.ToString();

            if (C3B4mapname.Contains("mp_"))
            {
                string C3B4mapnameaux = C3B4mapname;
                C3B4mapnamefixed = C3B4mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC3B4 = new StreamWriter("./database/dtbcustoms3/C3B4.txt"))
            {
                swdtbC3B4.WriteLine(C3B4devmapcheckbox);
                swdtbC3B4.WriteLine(C3B4devmapstate);
                swdtbC3B4.WriteLine(C3B4cfgargument);
                swdtbC3B4.WriteLine(C3B4cfgstate);
                swdtbC3B4.WriteLine(C3B4mapname);
                swdtbC3B4.WriteLine(C3B4mapnamefixed);
                swdtbC3B4.Close();
            }
            databaseC3B4path = ("./database/dtbcustoms3/C3B4.txt");

            using (var srdtbC3B4 = new StreamReader(databaseC3B4path))
            {
                lineC3B4devmapcheckbox = srdtbC3B4.ReadLine();
                lineC3B4devmapstate = srdtbC3B4.ReadLine();
                lineC3B4cfgargument = srdtbC3B4.ReadLine();
                lineC3B4cfgstate = srdtbC3B4.ReadLine();
                lineC3B4mapname = srdtbC3B4.ReadLine();
                lineC3B4mapnamefixed = srdtbC3B4.ReadLine();
            }
        }

        private void C3B4info_Click(object sender, EventArgs e)
        {
            c3start4info show = new c3start4info();
            show.ShowDialog();
        }

        // C3B5
        private void C3B5devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C3B5devmap.Checked == true)
            {
                C3B5devmapcheckbox = "+devmap ";
                C3B5devmapstate = "enabled";
            }
            if (C3B5devmap.Checked == false)
            {
                C3B5devmapcheckbox = "+map ";
                C3B5devmapstate = "disabled";
            }
        }

        private void C3B5save_Click(object sender, EventArgs e)
        {
            C3B5cfgname = C3B5cfg.Text.ToString();

            if (C3B5cfgname != "")
            {
                C3B5cfgargument = "+exec " + C3B5cfgname + ".cfg ";
                C3B5cfgstate = C3B5cfgname;
            }
            else
            {
                C3B5cfgargument = "";
                C3B5cfgstate = "";
            }

            C3B5mapname = C3B5map.Text.ToString();

            if (C3B5mapname.Contains("mp_"))
            {
                string C3B5mapnameaux = C3B5mapname;
                C3B5mapnamefixed = C3B5mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC3B5 = new StreamWriter("./database/dtbcustoms3/C3B5.txt"))
            {
                swdtbC3B5.WriteLine(C3B5devmapcheckbox);
                swdtbC3B5.WriteLine(C3B5devmapstate);
                swdtbC3B5.WriteLine(C3B5cfgargument);
                swdtbC3B5.WriteLine(C3B5cfgstate);
                swdtbC3B5.WriteLine(C3B5mapname);
                swdtbC3B5.WriteLine(C3B5mapnamefixed);
                swdtbC3B5.Close();
            }
            databaseC3B5path = ("./database/dtbcustoms3/C3B5.txt");

            using (var srdtbC3B5 = new StreamReader(databaseC3B5path))
            {
                lineC3B5devmapcheckbox = srdtbC3B5.ReadLine();
                lineC3B5devmapstate = srdtbC3B5.ReadLine();
                lineC3B5cfgargument = srdtbC3B5.ReadLine();
                lineC3B5cfgstate = srdtbC3B5.ReadLine();
                lineC3B5mapname = srdtbC3B5.ReadLine();
                lineC3B5mapnamefixed = srdtbC3B5.ReadLine();
            }
        }

        private void C3B5info_Click(object sender, EventArgs e)
        {
            c3start5info show = new c3start5info();
            show.ShowDialog();
        }

        // C3B6
        private void C3B6devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C3B6devmap.Checked == true)
            {
                C3B6devmapcheckbox = "+devmap ";
                C3B6devmapstate = "enabled";
            }
            if (C3B6devmap.Checked == false)
            {
                C3B6devmapcheckbox = "+map ";
                C3B6devmapstate = "disabled";
            }
        }

        private void C3B6save_Click(object sender, EventArgs e)
        {
            C3B6cfgname = C3B6cfg.Text.ToString();

            if (C3B6cfgname != "")
            {
                C3B6cfgargument = "+exec " + C3B6cfgname + ".cfg ";
                C3B6cfgstate = C3B6cfgname;
            }
            else
            {
                C3B6cfgargument = "";
                C3B6cfgstate = "";
            }

            C3B6mapname = C3B6map.Text.ToString();

            if (C3B6mapname.Contains("mp_"))
            {
                string C3B6mapnameaux = C3B6mapname;
                C3B6mapnamefixed = C3B6mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC3B6 = new StreamWriter("./database/dtbcustoms3/C3B6.txt"))
            {
                swdtbC3B6.WriteLine(C3B6devmapcheckbox);
                swdtbC3B6.WriteLine(C3B6devmapstate);
                swdtbC3B6.WriteLine(C3B6cfgargument);
                swdtbC3B6.WriteLine(C3B6cfgstate);
                swdtbC3B6.WriteLine(C3B6mapname);
                swdtbC3B6.WriteLine(C3B6mapnamefixed);
                swdtbC3B6.Close();
            }
            databaseC3B6path = ("./database/dtbcustoms3/C3B6.txt");

            using (var srdtbC3B6 = new StreamReader(databaseC3B6path))
            {
                lineC3B6devmapcheckbox = srdtbC3B6.ReadLine();
                lineC3B6devmapstate = srdtbC3B6.ReadLine();
                lineC3B6cfgargument = srdtbC3B6.ReadLine();
                lineC3B6cfgstate = srdtbC3B6.ReadLine();
                lineC3B6mapname = srdtbC3B6.ReadLine();
                lineC3B6mapnamefixed = srdtbC3B6.ReadLine();
            }
        }

        private void C3B6info_Click(object sender, EventArgs e)
        {
            c3start6info show = new c3start6info();
            show.ShowDialog();
        }
    }
}
