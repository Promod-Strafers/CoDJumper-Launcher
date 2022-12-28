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
    public partial class FormCoDJumper : Form
    {
        public FormCoDJumper()
        {
            InitializeComponent();
        }

        private void btncheops_Click(object sender, EventArgs e)
        {
            Process processcheops = new Process();
            processcheops.StartInfo.FileName = FormSettings.filepathdtb;
            processcheops.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgcodjumperargument + FormSettings.linedevmapcodjumpercheckbox + "mp_cheops";
            processcheops.StartInfo.CreateNoWindow = true;
            processcheops.Start();
        }

        private void btndigital_Click(object sender, EventArgs e)
        {
            Process processdigital = new Process();
            processdigital.StartInfo.FileName = FormSettings.filepathdtb;
            processdigital.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgcodjumperargument + FormSettings.linedevmapcodjumpercheckbox + "mp_digital";
            processdigital.StartInfo.CreateNoWindow = true;
            processdigital.Start();
        }

        private void btndungeon_Click(object sender, EventArgs e)
        {
            Process processdungeon = new Process();
            processdungeon.StartInfo.FileName = FormSettings.filepathdtb;
            processdungeon.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgcodjumperargument + FormSettings.linedevmapcodjumpercheckbox + "mp_dungeon_p";
            processdungeon.StartInfo.CreateNoWindow = true;
            processdungeon.Start();
        }

        private void btnforgotten_Click(object sender, EventArgs e)
        {
            Process processforgotten = new Process();
            processforgotten.StartInfo.FileName = FormSettings.filepathdtb;
            processforgotten.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgcodjumperargument + FormSettings.linedevmapcodjumpercheckbox + "mp_forgotten";
            processforgotten.StartInfo.CreateNoWindow = true;
            processforgotten.Start();
        }

        private void btnib_glass_v3_Click(object sender, EventArgs e)
        {
            Process processib_glass_v3 = new Process();
            processib_glass_v3.StartInfo.FileName = FormSettings.filepathdtb;
            processib_glass_v3.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgcodjumperargument + FormSettings.linedevmapcodjumpercheckbox + "mp_ib_glass_v3";
            processib_glass_v3.StartInfo.CreateNoWindow = true;
            processib_glass_v3.Start();
        }

        private void btnjm_cruise_Click(object sender, EventArgs e)
        {
            Process processjm_cruise = new Process();
            processjm_cruise.StartInfo.FileName = FormSettings.filepathdtb;
            processjm_cruise.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgcodjumperargument + FormSettings.linedevmapcodjumpercheckbox + "mp_jm_cruise";
            processjm_cruise.StartInfo.CreateNoWindow = true;
            processjm_cruise.Start();
        }

        private void btnjm_offices_Click(object sender, EventArgs e)
        {
            Process processjm_offices = new Process();
            processjm_offices.StartInfo.FileName = FormSettings.filepathdtb;
            processjm_offices.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgcodjumperargument + FormSettings.linedevmapcodjumpercheckbox + "mp_jm_offices";
            processjm_offices.StartInfo.CreateNoWindow = true;
            processjm_offices.Start();
        }

        private void btnlighthouse_Click(object sender, EventArgs e)
        {
            Process processlighthouse = new Process();
            processlighthouse.StartInfo.FileName = FormSettings.filepathdtb;
            processlighthouse.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgcodjumperargument + FormSettings.linedevmapcodjumpercheckbox + "mp_lighthouse";
            processlighthouse.StartInfo.CreateNoWindow = true;
            processlighthouse.Start();
        }

        private void btnmountainbase_Click(object sender, EventArgs e)
        {
            Process processmountainbase = new Process();
            processmountainbase.StartInfo.FileName = FormSettings.filepathdtb;
            processmountainbase.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgcodjumperargument + FormSettings.linedevmapcodjumpercheckbox + "mp_mountainbase";
            processmountainbase.StartInfo.CreateNoWindow = true;
            processmountainbase.Start();
        }

        private void btnportal_Click(object sender, EventArgs e)
        {
            Process processportal = new Process();
            processportal.StartInfo.FileName = FormSettings.filepathdtb;
            processportal.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgcodjumperargument + FormSettings.linedevmapcodjumpercheckbox + "mp_portal";
            processportal.StartInfo.CreateNoWindow = true;
            processportal.Start();
        }

        private void btnrocket_Click(object sender, EventArgs e)
        {
            Process processrocket = new Process();
            processrocket.StartInfo.FileName = FormSettings.filepathdtb;
            processrocket.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgcodjumperargument + FormSettings.linedevmapcodjumpercheckbox + "mp_rocket";
            processrocket.StartInfo.CreateNoWindow = true;
            processrocket.Start();
        }

        private void btntrial_2_Click(object sender, EventArgs e)
        {
            Process processtrial_2 = new Process();
            processtrial_2.StartInfo.FileName = FormSettings.filepathdtb;
            processtrial_2.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgcodjumperargument + FormSettings.linedevmapcodjumpercheckbox + "mp_trial_2_p";
            processtrial_2.StartInfo.CreateNoWindow = true;
            processtrial_2.Start();
        }

        private void btncodjumper_training_Click(object sender, EventArgs e)
        {
            Process processcodjumper_training = new Process();
            processcodjumper_training.StartInfo.FileName = FormSettings.filepathdtb;
            processcodjumper_training.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgcodjumperargument + FormSettings.linedevmapcodjumpercheckbox + "mp_codjumper_training";
            processcodjumper_training.StartInfo.CreateNoWindow = true;
            processcodjumper_training.Start();
        }

        private void btnpeds_propel_Click(object sender, EventArgs e)
        {
            Process processpeds_propel = new Process();
            processpeds_propel.StartInfo.FileName = FormSettings.filepathdtb;
            processpeds_propel.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgcodjumperargument + FormSettings.linedevmapcodjumpercheckbox + "mp_peds_propel";
            processpeds_propel.StartInfo.CreateNoWindow = true;
            processpeds_propel.Start();
        }
    }
}
