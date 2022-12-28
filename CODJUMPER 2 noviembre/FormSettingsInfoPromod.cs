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
    public partial class FormSettingsInfoPromod : Form
    {
        public string cfgname;
        public string devmapstate;
        public FormSettingsInfoPromod()
        {
            InitializeComponent();
            cfgname = FormSettings.linecfgpromodstate;
            lblcfgname.Text = cfgname;

            devmapstate = FormSettings.linedevmappromodstate;
            lbldevmapmode.Text = devmapstate;
        }

        private void btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
