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
    public partial class c5start5info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c5start5info()
        {
            InitializeComponent();

            devmapstate = SettingsCustom5.lineC5B5devmapstate;
            c5start5lbldevmap.Text = devmapstate;

            mapname = SettingsCustom5.lineC5B5mapnamefixed;
            c5start5lblmapname.Text = mapname;

            cfgname = SettingsCustom5.lineC5B5cfgstate;
            c5start5lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
