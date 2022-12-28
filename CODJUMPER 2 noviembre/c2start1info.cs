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
    public partial class c2start1info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c2start1info()
        {
            InitializeComponent();

            devmapstate = SettingsCustoms2.lineC2B1devmapstate;
            c2start1lbldevmap.Text = devmapstate;

            mapname = SettingsCustoms2.lineC2B1mapnamefixed;
            c2start1lblmapname.Text = mapname;

            cfgname = SettingsCustoms2.lineC2B1cfgstate;
            c2start1lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
