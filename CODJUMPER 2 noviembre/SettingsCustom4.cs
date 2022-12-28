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
    public partial class SettingsCustom4 : Form
    {
        // strings C4B1
        public string C4B1devmapcheckbox;
        public string C4B1devmapstate;
        public string C4B1cfgname;
        public string C4B1cfgargument;
        public string C4B1cfgstate;
        public string databaseC4B1path;
        public static string lineC4B1devmapcheckbox;
        public static string lineC4B1devmapstate;
        public static string lineC4B1cfgargument;
        public static string lineC4B1cfgstate;
        public static string C4B1mapname;
        public static string C4B1mapnamefixed;
        public static string lineC4B1mapname;
        public static string lineC4B1mapnamefixed;

        // strings C4B2
        public string C4B2devmapcheckbox;
        public string C4B2devmapstate;
        public string C4B2cfgname;
        public string C4B2cfgargument;
        public string C4B2cfgstate;
        public string databaseC4B2path;
        public static string lineC4B2devmapcheckbox;
        public static string lineC4B2devmapstate;
        public static string lineC4B2cfgargument;
        public static string lineC4B2cfgstate;
        public static string C4B2mapname;
        public static string C4B2mapnamefixed;
        public static string lineC4B2mapname;
        public static string lineC4B2mapnamefixed;

        // strings C4B3
        public string C4B3devmapcheckbox;
        public string C4B3devmapstate;
        public string C4B3cfgname;
        public string C4B3cfgargument;
        public string C4B3cfgstate;
        public string databaseC4B3path;
        public static string lineC4B3devmapcheckbox;
        public static string lineC4B3devmapstate;
        public static string lineC4B3cfgargument;
        public static string lineC4B3cfgstate;
        public static string C4B3mapname;
        public static string C4B3mapnamefixed;
        public static string lineC4B3mapname;
        public static string lineC4B3mapnamefixed;

        // strings C4B4
        public string C4B4devmapcheckbox;
        public string C4B4devmapstate;
        public string C4B4cfgname;
        public string C4B4cfgargument;
        public string C4B4cfgstate;
        public string databaseC4B4path;
        public static string lineC4B4devmapcheckbox;
        public static string lineC4B4devmapstate;
        public static string lineC4B4cfgargument;
        public static string lineC4B4cfgstate;
        public static string C4B4mapname;
        public static string C4B4mapnamefixed;
        public static string lineC4B4mapname;
        public static string lineC4B4mapnamefixed;

        // strings C4B5
        public string C4B5devmapcheckbox;
        public string C4B5devmapstate;
        public string C4B5cfgname;
        public string C4B5cfgargument;
        public string C4B5cfgstate;
        public string databaseC4B5path;
        public static string lineC4B5devmapcheckbox;
        public static string lineC4B5devmapstate;
        public static string lineC4B5cfgargument;
        public static string lineC4B5cfgstate;
        public static string C4B5mapname;
        public static string C4B5mapnamefixed;
        public static string lineC4B5mapname;
        public static string lineC4B5mapnamefixed;

        // strings C4B6
        public string C4B6devmapcheckbox;
        public string C4B6devmapstate;
        public string C4B6cfgname;
        public string C4B6cfgargument;
        public string C4B6cfgstate;
        public string databaseC4B6path;
        public static string lineC4B6devmapcheckbox;
        public static string lineC4B6devmapstate;
        public static string lineC4B6cfgargument;
        public static string lineC4B6cfgstate;
        public static string C4B6mapname;
        public static string C4B6mapnamefixed;
        public static string lineC4B6mapname;
        public static string lineC4B6mapnamefixed;
        public SettingsCustom4()
        {
            InitializeComponent();

            C4B1devmapcheckbox = "+map ";
            C4B1devmapstate = "disabled";
            C4B2devmapcheckbox = "+map ";
            C4B2devmapstate = "disabled";
            C4B3devmapcheckbox = "+map ";
            C4B3devmapstate = "disabled";
            C4B4devmapcheckbox = "+map ";
            C4B4devmapstate = "disabled";
            C4B5devmapcheckbox = "+map ";
            C4B5devmapstate = "disabled";
            C4B6devmapcheckbox = "+map ";
            C4B6devmapstate = "disabled";
        }

        // C4B1
        private void C4B1devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C4B1devmap.Checked == true)
            {
                C4B1devmapcheckbox = "+devmap ";
                C4B1devmapstate = "enabled";
            }
            if (C4B1devmap.Checked == false)
            {
                C4B1devmapcheckbox = "+map ";
                C4B1devmapstate = "disabled";
            }
        }

        private void C4B1save_Click(object sender, EventArgs e)
        {
            C4B1cfgname = C4B1cfg.Text.ToString();

            if (C4B1cfgname != "")
            {
                C4B1cfgargument = "+exec " + C4B1cfgname + ".cfg ";
                C4B1cfgstate = C4B1cfgname;
            }
            else
            {
                C4B1cfgargument = "";
                C4B1cfgstate = "";
            }

            C4B1mapname = C4B1map.Text.ToString();

            if (C4B1mapname.Contains("mp_"))
            {
                string C4B1mapnameaux = C4B1mapname;
                C4B1mapnamefixed = C4B1mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC4B1 = new StreamWriter("./database/dtbcustoms4/C4B1.txt"))
            {
                swdtbC4B1.WriteLine(C4B1devmapcheckbox);
                swdtbC4B1.WriteLine(C4B1devmapstate);
                swdtbC4B1.WriteLine(C4B1cfgargument);
                swdtbC4B1.WriteLine(C4B1cfgstate);
                swdtbC4B1.WriteLine(C4B1mapname);
                swdtbC4B1.WriteLine(C4B1mapnamefixed);
                swdtbC4B1.Close();
            }
            databaseC4B1path = ("./database/dtbcustoms4/C4B1.txt");

            using (var srdtbC4B1 = new StreamReader(databaseC4B1path))
            {
                lineC4B1devmapcheckbox = srdtbC4B1.ReadLine();
                lineC4B1devmapstate = srdtbC4B1.ReadLine();
                lineC4B1cfgargument = srdtbC4B1.ReadLine();
                lineC4B1cfgstate = srdtbC4B1.ReadLine();
                lineC4B1mapname = srdtbC4B1.ReadLine();
                lineC4B1mapnamefixed = srdtbC4B1.ReadLine();
            }
        }

        private void C4B1info_Click(object sender, EventArgs e)
        {
            c4start1info show = new c4start1info();
            show.ShowDialog();
        }

        // C4B2
        private void C4B2devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C4B2devmap.Checked == true)
            {
                C4B2devmapcheckbox = "+devmap ";
                C4B2devmapstate = "enabled";
            }
            if (C4B2devmap.Checked == false)
            {
                C4B2devmapcheckbox = "+map ";
                C4B2devmapstate = "disabled";
            }
        }

        private void C4B2save_Click(object sender, EventArgs e)
        {
            C4B2cfgname = C4B2cfg.Text.ToString();

            if (C4B2cfgname != "")
            {
                C4B2cfgargument = "+exec " + C4B2cfgname + ".cfg ";
                C4B2cfgstate = C4B2cfgname;
            }
            else
            {
                C4B2cfgargument = "";
                C4B2cfgstate = "";
            }

            C4B2mapname = C4B2map.Text.ToString();

            if (C4B2mapname.Contains("mp_"))
            {
                string C4B2mapnameaux = C4B2mapname;
                C4B2mapnamefixed = C4B2mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC4B2 = new StreamWriter("./database/dtbcustoms4/C4B2.txt"))
            {
                swdtbC4B2.WriteLine(C4B2devmapcheckbox);
                swdtbC4B2.WriteLine(C4B2devmapstate);
                swdtbC4B2.WriteLine(C4B2cfgargument);
                swdtbC4B2.WriteLine(C4B2cfgstate);
                swdtbC4B2.WriteLine(C4B2mapname);
                swdtbC4B2.WriteLine(C4B2mapnamefixed);
                swdtbC4B2.Close();
            }
            databaseC4B2path = ("./database/dtbcustoms4/C4B2.txt");

            using (var srdtbC4B2 = new StreamReader(databaseC4B2path))
            {
                lineC4B2devmapcheckbox = srdtbC4B2.ReadLine();
                lineC4B2devmapstate = srdtbC4B2.ReadLine();
                lineC4B2cfgargument = srdtbC4B2.ReadLine();
                lineC4B2cfgstate = srdtbC4B2.ReadLine();
                lineC4B2mapname = srdtbC4B2.ReadLine();
                lineC4B2mapnamefixed = srdtbC4B2.ReadLine();
            }
        }

        private void C4B2info_Click(object sender, EventArgs e)
        {
            c4start2info show = new c4start2info();
            show.ShowDialog();
        }

        // C4B3
        private void C4B3devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C4B3devmap.Checked == true)
            {
                C4B3devmapcheckbox = "+devmap ";
                C4B3devmapstate = "enabled";
            }
            if (C4B3devmap.Checked == false)
            {
                C4B3devmapcheckbox = "+map ";
                C4B3devmapstate = "disabled";
            }
        }

        private void C4B3save_Click(object sender, EventArgs e)
        {
            C4B3cfgname = C4B3cfg.Text.ToString();

            if (C4B3cfgname != "")
            {
                C4B3cfgargument = "+exec " + C4B3cfgname + ".cfg ";
                C4B3cfgstate = C4B3cfgname;
            }
            else
            {
                C4B3cfgargument = "";
                C4B3cfgstate = "";
            }

            C4B3mapname = C4B3map.Text.ToString();

            if (C4B3mapname.Contains("mp_"))
            {
                string C4B3mapnameaux = C4B3mapname;
                C4B3mapnamefixed = C4B3mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC4B3 = new StreamWriter("./database/dtbcustoms4/C4B3.txt"))
            {
                swdtbC4B3.WriteLine(C4B3devmapcheckbox);
                swdtbC4B3.WriteLine(C4B3devmapstate);
                swdtbC4B3.WriteLine(C4B3cfgargument);
                swdtbC4B3.WriteLine(C4B3cfgstate);
                swdtbC4B3.WriteLine(C4B3mapname);
                swdtbC4B3.WriteLine(C4B3mapnamefixed);
                swdtbC4B3.Close();
            }
            databaseC4B3path = ("./database/dtbcustoms4/C4B3.txt");

            using (var srdtbC4B3 = new StreamReader(databaseC4B3path))
            {
                lineC4B3devmapcheckbox = srdtbC4B3.ReadLine();
                lineC4B3devmapstate = srdtbC4B3.ReadLine();
                lineC4B3cfgargument = srdtbC4B3.ReadLine();
                lineC4B3cfgstate = srdtbC4B3.ReadLine();
                lineC4B3mapname = srdtbC4B3.ReadLine();
                lineC4B3mapnamefixed = srdtbC4B3.ReadLine();
            }
        }

        private void C4B3info_Click(object sender, EventArgs e)
        {
            c4start3info show = new c4start3info();
            show.ShowDialog();
        }

        // C4B4
        private void C4B4devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C4B4devmap.Checked == true)
            {
                C4B4devmapcheckbox = "+devmap ";
                C4B4devmapstate = "enabled";
            }
            if (C4B4devmap.Checked == false)
            {
                C4B4devmapcheckbox = "+map ";
                C4B4devmapstate = "disabled";
            }
        }

        private void C4B4save_Click(object sender, EventArgs e)
        {
            C4B4cfgname = C4B4cfg.Text.ToString();

            if (C4B4cfgname != "")
            {
                C4B4cfgargument = "+exec " + C4B4cfgname + ".cfg ";
                C4B4cfgstate = C4B4cfgname;
            }
            else
            {
                C4B4cfgargument = "";
                C4B4cfgstate = "";
            }

            C4B4mapname = C4B4map.Text.ToString();

            if (C4B4mapname.Contains("mp_"))
            {
                string C4B4mapnameaux = C4B4mapname;
                C4B4mapnamefixed = C4B4mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC4B4 = new StreamWriter("./database/dtbcustoms4/C4B4.txt"))
            {
                swdtbC4B4.WriteLine(C4B4devmapcheckbox);
                swdtbC4B4.WriteLine(C4B4devmapstate);
                swdtbC4B4.WriteLine(C4B4cfgargument);
                swdtbC4B4.WriteLine(C4B4cfgstate);
                swdtbC4B4.WriteLine(C4B4mapname);
                swdtbC4B4.WriteLine(C4B4mapnamefixed);
                swdtbC4B4.Close();
            }
            databaseC4B4path = ("./database/dtbcustoms4/C4B4.txt");

            using (var srdtbC4B4 = new StreamReader(databaseC4B4path))
            {
                lineC4B4devmapcheckbox = srdtbC4B4.ReadLine();
                lineC4B4devmapstate = srdtbC4B4.ReadLine();
                lineC4B4cfgargument = srdtbC4B4.ReadLine();
                lineC4B4cfgstate = srdtbC4B4.ReadLine();
                lineC4B4mapname = srdtbC4B4.ReadLine();
                lineC4B4mapnamefixed = srdtbC4B4.ReadLine();
            }
        }

        private void C4B4info_Click(object sender, EventArgs e)
        {
            c4start4info show = new c4start4info();
            show.ShowDialog();
        }

        // C4B5
        private void C4B5devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C4B5devmap.Checked == true)
            {
                C4B5devmapcheckbox = "+devmap ";
                C4B5devmapstate = "enabled";
            }
            if (C4B5devmap.Checked == false)
            {
                C4B5devmapcheckbox = "+map ";
                C4B5devmapstate = "disabled";
            }
        }

        private void C4B5save_Click(object sender, EventArgs e)
        {
            C4B5cfgname = C4B5cfg.Text.ToString();

            if (C4B5cfgname != "")
            {
                C4B5cfgargument = "+exec " + C4B5cfgname + ".cfg ";
                C4B5cfgstate = C4B5cfgname;
            }
            else
            {
                C4B5cfgargument = "";
                C4B5cfgstate = "";
            }

            C4B5mapname = C4B5map.Text.ToString();

            if (C4B5mapname.Contains("mp_"))
            {
                string C4B5mapnameaux = C4B5mapname;
                C4B5mapnamefixed = C4B5mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC4B5 = new StreamWriter("./database/dtbcustoms4/C4B5.txt"))
            {
                swdtbC4B5.WriteLine(C4B5devmapcheckbox);
                swdtbC4B5.WriteLine(C4B5devmapstate);
                swdtbC4B5.WriteLine(C4B5cfgargument);
                swdtbC4B5.WriteLine(C4B5cfgstate);
                swdtbC4B5.WriteLine(C4B5mapname);
                swdtbC4B5.WriteLine(C4B5mapnamefixed);
                swdtbC4B5.Close();
            }
            databaseC4B5path = ("./database/dtbcustoms4/C4B5.txt");

            using (var srdtbC4B5 = new StreamReader(databaseC4B5path))
            {
                lineC4B5devmapcheckbox = srdtbC4B5.ReadLine();
                lineC4B5devmapstate = srdtbC4B5.ReadLine();
                lineC4B5cfgargument = srdtbC4B5.ReadLine();
                lineC4B5cfgstate = srdtbC4B5.ReadLine();
                lineC4B5mapname = srdtbC4B5.ReadLine();
                lineC4B5mapnamefixed = srdtbC4B5.ReadLine();
            }
        }

        private void C4B5info_Click(object sender, EventArgs e)
        {
            c4start5info show = new c4start5info();
            show.ShowDialog();
        }

        // C4B6
        private void C4B6devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C4B6devmap.Checked == true)
            {
                C4B6devmapcheckbox = "+devmap ";
                C4B6devmapstate = "enabled";
            }
            if (C4B6devmap.Checked == false)
            {
                C4B6devmapcheckbox = "+map ";
                C4B6devmapstate = "disabled";
            }
        }

        private void C4B6save_Click(object sender, EventArgs e)
        {
            C4B6cfgname = C4B6cfg.Text.ToString();

            if (C4B6cfgname != "")
            {
                C4B6cfgargument = "+exec " + C4B6cfgname + ".cfg ";
                C4B6cfgstate = C4B6cfgname;
            }
            else
            {
                C4B6cfgargument = "";
                C4B6cfgstate = "";
            }

            C4B6mapname = C4B6map.Text.ToString();

            if (C4B6mapname.Contains("mp_"))
            {
                string C4B6mapnameaux = C4B6mapname;
                C4B6mapnamefixed = C4B6mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC4B6 = new StreamWriter("./database/dtbcustoms4/C4B6.txt"))
            {
                swdtbC4B6.WriteLine(C4B6devmapcheckbox);
                swdtbC4B6.WriteLine(C4B6devmapstate);
                swdtbC4B6.WriteLine(C4B6cfgargument);
                swdtbC4B6.WriteLine(C4B6cfgstate);
                swdtbC4B6.WriteLine(C4B6mapname);
                swdtbC4B6.WriteLine(C4B6mapnamefixed);
                swdtbC4B6.Close();
            }
            databaseC4B6path = ("./database/dtbcustoms4/C4B6.txt");

            using (var srdtbC4B6 = new StreamReader(databaseC4B6path))
            {
                lineC4B6devmapcheckbox = srdtbC4B6.ReadLine();
                lineC4B6devmapstate = srdtbC4B6.ReadLine();
                lineC4B6cfgargument = srdtbC4B6.ReadLine();
                lineC4B6cfgstate = srdtbC4B6.ReadLine();
                lineC4B6mapname = srdtbC4B6.ReadLine();
                lineC4B6mapnamefixed = srdtbC4B6.ReadLine();
            }
        }

        private void C4B6info_Click(object sender, EventArgs e)
        {
            c4start6info show = new c4start6info();
            show.ShowDialog();
        }
    }
}
