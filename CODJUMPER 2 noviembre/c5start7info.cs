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
    public partial class c5start7info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c5start7info()
        {
            InitializeComponent();

            devmapstate = SettingsCustom5pt2.lineC5B7devmapstate;
            c5start7lbldevmap.Text = devmapstate;

            mapname = SettingsCustom5pt2.lineC5B7mapnamefixed;
            c5start7lblmapname.Text = mapname;

            cfgname = SettingsCustom5pt2.lineC5B7cfgstate;
            c5start7lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
