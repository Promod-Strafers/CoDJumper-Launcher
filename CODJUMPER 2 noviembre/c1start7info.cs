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
    public partial class c1start7info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c1start7info()
        {
            InitializeComponent();

            devmapstate = SettingsCustoms1pt2.lineC1B7devmapstate;
            start7lbldevmap.Text = devmapstate;

            mapname = SettingsCustoms1pt2.lineC1B7mapnamefixed;
            start7lblmapname.Text = mapname;

            cfgname = SettingsCustoms1pt2.lineC1B7cfgstate;
            start7lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
