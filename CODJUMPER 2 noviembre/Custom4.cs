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
    public partial class Custom4 : Form
    {
        public Custom4()
        {
            InitializeComponent();

            c4lblstart1.Text = SettingsCustom4.lineC4B1mapnamefixed;
            c4lblstart2.Text = SettingsCustom4.lineC4B2mapnamefixed;
            c4lblstart3.Text = SettingsCustom4.lineC4B3mapnamefixed;
            c4lblstart4.Text = SettingsCustom4.lineC4B4mapnamefixed;
            c4lblstart5.Text = SettingsCustom4.lineC4B5mapnamefixed;
            c4lblstart6.Text = SettingsCustom4.lineC4B6mapnamefixed;
            c4lblstart7.Text = SettingsCustom4pt2.lineC4B7mapnamefixed;
            c4lblstart8.Text = SettingsCustom4pt2.lineC4B8mapnamefixed;
            c4lblstart9.Text = SettingsCustom4pt2.lineC4B9mapnamefixed;
            c4lblstart10.Text = SettingsCustom4pt2.lineC4B10mapnamefixed;
            c4lblstart11.Text = SettingsCustom4pt2.lineC4B11mapnamefixed;
            c4lblstart12.Text = SettingsCustom4pt2.lineC4B12mapnamefixed;
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
        private void c4settings_Click(object sender, EventArgs e)
        {
            loadform(new SettingsCustom4());
        }

        private void c4settings2_Click(object sender, EventArgs e)
        {
            loadform(new SettingsCustom4pt2());
        }

        static private void start(string pathfiledtb, string cfgarg, string devmaparg, string maparg)
        {
            Process processstart = new Process();
            processstart.StartInfo.FileName = pathfiledtb;
            processstart.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + cfgarg + devmaparg + maparg + " +set r_xassetnum \"material=2560 xmodel=1200 xanim=3200 image=3000\"";
            processstart.StartInfo.CreateNoWindow = true;
            processstart.Start();

        }

        private void c4start1_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustom4.lineC4B1cfgargument, SettingsCustom4.lineC4B1devmapcheckbox, SettingsCustom4.lineC4B1mapname);
        }

        private void c4start2_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustom4.lineC4B2cfgargument, SettingsCustom4.lineC4B2devmapcheckbox, SettingsCustom4.lineC4B2mapname);
        }

        private void c4start3_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustom4.lineC4B3cfgargument, SettingsCustom4.lineC4B3devmapcheckbox, SettingsCustom4.lineC4B3mapname);
        }

        private void c4start4_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustom4.lineC4B4cfgargument, SettingsCustom4.lineC4B4devmapcheckbox, SettingsCustom4.lineC4B4mapname);
        }

        private void c4start5_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustom4.lineC4B5cfgargument, SettingsCustom4.lineC4B5devmapcheckbox, SettingsCustom4.lineC4B5mapname);
        }

        private void c4start6_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustom4.lineC4B6cfgargument, SettingsCustom4.lineC4B6devmapcheckbox, SettingsCustom4.lineC4B6mapname);
        }

        private void c4start7_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustom4pt2.lineC4B7cfgargument, SettingsCustom4pt2.lineC4B7devmapcheckbox, SettingsCustom4pt2.lineC4B7mapname);
        }

        private void c4start8_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustom4pt2.lineC4B8cfgargument, SettingsCustom4pt2.lineC4B8devmapcheckbox, SettingsCustom4pt2.lineC4B8mapname);
        }

        private void c4start9_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustom4pt2.lineC4B9cfgargument, SettingsCustom4pt2.lineC4B9devmapcheckbox, SettingsCustom4pt2.lineC4B9mapname);
        }

        private void c4start10_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustom4pt2.lineC4B10cfgargument, SettingsCustom4pt2.lineC4B10devmapcheckbox, SettingsCustom4pt2.lineC4B10mapname);
        }

        private void c4start11_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustom4pt2.lineC4B11cfgargument, SettingsCustom4pt2.lineC4B11devmapcheckbox, SettingsCustom4pt2.lineC4B11mapname);
        }

        private void c4start12_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustom4pt2.lineC4B12cfgargument, SettingsCustom4pt2.lineC4B12devmapcheckbox, SettingsCustom4pt2.lineC4B12mapname);
        }
    }
}
