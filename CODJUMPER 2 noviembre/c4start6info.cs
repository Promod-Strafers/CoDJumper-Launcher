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
    public partial class c4start6info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c4start6info()
        {
            InitializeComponent();

            devmapstate = SettingsCustom4.lineC4B6devmapstate;
            c4start6lbldevmap.Text = devmapstate;

            mapname = SettingsCustom4.lineC4B6mapnamefixed;
            c4start6lblmapname.Text = mapname;

            cfgname = SettingsCustom4.lineC4B6cfgstate;
            c4start6lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
