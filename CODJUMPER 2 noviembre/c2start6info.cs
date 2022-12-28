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
    public partial class c2start6info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c2start6info()
        {
            InitializeComponent();

            devmapstate = SettingsCustoms2.lineC2B6devmapstate;
            c2start6lbldevmap.Text = devmapstate;

            mapname = SettingsCustoms2.lineC2B6mapnamefixed;
            c2start6lblmapname.Text = mapname;

            cfgname = SettingsCustoms2.lineC2B6cfgstate;
            c2start6lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
