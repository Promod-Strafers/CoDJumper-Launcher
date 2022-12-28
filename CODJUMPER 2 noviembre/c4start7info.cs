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
    public partial class c4start7info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c4start7info()
        {
            InitializeComponent();

            devmapstate = SettingsCustom4pt2.lineC4B7devmapstate;
            c4start7lbldevmap.Text = devmapstate;

            mapname = SettingsCustom4pt2.lineC4B7mapnamefixed;
            c4start7lblmapname.Text = mapname;

            cfgname = SettingsCustom4pt2.lineC4B7cfgstate;
            c4start7lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
