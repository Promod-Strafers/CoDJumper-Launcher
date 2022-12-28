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
    public partial class c1start2info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c1start2info()
        {
            InitializeComponent();

            devmapstate = SettingsCustoms1.lineC1B2devmapstate;
            start2lbldevmap.Text = devmapstate;

            mapname = SettingsCustoms1.lineC1B2mapnamefixed;
            start2lblmapname.Text = mapname;

            cfgname = SettingsCustoms1.lineC1B2cfgstate;
            start2lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
