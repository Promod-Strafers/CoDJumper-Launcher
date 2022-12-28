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
    public partial class c3start2info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c3start2info()
        {
            InitializeComponent();

            devmapstate = SettingsCustom3.lineC3B2devmapstate;
            c3start2lbldevmap.Text = devmapstate;

            mapname = SettingsCustom3.lineC3B2mapnamefixed;
            c3start2lblmapname.Text = mapname;

            cfgname = SettingsCustom3.lineC3B2cfgstate;
            c3start2lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
