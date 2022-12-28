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
    public partial class c2start7info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c2start7info()
        {
            InitializeComponent();

            devmapstate = SettingsCustoms2pt2.lineC2B7devmapstate;
            c2start7lbldevmap.Text = devmapstate;

            mapname = SettingsCustoms2pt2.lineC2B7mapnamefixed;
            c2start7lblmapname.Text = mapname;

            cfgname = SettingsCustoms2pt2.lineC2B7cfgstate;
            c2start7lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
