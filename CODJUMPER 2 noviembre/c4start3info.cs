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
    public partial class c4start3info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c4start3info()
        {
            InitializeComponent();

            devmapstate = SettingsCustom4.lineC4B3devmapstate;
            c4start3lbldevmap.Text = devmapstate;

            mapname = SettingsCustom4.lineC4B3mapnamefixed;
            c4start3lblmapname.Text = mapname;

            cfgname = SettingsCustom4.lineC4B3cfgstate;
            c4start3lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
