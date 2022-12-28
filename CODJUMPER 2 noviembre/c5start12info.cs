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
    public partial class c5start12info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c5start12info()
        {
            InitializeComponent();

            devmapstate = SettingsCustom5pt2.lineC5B12devmapstate;
            c5start12lbldevmap.Text = devmapstate;

            mapname = SettingsCustom5pt2.lineC5B12mapnamefixed;
            c5start12lblmapname.Text = mapname;

            cfgname = SettingsCustom5pt2.lineC5B12cfgstate;
            c5start12lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
