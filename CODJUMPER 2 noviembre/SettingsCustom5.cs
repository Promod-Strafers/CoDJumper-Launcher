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
    public partial class SettingsCustom5 : Form
    {
        // strings C5B1
        public string C5B1devmapcheckbox;
        public string C5B1devmapstate;
        public string C5B1cfgname;
        public string C5B1cfgargument;
        public string C5B1cfgstate;
        public string databaseC5B1path;
        public static string lineC5B1devmapcheckbox;
        public static string lineC5B1devmapstate;
        public static string lineC5B1cfgargument;
        public static string lineC5B1cfgstate;
        public static string C5B1mapname;
        public static string C5B1mapnamefixed;
        public static string lineC5B1mapname;
        public static string lineC5B1mapnamefixed;

        // strings C5B2
        public string C5B2devmapcheckbox;
        public string C5B2devmapstate;
        public string C5B2cfgname;
        public string C5B2cfgargument;
        public string C5B2cfgstate;
        public string databaseC5B2path;
        public static string lineC5B2devmapcheckbox;
        public static string lineC5B2devmapstate;
        public static string lineC5B2cfgargument;
        public static string lineC5B2cfgstate;
        public static string C5B2mapname;
        public static string C5B2mapnamefixed;
        public static string lineC5B2mapname;
        public static string lineC5B2mapnamefixed;

        // strings C5B3
        public string C5B3devmapcheckbox;
        public string C5B3devmapstate;
        public string C5B3cfgname;
        public string C5B3cfgargument;
        public string C5B3cfgstate;
        public string databaseC5B3path;
        public static string lineC5B3devmapcheckbox;
        public static string lineC5B3devmapstate;
        public static string lineC5B3cfgargument;
        public static string lineC5B3cfgstate;
        public static string C5B3mapname;
        public static string C5B3mapnamefixed;
        public static string lineC5B3mapname;
        public static string lineC5B3mapnamefixed;

        // strings C5B4
        public string C5B4devmapcheckbox;
        public string C5B4devmapstate;
        public string C5B4cfgname;
        public string C5B4cfgargument;
        public string C5B4cfgstate;
        public string databaseC5B4path;
        public static string lineC5B4devmapcheckbox;
        public static string lineC5B4devmapstate;
        public static string lineC5B4cfgargument;
        public static string lineC5B4cfgstate;
        public static string C5B4mapname;
        public static string C5B4mapnamefixed;
        public static string lineC5B4mapname;
        public static string lineC5B4mapnamefixed;

        // strings C5B5
        public string C5B5devmapcheckbox;
        public string C5B5devmapstate;
        public string C5B5cfgname;
        public string C5B5cfgargument;
        public string C5B5cfgstate;
        public string databaseC5B5path;
        public static string lineC5B5devmapcheckbox;
        public static string lineC5B5devmapstate;
        public static string lineC5B5cfgargument;
        public static string lineC5B5cfgstate;
        public static string C5B5mapname;
        public static string C5B5mapnamefixed;
        public static string lineC5B5mapname;
        public static string lineC5B5mapnamefixed;

        // strings C5B6
        public string C5B6devmapcheckbox;
        public string C5B6devmapstate;
        public string C5B6cfgname;
        public string C5B6cfgargument;
        public string C5B6cfgstate;
        public string databaseC5B6path;
        public static string lineC5B6devmapcheckbox;
        public static string lineC5B6devmapstate;
        public static string lineC5B6cfgargument;
        public static string lineC5B6cfgstate;
        public static string C5B6mapname;
        public static string C5B6mapnamefixed;
        public static string lineC5B6mapname;
        public static string lineC5B6mapnamefixed;
        public SettingsCustom5()
        {
            InitializeComponent();

            C5B1devmapcheckbox = "+map ";
            C5B1devmapstate = "disabled";
            C5B2devmapcheckbox = "+map ";
            C5B2devmapstate = "disabled";
            C5B3devmapcheckbox = "+map ";
            C5B3devmapstate = "disabled";
            C5B4devmapcheckbox = "+map ";
            C5B4devmapstate = "disabled";
            C5B5devmapcheckbox = "+map ";
            C5B5devmapstate = "disabled";
            C5B6devmapcheckbox = "+map ";
            C5B6devmapstate = "disabled";
        }

        // C5B1
        private void C5B1devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C5B1devmap.Checked == true)
            {
                C5B1devmapcheckbox = "+devmap ";
                C5B1devmapstate = "enabled";
            }
            if (C5B1devmap.Checked == false)
            {
                C5B1devmapcheckbox = "+map ";
                C5B1devmapstate = "disabled";
            }
        }

        private void C5B1save_Click(object sender, EventArgs e)
        {
            C5B1cfgname = C5B1cfg.Text.ToString();

            if (C5B1cfgname != "")
            {
                C5B1cfgargument = "+exec " + C5B1cfgname + ".cfg ";
                C5B1cfgstate = C5B1cfgname;
            }
            else
            {
                C5B1cfgargument = "";
                C5B1cfgstate = "";
            }

            C5B1mapname = C5B1map.Text.ToString();

            if (C5B1mapname.Contains("mp_"))
            {
                string C5B1mapnameaux = C5B1mapname;
                C5B1mapnamefixed = C5B1mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC5B1 = new StreamWriter("./database/dtbcustoms5/C5B1.txt"))
            {
                swdtbC5B1.WriteLine(C5B1devmapcheckbox);
                swdtbC5B1.WriteLine(C5B1devmapstate);
                swdtbC5B1.WriteLine(C5B1cfgargument);
                swdtbC5B1.WriteLine(C5B1cfgstate);
                swdtbC5B1.WriteLine(C5B1mapname);
                swdtbC5B1.WriteLine(C5B1mapnamefixed);
                swdtbC5B1.Close();
            }
            databaseC5B1path = ("./database/dtbcustoms5/C5B1.txt");

            using (var srdtbC5B1 = new StreamReader(databaseC5B1path))
            {
                lineC5B1devmapcheckbox = srdtbC5B1.ReadLine();
                lineC5B1devmapstate = srdtbC5B1.ReadLine();
                lineC5B1cfgargument = srdtbC5B1.ReadLine();
                lineC5B1cfgstate = srdtbC5B1.ReadLine();
                lineC5B1mapname = srdtbC5B1.ReadLine();
                lineC5B1mapnamefixed = srdtbC5B1.ReadLine();
            }
        }

        private void C5B1info_Click(object sender, EventArgs e)
        {
            c5start1info show = new c5start1info();
            show.ShowDialog();
        }

        // C5B2
        private void C5B2devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C5B2devmap.Checked == true)
            {
                C5B2devmapcheckbox = "+devmap ";
                C5B2devmapstate = "enabled";
            }
            if (C5B2devmap.Checked == false)
            {
                C5B2devmapcheckbox = "+map ";
                C5B2devmapstate = "disabled";
            }
        }

        private void C5B2save_Click(object sender, EventArgs e)
        {
            C5B2cfgname = C5B2cfg.Text.ToString();

            if (C5B2cfgname != "")
            {
                C5B2cfgargument = "+exec " + C5B2cfgname + ".cfg ";
                C5B2cfgstate = C5B2cfgname;
            }
            else
            {
                C5B2cfgargument = "";
                C5B2cfgstate = "";
            }

            C5B2mapname = C5B2map.Text.ToString();

            if (C5B2mapname.Contains("mp_"))
            {
                string C5B2mapnameaux = C5B2mapname;
                C5B2mapnamefixed = C5B2mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC5B2 = new StreamWriter("./database/dtbcustoms5/C5B2.txt"))
            {
                swdtbC5B2.WriteLine(C5B2devmapcheckbox);
                swdtbC5B2.WriteLine(C5B2devmapstate);
                swdtbC5B2.WriteLine(C5B2cfgargument);
                swdtbC5B2.WriteLine(C5B2cfgstate);
                swdtbC5B2.WriteLine(C5B2mapname);
                swdtbC5B2.WriteLine(C5B2mapnamefixed);
                swdtbC5B2.Close();
            }
            databaseC5B2path = ("./database/dtbcustoms5/C5B2.txt");

            using (var srdtbC5B2 = new StreamReader(databaseC5B2path))
            {
                lineC5B2devmapcheckbox = srdtbC5B2.ReadLine();
                lineC5B2devmapstate = srdtbC5B2.ReadLine();
                lineC5B2cfgargument = srdtbC5B2.ReadLine();
                lineC5B2cfgstate = srdtbC5B2.ReadLine();
                lineC5B2mapname = srdtbC5B2.ReadLine();
                lineC5B2mapnamefixed = srdtbC5B2.ReadLine();
            }
        }

        private void C5B2info_Click(object sender, EventArgs e)
        {
            c5start2info show = new c5start2info();
            show.ShowDialog();
        }

        // C5B3
        private void C5B3devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C5B3devmap.Checked == true)
            {
                C5B3devmapcheckbox = "+devmap ";
                C5B3devmapstate = "enabled";
            }
            if (C5B3devmap.Checked == false)
            {
                C5B3devmapcheckbox = "+map ";
                C5B3devmapstate = "disabled";
            }
        }

        private void C5B3save_Click(object sender, EventArgs e)
        {
            C5B3cfgname = C5B3cfg.Text.ToString();

            if (C5B3cfgname != "")
            {
                C5B3cfgargument = "+exec " + C5B3cfgname + ".cfg ";
                C5B3cfgstate = C5B3cfgname;
            }
            else
            {
                C5B3cfgargument = "";
                C5B3cfgstate = "";
            }

            C5B3mapname = C5B3map.Text.ToString();

            if (C5B3mapname.Contains("mp_"))
            {
                string C5B3mapnameaux = C5B3mapname;
                C5B3mapnamefixed = C5B3mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC5B3 = new StreamWriter("./database/dtbcustoms5/C5B3.txt"))
            {
                swdtbC5B3.WriteLine(C5B3devmapcheckbox);
                swdtbC5B3.WriteLine(C5B3devmapstate);
                swdtbC5B3.WriteLine(C5B3cfgargument);
                swdtbC5B3.WriteLine(C5B3cfgstate);
                swdtbC5B3.WriteLine(C5B3mapname);
                swdtbC5B3.WriteLine(C5B3mapnamefixed);
                swdtbC5B3.Close();
            }
            databaseC5B3path = ("./database/dtbcustoms5/C5B3.txt");

            using (var srdtbC5B3 = new StreamReader(databaseC5B3path))
            {
                lineC5B3devmapcheckbox = srdtbC5B3.ReadLine();
                lineC5B3devmapstate = srdtbC5B3.ReadLine();
                lineC5B3cfgargument = srdtbC5B3.ReadLine();
                lineC5B3cfgstate = srdtbC5B3.ReadLine();
                lineC5B3mapname = srdtbC5B3.ReadLine();
                lineC5B3mapnamefixed = srdtbC5B3.ReadLine();
            }
        }

        private void C5B3info_Click(object sender, EventArgs e)
        {
            c5start3info show = new c5start3info();
            show.ShowDialog();
        }

        // C5B4
        private void C5B4devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C5B4devmap.Checked == true)
            {
                C5B4devmapcheckbox = "+devmap ";
                C5B4devmapstate = "enabled";
            }
            if (C5B4devmap.Checked == false)
            {
                C5B4devmapcheckbox = "+map ";
                C5B4devmapstate = "disabled";
            }
        }

        private void C5B4save_Click(object sender, EventArgs e)
        {
            C5B4cfgname = C5B4cfg.Text.ToString();

            if (C5B4cfgname != "")
            {
                C5B4cfgargument = "+exec " + C5B4cfgname + ".cfg ";
                C5B4cfgstate = C5B4cfgname;
            }
            else
            {
                C5B4cfgargument = "";
                C5B4cfgstate = "";
            }

            C5B4mapname = C5B4map.Text.ToString();

            if (C5B4mapname.Contains("mp_"))
            {
                string C5B4mapnameaux = C5B4mapname;
                C5B4mapnamefixed = C5B4mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC5B4 = new StreamWriter("./database/dtbcustoms5/C5B4.txt"))
            {
                swdtbC5B4.WriteLine(C5B4devmapcheckbox);
                swdtbC5B4.WriteLine(C5B4devmapstate);
                swdtbC5B4.WriteLine(C5B4cfgargument);
                swdtbC5B4.WriteLine(C5B4cfgstate);
                swdtbC5B4.WriteLine(C5B4mapname);
                swdtbC5B4.WriteLine(C5B4mapnamefixed);
                swdtbC5B4.Close();
            }
            databaseC5B4path = ("./database/dtbcustoms5/C5B4.txt");

            using (var srdtbC5B4 = new StreamReader(databaseC5B4path))
            {
                lineC5B4devmapcheckbox = srdtbC5B4.ReadLine();
                lineC5B4devmapstate = srdtbC5B4.ReadLine();
                lineC5B4cfgargument = srdtbC5B4.ReadLine();
                lineC5B4cfgstate = srdtbC5B4.ReadLine();
                lineC5B4mapname = srdtbC5B4.ReadLine();
                lineC5B4mapnamefixed = srdtbC5B4.ReadLine();
            }
        }

        private void C5B4info_Click(object sender, EventArgs e)
        {
            c5start4info show = new c5start4info();
            show.ShowDialog();
        }

        // C5B5
        private void C5B5devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C5B5devmap.Checked == true)
            {
                C5B5devmapcheckbox = "+devmap ";
                C5B5devmapstate = "enabled";
            }
            if (C5B5devmap.Checked == false)
            {
                C5B5devmapcheckbox = "+map ";
                C5B5devmapstate = "disabled";
            }
        }

        private void C5B5save_Click(object sender, EventArgs e)
        {
            C5B5cfgname = C5B5cfg.Text.ToString();

            if (C5B5cfgname != "")
            {
                C5B5cfgargument = "+exec " + C5B5cfgname + ".cfg ";
                C5B5cfgstate = C5B5cfgname;
            }
            else
            {
                C5B5cfgargument = "";
                C5B5cfgstate = "";
            }

            C5B5mapname = C5B5map.Text.ToString();

            if (C5B5mapname.Contains("mp_"))
            {
                string C5B5mapnameaux = C5B5mapname;
                C5B5mapnamefixed = C5B5mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC5B5 = new StreamWriter("./database/dtbcustoms5/C5B5.txt"))
            {
                swdtbC5B5.WriteLine(C5B5devmapcheckbox);
                swdtbC5B5.WriteLine(C5B5devmapstate);
                swdtbC5B5.WriteLine(C5B5cfgargument);
                swdtbC5B5.WriteLine(C5B5cfgstate);
                swdtbC5B5.WriteLine(C5B5mapname);
                swdtbC5B5.WriteLine(C5B5mapnamefixed);
                swdtbC5B5.Close();
            }
            databaseC5B5path = ("./database/dtbcustoms5/C5B5.txt");

            using (var srdtbC5B5 = new StreamReader(databaseC5B5path))
            {
                lineC5B5devmapcheckbox = srdtbC5B5.ReadLine();
                lineC5B5devmapstate = srdtbC5B5.ReadLine();
                lineC5B5cfgargument = srdtbC5B5.ReadLine();
                lineC5B5cfgstate = srdtbC5B5.ReadLine();
                lineC5B5mapname = srdtbC5B5.ReadLine();
                lineC5B5mapnamefixed = srdtbC5B5.ReadLine();
            }
        }

        private void C5B5info_Click(object sender, EventArgs e)
        {
            c5start5info show = new c5start5info();
            show.ShowDialog();
        }

        // C5B6
        private void C5B6devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C5B6devmap.Checked == true)
            {
                C5B6devmapcheckbox = "+devmap ";
                C5B6devmapstate = "enabled";
            }
            if (C5B6devmap.Checked == false)
            {
                C5B6devmapcheckbox = "+map ";
                C5B6devmapstate = "disabled";
            }
        }

        private void C5B6save_Click(object sender, EventArgs e)
        {
            C5B6cfgname = C5B6cfg.Text.ToString();

            if (C5B6cfgname != "")
            {
                C5B6cfgargument = "+exec " + C5B6cfgname + ".cfg ";
                C5B6cfgstate = C5B6cfgname;
            }
            else
            {
                C5B6cfgargument = "";
                C5B6cfgstate = "";
            }

            C5B6mapname = C5B6map.Text.ToString();

            if (C5B6mapname.Contains("mp_"))
            {
                string C5B6mapnameaux = C5B6mapname;
                C5B6mapnamefixed = C5B6mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC5B6 = new StreamWriter("./database/dtbcustoms5/C5B6.txt"))
            {
                swdtbC5B6.WriteLine(C5B6devmapcheckbox);
                swdtbC5B6.WriteLine(C5B6devmapstate);
                swdtbC5B6.WriteLine(C5B6cfgargument);
                swdtbC5B6.WriteLine(C5B6cfgstate);
                swdtbC5B6.WriteLine(C5B6mapname);
                swdtbC5B6.WriteLine(C5B6mapnamefixed);
                swdtbC5B6.Close();
            }
            databaseC5B6path = ("./database/dtbcustoms5/C5B6.txt");

            using (var srdtbC5B6 = new StreamReader(databaseC5B6path))
            {
                lineC5B6devmapcheckbox = srdtbC5B6.ReadLine();
                lineC5B6devmapstate = srdtbC5B6.ReadLine();
                lineC5B6cfgargument = srdtbC5B6.ReadLine();
                lineC5B6cfgstate = srdtbC5B6.ReadLine();
                lineC5B6mapname = srdtbC5B6.ReadLine();
                lineC5B6mapnamefixed = srdtbC5B6.ReadLine();
            }
        }

        private void C5B6info_Click(object sender, EventArgs e)
        {
            c5start6info show = new c5start6info();
            show.ShowDialog();
        }
    }
}
