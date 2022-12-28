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
    public partial class c3start5info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c3start5info()
        {
            InitializeComponent();

            devmapstate = SettingsCustom3.lineC3B5devmapstate;
            c3start5lbldevmap.Text = devmapstate;

            mapname = SettingsCustom3.lineC3B5mapnamefixed;
            c3start5lblmapname.Text = mapname;

            cfgname = SettingsCustom3.lineC3B5cfgstate;
            c3start5lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
