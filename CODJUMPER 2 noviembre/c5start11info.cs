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
    public partial class c5start11info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c5start11info()
        {
            InitializeComponent();

            devmapstate = SettingsCustom5pt2.lineC5B11devmapstate;
            c5start11lbldevmap.Text = devmapstate;

            mapname = SettingsCustom5pt2.lineC5B11mapnamefixed;
            c5start11lblmapname.Text = mapname;

            cfgname = SettingsCustom5pt2.lineC5B11cfgstate;
            c5start11lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
