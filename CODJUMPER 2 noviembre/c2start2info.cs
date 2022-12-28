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
    public partial class c2start2info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c2start2info()
        {
            InitializeComponent();

            devmapstate = SettingsCustoms2.lineC2B2devmapstate;
            c2start2lbldevmap.Text = devmapstate;

            mapname = SettingsCustoms2.lineC2B2mapnamefixed;
            c2start2lblmapname.Text = mapname;

            cfgname = SettingsCustoms2.lineC2B2cfgstate;
            c2start2lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
