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
    public partial class SettingsCustoms2 : Form
    {
        // strings C2B1
        public string C2B1devmapcheckbox;
        public string C2B1devmapstate;
        public string C2B1cfgname;
        public string C2B1cfgargument;
        public string C2B1cfgstate;
        public string databaseC2B1path;
        public static string lineC2B1devmapcheckbox;
        public static string lineC2B1devmapstate;
        public static string lineC2B1cfgargument;
        public static string lineC2B1cfgstate;
        public static string C2B1mapname;
        public static string C2B1mapnamefixed;
        public static string lineC2B1mapname;
        public static string lineC2B1mapnamefixed;

        // strings C2B2
        public string C2B2devmapcheckbox;
        public string C2B2devmapstate;
        public string C2B2cfgname;
        public string C2B2cfgargument;
        public string C2B2cfgstate;
        public string databaseC2B2path;
        public static string lineC2B2devmapcheckbox;
        public static string lineC2B2devmapstate;
        public static string lineC2B2cfgargument;
        public static string lineC2B2cfgstate;
        public static string C2B2mapname;
        public static string C2B2mapnamefixed;
        public static string lineC2B2mapname;
        public static string lineC2B2mapnamefixed;

        // strings C2B3
        public string C2B3devmapcheckbox;
        public string C2B3devmapstate;
        public string C2B3cfgname;
        public string C2B3cfgargument;
        public string C2B3cfgstate;
        public string databaseC2B3path;
        public static string lineC2B3devmapcheckbox;
        public static string lineC2B3devmapstate;
        public static string lineC2B3cfgargument;
        public static string lineC2B3cfgstate;
        public static string C2B3mapname;
        public static string C2B3mapnamefixed;
        public static string lineC2B3mapname;
        public static string lineC2B3mapnamefixed;

        // strings C2B4
        public string C2B4devmapcheckbox;
        public string C2B4devmapstate;
        public string C2B4cfgname;
        public string C2B4cfgargument;
        public string C2B4cfgstate;
        public string databaseC2B4path;
        public static string lineC2B4devmapcheckbox;
        public static string lineC2B4devmapstate;
        public static string lineC2B4cfgargument;
        public static string lineC2B4cfgstate;
        public static string C2B4mapname;
        public static string C2B4mapnamefixed;
        public static string lineC2B4mapname;
        public static string lineC2B4mapnamefixed;

        // strings C2B5
        public string C2B5devmapcheckbox;
        public string C2B5devmapstate;
        public string C2B5cfgname;
        public string C2B5cfgargument;
        public string C2B5cfgstate;
        public string databaseC2B5path;
        public static string lineC2B5devmapcheckbox;
        public static string lineC2B5devmapstate;
        public static string lineC2B5cfgargument;
        public static string lineC2B5cfgstate;
        public static string C2B5mapname;
        public static string C2B5mapnamefixed;
        public static string lineC2B5mapname;
        public static string lineC2B5mapnamefixed;

        // strings C2B6
        public string C2B6devmapcheckbox;
        public string C2B6devmapstate;
        public string C2B6cfgname;
        public string C2B6cfgargument;
        public string C2B6cfgstate;
        public string databaseC2B6path;
        public static string lineC2B6devmapcheckbox;
        public static string lineC2B6devmapstate;
        public static string lineC2B6cfgargument;
        public static string lineC2B6cfgstate;
        public static string C2B6mapname;
        public static string C2B6mapnamefixed;
        public static string lineC2B6mapname;
        public static string lineC2B6mapnamefixed;
        public SettingsCustoms2()
        {
            InitializeComponent();

            C2B1devmapcheckbox = "+map ";
            C2B1devmapstate = "disabled";
            C2B2devmapcheckbox = "+map ";
            C2B2devmapstate = "disabled";
            C2B3devmapcheckbox = "+map ";
            C2B3devmapstate = "disabled";
            C2B4devmapcheckbox = "+map ";
            C2B4devmapstate = "disabled";
            C2B5devmapcheckbox = "+map ";
            C2B5devmapstate = "disabled";
            C2B6devmapcheckbox = "+map ";
            C2B6devmapstate = "disabled";
        }

        // C2B1
        private void C2B1devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C2B1devmap.Checked == true)
            {
                C2B1devmapcheckbox = "+devmap ";
                C2B1devmapstate = "enabled";
            }
            if (C2B1devmap.Checked == false)
            {
                C2B1devmapcheckbox = "+map ";
                C2B1devmapstate = "disabled";
            }
        }

        private void C2B1save_Click(object sender, EventArgs e)
        {
            C2B1cfgname = C2B1cfg.Text.ToString();

            if (C2B1cfgname != "")
            {
                C2B1cfgargument = "+exec " + C2B1cfgname + ".cfg ";
                C2B1cfgstate = C2B1cfgname;
            }
            else
            {
                C2B1cfgargument = "";
                C2B1cfgstate = "";
            }

            C2B1mapname = C2B1map.Text.ToString();

            if (C2B1mapname.Contains("mp_"))
            {
                string C2B1mapnameaux = C2B1mapname;
                C2B1mapnamefixed = C2B1mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC2B1 = new StreamWriter("./database/dtbcustoms2/C2B1.txt"))
            {
                swdtbC2B1.WriteLine(C2B1devmapcheckbox);
                swdtbC2B1.WriteLine(C2B1devmapstate);
                swdtbC2B1.WriteLine(C2B1cfgargument);
                swdtbC2B1.WriteLine(C2B1cfgstate);
                swdtbC2B1.WriteLine(C2B1mapname);
                swdtbC2B1.WriteLine(C2B1mapnamefixed);
                swdtbC2B1.Close();
            }
            databaseC2B1path = ("./database/dtbcustoms2/C2B1.txt");

            using (var srdtbC2B1 = new StreamReader(databaseC2B1path))
            {
                lineC2B1devmapcheckbox = srdtbC2B1.ReadLine();
                lineC2B1devmapstate = srdtbC2B1.ReadLine();
                lineC2B1cfgargument = srdtbC2B1.ReadLine();
                lineC2B1cfgstate = srdtbC2B1.ReadLine();
                lineC2B1mapname = srdtbC2B1.ReadLine();
                lineC2B1mapnamefixed = srdtbC2B1.ReadLine();
            }
        }

        private void C2B1info_Click(object sender, EventArgs e)
        {
            c2start1info show = new c2start1info();
            show.ShowDialog();
        }

        //C2B2
        private void C2B2devmap_CheckedChanged(object sender, EventArgs e)
        {

            if (C2B2devmap.Checked == true)
            {
                C2B2devmapcheckbox = "+devmap ";
                C2B2devmapstate = "enabled";
            }
            if (C2B2devmap.Checked == false)
            {
                C2B2devmapcheckbox = "+map ";
                C2B2devmapstate = "disabled";
            }
        }

        private void C2B2save_Click(object sender, EventArgs e)
        {
            C2B2cfgname = C2B2cfg.Text.ToString();

            if (C2B2cfgname != "")
            {
                C2B2cfgargument = "+exec " + C2B2cfgname + ".cfg ";
                C2B2cfgstate = C2B2cfgname;
            }
            else
            {
                C2B2cfgargument = "";
                C2B2cfgstate = "";
            }

            C2B2mapname = C2B2map.Text.ToString();

            if (C2B2mapname.Contains("mp_"))
            {
                string C2B2mapnameaux = C2B2mapname;
                C2B2mapnamefixed = C2B2mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC2B2 = new StreamWriter("./database/dtbcustoms2/C2B2.txt"))
            {
                swdtbC2B2.WriteLine(C2B2devmapcheckbox);
                swdtbC2B2.WriteLine(C2B2devmapstate);
                swdtbC2B2.WriteLine(C2B2cfgargument);
                swdtbC2B2.WriteLine(C2B2cfgstate);
                swdtbC2B2.WriteLine(C2B2mapname);
                swdtbC2B2.WriteLine(C2B2mapnamefixed);
                swdtbC2B2.Close();
            }
            databaseC2B2path = ("./database/dtbcustoms2/C2B2.txt");

            using (var srdtbC2B2 = new StreamReader(databaseC2B2path))
            {
                lineC2B2devmapcheckbox = srdtbC2B2.ReadLine();
                lineC2B2devmapstate = srdtbC2B2.ReadLine();
                lineC2B2cfgargument = srdtbC2B2.ReadLine();
                lineC2B2cfgstate = srdtbC2B2.ReadLine();
                lineC2B2mapname = srdtbC2B2.ReadLine();
                lineC2B2mapnamefixed = srdtbC2B2.ReadLine();
            }
        }

        private void C2B2info_Click(object sender, EventArgs e)
        {
            c2start2info show = new c2start2info();
            show.ShowDialog();
        }

        // C2B3
        private void C2B3devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C2B3devmap.Checked == true)
            {
                C2B3devmapcheckbox = "+devmap ";
                C2B3devmapstate = "enabled";
            }
            if (C2B3devmap.Checked == false)
            {
                C2B3devmapcheckbox = "+map ";
                C2B3devmapstate = "disabled";
            }
        }

        private void C2B3save_Click(object sender, EventArgs e)
        {
            C2B3cfgname = C2B3cfg.Text.ToString();

            if (C2B3cfgname != "")
            {
                C2B3cfgargument = "+exec " + C2B3cfgname + ".cfg ";
                C2B3cfgstate = C2B3cfgname;
            }
            else
            {
                C2B3cfgargument = "";
                C2B3cfgstate = "";
            }

            C2B3mapname = C2B3map.Text.ToString();

            if (C2B3mapname.Contains("mp_"))
            {
                string C2B3mapnameaux = C2B3mapname;
                C2B3mapnamefixed = C2B3mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC2B3 = new StreamWriter("./database/dtbcustoms2/C2B3.txt"))
            {
                swdtbC2B3.WriteLine(C2B3devmapcheckbox);
                swdtbC2B3.WriteLine(C2B3devmapstate);
                swdtbC2B3.WriteLine(C2B3cfgargument);
                swdtbC2B3.WriteLine(C2B3cfgstate);
                swdtbC2B3.WriteLine(C2B3mapname);
                swdtbC2B3.WriteLine(C2B3mapnamefixed);
                swdtbC2B3.Close();
            }
            databaseC2B3path = ("./database/dtbcustoms2/C2B3.txt");

            using (var srdtbC2B3 = new StreamReader(databaseC2B3path))
            {
                lineC2B3devmapcheckbox = srdtbC2B3.ReadLine();
                lineC2B3devmapstate = srdtbC2B3.ReadLine();
                lineC2B3cfgargument = srdtbC2B3.ReadLine();
                lineC2B3cfgstate = srdtbC2B3.ReadLine();
                lineC2B3mapname = srdtbC2B3.ReadLine();
                lineC2B3mapnamefixed = srdtbC2B3.ReadLine();
            }
        }

        private void C2B3info_Click(object sender, EventArgs e)
        {
            c2start3info show = new c2start3info();
            show.ShowDialog();
        }

        // C2B4
        private void C2B4devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C2B4devmap.Checked == true)
            {
                C2B4devmapcheckbox = "+devmap ";
                C2B4devmapstate = "enabled";
            }
            if (C2B4devmap.Checked == false)
            {
                C2B4devmapcheckbox = "+map ";
                C2B4devmapstate = "disabled";
            }
        }

        private void C2B4save_Click(object sender, EventArgs e)
        {
            C2B4cfgname = C2B4cfg.Text.ToString();

            if (C2B4cfgname != "")
            {
                C2B4cfgargument = "+exec " + C2B4cfgname + ".cfg ";
                C2B4cfgstate = C2B4cfgname;
            }
            else
            {
                C2B4cfgargument = "";
                C2B4cfgstate = "";
            }

            C2B4mapname = C2B4map.Text.ToString();

            if (C2B4mapname.Contains("mp_"))
            {
                string C2B4mapnameaux = C2B4mapname;
                C2B4mapnamefixed = C2B4mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC2B4 = new StreamWriter("./database/dtbcustoms2/C2B4.txt"))
            {
                swdtbC2B4.WriteLine(C2B4devmapcheckbox);
                swdtbC2B4.WriteLine(C2B4devmapstate);
                swdtbC2B4.WriteLine(C2B4cfgargument);
                swdtbC2B4.WriteLine(C2B4cfgstate);
                swdtbC2B4.WriteLine(C2B4mapname);
                swdtbC2B4.WriteLine(C2B4mapnamefixed);
                swdtbC2B4.Close();
            }
            databaseC2B4path = ("./database/dtbcustoms2/C2B4.txt");

            using (var srdtbC2B4 = new StreamReader(databaseC2B4path))
            {
                lineC2B4devmapcheckbox = srdtbC2B4.ReadLine();
                lineC2B4devmapstate = srdtbC2B4.ReadLine();
                lineC2B4cfgargument = srdtbC2B4.ReadLine();
                lineC2B4cfgstate = srdtbC2B4.ReadLine();
                lineC2B4mapname = srdtbC2B4.ReadLine();
                lineC2B4mapnamefixed = srdtbC2B4.ReadLine();
            }
        }

        private void C2B4info_Click(object sender, EventArgs e)
        {
            c2start4info show = new c2start4info();
            show.ShowDialog();
        }

        // C2B5
        private void C2B5devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C2B5devmap.Checked == true)
            {
                C2B5devmapcheckbox = "+devmap ";
                C2B5devmapstate = "enabled";
            }
            if (C2B5devmap.Checked == false)
            {
                C2B5devmapcheckbox = "+map ";
                C2B5devmapstate = "disabled";
            }
        }

        private void C2B5save_Click(object sender, EventArgs e)
        {
            C2B5cfgname = C2B5cfg.Text.ToString();

            if (C2B5cfgname != "")
            {
                C2B5cfgargument = "+exec " + C2B5cfgname + ".cfg ";
                C2B5cfgstate = C2B5cfgname;
            }
            else
            {
                C2B5cfgargument = "";
                C2B5cfgstate = "";
            }

            C2B5mapname = C2B5map.Text.ToString();

            if (C2B5mapname.Contains("mp_"))
            {
                string C2B5mapnameaux = C2B5mapname;
                C2B5mapnamefixed = C2B5mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC2B5 = new StreamWriter("./database/dtbcustoms2/C2B5.txt"))
            {
                swdtbC2B5.WriteLine(C2B5devmapcheckbox);
                swdtbC2B5.WriteLine(C2B5devmapstate);
                swdtbC2B5.WriteLine(C2B5cfgargument);
                swdtbC2B5.WriteLine(C2B5cfgstate);
                swdtbC2B5.WriteLine(C2B5mapname);
                swdtbC2B5.WriteLine(C2B5mapnamefixed);
                swdtbC2B5.Close();
            }
            databaseC2B5path = ("./database/dtbcustoms2/C2B5.txt");

            using (var srdtbC2B5 = new StreamReader(databaseC2B5path))
            {
                lineC2B5devmapcheckbox = srdtbC2B5.ReadLine();
                lineC2B5devmapstate = srdtbC2B5.ReadLine();
                lineC2B5cfgargument = srdtbC2B5.ReadLine();
                lineC2B5cfgstate = srdtbC2B5.ReadLine();
                lineC2B5mapname = srdtbC2B5.ReadLine();
                lineC2B5mapnamefixed = srdtbC2B5.ReadLine();
            }
        }

        private void C2B5info_Click(object sender, EventArgs e)
        {
            c2start5info show = new c2start5info();
            show.ShowDialog();
        }

        // C2BB6
        private void C2B6devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C2B6devmap.Checked == true)
            {
                C2B6devmapcheckbox = "+devmap ";
                C2B6devmapstate = "enabled";
            }
            if (C2B6devmap.Checked == false)
            {
                C2B6devmapcheckbox = "+map ";
                C2B6devmapstate = "disabled";
            }
        }

        private void C2B6save_Click(object sender, EventArgs e)
        {
            C2B6cfgname = C2B6cfg.Text.ToString();

            if (C2B6cfgname != "")
            {
                C2B6cfgargument = "+exec " + C2B6cfgname + ".cfg ";
                C2B6cfgstate = C2B6cfgname;
            }
            else
            {
                C2B6cfgargument = "";
                C2B6cfgstate = "";
            }

            C2B6mapname = C2B6map.Text.ToString();

            if (C2B6mapname.Contains("mp_"))
            {
                string C2B6mapnameaux = C2B6mapname;
                C2B6mapnamefixed = C2B6mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC2B6 = new StreamWriter("./database/dtbcustoms2/C2B6.txt"))
            {
                swdtbC2B6.WriteLine(C2B6devmapcheckbox);
                swdtbC2B6.WriteLine(C2B6devmapstate);
                swdtbC2B6.WriteLine(C2B6cfgargument);
                swdtbC2B6.WriteLine(C2B6cfgstate);
                swdtbC2B6.WriteLine(C2B6mapname);
                swdtbC2B6.WriteLine(C2B6mapnamefixed);
                swdtbC2B6.Close();
            }
            databaseC2B6path = ("./database/dtbcustoms2/C2B6.txt");

            using (var srdtbC2B6 = new StreamReader(databaseC2B6path))
            {
                lineC2B6devmapcheckbox = srdtbC2B6.ReadLine();
                lineC2B6devmapstate = srdtbC2B6.ReadLine();
                lineC2B6cfgargument = srdtbC2B6.ReadLine();
                lineC2B6cfgstate = srdtbC2B6.ReadLine();
                lineC2B6mapname = srdtbC2B6.ReadLine();
                lineC2B6mapnamefixed = srdtbC2B6.ReadLine();
            }
        }

        private void C2B6info_Click(object sender, EventArgs e)
        {
            c2start6info show = new c2start6info();
            show.ShowDialog();
        }
    }
}
