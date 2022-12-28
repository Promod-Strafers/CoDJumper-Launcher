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
    public partial class c4start1info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c4start1info()
        {
            InitializeComponent();

            devmapstate = SettingsCustom4.lineC4B1devmapstate;
            c4start1lbldevmap.Text = devmapstate;

            mapname = SettingsCustom4.lineC4B1mapnamefixed;
            c4start1lblmapname.Text = mapname;

            cfgname = SettingsCustom4.lineC4B1cfgstate;
            c4start1lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
