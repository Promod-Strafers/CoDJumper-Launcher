using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CODJUMPER_2_noviembre
{
    public partial class FormPromod : Form
    {
        public FormPromod()
        {
            InitializeComponent();
        }

        private void btnbacklot_Click(object sender, EventArgs e)
        {
            Process processbacklot = new Process();
            processbacklot.StartInfo.FileName = FormSettings.filepathdtb;
            processbacklot.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgpromodargument + FormSettings.linedevmappromodcheckbox + "mp_backlot";
            processbacklot.StartInfo.CreateNoWindow = true;
            processbacklot.Start();
        }

        private void btncrash_Click(object sender, EventArgs e)
        {
            Process processcrash = new Process();
            processcrash.StartInfo.FileName = FormSettings.filepathdtb;
            processcrash.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgpromodargument + FormSettings.linedevmappromodcheckbox + "mp_crash";
            processcrash.StartInfo.CreateNoWindow = true;
            processcrash.Start();
        }

        private void btnwintercrash_Click(object sender, EventArgs e)
        {
            Process processwintercrash = new Process();
            processwintercrash.StartInfo.FileName = FormSettings.filepathdtb;
            processwintercrash.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgpromodargument + FormSettings.linedevmappromodcheckbox + "mp_crash_snow";
            processwintercrash.StartInfo.CreateNoWindow = true;
            processwintercrash.Start();
        }

        private void btncrossfire_Click(object sender, EventArgs e)
        {
            Process processcrossfire = new Process();
            processcrossfire.StartInfo.FileName = FormSettings.filepathdtb;
            processcrossfire.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgpromodargument + FormSettings.linedevmappromodcheckbox + "mp_crossfire";
            processcrossfire.StartInfo.CreateNoWindow = true;
            processcrossfire.Start();
        }

        private void btndistrict_Click(object sender, EventArgs e)
        {
            Process processdistrict = new Process();
            processdistrict.StartInfo.FileName = FormSettings.filepathdtb;
            processdistrict.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgpromodargument + FormSettings.linedevmappromodcheckbox + "mp_citystreets" + " +set r_xassetnum \"material=2560 xmodel=1200 xanim=3200 image=3000\"";
            processdistrict.StartInfo.CreateNoWindow = true;
            processdistrict.Start();
        }

        private void btnstrike_Click(object sender, EventArgs e)
        {
            Process processstrike = new Process();
            processstrike.StartInfo.FileName = FormSettings.filepathdtb;
            processstrike.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgpromodargument + FormSettings.linedevmappromodcheckbox + "mp_strike";
            processstrike.StartInfo.CreateNoWindow = true;
            processstrike.Start();
        }

        private void btncluster_Click(object sender, EventArgs e)
        {
            Process processcluster = new Process();
            processcluster.StartInfo.FileName = FormSettings.filepathdtb;
            processcluster.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgpromodargument + FormSettings.linedevmappromodcheckbox + "mp_cluster";
            processcluster.StartInfo.CreateNoWindow = true;
            processcluster.Start();
        }

        private void btndusty_Click(object sender, EventArgs e)
        {
            Process processdusty = new Process();
            processdusty.StartInfo.FileName = FormSettings.filepathdtb;
            processdusty.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgpromodargument + FormSettings.linedevmappromodcheckbox + "mp_dusty" + " +set r_xassetnum \"material=2560 xmodel=1200 xanim=3200 image=3000\"";
            processdusty.StartInfo.CreateNoWindow = true;
            processdusty.Start();
        }

        private void btnhideout_Click(object sender, EventArgs e)
        {
            Process processhideout = new Process();
            processhideout.StartInfo.FileName = FormSettings.filepathdtb;
            processhideout.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgpromodargument + FormSettings.linedevmappromodcheckbox + "mp_hideout";
            processhideout.StartInfo.CreateNoWindow = true;
            processhideout.Start();
        }

        private void btnmarketcenter_Click(object sender, EventArgs e)
        {
            Process processmarketcenter = new Process();
            processmarketcenter.StartInfo.FileName = FormSettings.filepathdtb;
            processmarketcenter.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgpromodargument + FormSettings.linedevmappromodcheckbox + "mp_marketcenter";
            processmarketcenter.StartInfo.CreateNoWindow = true;
            processmarketcenter.Start();
        }

        private void btnportside_Click(object sender, EventArgs e)
        {
            Process processportside = new Process();
            processportside.StartInfo.FileName = FormSettings.filepathdtb;
            processportside.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgpromodargument + FormSettings.linedevmappromodcheckbox + "mp_portside";
            processportside.StartInfo.CreateNoWindow = true;
            processportside.Start();
        }

        private void btnseason_Click(object sender, EventArgs e)
        {
            Process processseason = new Process();
            processseason.StartInfo.FileName = FormSettings.filepathdtb;
            processseason.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgpromodargument + FormSettings.linedevmappromodcheckbox + "mp_season";
            processseason.StartInfo.CreateNoWindow = true;
            processseason.Start();
        }

        private void btnshantytown_eu_Click(object sender, EventArgs e)
        {
            Process processshantytown_eu = new Process();
            processshantytown_eu.StartInfo.FileName = FormSettings.filepathdtb;
            processshantytown_eu.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgpromodargument + FormSettings.linedevmappromodcheckbox + "mp_shantytown_eu";
            processshantytown_eu.StartInfo.CreateNoWindow = true;
            processshantytown_eu.Start();
        }

        private void btnsmalltownx_Click(object sender, EventArgs e)
        {
            Process processsmalltownx = new Process();
            processsmalltownx.StartInfo.FileName = FormSettings.filepathdtb;
            processsmalltownx.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgpromodargument + FormSettings.linedevmappromodcheckbox + "mp_smalltownx" + " +set r_xassetnum \"material=2560 xmodel=1200 xanim=3200 image=3000\"";
            processsmalltownx.StartInfo.CreateNoWindow = true;
            processsmalltownx.Start();
        }
    }
}
