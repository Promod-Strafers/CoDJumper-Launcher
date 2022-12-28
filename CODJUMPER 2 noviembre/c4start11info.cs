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
    public partial class c4start11info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c4start11info()
        {
            InitializeComponent();

            devmapstate = SettingsCustom4pt2.lineC4B11devmapstate;
            c4start11lbldevmap.Text = devmapstate;

            mapname = SettingsCustom4pt2.lineC4B11mapnamefixed;
            c4start11lblmapname.Text = mapname;

            cfgname = SettingsCustom4pt2.lineC4B11cfgstate;
            c4start11lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
