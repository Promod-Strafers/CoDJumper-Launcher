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
    public partial class c3start1info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c3start1info()
        {
            InitializeComponent();

            devmapstate = SettingsCustom3.lineC3B1devmapstate;
            c3start1lbldevmap.Text = devmapstate;

            mapname = SettingsCustom3.lineC3B1mapnamefixed;
            c3start1lblmapname.Text = mapname;

            cfgname = SettingsCustom3.lineC3B1cfgstate;
            c3start1lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
