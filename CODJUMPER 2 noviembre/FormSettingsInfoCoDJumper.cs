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
    public partial class FormSettingsInfoCoDJumper : Form
    {
        public string cfgname;
        public string devmapstate;
        public FormSettingsInfoCoDJumper()
        {
            InitializeComponent();
            cfgname = FormSettings.linecfgcodjumperstate;
            lblcfgname.Text = cfgname;

            devmapstate = FormSettings.linedevmapcodjumperstate;
            lbldevmapmode.Text = devmapstate;
        }

        private void btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
