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
    public partial class c2start12info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c2start12info()
        {
            InitializeComponent();

            devmapstate = SettingsCustoms2pt2.lineC2B12devmapstate;
            c2start12lbldevmap.Text = devmapstate;

            mapname = SettingsCustoms2pt2.lineC2B12mapnamefixed;
            c2start12lblmapname.Text = mapname;

            cfgname = SettingsCustoms2pt2.lineC2B12cfgstate;
            c2start12lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
