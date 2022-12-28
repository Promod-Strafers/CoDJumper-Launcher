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
    public partial class c4start5info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c4start5info()
        {
            InitializeComponent();

            devmapstate = SettingsCustom4.lineC4B5devmapstate;
            c4start5lbldevmap.Text = devmapstate;

            mapname = SettingsCustom4.lineC4B5mapnamefixed;
            c4start5lblmapname.Text = mapname;

            cfgname = SettingsCustom4.lineC4B5cfgstate;
            c4start5lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
