using System.Linq.Expressions;

namespace CODJUMPER_2_noviembre
{
    public partial class FormMain : Form
    {

        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }

        bool drag = false;
        Point start_point = new Point(0, 0);
        public FormMain()
        {
            InitializeComponent();
            hideSubMenu();

            if (Directory.Exists("./database"))
            {

                var txtdtbfilepath = ("./database/dtbfilepath.txt");

                using (var srdtbpathfile = new StreamReader(txtdtbfilepath))
                {
                    FormSettings.filepathdtb = srdtbpathfile.ReadLine();

                }

                if (File.Exists("./database/dtbsettings/dtbdefault.txt"))
                {

                    var dtbdefaultpath = ("./database/dtbsettings/dtbdefault.txt");
                    using (var srdtbdefault = new StreamReader(dtbdefaultpath))
                    {
                        FormSettings.linedevmapdefaultcheckbox = srdtbdefault.ReadLine();
                        FormSettings.linedevmapdefaultstate = srdtbdefault.ReadLine();
                        FormSettings.linecfgdefaultargument = srdtbdefault.ReadLine();
                        FormSettings.linecfgdefaultstate = srdtbdefault.ReadLine();
                    }

                }

                if (File.Exists("./database/dtbsettings/dtbpromod.txt"))
                {

                    var dtbpromodpath = ("./database/dtbsettings/dtbpromod.txt");

                    using (var srdtbpromod = new StreamReader(dtbpromodpath))
                    {
                        FormSettings.linedevmappromodcheckbox = srdtbpromod.ReadLine();
                        FormSettings.linedevmappromodstate = srdtbpromod.ReadLine();
                        FormSettings.linecfgpromodargument = srdtbpromod.ReadLine();
                        FormSettings.linecfgpromodstate = srdtbpromod.ReadLine();
                    }

                }

                if (File.Exists("./database/dtbsettings/dtbcodjumper.txt"))
                {
                    var dtbcodjumperpath = ("./database/dtbsettings/dtbcodjumper.txt");

                    using (var srdtbcodjumper = new StreamReader(dtbcodjumperpath))
                    {
                        FormSettings.linedevmapcodjumpercheckbox = srdtbcodjumper.ReadLine();
                        FormSettings.linedevmapcodjumperstate = srdtbcodjumper.ReadLine();
                        FormSettings.linecfgcodjumperargument = srdtbcodjumper.ReadLine();
                        FormSettings.linecfgcodjumperstate = srdtbcodjumper.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms1/C1B1.txt"))
                {
                    var databaseC1B1path = ("./database/dtbcustoms1/C1B1.txt");

                    using (var srdtbC1B1 = new StreamReader(databaseC1B1path))
                    {
                        SettingsCustoms1.lineC1B1devmapcheckbox = srdtbC1B1.ReadLine();
                        SettingsCustoms1.lineC1B1devmapstate = srdtbC1B1.ReadLine();
                        SettingsCustoms1.lineC1B1cfgargument = srdtbC1B1.ReadLine();
                        SettingsCustoms1.lineC1B1cfgstate = srdtbC1B1.ReadLine();
                        SettingsCustoms1.lineC1B1mapname = srdtbC1B1.ReadLine();
                        SettingsCustoms1.lineC1B1mapnamefixed = srdtbC1B1.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms1/C1B2.txt"))
                {
                    var databaseC1B2path = ("./database/dtbcustoms1/C1B2.txt");

                    using (var srdtbC1B2 = new StreamReader(databaseC1B2path))
                    {
                        SettingsCustoms1.lineC1B2devmapcheckbox = srdtbC1B2.ReadLine();
                        SettingsCustoms1.lineC1B2devmapstate = srdtbC1B2.ReadLine();
                        SettingsCustoms1.lineC1B2cfgargument = srdtbC1B2.ReadLine();
                        SettingsCustoms1.lineC1B2cfgstate = srdtbC1B2.ReadLine();
                        SettingsCustoms1.lineC1B2mapname = srdtbC1B2.ReadLine();
                        SettingsCustoms1.lineC1B2mapnamefixed = srdtbC1B2.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms1/C1B3.txt"))
                {
                    var databaseC1B3path = ("./database/dtbcustoms1/C1B3.txt");

                    using (var srdtbC1B3 = new StreamReader(databaseC1B3path))
                    {
                        SettingsCustoms1.lineC1B3devmapcheckbox = srdtbC1B3.ReadLine();
                        SettingsCustoms1.lineC1B3devmapstate = srdtbC1B3.ReadLine();
                        SettingsCustoms1.lineC1B3cfgargument = srdtbC1B3.ReadLine();
                        SettingsCustoms1.lineC1B3cfgstate = srdtbC1B3.ReadLine();
                        SettingsCustoms1.lineC1B3mapname = srdtbC1B3.ReadLine();
                        SettingsCustoms1.lineC1B3mapnamefixed = srdtbC1B3.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms1/C1B4.txt"))
                {
                    var databaseC1B4path = ("./database/dtbcustoms1/C1B4.txt");

                    using (var srdtbC1B4 = new StreamReader(databaseC1B4path))
                    {
                        SettingsCustoms1.lineC1B4devmapcheckbox = srdtbC1B4.ReadLine();
                        SettingsCustoms1.lineC1B4devmapstate = srdtbC1B4.ReadLine();
                        SettingsCustoms1.lineC1B4cfgargument = srdtbC1B4.ReadLine();
                        SettingsCustoms1.lineC1B4cfgstate = srdtbC1B4.ReadLine();
                        SettingsCustoms1.lineC1B4mapname = srdtbC1B4.ReadLine();
                        SettingsCustoms1.lineC1B4mapnamefixed = srdtbC1B4.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms1/C1B5.txt"))
                {
                    var databaseC1B5path = ("./database/dtbcustoms1/C1B5.txt");

                    using (var srdtbC1B5 = new StreamReader(databaseC1B5path))
                    {
                        SettingsCustoms1.lineC1B5devmapcheckbox = srdtbC1B5.ReadLine();
                        SettingsCustoms1.lineC1B5devmapstate = srdtbC1B5.ReadLine();
                        SettingsCustoms1.lineC1B5cfgargument = srdtbC1B5.ReadLine();
                        SettingsCustoms1.lineC1B5cfgstate = srdtbC1B5.ReadLine();
                        SettingsCustoms1.lineC1B5mapname = srdtbC1B5.ReadLine();
                        SettingsCustoms1.lineC1B5mapnamefixed = srdtbC1B5.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms1/C1B6.txt"))
                {
                    var databaseC1B6path = ("./database/dtbcustoms1/C1B6.txt");

                    using (var srdtbC1B6 = new StreamReader(databaseC1B6path))
                    {
                        SettingsCustoms1.lineC1B6devmapcheckbox = srdtbC1B6.ReadLine();
                        SettingsCustoms1.lineC1B6devmapstate = srdtbC1B6.ReadLine();
                        SettingsCustoms1.lineC1B6cfgargument = srdtbC1B6.ReadLine();
                        SettingsCustoms1.lineC1B6cfgstate = srdtbC1B6.ReadLine();
                        SettingsCustoms1.lineC1B6mapname = srdtbC1B6.ReadLine();
                        SettingsCustoms1.lineC1B6mapnamefixed = srdtbC1B6.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms1/C1B7.txt"))
                {
                    var databaseC1B7path = ("./database/dtbcustoms1/C1B7.txt");

                    using (var srdtbC1B7 = new StreamReader(databaseC1B7path))
                    {
                        SettingsCustoms1pt2.lineC1B7devmapcheckbox = srdtbC1B7.ReadLine();
                        SettingsCustoms1pt2.lineC1B7devmapstate = srdtbC1B7.ReadLine();
                        SettingsCustoms1pt2.lineC1B7cfgargument = srdtbC1B7.ReadLine();
                        SettingsCustoms1pt2.lineC1B7cfgstate = srdtbC1B7.ReadLine();
                        SettingsCustoms1pt2.lineC1B7mapname = srdtbC1B7.ReadLine();
                        SettingsCustoms1pt2.lineC1B7mapnamefixed = srdtbC1B7.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms1/C1B8.txt"))
                {
                    var databaseC1B8path = ("./database/dtbcustoms1/C1B8.txt");

                    using (var srdtbC1B8 = new StreamReader(databaseC1B8path))
                    {
                        SettingsCustoms1pt2.lineC1B8devmapcheckbox = srdtbC1B8.ReadLine();
                        SettingsCustoms1pt2.lineC1B8devmapstate = srdtbC1B8.ReadLine();
                        SettingsCustoms1pt2.lineC1B8cfgargument = srdtbC1B8.ReadLine();
                        SettingsCustoms1pt2.lineC1B8cfgstate = srdtbC1B8.ReadLine();
                        SettingsCustoms1pt2.lineC1B8mapname = srdtbC1B8.ReadLine();
                        SettingsCustoms1pt2.lineC1B8mapnamefixed = srdtbC1B8.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms1/C1B9.txt"))
                {
                    var databaseC1B9path = ("./database/dtbcustoms1/C1B9.txt");

                    using (var srdtbC1B9 = new StreamReader(databaseC1B9path))
                    {
                        SettingsCustoms1pt2.lineC1B9devmapcheckbox = srdtbC1B9.ReadLine();
                        SettingsCustoms1pt2.lineC1B9devmapstate = srdtbC1B9.ReadLine();
                        SettingsCustoms1pt2.lineC1B9cfgargument = srdtbC1B9.ReadLine();
                        SettingsCustoms1pt2.lineC1B9cfgstate = srdtbC1B9.ReadLine();
                        SettingsCustoms1pt2.lineC1B9mapname = srdtbC1B9.ReadLine();
                        SettingsCustoms1pt2.lineC1B9mapnamefixed = srdtbC1B9.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms1/C1B10.txt"))
                {
                    var databaseC1B10path = ("./database/dtbcustoms1/C1B10.txt");

                    using (var srdtbC1B10 = new StreamReader(databaseC1B10path))
                    {
                        SettingsCustoms1pt2.lineC1B10devmapcheckbox = srdtbC1B10.ReadLine();
                        SettingsCustoms1pt2.lineC1B10devmapstate = srdtbC1B10.ReadLine();
                        SettingsCustoms1pt2.lineC1B10cfgargument = srdtbC1B10.ReadLine();
                        SettingsCustoms1pt2.lineC1B10cfgstate = srdtbC1B10.ReadLine();
                        SettingsCustoms1pt2.lineC1B10mapname = srdtbC1B10.ReadLine();
                        SettingsCustoms1pt2.lineC1B10mapnamefixed = srdtbC1B10.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms1/C1B11.txt"))
                {
                    var databaseC1B11path = ("./database/dtbcustoms1/C1B11.txt");

                    using (var srdtbC1B11 = new StreamReader(databaseC1B11path))
                    {
                        SettingsCustoms1pt2.lineC1B11devmapcheckbox = srdtbC1B11.ReadLine();
                        SettingsCustoms1pt2.lineC1B11devmapstate = srdtbC1B11.ReadLine();
                        SettingsCustoms1pt2.lineC1B11cfgargument = srdtbC1B11.ReadLine();
                        SettingsCustoms1pt2.lineC1B11cfgstate = srdtbC1B11.ReadLine();
                        SettingsCustoms1pt2.lineC1B11mapname = srdtbC1B11.ReadLine();
                        SettingsCustoms1pt2.lineC1B11mapnamefixed = srdtbC1B11.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms1/C1B12.txt"))
                {
                    var databaseC1B12path = ("./database/dtbcustoms1/C1B12.txt");

                    using (var srdtbC1B12 = new StreamReader(databaseC1B12path))
                    {
                        SettingsCustoms1pt2.lineC1B12devmapcheckbox = srdtbC1B12.ReadLine();
                        SettingsCustoms1pt2.lineC1B12devmapstate = srdtbC1B12.ReadLine();
                        SettingsCustoms1pt2.lineC1B12cfgargument = srdtbC1B12.ReadLine();
                        SettingsCustoms1pt2.lineC1B12cfgstate = srdtbC1B12.ReadLine();
                        SettingsCustoms1pt2.lineC1B12mapname = srdtbC1B12.ReadLine();
                        SettingsCustoms1pt2.lineC1B12mapnamefixed = srdtbC1B12.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms2/C2B1.txt"))
                {
                    var databaseC2B1path = ("./database/dtbcustoms2/C2B1.txt");

                    using (var srdtbC2B1 = new StreamReader(databaseC2B1path))
                    {
                        SettingsCustoms2.lineC2B1devmapcheckbox = srdtbC2B1.ReadLine();
                        SettingsCustoms2.lineC2B1devmapstate = srdtbC2B1.ReadLine();
                        SettingsCustoms2.lineC2B1cfgargument = srdtbC2B1.ReadLine();
                        SettingsCustoms2.lineC2B1cfgstate = srdtbC2B1.ReadLine();
                        SettingsCustoms2.lineC2B1mapname = srdtbC2B1.ReadLine();
                        SettingsCustoms2.lineC2B1mapnamefixed = srdtbC2B1.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms2/C2B2.txt"))
                {
                    var databaseC2B2path = ("./database/dtbcustoms2/C2B2.txt");

                    using (var srdtbC2B2 = new StreamReader(databaseC2B2path))
                    {
                        SettingsCustoms2.lineC2B2devmapcheckbox = srdtbC2B2.ReadLine();
                        SettingsCustoms2.lineC2B2devmapstate = srdtbC2B2.ReadLine();
                        SettingsCustoms2.lineC2B2cfgargument = srdtbC2B2.ReadLine();
                        SettingsCustoms2.lineC2B2cfgstate = srdtbC2B2.ReadLine();
                        SettingsCustoms2.lineC2B2mapname = srdtbC2B2.ReadLine();
                        SettingsCustoms2.lineC2B2mapnamefixed = srdtbC2B2.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms2/C2B3.txt"))
                {
                    var databaseC2B3path = ("./database/dtbcustoms2/C2B3.txt");

                    using (var srdtbC2B3 = new StreamReader(databaseC2B3path))
                    {
                        SettingsCustoms2.lineC2B3devmapcheckbox = srdtbC2B3.ReadLine();
                        SettingsCustoms2.lineC2B3devmapstate = srdtbC2B3.ReadLine();
                        SettingsCustoms2.lineC2B3cfgargument = srdtbC2B3.ReadLine();
                        SettingsCustoms2.lineC2B3cfgstate = srdtbC2B3.ReadLine();
                        SettingsCustoms2.lineC2B3mapname = srdtbC2B3.ReadLine();
                        SettingsCustoms2.lineC2B3mapnamefixed = srdtbC2B3.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms2/C2B4.txt"))
                {
                    var databaseC2B4path = ("./database/dtbcustoms2/C2B4.txt");

                    using (var srdtbC2B4 = new StreamReader(databaseC2B4path))
                    {
                        SettingsCustoms2.lineC2B4devmapcheckbox = srdtbC2B4.ReadLine();
                        SettingsCustoms2.lineC2B4devmapstate = srdtbC2B4.ReadLine();
                        SettingsCustoms2.lineC2B4cfgargument = srdtbC2B4.ReadLine();
                        SettingsCustoms2.lineC2B4cfgstate = srdtbC2B4.ReadLine();
                        SettingsCustoms2.lineC2B4mapname = srdtbC2B4.ReadLine();
                        SettingsCustoms2.lineC2B4mapnamefixed = srdtbC2B4.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms2/C2B5.txt"))
                {
                    var databaseC2B5path = ("./database/dtbcustoms2/C2B5.txt");

                    using (var srdtbC2B5 = new StreamReader(databaseC2B5path))
                    {
                        SettingsCustoms2.lineC2B5devmapcheckbox = srdtbC2B5.ReadLine();
                        SettingsCustoms2.lineC2B5devmapstate = srdtbC2B5.ReadLine();
                        SettingsCustoms2.lineC2B5cfgargument = srdtbC2B5.ReadLine();
                        SettingsCustoms2.lineC2B5cfgstate = srdtbC2B5.ReadLine();
                        SettingsCustoms2.lineC2B5mapname = srdtbC2B5.ReadLine();
                        SettingsCustoms2.lineC2B5mapnamefixed = srdtbC2B5.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms2/C2B6.txt"))
                {
                    var databaseC2B6path = ("./database/dtbcustoms2/C2B6.txt");

                    using (var srdtbC2B6 = new StreamReader(databaseC2B6path))
                    {
                        SettingsCustoms2.lineC2B6devmapcheckbox = srdtbC2B6.ReadLine();
                        SettingsCustoms2.lineC2B6devmapstate = srdtbC2B6.ReadLine();
                        SettingsCustoms2.lineC2B6cfgargument = srdtbC2B6.ReadLine();
                        SettingsCustoms2.lineC2B6cfgstate = srdtbC2B6.ReadLine();
                        SettingsCustoms2.lineC2B6mapname = srdtbC2B6.ReadLine();
                        SettingsCustoms2.lineC2B6mapnamefixed = srdtbC2B6.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms2/C2B7.txt"))
                {
                    var databaseC2B7path = ("./database/dtbcustoms2/C2B7.txt");

                    using (var srdtbC2B7 = new StreamReader(databaseC2B7path))
                    {
                        SettingsCustoms2pt2.lineC2B7devmapcheckbox = srdtbC2B7.ReadLine();
                        SettingsCustoms2pt2.lineC2B7devmapstate = srdtbC2B7.ReadLine();
                        SettingsCustoms2pt2.lineC2B7cfgargument = srdtbC2B7.ReadLine();
                        SettingsCustoms2pt2.lineC2B7cfgstate = srdtbC2B7.ReadLine();
                        SettingsCustoms2pt2.lineC2B7mapname = srdtbC2B7.ReadLine();
                        SettingsCustoms2pt2.lineC2B7mapnamefixed = srdtbC2B7.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms2/C2B8.txt"))
                {
                    var databaseC2B8path = ("./database/dtbcustoms2/C2B8.txt");

                    using (var srdtbC2B8 = new StreamReader(databaseC2B8path))
                    {
                        SettingsCustoms2pt2.lineC2B8devmapcheckbox = srdtbC2B8.ReadLine();
                        SettingsCustoms2pt2.lineC2B8devmapstate = srdtbC2B8.ReadLine();
                        SettingsCustoms2pt2.lineC2B8cfgargument = srdtbC2B8.ReadLine();
                        SettingsCustoms2pt2.lineC2B8cfgstate = srdtbC2B8.ReadLine();
                        SettingsCustoms2pt2.lineC2B8mapname = srdtbC2B8.ReadLine();
                        SettingsCustoms2pt2.lineC2B8mapnamefixed = srdtbC2B8.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms2/C2B9.txt"))
                {
                    var databaseC2B9path = ("./database/dtbcustoms2/C2B9.txt");

                    using (var srdtbC2B9 = new StreamReader(databaseC2B9path))
                    {
                        SettingsCustoms2pt2.lineC2B9devmapcheckbox = srdtbC2B9.ReadLine();
                        SettingsCustoms2pt2.lineC2B9devmapstate = srdtbC2B9.ReadLine();
                        SettingsCustoms2pt2.lineC2B9cfgargument = srdtbC2B9.ReadLine();
                        SettingsCustoms2pt2.lineC2B9cfgstate = srdtbC2B9.ReadLine();
                        SettingsCustoms2pt2.lineC2B9mapname = srdtbC2B9.ReadLine();
                        SettingsCustoms2pt2.lineC2B9mapnamefixed = srdtbC2B9.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms2/C2B10.txt"))
                {
                    var databaseC2B10path = ("./database/dtbcustoms2/C2B10.txt");

                    using (var srdtbC2B10 = new StreamReader(databaseC2B10path))
                    {
                        SettingsCustoms2pt2.lineC2B10devmapcheckbox = srdtbC2B10.ReadLine();
                        SettingsCustoms2pt2.lineC2B10devmapstate = srdtbC2B10.ReadLine();
                        SettingsCustoms2pt2.lineC2B10cfgargument = srdtbC2B10.ReadLine();
                        SettingsCustoms2pt2.lineC2B10cfgstate = srdtbC2B10.ReadLine();
                        SettingsCustoms2pt2.lineC2B10mapname = srdtbC2B10.ReadLine();
                        SettingsCustoms2pt2.lineC2B10mapnamefixed = srdtbC2B10.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms2/C2B11.txt"))
                {
                    var databaseC2B11path = ("./database/dtbcustoms2/C2B11.txt");

                    using (var srdtbC2B11 = new StreamReader(databaseC2B11path))
                    {
                        SettingsCustoms2pt2.lineC2B11devmapcheckbox = srdtbC2B11.ReadLine();
                        SettingsCustoms2pt2.lineC2B11devmapstate = srdtbC2B11.ReadLine();
                        SettingsCustoms2pt2.lineC2B11cfgargument = srdtbC2B11.ReadLine();
                        SettingsCustoms2pt2.lineC2B11cfgstate = srdtbC2B11.ReadLine();
                        SettingsCustoms2pt2.lineC2B11mapname = srdtbC2B11.ReadLine();
                        SettingsCustoms2pt2.lineC2B11mapnamefixed = srdtbC2B11.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms2/C2B12.txt"))
                {
                    var databaseC2B12path = ("./database/dtbcustoms2/C2B12.txt");

                    using (var srdtbC2B12 = new StreamReader(databaseC2B12path))
                    {
                        SettingsCustoms2pt2.lineC2B12devmapcheckbox = srdtbC2B12.ReadLine();
                        SettingsCustoms2pt2.lineC2B12devmapstate = srdtbC2B12.ReadLine();
                        SettingsCustoms2pt2.lineC2B12cfgargument = srdtbC2B12.ReadLine();
                        SettingsCustoms2pt2.lineC2B12cfgstate = srdtbC2B12.ReadLine();
                        SettingsCustoms2pt2.lineC2B12mapname = srdtbC2B12.ReadLine();
                        SettingsCustoms2pt2.lineC2B12mapnamefixed = srdtbC2B12.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms3/C3B1.txt"))
                {
                    var databaseC3B1path = ("./database/dtbcustoms3/C3B1.txt");

                    using (var srdtbC3B1 = new StreamReader(databaseC3B1path))
                    {
                        SettingsCustom3.lineC3B1devmapcheckbox = srdtbC3B1.ReadLine();
                        SettingsCustom3.lineC3B1devmapstate = srdtbC3B1.ReadLine();
                        SettingsCustom3.lineC3B1cfgargument = srdtbC3B1.ReadLine();
                        SettingsCustom3.lineC3B1cfgstate = srdtbC3B1.ReadLine();
                        SettingsCustom3.lineC3B1mapname = srdtbC3B1.ReadLine();
                        SettingsCustom3.lineC3B1mapnamefixed = srdtbC3B1.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms3/C3B2.txt"))
                {
                    var databaseC3B2path = ("./database/dtbcustoms3/C3B2.txt");

                    using (var srdtbC3B2 = new StreamReader(databaseC3B2path))
                    {
                        SettingsCustom3.lineC3B2devmapcheckbox = srdtbC3B2.ReadLine();
                        SettingsCustom3.lineC3B2devmapstate = srdtbC3B2.ReadLine();
                        SettingsCustom3.lineC3B2cfgargument = srdtbC3B2.ReadLine();
                        SettingsCustom3.lineC3B2cfgstate = srdtbC3B2.ReadLine();
                        SettingsCustom3.lineC3B2mapname = srdtbC3B2.ReadLine();
                        SettingsCustom3.lineC3B2mapnamefixed = srdtbC3B2.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms3/C3B3.txt"))
                {
                    var databaseC3B3path = ("./database/dtbcustoms3/C3B3.txt");

                    using (var srdtbC3B3 = new StreamReader(databaseC3B3path))
                    {
                        SettingsCustom3.lineC3B3devmapcheckbox = srdtbC3B3.ReadLine();
                        SettingsCustom3.lineC3B3devmapstate = srdtbC3B3.ReadLine();
                        SettingsCustom3.lineC3B3cfgargument = srdtbC3B3.ReadLine();
                        SettingsCustom3.lineC3B3cfgstate = srdtbC3B3.ReadLine();
                        SettingsCustom3.lineC3B3mapname = srdtbC3B3.ReadLine();
                        SettingsCustom3.lineC3B3mapnamefixed = srdtbC3B3.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms3/C3B4.txt"))
                {
                    var databaseC3B4path = ("./database/dtbcustoms3/C3B4.txt");

                    using (var srdtbC3B4 = new StreamReader(databaseC3B4path))
                    {
                        SettingsCustom3.lineC3B4devmapcheckbox = srdtbC3B4.ReadLine();
                        SettingsCustom3.lineC3B4devmapstate = srdtbC3B4.ReadLine();
                        SettingsCustom3.lineC3B4cfgargument = srdtbC3B4.ReadLine();
                        SettingsCustom3.lineC3B4cfgstate = srdtbC3B4.ReadLine();
                        SettingsCustom3.lineC3B4mapname = srdtbC3B4.ReadLine();
                        SettingsCustom3.lineC3B4mapnamefixed = srdtbC3B4.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms3/C3B5.txt"))
                {
                    var databaseC3B5path = ("./database/dtbcustoms3/C3B5.txt");

                    using (var srdtbC3B5 = new StreamReader(databaseC3B5path))
                    {
                        SettingsCustom3.lineC3B5devmapcheckbox = srdtbC3B5.ReadLine();
                        SettingsCustom3.lineC3B5devmapstate = srdtbC3B5.ReadLine();
                        SettingsCustom3.lineC3B5cfgargument = srdtbC3B5.ReadLine();
                        SettingsCustom3.lineC3B5cfgstate = srdtbC3B5.ReadLine();
                        SettingsCustom3.lineC3B5mapname = srdtbC3B5.ReadLine();
                        SettingsCustom3.lineC3B5mapnamefixed = srdtbC3B5.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms3/C3B6.txt"))
                {
                    var databaseC3B6path = ("./database/dtbcustoms3/C3B6.txt");

                    using (var srdtbC3B6 = new StreamReader(databaseC3B6path))
                    {
                        SettingsCustom3.lineC3B6devmapcheckbox = srdtbC3B6.ReadLine();
                        SettingsCustom3.lineC3B6devmapstate = srdtbC3B6.ReadLine();
                        SettingsCustom3.lineC3B6cfgargument = srdtbC3B6.ReadLine();
                        SettingsCustom3.lineC3B6cfgstate = srdtbC3B6.ReadLine();
                        SettingsCustom3.lineC3B6mapname = srdtbC3B6.ReadLine();
                        SettingsCustom3.lineC3B6mapnamefixed = srdtbC3B6.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms3/C3B7.txt"))
                {
                    var databaseC3B7path = ("./database/dtbcustoms3/C3B7.txt");

                    using (var srdtbC3B7 = new StreamReader(databaseC3B7path))
                    {
                        SettingsCustom3pt2.lineC3B7devmapcheckbox = srdtbC3B7.ReadLine();
                        SettingsCustom3pt2.lineC3B7devmapstate = srdtbC3B7.ReadLine();
                        SettingsCustom3pt2.lineC3B7cfgargument = srdtbC3B7.ReadLine();
                        SettingsCustom3pt2.lineC3B7cfgstate = srdtbC3B7.ReadLine();
                        SettingsCustom3pt2.lineC3B7mapname = srdtbC3B7.ReadLine();
                        SettingsCustom3pt2.lineC3B7mapnamefixed = srdtbC3B7.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms3/C3B8.txt"))
                {
                    var databaseC3B8path = ("./database/dtbcustoms3/C3B8.txt");

                    using (var srdtbC3B8 = new StreamReader(databaseC3B8path))
                    {
                        SettingsCustom3pt2.lineC3B8devmapcheckbox = srdtbC3B8.ReadLine();
                        SettingsCustom3pt2.lineC3B8devmapstate = srdtbC3B8.ReadLine();
                        SettingsCustom3pt2.lineC3B8cfgargument = srdtbC3B8.ReadLine();
                        SettingsCustom3pt2.lineC3B8cfgstate = srdtbC3B8.ReadLine();
                        SettingsCustom3pt2.lineC3B8mapname = srdtbC3B8.ReadLine();
                        SettingsCustom3pt2.lineC3B8mapnamefixed = srdtbC3B8.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms3/C3B9.txt"))
                {
                    var databaseC3B9path = ("./database/dtbcustoms3/C3B9.txt");

                    using (var srdtbC3B9 = new StreamReader(databaseC3B9path))
                    {
                        SettingsCustom3pt2.lineC3B9devmapcheckbox = srdtbC3B9.ReadLine();
                        SettingsCustom3pt2.lineC3B9devmapstate = srdtbC3B9.ReadLine();
                        SettingsCustom3pt2.lineC3B9cfgargument = srdtbC3B9.ReadLine();
                        SettingsCustom3pt2.lineC3B9cfgstate = srdtbC3B9.ReadLine();
                        SettingsCustom3pt2.lineC3B9mapname = srdtbC3B9.ReadLine();
                        SettingsCustom3pt2.lineC3B9mapnamefixed = srdtbC3B9.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms3/C3B10.txt"))
                {
                    var databaseC3B10path = ("./database/dtbcustoms3/C3B10.txt");

                    using (var srdtbC3B10 = new StreamReader(databaseC3B10path))
                    {
                        SettingsCustom3pt2.lineC3B10devmapcheckbox = srdtbC3B10.ReadLine();
                        SettingsCustom3pt2.lineC3B10devmapstate = srdtbC3B10.ReadLine();
                        SettingsCustom3pt2.lineC3B10cfgargument = srdtbC3B10.ReadLine();
                        SettingsCustom3pt2.lineC3B10cfgstate = srdtbC3B10.ReadLine();
                        SettingsCustom3pt2.lineC3B10mapname = srdtbC3B10.ReadLine();
                        SettingsCustom3pt2.lineC3B10mapnamefixed = srdtbC3B10.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms3/C3B11.txt"))
                {
                    var databaseC3B11path = ("./database/dtbcustoms3/C3B11.txt");

                    using (var srdtbC3B11 = new StreamReader(databaseC3B11path))
                    {
                        SettingsCustom3pt2.lineC3B11devmapcheckbox = srdtbC3B11.ReadLine();
                        SettingsCustom3pt2.lineC3B11devmapstate = srdtbC3B11.ReadLine();
                        SettingsCustom3pt2.lineC3B11cfgargument = srdtbC3B11.ReadLine();
                        SettingsCustom3pt2.lineC3B11cfgstate = srdtbC3B11.ReadLine();
                        SettingsCustom3pt2.lineC3B11mapname = srdtbC3B11.ReadLine();
                        SettingsCustom3pt2.lineC3B11mapnamefixed = srdtbC3B11.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms3/C3B12.txt"))
                {
                    var databaseC3B12path = ("./database/dtbcustoms3/C3B12.txt");

                    using (var srdtbC3B12 = new StreamReader(databaseC3B12path))
                    {
                        SettingsCustom3pt2.lineC3B12devmapcheckbox = srdtbC3B12.ReadLine();
                        SettingsCustom3pt2.lineC3B12devmapstate = srdtbC3B12.ReadLine();
                        SettingsCustom3pt2.lineC3B12cfgargument = srdtbC3B12.ReadLine();
                        SettingsCustom3pt2.lineC3B12cfgstate = srdtbC3B12.ReadLine();
                        SettingsCustom3pt2.lineC3B12mapname = srdtbC3B12.ReadLine();
                        SettingsCustom3pt2.lineC3B12mapnamefixed = srdtbC3B12.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms4/C4B1.txt"))
                {
                    var databaseC4B1path = ("./database/dtbcustoms4/C4B1.txt");

                    using (var srdtbC4B1 = new StreamReader(databaseC4B1path))
                    {
                        SettingsCustom4.lineC4B1devmapcheckbox = srdtbC4B1.ReadLine();
                        SettingsCustom4.lineC4B1devmapstate = srdtbC4B1.ReadLine();
                        SettingsCustom4.lineC4B1cfgargument = srdtbC4B1.ReadLine();
                        SettingsCustom4.lineC4B1cfgstate = srdtbC4B1.ReadLine();
                        SettingsCustom4.lineC4B1mapname = srdtbC4B1.ReadLine();
                        SettingsCustom4.lineC4B1mapnamefixed = srdtbC4B1.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms4/C4B2.txt"))
                {
                    var databaseC4B2path = ("./database/dtbcustoms4/C4B2.txt");

                    using (var srdtbC4B2 = new StreamReader(databaseC4B2path))
                    {
                        SettingsCustom4.lineC4B2devmapcheckbox = srdtbC4B2.ReadLine();
                        SettingsCustom4.lineC4B2devmapstate = srdtbC4B2.ReadLine();
                        SettingsCustom4.lineC4B2cfgargument = srdtbC4B2.ReadLine();
                        SettingsCustom4.lineC4B2cfgstate = srdtbC4B2.ReadLine();
                        SettingsCustom4.lineC4B2mapname = srdtbC4B2.ReadLine();
                        SettingsCustom4.lineC4B2mapnamefixed = srdtbC4B2.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms4/C4B3.txt"))
                {
                    var databaseC4B3path = ("./database/dtbcustoms4/C4B3.txt");

                    using (var srdtbC4B3 = new StreamReader(databaseC4B3path))
                    {
                        SettingsCustom4.lineC4B3devmapcheckbox = srdtbC4B3.ReadLine();
                        SettingsCustom4.lineC4B3devmapstate = srdtbC4B3.ReadLine();
                        SettingsCustom4.lineC4B3cfgargument = srdtbC4B3.ReadLine();
                        SettingsCustom4.lineC4B3cfgstate = srdtbC4B3.ReadLine();
                        SettingsCustom4.lineC4B3mapname = srdtbC4B3.ReadLine();
                        SettingsCustom4.lineC4B3mapnamefixed = srdtbC4B3.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms4/C4B4.txt"))
                {
                    var databaseC4B4path = ("./database/dtbcustoms4/C4B4.txt");

                    using (var srdtbC4B4 = new StreamReader(databaseC4B4path))
                    {
                        SettingsCustom4.lineC4B4devmapcheckbox = srdtbC4B4.ReadLine();
                        SettingsCustom4.lineC4B4devmapstate = srdtbC4B4.ReadLine();
                        SettingsCustom4.lineC4B4cfgargument = srdtbC4B4.ReadLine();
                        SettingsCustom4.lineC4B4cfgstate = srdtbC4B4.ReadLine();
                        SettingsCustom4.lineC4B4mapname = srdtbC4B4.ReadLine();
                        SettingsCustom4.lineC4B4mapnamefixed = srdtbC4B4.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms4/C4B5.txt"))
                {
                    var databaseC4B5path = ("./database/dtbcustoms4/C4B5.txt");

                    using (var srdtbC4B5 = new StreamReader(databaseC4B5path))
                    {
                        SettingsCustom4.lineC4B5devmapcheckbox = srdtbC4B5.ReadLine();
                        SettingsCustom4.lineC4B5devmapstate = srdtbC4B5.ReadLine();
                        SettingsCustom4.lineC4B5cfgargument = srdtbC4B5.ReadLine();
                        SettingsCustom4.lineC4B5cfgstate = srdtbC4B5.ReadLine();
                        SettingsCustom4.lineC4B5mapname = srdtbC4B5.ReadLine();
                        SettingsCustom4.lineC4B5mapnamefixed = srdtbC4B5.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms4/C4B6.txt"))
                {
                    var databaseC4B6path = ("./database/dtbcustoms4/C4B6.txt");

                    using (var srdtbC4B6 = new StreamReader(databaseC4B6path))
                    {
                        SettingsCustom4.lineC4B6devmapcheckbox = srdtbC4B6.ReadLine();
                        SettingsCustom4.lineC4B6devmapstate = srdtbC4B6.ReadLine();
                        SettingsCustom4.lineC4B6cfgargument = srdtbC4B6.ReadLine();
                        SettingsCustom4.lineC4B6cfgstate = srdtbC4B6.ReadLine();
                        SettingsCustom4.lineC4B6mapname = srdtbC4B6.ReadLine();
                        SettingsCustom4.lineC4B6mapnamefixed = srdtbC4B6.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms4/C4B7.txt"))
                {
                    var databaseC4B7path = ("./database/dtbcustoms4/C4B7.txt");

                    using (var srdtbC4B7 = new StreamReader(databaseC4B7path))
                    {
                        SettingsCustom4pt2.lineC4B7devmapcheckbox = srdtbC4B7.ReadLine();
                        SettingsCustom4pt2.lineC4B7devmapstate = srdtbC4B7.ReadLine();
                        SettingsCustom4pt2.lineC4B7cfgargument = srdtbC4B7.ReadLine();
                        SettingsCustom4pt2.lineC4B7cfgstate = srdtbC4B7.ReadLine();
                        SettingsCustom4pt2.lineC4B7mapname = srdtbC4B7.ReadLine();
                        SettingsCustom4pt2.lineC4B7mapnamefixed = srdtbC4B7.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms4/C4B8.txt"))
                {
                    var databaseC4B8path = ("./database/dtbcustoms4/C4B8.txt");

                    using (var srdtbC4B8 = new StreamReader(databaseC4B8path))
                    {
                        SettingsCustom4pt2.lineC4B8devmapcheckbox = srdtbC4B8.ReadLine();
                        SettingsCustom4pt2.lineC4B8devmapstate = srdtbC4B8.ReadLine();
                        SettingsCustom4pt2.lineC4B8cfgargument = srdtbC4B8.ReadLine();
                        SettingsCustom4pt2.lineC4B8cfgstate = srdtbC4B8.ReadLine();
                        SettingsCustom4pt2.lineC4B8mapname = srdtbC4B8.ReadLine();
                        SettingsCustom4pt2.lineC4B8mapnamefixed = srdtbC4B8.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms4/C4B9.txt"))
                {
                    var databaseC4B9path = ("./database/dtbcustoms4/C4B9.txt");

                    using (var srdtbC4B9 = new StreamReader(databaseC4B9path))
                    {
                        SettingsCustom4pt2.lineC4B9devmapcheckbox = srdtbC4B9.ReadLine();
                        SettingsCustom4pt2.lineC4B9devmapstate = srdtbC4B9.ReadLine();
                        SettingsCustom4pt2.lineC4B9cfgargument = srdtbC4B9.ReadLine();
                        SettingsCustom4pt2.lineC4B9cfgstate = srdtbC4B9.ReadLine();
                        SettingsCustom4pt2.lineC4B9mapname = srdtbC4B9.ReadLine();
                        SettingsCustom4pt2.lineC4B9mapnamefixed = srdtbC4B9.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms4/C4B10.txt"))
                {
                    var databaseC4B10path = ("./database/dtbcustoms4/C4B10.txt");

                    using (var srdtbC4B10 = new StreamReader(databaseC4B10path))
                    {
                        SettingsCustom4pt2.lineC4B10devmapcheckbox = srdtbC4B10.ReadLine();
                        SettingsCustom4pt2.lineC4B10devmapstate = srdtbC4B10.ReadLine();
                        SettingsCustom4pt2.lineC4B10cfgargument = srdtbC4B10.ReadLine();
                        SettingsCustom4pt2.lineC4B10cfgstate = srdtbC4B10.ReadLine();
                        SettingsCustom4pt2.lineC4B10mapname = srdtbC4B10.ReadLine();
                        SettingsCustom4pt2.lineC4B10mapnamefixed = srdtbC4B10.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms4/C4B11.txt"))
                {
                    var databaseC4B11path = ("./database/dtbcustoms4/C4B11.txt");

                    using (var srdtbC4B11 = new StreamReader(databaseC4B11path))
                    {
                        SettingsCustom4pt2.lineC4B11devmapcheckbox = srdtbC4B11.ReadLine();
                        SettingsCustom4pt2.lineC4B11devmapstate = srdtbC4B11.ReadLine();
                        SettingsCustom4pt2.lineC4B11cfgargument = srdtbC4B11.ReadLine();
                        SettingsCustom4pt2.lineC4B11cfgstate = srdtbC4B11.ReadLine();
                        SettingsCustom4pt2.lineC4B11mapname = srdtbC4B11.ReadLine();
                        SettingsCustom4pt2.lineC4B11mapnamefixed = srdtbC4B11.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms4/C4B12.txt"))
                {
                    var databaseC4B12path = ("./database/dtbcustoms4/C4B12.txt");

                    using (var srdtbC4B12 = new StreamReader(databaseC4B12path))
                    {
                        SettingsCustom4pt2.lineC4B12devmapcheckbox = srdtbC4B12.ReadLine();
                        SettingsCustom4pt2.lineC4B12devmapstate = srdtbC4B12.ReadLine();
                        SettingsCustom4pt2.lineC4B12cfgargument = srdtbC4B12.ReadLine();
                        SettingsCustom4pt2.lineC4B12cfgstate = srdtbC4B12.ReadLine();
                        SettingsCustom4pt2.lineC4B12mapname = srdtbC4B12.ReadLine();
                        SettingsCustom4pt2.lineC4B12mapnamefixed = srdtbC4B12.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms5/C5B1.txt"))
                {
                    var databaseC5B1path = ("./database/dtbcustoms5/C5B1.txt");

                    using (var srdtbC5B1 = new StreamReader(databaseC5B1path))
                    {
                        SettingsCustom5.lineC5B1devmapcheckbox = srdtbC5B1.ReadLine();
                        SettingsCustom5.lineC5B1devmapstate = srdtbC5B1.ReadLine();
                        SettingsCustom5.lineC5B1cfgargument = srdtbC5B1.ReadLine();
                        SettingsCustom5.lineC5B1cfgstate = srdtbC5B1.ReadLine();
                        SettingsCustom5.lineC5B1mapname = srdtbC5B1.ReadLine();
                        SettingsCustom5.lineC5B1mapnamefixed = srdtbC5B1.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms5/C5B2.txt"))
                {
                    var databaseC5B2path = ("./database/dtbcustoms5/C5B2.txt");

                    using (var srdtbC5B2 = new StreamReader(databaseC5B2path))
                    {
                        SettingsCustom5.lineC5B2devmapcheckbox = srdtbC5B2.ReadLine();
                        SettingsCustom5.lineC5B2devmapstate = srdtbC5B2.ReadLine();
                        SettingsCustom5.lineC5B2cfgargument = srdtbC5B2.ReadLine();
                        SettingsCustom5.lineC5B2cfgstate = srdtbC5B2.ReadLine();
                        SettingsCustom5.lineC5B2mapname = srdtbC5B2.ReadLine();
                        SettingsCustom5.lineC5B2mapnamefixed = srdtbC5B2.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms5/C5B3.txt"))
                {
                    var databaseC5B3path = ("./database/dtbcustoms5/C5B3.txt");

                    using (var srdtbC5B3 = new StreamReader(databaseC5B3path))
                    {
                        SettingsCustom5.lineC5B3devmapcheckbox = srdtbC5B3.ReadLine();
                        SettingsCustom5.lineC5B3devmapstate = srdtbC5B3.ReadLine();
                        SettingsCustom5.lineC5B3cfgargument = srdtbC5B3.ReadLine();
                        SettingsCustom5.lineC5B3cfgstate = srdtbC5B3.ReadLine();
                        SettingsCustom5.lineC5B3mapname = srdtbC5B3.ReadLine();
                        SettingsCustom5.lineC5B3mapnamefixed = srdtbC5B3.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms5/C5B4.txt"))
                {
                    var databaseC5B4path = ("./database/dtbcustoms5/C5B4.txt");

                    using (var srdtbC5B4 = new StreamReader(databaseC5B4path))
                    {
                        SettingsCustom5.lineC5B4devmapcheckbox = srdtbC5B4.ReadLine();
                        SettingsCustom5.lineC5B4devmapstate = srdtbC5B4.ReadLine();
                        SettingsCustom5.lineC5B4cfgargument = srdtbC5B4.ReadLine();
                        SettingsCustom5.lineC5B4cfgstate = srdtbC5B4.ReadLine();
                        SettingsCustom5.lineC5B4mapname = srdtbC5B4.ReadLine();
                        SettingsCustom5.lineC5B4mapnamefixed = srdtbC5B4.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms5/C5B5.txt"))
                {
                    var databaseC5B5path = ("./database/dtbcustoms5/C5B5.txt");

                    using (var srdtbC5B5 = new StreamReader(databaseC5B5path))
                    {
                        SettingsCustom5.lineC5B5devmapcheckbox = srdtbC5B5.ReadLine();
                        SettingsCustom5.lineC5B5devmapstate = srdtbC5B5.ReadLine();
                        SettingsCustom5.lineC5B5cfgargument = srdtbC5B5.ReadLine();
                        SettingsCustom5.lineC5B5cfgstate = srdtbC5B5.ReadLine();
                        SettingsCustom5.lineC5B5mapname = srdtbC5B5.ReadLine();
                        SettingsCustom5.lineC5B5mapnamefixed = srdtbC5B5.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms5/C5B6.txt"))
                {
                    var databaseC5B6path = ("./database/dtbcustoms5/C5B6.txt");

                    using (var srdtbC5B6 = new StreamReader(databaseC5B6path))
                    {
                        SettingsCustom5.lineC5B6devmapcheckbox = srdtbC5B6.ReadLine();
                        SettingsCustom5.lineC5B6devmapstate = srdtbC5B6.ReadLine();
                        SettingsCustom5.lineC5B6cfgargument = srdtbC5B6.ReadLine();
                        SettingsCustom5.lineC5B6cfgstate = srdtbC5B6.ReadLine();
                        SettingsCustom5.lineC5B6mapname = srdtbC5B6.ReadLine();
                        SettingsCustom5.lineC5B6mapnamefixed = srdtbC5B6.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms5/C5B7.txt"))
                {
                    var databaseC5B7path = ("./database/dtbcustoms5/C5B7.txt");

                    using (var srdtbC5B7 = new StreamReader(databaseC5B7path))
                    {
                        SettingsCustom5pt2.lineC5B7devmapcheckbox = srdtbC5B7.ReadLine();
                        SettingsCustom5pt2.lineC5B7devmapstate = srdtbC5B7.ReadLine();
                        SettingsCustom5pt2.lineC5B7cfgargument = srdtbC5B7.ReadLine();
                        SettingsCustom5pt2.lineC5B7cfgstate = srdtbC5B7.ReadLine();
                        SettingsCustom5pt2.lineC5B7mapname = srdtbC5B7.ReadLine();
                        SettingsCustom5pt2.lineC5B7mapnamefixed = srdtbC5B7.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms5/C5B8.txt"))
                {
                    var databaseC5B8path = ("./database/dtbcustoms5/C5B8.txt");

                    using (var srdtbC5B8 = new StreamReader(databaseC5B8path))
                    {
                        SettingsCustom5pt2.lineC5B8devmapcheckbox = srdtbC5B8.ReadLine();
                        SettingsCustom5pt2.lineC5B8devmapstate = srdtbC5B8.ReadLine();
                        SettingsCustom5pt2.lineC5B8cfgargument = srdtbC5B8.ReadLine();
                        SettingsCustom5pt2.lineC5B8cfgstate = srdtbC5B8.ReadLine();
                        SettingsCustom5pt2.lineC5B8mapname = srdtbC5B8.ReadLine();
                        SettingsCustom5pt2.lineC5B8mapnamefixed = srdtbC5B8.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms5/C5B9.txt"))
                {
                    var databaseC5B9path = ("./database/dtbcustoms5/C5B9.txt");

                    using (var srdtbC5B9 = new StreamReader(databaseC5B9path))
                    {
                        SettingsCustom5pt2.lineC5B9devmapcheckbox = srdtbC5B9.ReadLine();
                        SettingsCustom5pt2.lineC5B9devmapstate = srdtbC5B9.ReadLine();
                        SettingsCustom5pt2.lineC5B9cfgargument = srdtbC5B9.ReadLine();
                        SettingsCustom5pt2.lineC5B9cfgstate = srdtbC5B9.ReadLine();
                        SettingsCustom5pt2.lineC5B9mapname = srdtbC5B9.ReadLine();
                        SettingsCustom5pt2.lineC5B9mapnamefixed = srdtbC5B9.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms5/C5B10.txt"))
                {
                    var databaseC5B10path = ("./database/dtbcustoms5/C5B10.txt");

                    using (var srdtbC5B10 = new StreamReader(databaseC5B10path))
                    {
                        SettingsCustom5pt2.lineC5B10devmapcheckbox = srdtbC5B10.ReadLine();
                        SettingsCustom5pt2.lineC5B10devmapstate = srdtbC5B10.ReadLine();
                        SettingsCustom5pt2.lineC5B10cfgargument = srdtbC5B10.ReadLine();
                        SettingsCustom5pt2.lineC5B10cfgstate = srdtbC5B10.ReadLine();
                        SettingsCustom5pt2.lineC5B10mapname = srdtbC5B10.ReadLine();
                        SettingsCustom5pt2.lineC5B10mapnamefixed = srdtbC5B10.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms5/C5B11.txt"))
                {
                    var databaseC5B11path = ("./database/dtbcustoms5/C5B11.txt");

                    using (var srdtbC5B11 = new StreamReader(databaseC5B11path))
                    {
                        SettingsCustom5pt2.lineC5B11devmapcheckbox = srdtbC5B11.ReadLine();
                        SettingsCustom5pt2.lineC5B11devmapstate = srdtbC5B11.ReadLine();
                        SettingsCustom5pt2.lineC5B11cfgargument = srdtbC5B11.ReadLine();
                        SettingsCustom5pt2.lineC5B11cfgstate = srdtbC5B11.ReadLine();
                        SettingsCustom5pt2.lineC5B11mapname = srdtbC5B11.ReadLine();
                        SettingsCustom5pt2.lineC5B11mapnamefixed = srdtbC5B11.ReadLine();
                    }


                }

                if (File.Exists("./database/dtbcustoms5/C5B12.txt"))
                {
                    var databaseC5B12path = ("./database/dtbcustoms5/C5B12.txt");

                    using (var srdtbC5B12 = new StreamReader(databaseC5B12path))
                    {
                        SettingsCustom5pt2.lineC5B12devmapcheckbox = srdtbC5B12.ReadLine();
                        SettingsCustom5pt2.lineC5B12devmapstate = srdtbC5B12.ReadLine();
                        SettingsCustom5pt2.lineC5B12cfgargument = srdtbC5B12.ReadLine();
                        SettingsCustom5pt2.lineC5B12cfgstate = srdtbC5B12.ReadLine();
                        SettingsCustom5pt2.lineC5B12mapname = srdtbC5B12.ReadLine();
                        SettingsCustom5pt2.lineC5B12mapnamefixed = srdtbC5B12.ReadLine();
                    }


                }
            }
        }
        public bool _unclicked = true;

        void hideSubMenu()
        {
            foreach (var pnl in panelcolumn.Controls.OfType<Panel>())
            {
                pnl.Height = 41;
            }
        }
        void showSubMenu(Panel pnl)
        {
            pnl.Height = pnl.Controls.OfType<Button>().Count() * 50 + 11;

        }

        private void btnMainClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMainMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void paneltop1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void paneltop1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void paneltop1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void paneltop2_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void paneltop2_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void paneltop2_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        public void loadform (object Form)
        {
            if (this.panelMain.Controls.Count >0)
                this.panelMain.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock= DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            loadform(new FormSettings());
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            loadform(new FormDefault());
        }

        private void btnPromod_Click(object sender, EventArgs e)
        {
            loadform(new FormPromod());
        }

        private void btnCoDJumper_Click(object sender, EventArgs e)
        {
            loadform(new FormCoDJumper());
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            if (!_unclicked)
            {
                _unclicked = true; 

                hideSubMenu();
            }
            else
            {
                _unclicked = false; 
                showSubMenu(panelform1deployable);

            }
        }

        private void btnCustom1_Click(object sender, EventArgs e)
        {
            loadform(new Customs1());
        }

        private void btnCustom2_Click(object sender, EventArgs e)
        {
            loadform(new Custom2());
        }

        private void btnCustom3_Click(object sender, EventArgs e)
        {
            loadform(new Custom3());
        }

        private void btnCustom4_Click(object sender, EventArgs e)
        {
            loadform(new Custom4());
        }

        private void btnCustom5_Click(object sender, EventArgs e)
        {
            loadform(new Custom5());
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            loadform(new FormInfo());
        }
    }
}


