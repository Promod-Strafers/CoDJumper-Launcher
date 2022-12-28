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
    public partial class c1start1info : Form
    {

        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c1start1info()
        {
            InitializeComponent();

            devmapstate = SettingsCustoms1.lineC1B1devmapstate;
            start1lbldevmap.Text = devmapstate;

            mapname = SettingsCustoms1.lineC1B1mapnamefixed;
            start1lblmapname.Text = mapname;

            cfgname = SettingsCustoms1.lineC1B1cfgstate;
            start1lblcfgstate.Text = cfgname;

        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
