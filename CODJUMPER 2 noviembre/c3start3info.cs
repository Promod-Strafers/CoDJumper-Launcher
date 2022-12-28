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
    public partial class c3start3info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c3start3info()
        {
            InitializeComponent();

            devmapstate = SettingsCustom3.lineC3B3devmapstate;
            c3start3lbldevmap.Text = devmapstate;

            mapname = SettingsCustom3.lineC3B3mapnamefixed;
            c3start3lblmapname.Text = mapname;

            cfgname = SettingsCustom3.lineC3B3cfgstate;
            c3start3lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
