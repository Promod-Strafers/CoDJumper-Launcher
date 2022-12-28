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
    public partial class c5start10info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c5start10info()
        {
            InitializeComponent();

            devmapstate = SettingsCustom5pt2.lineC5B10devmapstate;
            c5start10lbldevmap.Text = devmapstate;

            mapname = SettingsCustom5pt2.lineC5B10mapnamefixed;
            c5start10lblmapname.Text = mapname;

            cfgname = SettingsCustom5pt2.lineC5B10cfgstate;
            c5start10lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
