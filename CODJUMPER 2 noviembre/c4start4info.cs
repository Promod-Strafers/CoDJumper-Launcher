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
    public partial class c4start4info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c4start4info()
        {
            InitializeComponent();

            devmapstate = SettingsCustom4.lineC4B4devmapstate;
            c4start4lbldevmap.Text = devmapstate;

            mapname = SettingsCustom4.lineC4B4mapnamefixed;
            c4start4lblmapname.Text = mapname;

            cfgname = SettingsCustom4.lineC4B4cfgstate;
            c4start4lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
