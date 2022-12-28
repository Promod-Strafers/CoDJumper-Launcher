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
    public partial class c5start1info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c5start1info()
        {
            InitializeComponent();

            devmapstate = SettingsCustom5.lineC5B1devmapstate;
            c5start1lbldevmap.Text = devmapstate;

            mapname = SettingsCustom5.lineC5B1mapnamefixed;
            c5start1lblmapname.Text = mapname;

            cfgname = SettingsCustom5.lineC5B1cfgstate;
            c5start1lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
