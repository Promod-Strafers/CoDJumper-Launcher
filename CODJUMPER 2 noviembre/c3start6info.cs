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
    public partial class c3start6info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c3start6info()
        {
            InitializeComponent();

            devmapstate = SettingsCustom3.lineC3B6devmapstate;
            c3start6lbldevmap.Text = devmapstate;

            mapname = SettingsCustom3.lineC3B6mapnamefixed;
            c3start6lblmapname.Text = mapname;

            cfgname = SettingsCustom3.lineC3B6cfgstate;
            c3start6lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
