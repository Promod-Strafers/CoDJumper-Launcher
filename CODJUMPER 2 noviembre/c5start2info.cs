﻿using System;
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
    public partial class c5start2info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c5start2info()
        {
            InitializeComponent();

            devmapstate = SettingsCustom5.lineC5B2devmapstate;
            c5start2lbldevmap.Text = devmapstate;

            mapname = SettingsCustom5.lineC5B2mapnamefixed;
            c5start2lblmapname.Text = mapname;

            cfgname = SettingsCustom5.lineC5B2cfgstate;
            c5start2lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
