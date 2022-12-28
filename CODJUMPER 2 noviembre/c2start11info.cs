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
    public partial class c2start11info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c2start11info()
        {
            InitializeComponent();

            devmapstate = SettingsCustoms2pt2.lineC2B11devmapstate;
            c2start11lbldevmap.Text = devmapstate;

            mapname = SettingsCustoms2pt2.lineC2B11mapnamefixed;
            c2start11lblmapname.Text = mapname;

            cfgname = SettingsCustoms2pt2.lineC2B11cfgstate;
            c2start11lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
