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
    public partial class c1start6info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c1start6info()
        {
            InitializeComponent();

            devmapstate = SettingsCustoms1.lineC1B6devmapstate;
            start6lbldevmap.Text = devmapstate;

            mapname = SettingsCustoms1.lineC1B6mapnamefixed;
            start6lblmapname.Text = mapname;

            cfgname = SettingsCustoms1.lineC1B6cfgstate;
            start6lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
