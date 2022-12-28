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
    public partial class c3start4info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c3start4info()
        {
            InitializeComponent();

            devmapstate = SettingsCustom3.lineC3B4devmapstate;
            c3start4lbldevmap.Text = devmapstate;

            mapname = SettingsCustom3.lineC3B4mapnamefixed;
            c3start4lblmapname.Text = mapname;

            cfgname = SettingsCustom3.lineC3B4cfgstate;
            c3start4lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
