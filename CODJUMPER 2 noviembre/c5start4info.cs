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
    public partial class c5start4info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c5start4info()
        {
            InitializeComponent();

            devmapstate = SettingsCustom5.lineC5B4devmapstate;
            c5start4lbldevmap.Text = devmapstate;

            mapname = SettingsCustom5.lineC5B4mapnamefixed;
            c5start4lblmapname.Text = mapname;

            cfgname = SettingsCustom5.lineC5B4cfgstate;
            c5start4lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
