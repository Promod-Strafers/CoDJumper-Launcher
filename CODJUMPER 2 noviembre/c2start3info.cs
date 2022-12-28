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
    public partial class c2start3info : Form
    {
        public string cfgname;
        public string devmapstate;
        public string mapname;
        public c2start3info()
        {
            InitializeComponent();

            devmapstate = SettingsCustoms2.lineC2B3devmapstate;
            c2start3lbldevmap.Text = devmapstate;

            mapname = SettingsCustoms2.lineC2B3mapnamefixed;
            c2start3lblmapname.Text = mapname;

            cfgname = SettingsCustoms2.lineC2B3cfgstate;
            c2start3lblcfgstate.Text = cfgname;
        }

        private void start1btnaccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}