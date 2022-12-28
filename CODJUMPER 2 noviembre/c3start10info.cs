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
    public partial class c3start10info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c3start10info()
        {
            InitializeComponent();

            devmapstate = SettingsCustom3pt2.lineC3B10devmapstate;
            c3start10lbldevmap.Text = devmapstate;

            mapname = SettingsCustom3pt2.lineC3B10mapnamefixed;
            c3start10lblmapname.Text = mapname;

            cfgname = SettingsCustom3pt2.lineC3B10cfgstate;
            c3start10lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
