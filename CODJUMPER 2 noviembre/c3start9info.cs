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
    public partial class c3start9info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c3start9info()
        {
            InitializeComponent();

            devmapstate = SettingsCustom3pt2.lineC3B9devmapstate;
            c3start9lbldevmap.Text = devmapstate;

            mapname = SettingsCustom3pt2.lineC3B9mapnamefixed;
            c3start9lblmapname.Text = mapname;

            cfgname = SettingsCustom3pt2.lineC3B9cfgstate;
            c3start9lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
