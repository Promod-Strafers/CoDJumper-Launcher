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
    public partial class c2start5info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c2start5info()
        {
            InitializeComponent();

            devmapstate = SettingsCustoms2.lineC2B5devmapstate;
            c2start5lbldevmap.Text = devmapstate;

            mapname = SettingsCustoms2.lineC2B5mapnamefixed;
            c2start5lblmapname.Text = mapname;

            cfgname = SettingsCustoms2.lineC2B5cfgstate;
            c2start5lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
