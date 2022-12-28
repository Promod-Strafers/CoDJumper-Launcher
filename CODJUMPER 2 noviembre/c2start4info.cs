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
    public partial class c2start4info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c2start4info()
        {
            InitializeComponent();

            devmapstate = SettingsCustoms2.lineC2B4devmapstate;
            c2start4lbldevmap.Text = devmapstate;

            mapname = SettingsCustoms2.lineC2B4mapnamefixed;
            c2start4lblmapname.Text = mapname;

            cfgname = SettingsCustoms2.lineC2B4cfgstate;
            c2start4lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
