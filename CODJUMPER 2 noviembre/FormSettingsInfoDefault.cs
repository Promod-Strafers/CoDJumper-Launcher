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
    public partial class FormSettingsInfoDefault : Form
    {
        public string cfgname;
        public string devmapstate;
        public FormSettingsInfoDefault()
        {
            InitializeComponent();
            cfgname = FormSettings.linecfgdefaultstate;
            lblcfgname.Text = cfgname;

            devmapstate = FormSettings.linedevmapdefaultstate;
            lbldevmapmode.Text = devmapstate;

        }
        private void btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
