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

namespace CODJUMPER_2_noviembre
{
    public partial class SettingsCustoms1 : Form
    {
        // strings C1B1
        public string C1B1devmapcheckbox;
        public string C1B1devmapstate;
        public string C1B1cfgname;
        public string C1B1cfgargument;
        public string C1B1cfgstate;
        public string databaseC1B1path;
        public static string lineC1B1devmapcheckbox;
        public static string lineC1B1devmapstate;
        public static string lineC1B1cfgargument;
        public static string lineC1B1cfgstate;
        public static string C1B1mapname;
        public static string C1B1mapnamefixed;
        public static string lineC1B1mapname;
        public static string lineC1B1mapnamefixed;

        // strings C1B2
        public string C1B2devmapcheckbox;
        public string C1B2devmapstate;
        public string C1B2cfgname;
        public string C1B2cfgargument;
        public string C1B2cfgstate;
        public string databaseC1B2path;
        public static string lineC1B2devmapcheckbox;
        public static string lineC1B2devmapstate;
        public static string lineC1B2cfgargument;
        public static string lineC1B2cfgstate;
        public static string C1B2mapname;
        public static string C1B2mapnamefixed;
        public static string lineC1B2mapname;
        public static string lineC1B2mapnamefixed;

        // strings C1B3
        public string C1B3devmapcheckbox;
        public string C1B3devmapstate;
        public string C1B3cfgname;
        public string C1B3cfgargument;
        public string C1B3cfgstate;
        public string databaseC1B3path;
        public static string lineC1B3devmapcheckbox;
        public static string lineC1B3devmapstate;
        public static string lineC1B3cfgargument;
        public static string lineC1B3cfgstate;
        public static string C1B3mapname;
        public static string C1B3mapnamefixed;
        public static string lineC1B3mapname;
        public static string lineC1B3mapnamefixed;

        // strings C1B4
        public string C1B4devmapcheckbox;
        public string C1B4devmapstate;
        public string C1B4cfgname;
        public string C1B4cfgargument;
        public string C1B4cfgstate;
        public string databaseC1B4path;
        public static string lineC1B4devmapcheckbox;
        public static string lineC1B4devmapstate;
        public static string lineC1B4cfgargument;
        public static string lineC1B4cfgstate;
        public static string C1B4mapname;
        public static string C1B4mapnamefixed;
        public static string lineC1B4mapname;
        public static string lineC1B4mapnamefixed;

        // strings C1B5
        public string C1B5devmapcheckbox;
        public string C1B5devmapstate;
        public string C1B5cfgname;
        public string C1B5cfgargument;
        public string C1B5cfgstate;
        public string databaseC1B5path;
        public static string lineC1B5devmapcheckbox;
        public static string lineC1B5devmapstate;
        public static string lineC1B5cfgargument;
        public static string lineC1B5cfgstate;
        public static string C1B5mapname;
        public static string C1B5mapnamefixed;
        public static string lineC1B5mapname;
        public static string lineC1B5mapnamefixed;

        // strings C1B6
        public string C1B6devmapcheckbox;
        public string C1B6devmapstate;
        public string C1B6cfgname;
        public string C1B6cfgargument;
        public string C1B6cfgstate;
        public string databaseC1B6path;
        public static string lineC1B6devmapcheckbox;
        public static string lineC1B6devmapstate;
        public static string lineC1B6cfgargument;
        public static string lineC1B6cfgstate;
        public static string C1B6mapname;
        public static string C1B6mapnamefixed;
        public static string lineC1B6mapname;
        public static string lineC1B6mapnamefixed;
        public SettingsCustoms1()
        {
            InitializeComponent();

            C1B1devmapcheckbox = "+map ";
            C1B1devmapstate = "disabled";
            C1B2devmapcheckbox = "+map ";
            C1B2devmapstate = "disabled";
            C1B3devmapcheckbox = "+map ";
            C1B3devmapstate = "disabled";
            C1B4devmapcheckbox = "+map ";
            C1B4devmapstate = "disabled";
            C1B5devmapcheckbox = "+map ";
            C1B5devmapstate = "disabled";
            C1B6devmapcheckbox = "+map ";
            C1B6devmapstate = "disabled";
        }
        
        // C1B1
        private void C1B1devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C1B1devmap.Checked == true)
            {
                C1B1devmapcheckbox = "+devmap ";
                C1B1devmapstate = "enabled";
            }
            if (C1B1devmap.Checked == false)
            {
                C1B1devmapcheckbox = "+map ";
                C1B1devmapstate = "disabled";
            }
        }

        private void C1B1save_Click(object sender, EventArgs e)
        {
            C1B1cfgname = C1B1cfg.Text.ToString();

            if (C1B1cfgname != "")
            {
                C1B1cfgargument = "+exec " + C1B1cfgname + ".cfg ";
                C1B1cfgstate = C1B1cfgname;
            }
            else
            {
                C1B1cfgargument = "";
                C1B1cfgstate = "";
            }

            C1B1mapname = C1B1map.Text.ToString();
            
            if (C1B1mapname.Contains("mp_"))
            {
                string C1B1mapnameaux = C1B1mapname;
                C1B1mapnamefixed = C1B1mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC1B1 = new StreamWriter("./database/dtbcustoms1/C1B1.txt"))
            {
                swdtbC1B1.WriteLine(C1B1devmapcheckbox);
                swdtbC1B1.WriteLine(C1B1devmapstate);
                swdtbC1B1.WriteLine(C1B1cfgargument);
                swdtbC1B1.WriteLine(C1B1cfgstate);
                swdtbC1B1.WriteLine(C1B1mapname);
                swdtbC1B1.WriteLine(C1B1mapnamefixed);
                swdtbC1B1.Close();
            }
            databaseC1B1path = ("./database/dtbcustoms1/C1B1.txt");

            using (var srdtbC1B1 = new StreamReader(databaseC1B1path))
            {
                lineC1B1devmapcheckbox = srdtbC1B1.ReadLine();
                lineC1B1devmapstate = srdtbC1B1.ReadLine();
                lineC1B1cfgargument = srdtbC1B1.ReadLine();
                lineC1B1cfgstate = srdtbC1B1.ReadLine();
                lineC1B1mapname = srdtbC1B1.ReadLine();
                lineC1B1mapnamefixed = srdtbC1B1.ReadLine();
            }
        }

        private void C1B1info_Click(object sender, EventArgs e)
        {
            c1start1info show = new c1start1info();
            show.ShowDialog();
        }

        // C1B2
        private void C1B2devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C1B2devmap.Checked == true)
            {
                C1B2devmapcheckbox = "+devmap ";
                C1B2devmapstate = "enabled";
            }
            if (C1B2devmap.Checked == false)
            {
                C1B2devmapcheckbox = "+map ";
                C1B2devmapstate = "disabled";
            }
        }

        private void C1B2save_Click(object sender, EventArgs e)
        {
            C1B2cfgname = C1B2cfg.Text.ToString();

            if (C1B2cfgname != "")
            {
                C1B2cfgargument = "+exec " + C1B2cfgname + ".cfg ";
                C1B2cfgstate = C1B2cfgname;
            }
            else
            {
                C1B2cfgargument = "";
                C1B2cfgstate = "";
            }

            C1B2mapname = C1B2map.Text.ToString();

            if (C1B2mapname.Contains("mp_"))
            {
                string C1B2mapnameaux = C1B2mapname;
                C1B2mapnamefixed = C1B2mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC1B2 = new StreamWriter("./database/dtbcustoms1/C1B2.txt"))
            {
                swdtbC1B2.WriteLine(C1B2devmapcheckbox);
                swdtbC1B2.WriteLine(C1B2devmapstate);
                swdtbC1B2.WriteLine(C1B2cfgargument);
                swdtbC1B2.WriteLine(C1B2cfgstate);
                swdtbC1B2.WriteLine(C1B2mapname);
                swdtbC1B2.WriteLine(C1B2mapnamefixed);
                swdtbC1B2.Close();
            }
            databaseC1B2path = ("./database/dtbcustoms1/C1B2.txt");

            using (var srdtbC1B2 = new StreamReader(databaseC1B2path))
            {
                lineC1B2devmapcheckbox = srdtbC1B2.ReadLine();
                lineC1B2devmapstate = srdtbC1B2.ReadLine();
                lineC1B2cfgargument = srdtbC1B2.ReadLine();
                lineC1B2cfgstate = srdtbC1B2.ReadLine();
                lineC1B2mapname = srdtbC1B2.ReadLine();
                lineC1B2mapnamefixed = srdtbC1B2.ReadLine();
            }
        }

        private void C1B2info_Click(object sender, EventArgs e)
        {
            c1start2info show = new c1start2info();
            show.ShowDialog();
        }

        // C1B3
        private void C1B3devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C1B3devmap.Checked == true)
            {
                C1B3devmapcheckbox = "+devmap ";
                C1B3devmapstate = "enabled";
            }
            if (C1B3devmap.Checked == false)
            {
                C1B3devmapcheckbox = "+map ";
                C1B3devmapstate = "disabled";
            }
        }

        private void C1B3save_Click(object sender, EventArgs e)
        {
            C1B3cfgname = C1B3cfg.Text.ToString();

            if (C1B3cfgname != "")
            {
                C1B3cfgargument = "+exec " + C1B3cfgname + ".cfg ";
                C1B3cfgstate = C1B3cfgname;
            }
            else
            {
                C1B3cfgargument = "";
                C1B3cfgstate = "";
            }

            C1B3mapname = C1B3map.Text.ToString();

            if (C1B3mapname.Contains("mp_"))
            {
                string C1B3mapnameaux = C1B3mapname;
                C1B3mapnamefixed = C1B3mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC1B3 = new StreamWriter("./database/dtbcustoms1/C1B3.txt"))
            {
                swdtbC1B3.WriteLine(C1B3devmapcheckbox);
                swdtbC1B3.WriteLine(C1B3devmapstate);
                swdtbC1B3.WriteLine(C1B3cfgargument);
                swdtbC1B3.WriteLine(C1B3cfgstate);
                swdtbC1B3.WriteLine(C1B3mapname);
                swdtbC1B3.WriteLine(C1B3mapnamefixed);
                swdtbC1B3.Close();
            }
            databaseC1B3path = ("./database/dtbcustoms1/C1B3.txt");

            using (var srdtbC1B3 = new StreamReader(databaseC1B3path))
            {
                lineC1B3devmapcheckbox = srdtbC1B3.ReadLine();
                lineC1B3devmapstate = srdtbC1B3.ReadLine();
                lineC1B3cfgargument = srdtbC1B3.ReadLine();
                lineC1B3cfgstate = srdtbC1B3.ReadLine();
                lineC1B3mapname = srdtbC1B3.ReadLine();
                lineC1B3mapnamefixed = srdtbC1B3.ReadLine();
            }
        }

        private void C1B3info_Click(object sender, EventArgs e)
        {
            c1start3info show = new c1start3info();
            show.ShowDialog();
        }

        // C1B4
        private void C1B4devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C1B4devmap.Checked == true)
            {
                C1B4devmapcheckbox = "+devmap ";
                C1B4devmapstate = "enabled";
            }
            if (C1B4devmap.Checked == false)
            {
                C1B4devmapcheckbox = "+map ";
                C1B4devmapstate = "disabled";
            }
        }

        private void C1B4save_Click(object sender, EventArgs e)
        {
            C1B4cfgname = C1B4cfg.Text.ToString();

            if (C1B4cfgname != "")
            {
                C1B4cfgargument = "+exec " + C1B4cfgname + ".cfg ";
                C1B4cfgstate = C1B4cfgname;
            }
            else
            {
                C1B4cfgargument = "";
                C1B4cfgstate = "";
            }

            C1B4mapname = C1B4map.Text.ToString();

            if (C1B4mapname.Contains("mp_"))
            {
                string C1B4mapnameaux = C1B4mapname;
                C1B4mapnamefixed = C1B4mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC1B4 = new StreamWriter("./database/dtbcustoms1/C1B4.txt"))
            {
                swdtbC1B4.WriteLine(C1B4devmapcheckbox);
                swdtbC1B4.WriteLine(C1B4devmapstate);
                swdtbC1B4.WriteLine(C1B4cfgargument);
                swdtbC1B4.WriteLine(C1B4cfgstate);
                swdtbC1B4.WriteLine(C1B4mapname);
                swdtbC1B4.WriteLine(C1B4mapnamefixed);
                swdtbC1B4.Close();
            }
            databaseC1B4path = ("./database/dtbcustoms1/C1B4.txt");

            using (var srdtbC1B4 = new StreamReader(databaseC1B4path))
            {
                lineC1B4devmapcheckbox = srdtbC1B4.ReadLine();
                lineC1B4devmapstate = srdtbC1B4.ReadLine();
                lineC1B4cfgargument = srdtbC1B4.ReadLine();
                lineC1B4cfgstate = srdtbC1B4.ReadLine();
                lineC1B4mapname = srdtbC1B4.ReadLine();
                lineC1B4mapnamefixed = srdtbC1B4.ReadLine();
            }
        }

        private void C1B4info_Click(object sender, EventArgs e)
        {
            c1start4info show = new c1start4info();
            show.ShowDialog();
        }

        // C1B5
        private void C1B5devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C1B5devmap.Checked == true)
            {
                C1B5devmapcheckbox = "+devmap ";
                C1B5devmapstate = "enabled";
            }
            if (C1B5devmap.Checked == false)
            {
                C1B5devmapcheckbox = "+map ";
                C1B5devmapstate = "disabled";
            }
        }

        private void C1B5save_Click(object sender, EventArgs e)
        {
            C1B5cfgname = C1B5cfg.Text.ToString();

            if (C1B5cfgname != "")
            {
                C1B5cfgargument = "+exec " + C1B5cfgname + ".cfg ";
                C1B5cfgstate = C1B5cfgname;
            }
            else
            {
                C1B5cfgargument = "";
                C1B5cfgstate = "";
            }

            C1B5mapname = C1B5map.Text.ToString();

            if (C1B5mapname.Contains("mp_"))
            {
                string C1B5mapnameaux = C1B5mapname;
                C1B5mapnamefixed = C1B5mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC1B5 = new StreamWriter("./database/dtbcustoms1/C1B5.txt"))
            {
                swdtbC1B5.WriteLine(C1B5devmapcheckbox);
                swdtbC1B5.WriteLine(C1B5devmapstate);
                swdtbC1B5.WriteLine(C1B5cfgargument);
                swdtbC1B5.WriteLine(C1B5cfgstate);
                swdtbC1B5.WriteLine(C1B5mapname);
                swdtbC1B5.WriteLine(C1B5mapnamefixed);
                swdtbC1B5.Close();
            }
            databaseC1B5path = ("./database/dtbcustoms1/C1B5.txt");

            using (var srdtbC1B5 = new StreamReader(databaseC1B5path))
            {
                lineC1B5devmapcheckbox = srdtbC1B5.ReadLine();
                lineC1B5devmapstate = srdtbC1B5.ReadLine();
                lineC1B5cfgargument = srdtbC1B5.ReadLine();
                lineC1B5cfgstate = srdtbC1B5.ReadLine();
                lineC1B5mapname = srdtbC1B5.ReadLine();
                lineC1B5mapnamefixed = srdtbC1B5.ReadLine();
            }
        }

        private void C1B5info_Click(object sender, EventArgs e)
        {
            c1start5info show = new c1start5info();
            show.ShowDialog();
        }

        // C1B6
        private void C1B6devmap_CheckedChanged(object sender, EventArgs e)
        {
            if (C1B6devmap.Checked == true)
            {
                C1B6devmapcheckbox = "+devmap ";
                C1B6devmapstate = "enabled";
            }
            if (C1B6devmap.Checked == false)
            {
                C1B6devmapcheckbox = "+map ";
                C1B6devmapstate = "disabled";
            }
        }

        private void C1B6save_Click(object sender, EventArgs e)
        {
            C1B6cfgname = C1B6cfg.Text.ToString();

            if (C1B6cfgname != "")
            {
                C1B6cfgargument = "+exec " + C1B6cfgname + ".cfg ";
                C1B6cfgstate = C1B6cfgname;
            }
            else
            {
                C1B6cfgargument = "";
                C1B6cfgstate = "";
            }

            C1B6mapname = C1B6map.Text.ToString();

            if (C1B6mapname.Contains("mp_"))
            {
                string C1B6mapnameaux = C1B6mapname;
                C1B6mapnamefixed = C1B6mapnameaux.Remove(0, 3);
            }


            using (StreamWriter swdtbC1B6 = new StreamWriter("./database/dtbcustoms1/C1B6.txt"))
            {
                swdtbC1B6.WriteLine(C1B6devmapcheckbox);
                swdtbC1B6.WriteLine(C1B6devmapstate);
                swdtbC1B6.WriteLine(C1B6cfgargument);
                swdtbC1B6.WriteLine(C1B6cfgstate);
                swdtbC1B6.WriteLine(C1B6mapname);
                swdtbC1B6.WriteLine(C1B6mapnamefixed);
                swdtbC1B6.Close();
            }
            databaseC1B6path = ("./database/dtbcustoms1/C1B6.txt");

            using (var srdtbC1B6 = new StreamReader(databaseC1B6path))
            {
                lineC1B6devmapcheckbox = srdtbC1B6.ReadLine();
                lineC1B6devmapstate = srdtbC1B6.ReadLine();
                lineC1B6cfgargument = srdtbC1B6.ReadLine();
                lineC1B6cfgstate = srdtbC1B6.ReadLine();
                lineC1B6mapname = srdtbC1B6.ReadLine();
                lineC1B6mapnamefixed = srdtbC1B6.ReadLine();
            }
        }

        private void C1B6info_Click(object sender, EventArgs e)
        {
            c1start6info show = new c1start6info();
            show.ShowDialog();
        }
    }
}
