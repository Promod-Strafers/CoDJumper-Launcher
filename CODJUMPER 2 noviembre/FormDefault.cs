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
    public partial class FormDefault : Form
    {
        public FormDefault()
        {
            InitializeComponent();
        }

        private void btnambush_Click(object sender, EventArgs e)
        {
            Process processambush = new Process();
            processambush.StartInfo.FileName = FormSettings.filepathdtb;
            processambush.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b"+ FormSettings.linecfgdefaultargument +FormSettings.linedevmapdefaultcheckbox + "mp_convoy";
            processambush.StartInfo.CreateNoWindow = true;
            processambush.Start();
        }

        private void btnbloc_Click(object sender, EventArgs e)
        {
            Process processbloc = new Process();
            processbloc.StartInfo.FileName = FormSettings.filepathdtb;
            processbloc.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgdefaultargument + FormSettings.linedevmapdefaultcheckbox + "mp_bloc";
            processbloc.StartInfo.CreateNoWindow = true;
            processbloc.Start();
        }

        private void btnbog_Click(object sender, EventArgs e)
        {
            Process processbog = new Process();
            processbog.StartInfo.FileName = FormSettings.filepathdtb;
            processbog.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgdefaultargument + FormSettings.linedevmapdefaultcheckbox + "mp_bog";
            processbog.StartInfo.CreateNoWindow = true;
            processbog.Start();
        }

        private void btnbroadcast_Click(object sender, EventArgs e)
        {
            Process processbroadcast = new Process();
            processbroadcast.StartInfo.FileName = FormSettings.filepathdtb;
            processbroadcast.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgdefaultargument + FormSettings.linedevmapdefaultcheckbox + "mp_broadcast";
            processbroadcast.StartInfo.CreateNoWindow = true;
            processbroadcast.Start();
        }

        private void btnchinatown_Click(object sender, EventArgs e)
        {
            Process processchinatown = new Process();
            processchinatown.StartInfo.FileName = FormSettings.filepathdtb;
            processchinatown.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgdefaultargument + FormSettings.linedevmapdefaultcheckbox + "mp_carentan";
            processchinatown.StartInfo.CreateNoWindow = true;
            processchinatown.Start();
        }

        private void btncountdown_Click(object sender, EventArgs e)
        {
            Process processcountdown = new Process();
            processcountdown.StartInfo.FileName = FormSettings.filepathdtb;
            processcountdown.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgdefaultargument + FormSettings.linedevmapdefaultcheckbox + "mp_countdown";
            processcountdown.StartInfo.CreateNoWindow = true;
            processcountdown.Start();
        }

        private void btncreek_Click(object sender, EventArgs e)
        {
            Process processcreek = new Process();
            processcreek.StartInfo.FileName = FormSettings.filepathdtb;
            processcreek.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgdefaultargument + FormSettings.linedevmapdefaultcheckbox + "mp_creek";
            processcreek.StartInfo.CreateNoWindow = true;
            processcreek.Start();
        }

        private void btndownpour_Click(object sender, EventArgs e)
        {
            Process processdownpour = new Process();
            processdownpour.StartInfo.FileName = FormSettings.filepathdtb;
            processdownpour.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgdefaultargument + FormSettings.linedevmapdefaultcheckbox + "mp_farm";
            processdownpour.StartInfo.CreateNoWindow = true;
            processdownpour.Start();
        }

        private void btnkillhouse_Click(object sender, EventArgs e)
        {
            Process processkillhouse = new Process();
            processkillhouse.StartInfo.FileName = FormSettings.filepathdtb;
            processkillhouse.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgdefaultargument + FormSettings.linedevmapdefaultcheckbox + "mp_killhouse";
            processkillhouse.StartInfo.CreateNoWindow = true;
            processkillhouse.Start();
        }

        private void btnovergrown_Click(object sender, EventArgs e)
        {
            Process processovergrown = new Process();
            processovergrown.StartInfo.FileName = FormSettings.filepathdtb;
            processovergrown.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgdefaultargument + FormSettings.linedevmapdefaultcheckbox + "mp_overgrown";
            processovergrown.StartInfo.CreateNoWindow = true;
            processovergrown.Start();
        }

        private void btnpipeline_Click(object sender, EventArgs e)
        {
            Process processpipeline = new Process();
            processpipeline.StartInfo.FileName = FormSettings.filepathdtb;
            processpipeline.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgdefaultargument + FormSettings.linedevmapdefaultcheckbox + "mp_pipeline";
            processpipeline.StartInfo.CreateNoWindow = true;
            processpipeline.Start();
        }

        private void btnshipment_Click(object sender, EventArgs e)
        {
            Process processshipment = new Process();
            processshipment.StartInfo.FileName = FormSettings.filepathdtb;
            processshipment.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgdefaultargument + FormSettings.linedevmapdefaultcheckbox + "mp_shipment";
            processshipment.StartInfo.CreateNoWindow = true;
            processshipment.Start();
        }

        private void btnshowdown_Click(object sender, EventArgs e)
        {
            Process processshowdown = new Process();
            processshowdown.StartInfo.FileName = FormSettings.filepathdtb;
            processshowdown.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgdefaultargument + FormSettings.linedevmapdefaultcheckbox + "mp_showdown";
            processshowdown.StartInfo.CreateNoWindow = true;
            processshowdown.Start();
        }

        private void btnvacant_Click(object sender, EventArgs e)
        {
            Process processvacant = new Process();
            processvacant.StartInfo.FileName = FormSettings.filepathdtb;
            processvacant.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgdefaultargument + FormSettings.linedevmapdefaultcheckbox + "mp_vacant";
            processvacant.StartInfo.CreateNoWindow = true;
            processvacant.Start();
        }

        private void btnwetwork_Click(object sender, EventArgs e)
        {
            Process processwetwork = new Process();
            processwetwork.StartInfo.FileName = FormSettings.filepathdtb;
            processwetwork.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + FormSettings.linecfgdefaultargument + FormSettings.linedevmapdefaultcheckbox + "mp_cargoship";
            processwetwork.StartInfo.CreateNoWindow = true;
            processwetwork.Start();
        }
    }
}
