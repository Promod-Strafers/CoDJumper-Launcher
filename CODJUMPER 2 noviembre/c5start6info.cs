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
    public partial class c5start6info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c5start6info()
        {
            InitializeComponent();

            devmapstate = SettingsCustom5.lineC5B6devmapstate;
            c5start6lbldevmap.Text = devmapstate;

            mapname = SettingsCustom5.lineC5B6mapnamefixed;
            c5start6lblmapname.Text = mapname;

            cfgname = SettingsCustom5.lineC5B6cfgstate;
            c5start6lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
