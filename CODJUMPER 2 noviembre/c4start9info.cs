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
    public partial class c4start9info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c4start9info()
        {
            InitializeComponent();

            devmapstate = SettingsCustom4pt2.lineC4B9devmapstate;
            c4start9lbldevmap.Text = devmapstate;

            mapname = SettingsCustom4pt2.lineC4B9mapnamefixed;
            c4start9lblmapname.Text = mapname;

            cfgname = SettingsCustom4pt2.lineC4B9cfgstate;
            c4start9lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
