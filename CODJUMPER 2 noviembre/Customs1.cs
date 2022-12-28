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
using static System.Windows.Forms.DataFormats;

namespace CODJUMPER_2_noviembre
{
    public partial class Customs1 : Form
    {
        public Customs1()
        {
            InitializeComponent();

            c1lblstart1.Text = SettingsCustoms1.lineC1B1mapnamefixed;
            c1lblstart2.Text = SettingsCustoms1.lineC1B2mapnamefixed;
            c1lblstart3.Text = SettingsCustoms1.lineC1B3mapnamefixed;
            c1lblstart4.Text = SettingsCustoms1.lineC1B4mapnamefixed;
            c1lblstart5.Text = SettingsCustoms1.lineC1B5mapnamefixed;
            c1lblstart6.Text = SettingsCustoms1.lineC1B6mapnamefixed;
            c1lblstart7.Text = SettingsCustoms1pt2.lineC1B7mapnamefixed;
            c1lblstart8.Text = SettingsCustoms1pt2.lineC1B8mapnamefixed;
            c1lblstart9.Text = SettingsCustoms1pt2.lineC1B9mapnamefixed;
            c1lblstart10.Text = SettingsCustoms1pt2.lineC1B10mapnamefixed;
            c1lblstart11.Text = SettingsCustoms1pt2.lineC1B11mapnamefixed;
            c1lblstart12.Text = SettingsCustoms1pt2.lineC1B12mapnamefixed;
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

        private void c1settings_Click(object sender, EventArgs e)
        {
            loadform(new SettingsCustoms1());
        }

        private void c1settings2_Click(object sender, EventArgs e)
        {
            loadform(new SettingsCustoms1pt2());
        }

        static private void start(string pathfiledtb, string cfgarg, string devmaparg, string maparg)
        {
            Process processstart = new Process();
            processstart.StartInfo.FileName = pathfiledtb;
            processstart.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + cfgarg + devmaparg + maparg + " +set r_xassetnum \"material=2560 xmodel=1200 xanim=3200 image=3000\"";
            processstart.StartInfo.CreateNoWindow = true;
            processstart.Start();

        }

        private void c1start1_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustoms1.lineC1B1cfgargument, SettingsCustoms1.lineC1B1devmapcheckbox, SettingsCustoms1.lineC1B1mapname);
        }

        private void c1start2_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustoms1.lineC1B2cfgargument, SettingsCustoms1.lineC1B2devmapcheckbox, SettingsCustoms1.lineC1B2mapname);
        }

        private void c1start3_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustoms1.lineC1B3cfgargument, SettingsCustoms1.lineC1B3devmapcheckbox, SettingsCustoms1.lineC1B3mapname);
        }

        private void c1start4_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustoms1.lineC1B4cfgargument, SettingsCustoms1.lineC1B4devmapcheckbox, SettingsCustoms1.lineC1B4mapname);
        }

        private void c1start5_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustoms1.lineC1B5cfgargument, SettingsCustoms1.lineC1B5devmapcheckbox, SettingsCustoms1.lineC1B5mapname);
        }

        private void c1start6_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustoms1.lineC1B6cfgargument, SettingsCustoms1.lineC1B6devmapcheckbox, SettingsCustoms1.lineC1B6mapname);
        }

        private void c1start7_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustoms1pt2.lineC1B7cfgargument, SettingsCustoms1pt2.lineC1B7devmapcheckbox, SettingsCustoms1pt2.lineC1B7mapname);
        }

        private void c1start8_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustoms1pt2.lineC1B8cfgargument, SettingsCustoms1pt2.lineC1B8devmapcheckbox, SettingsCustoms1pt2.lineC1B8mapname);
        }

        private void c1start9_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustoms1pt2.lineC1B9cfgargument, SettingsCustoms1pt2.lineC1B9devmapcheckbox, SettingsCustoms1pt2.lineC1B9mapname);
        }

        private void c1start10_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustoms1pt2.lineC1B10cfgargument, SettingsCustoms1pt2.lineC1B10devmapcheckbox, SettingsCustoms1pt2.lineC1B10mapname);
        }

        private void c1start11_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustoms1pt2.lineC1B11cfgargument, SettingsCustoms1pt2.lineC1B11devmapcheckbox, SettingsCustoms1pt2.lineC1B11mapname);
        }

        private void c1start12_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustoms1pt2.lineC1B12cfgargument, SettingsCustoms1pt2.lineC1B12devmapcheckbox, SettingsCustoms1pt2.lineC1B12mapname);
        }
    }
}
