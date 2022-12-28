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
    public partial class c1start3info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c1start3info()
        {
            InitializeComponent();

            devmapstate = SettingsCustoms1.lineC1B3devmapstate;
            start3lbldevmap.Text = devmapstate;

            mapname = SettingsCustoms1.lineC1B3mapnamefixed;
            start3lblmapname.Text = mapname;

            cfgname = SettingsCustoms1.lineC1B3cfgstate;
            start3lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
