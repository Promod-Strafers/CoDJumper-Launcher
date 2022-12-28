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
    public partial class Custom5 : Form
    {
        public Custom5()
        {
            InitializeComponent();

            c5lblstart1.Text = SettingsCustom5.lineC5B1mapnamefixed;
            c5lblstart2.Text = SettingsCustom5.lineC5B2mapnamefixed;
            c5lblstart3.Text = SettingsCustom5.lineC5B3mapnamefixed;
            c5lblstart4.Text = SettingsCustom5.lineC5B4mapnamefixed;
            c5lblstart5.Text = SettingsCustom5.lineC5B5mapnamefixed;
            c5lblstart6.Text = SettingsCustom5.lineC5B6mapnamefixed;
            c5lblstart7.Text = SettingsCustom5pt2.lineC5B7mapnamefixed;
            c5lblstart8.Text = SettingsCustom5pt2.lineC5B8mapnamefixed;
            c5lblstart9.Text = SettingsCustom5pt2.lineC5B9mapnamefixed;
            c5lblstart10.Text = SettingsCustom5pt2.lineC5B10mapnamefixed;
            c5lblstart11.Text = SettingsCustom5pt2.lineC5B11mapnamefixed;
            c5lblstart12.Text = SettingsCustom5pt2.lineC5B12mapnamefixed;
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

        private void c5settings_Click(object sender, EventArgs e)
        {
            loadform(new SettingsCustom5());
        }

        private void c5settings2_Click(object sender, EventArgs e)
        {
            loadform(new SettingsCustom5pt2());
        }

        static private void start(string pathfiledtb, string cfgarg, string devmaparg, string maparg)
        {
            Process processstart = new Process();
            processstart.StartInfo.FileName = pathfiledtb;
            processstart.StartInfo.Arguments = " +set fs_game \"mods/codjumperv3_12b" + cfgarg + devmaparg + maparg + " +set r_xassetnum \"material=2560 xmodel=1200 xanim=3200 image=3000\"";
            processstart.StartInfo.CreateNoWindow = true;
            processstart.Start();

        }

        private void c5start1_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustom5.lineC5B1cfgargument, SettingsCustom5.lineC5B1devmapcheckbox, SettingsCustom5.lineC5B1mapname);
        }

        private void c5start2_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustom5.lineC5B2cfgargument, SettingsCustom5.lineC5B2devmapcheckbox, SettingsCustom5.lineC5B2mapname);
        }

        private void c5start3_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustom5.lineC5B3cfgargument, SettingsCustom5.lineC5B3devmapcheckbox, SettingsCustom5.lineC5B3mapname);
        }

        private void c5start4_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustom5.lineC5B4cfgargument, SettingsCustom5.lineC5B4devmapcheckbox, SettingsCustom5.lineC5B4mapname);
        }

        private void c5start5_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustom5.lineC5B5cfgargument, SettingsCustom5.lineC5B5devmapcheckbox, SettingsCustom5.lineC5B5mapname);
        }

        private void c5start6_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustom5.lineC5B6cfgargument, SettingsCustom5.lineC5B6devmapcheckbox, SettingsCustom5.lineC5B6mapname);
        }

        private void c5start7_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustom5pt2.lineC5B7cfgargument, SettingsCustom5pt2.lineC5B7devmapcheckbox, SettingsCustom5pt2.lineC5B7mapname);
        }

        private void c5start8_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustom5pt2.lineC5B8cfgargument, SettingsCustom5pt2.lineC5B8devmapcheckbox, SettingsCustom5pt2.lineC5B8mapname);
        }

        private void c5start9_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustom5pt2.lineC5B9cfgargument, SettingsCustom5pt2.lineC5B9devmapcheckbox, SettingsCustom5pt2.lineC5B9mapname);
        }

        private void c5start10_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustom5pt2.lineC5B10cfgargument, SettingsCustom5pt2.lineC5B10devmapcheckbox, SettingsCustom5pt2.lineC5B10mapname);
        }

        private void c5start11_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustom5pt2.lineC5B11cfgargument, SettingsCustom5pt2.lineC5B11devmapcheckbox, SettingsCustom5pt2.lineC5B11mapname);
        }

        private void c5start12_Click(object sender, EventArgs e)
        {
            start(FormSettings.filepathdtb, SettingsCustom5pt2.lineC5B12cfgargument, SettingsCustom5pt2.lineC5B12devmapcheckbox, SettingsCustom5pt2.lineC5B12mapname);
        }
    }
}
