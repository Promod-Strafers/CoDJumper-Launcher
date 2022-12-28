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
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace CODJUMPER_2_noviembre
{
    public partial class Custom3 : Form
    {
        public Custom3()
        {
            InitializeComponent();

            c3lblstart1.Text = SettingsCustom3.lineC3B1mapnamefixed;
            c3lblstart2.Text = SettingsCustom3.lineC3B2mapnamefixed;
            c3lblstart3.Text = SettingsCustom3.lineC3B3mapnamefixed;
            c3lblstart4.Text = SettingsCustom3.lineC3B4mapnamefixed;
            c3lblstart5.Text = SettingsCustom3.lineC3B5mapnamefixed;
            c3lblstart6.Text = SettingsCustom3.lineC3B6mapnamefixed;
            c3lblstart7.Text = SettingsCustom3pt2.lineC3B7mapnamefixed;
            c3lblstart8.Text = SettingsCustom3pt2.lineC3B8mapnamefixed;
            c3lblstart9.Text = SettingsCustom3pt2.lineC3B9mapnamefixed;
            c3lblstart10.Text = SettingsCustom3pt2.lineC3B10mapnamefixed;
            c3lblstart11.Text = SettingsCustom3pt2.lineC3B11mapnamefixed;
            c3lblstart12.Text = SettingsCustom3pt2.lineC3B12mapnamefixed;
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

        private void c3settings_Click(object sender, EventArgs e)
        {
            loadform(new SettingsCustom3());
        }

        private void c3settings2_Click(object sender, EventArgs e)
        {
            loadform(new SettingsCustom3pt2());
        }

        static private void start(string pathfiledtb, string cfgarg, string devmaparg, string maparg)
        {
            Process processstart = new Process();
            processstart.StartInfo.FileName = pathfiledtb;
            processstart.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + cfgarg + devmaparg + maparg + " +set r_xassetnum \"material=2560 xmodel=1200 xanim=3200 image=3000\"";
            processstart.StartInfo.CreateNoWindow = true;
            processstart.Start();
        }

        private void c3start1_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustom3.lineC3B1cfgargument, SettingsCustom3.lineC3B1devmapcheckbox, SettingsCustom3.lineC3B1mapname);
        }

        private void c3start2_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustom3.lineC3B2cfgargument, SettingsCustom3.lineC3B2devmapcheckbox, SettingsCustom3.lineC3B2mapname);
        }

        private void c3start3_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustom3.lineC3B3cfgargument, SettingsCustom3.lineC3B3devmapcheckbox, SettingsCustom3.lineC3B3mapname);
        }

        private void c3start4_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustom3.lineC3B4cfgargument, SettingsCustom3.lineC3B4devmapcheckbox, SettingsCustom3.lineC3B4mapname);
        }

        private void c3start5_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustom3.lineC3B5cfgargument, SettingsCustom3.lineC3B5devmapcheckbox, SettingsCustom3.lineC3B5mapname);
        }

        private void c3start6_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustom3.lineC3B6cfgargument, SettingsCustom3.lineC3B6devmapcheckbox, SettingsCustom3.lineC3B6mapname);
        }

        private void c3start7_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustom3pt2.lineC3B7cfgargument, SettingsCustom3pt2.lineC3B7devmapcheckbox, SettingsCustom3pt2.lineC3B7mapname);
        }

        private void c3start8_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustom3pt2.lineC3B8cfgargument, SettingsCustom3pt2.lineC3B8devmapcheckbox, SettingsCustom3pt2.lineC3B8mapname);
        }

        private void c3start9_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustom3pt2.lineC3B9cfgargument, SettingsCustom3pt2.lineC3B9devmapcheckbox, SettingsCustom3pt2.lineC3B9mapname);
        }

        private void c3start10_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustom3pt2.lineC3B10cfgargument, SettingsCustom3pt2.lineC3B10devmapcheckbox, SettingsCustom3pt2.lineC3B10mapname);
        }

        private void c3start11_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustom3pt2.lineC3B11cfgargument, SettingsCustom3pt2.lineC3B11devmapcheckbox, SettingsCustom3pt2.lineC3B11mapname);
        }

        private void c3start12_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustom3pt2.lineC3B12cfgargument, SettingsCustom3pt2.lineC3B12devmapcheckbox, SettingsCustom3pt2.lineC3B12mapname);
        }
    }
}
