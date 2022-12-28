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
    public partial class c5start3info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c5start3info()
        {
            InitializeComponent();

            devmapstate = SettingsCustom5.lineC5B3devmapstate;
            c5start3lbldevmap.Text = devmapstate;

            mapname = SettingsCustom5.lineC5B3mapnamefixed;
            c5start3lblmapname.Text = mapname;

            cfgname = SettingsCustom5.lineC5B3cfgstate;
            c5start3lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
