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
    public partial class c1start11info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c1start11info()
        {
            InitializeComponent();

            devmapstate = SettingsCustoms1pt2.lineC1B11devmapstate;
            start11lbldevmap.Text = devmapstate;

            mapname = SettingsCustoms1pt2.lineC1B11mapnamefixed;
            start11lblmapname.Text = mapname;

            cfgname = SettingsCustoms1pt2.lineC1B11cfgstate;
            start11lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
