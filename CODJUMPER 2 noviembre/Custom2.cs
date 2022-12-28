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
    public partial class Custom2 : Form
    {
        public Custom2()
        {
            InitializeComponent();

            c2lblstart1.Text = SettingsCustoms2.lineC2B1mapnamefixed;
            c2lblstart2.Text = SettingsCustoms2.lineC2B2mapnamefixed;
            c2lblstart3.Text = SettingsCustoms2.lineC2B3mapnamefixed;
            c2lblstart4.Text = SettingsCustoms2.lineC2B4mapnamefixed;
            c2lblstart5.Text = SettingsCustoms2.lineC2B5mapnamefixed;
            c2lblstart6.Text = SettingsCustoms2.lineC2B6mapnamefixed;
            c2lblstart7.Text = SettingsCustoms2pt2.lineC2B7mapnamefixed;
            c2lblstart8.Text = SettingsCustoms2pt2.lineC2B8mapnamefixed;
            c2lblstart9.Text = SettingsCustoms2pt2.lineC2B9mapnamefixed;
            c2lblstart10.Text = SettingsCustoms2pt2.lineC2B10mapnamefixed;
            c2lblstart11.Text = SettingsCustoms2pt2.lineC2B11mapnamefixed;
            c2lblstart12.Text = SettingsCustoms2pt2.lineC2B12mapnamefixed;

        }

        public void loadform(object Form)
        {
            if (this.panelMain.Controls.Count > 0)
                this.panelMain.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Show();
        }

        private void c2settings_Click(object sender, EventArgs e)
        {
            loadform(new SettingsCustoms2());
        }

        private void c2settings2_Click(object sender, EventArgs e)
        {
            loadform(new SettingsCustoms2pt2());
        }

        static private void start(string pathfiledtb, string cfgarg, string devmaparg, string maparg)
        {
            Process processstart = new Process();
            processstart.StartInfo.FileName = pathfiledtb;
            processstart.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + cfgarg + devmaparg + maparg + " +set r_xassetnum \"material=2560 xmodel=1200 xanim=3200 image=3000\"";
            processstart.StartInfo.CreateNoWindow = true;
            processstart.Start();

        }

        private void c2start1_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustoms2.lineC2B1cfgargument, SettingsCustoms2.lineC2B1devmapcheckbox, SettingsCustoms2.lineC2B1mapname);
        }

        private void c2start2_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustoms2.lineC2B2cfgargument, SettingsCustoms2.lineC2B2devmapcheckbox, SettingsCustoms2.lineC2B2mapname);
        }

        private void c2start3_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustoms2.lineC2B3cfgargument, SettingsCustoms2.lineC2B3devmapcheckbox, SettingsCustoms2.lineC2B3mapname);
        }

        private void c2start4_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustoms2.lineC2B4cfgargument, SettingsCustoms2.lineC2B4devmapcheckbox, SettingsCustoms2.lineC2B4mapname);
        }

        private void c2start5_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustoms2.lineC2B5cfgargument, SettingsCustoms2.lineC2B5devmapcheckbox, SettingsCustoms2.lineC2B5mapname);
        }

        private void c2start6_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustoms2.lineC2B6cfgargument, SettingsCustoms2.lineC2B6devmapcheckbox, SettingsCustoms2.lineC2B6mapname);
        }

        private void c2start7_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustoms2pt2.lineC2B7cfgargument, SettingsCustoms2pt2.lineC2B7devmapcheckbox, SettingsCustoms2pt2.lineC2B7mapname);
        }

        private void c2start8_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustoms2pt2.lineC2B8cfgargument, SettingsCustoms2pt2.lineC2B8devmapcheckbox, SettingsCustoms2pt2.lineC2B8mapname);
        }

        private void c2start9_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustoms2pt2.lineC2B9cfgargument, SettingsCustoms2pt2.lineC2B9devmapcheckbox, SettingsCustoms2pt2.lineC2B9mapname);
        }

        private void c2start10_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustoms2pt2.lineC2B10cfgargument, SettingsCustoms2pt2.lineC2B10devmapcheckbox, SettingsCustoms2pt2.lineC2B10mapname);
        }

        private void c2start11_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustoms2pt2.lineC2B11cfgargument, SettingsCustoms2pt2.lineC2B11devmapcheckbox, SettingsCustoms2pt2.lineC2B11mapname);
        }

        private void c2start12_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustoms2pt2.lineC2B12cfgargument, SettingsCustoms2pt2.lineC2B12devmapcheckbox, SettingsCustoms2pt2.lineC2B12mapname);
        }
    }
}
