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
    public partial class c2start8info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c2start8info()
        {
            InitializeComponent();

            devmapstate = SettingsCustoms2pt2.lineC2B8devmapstate;
            c2start8lbldevmap.Text = devmapstate;

            mapname = SettingsCustoms2pt2.lineC2B8mapnamefixed;
            c2start8lblmapname.Text = mapname;

            cfgname = SettingsCustoms2pt2.lineC2B8cfgstate;
            c2start8lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
