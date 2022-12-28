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
    public partial class c4start2info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c4start2info()
        {
            InitializeComponent();

            devmapstate = SettingsCustom4.lineC4B2devmapstate;
            c4start2lbldevmap.Text = devmapstate;

            mapname = SettingsCustom4.lineC4B2mapnamefixed;
            c4start2lblmapname.Text = mapname;

            cfgname = SettingsCustom4.lineC4B2cfgstate;
            c4start2lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
