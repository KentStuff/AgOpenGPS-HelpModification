using System;
using System.Globalization;
using System.IO;
using AgOpenGPS.Properties;
using System.Windows.Forms;


namespace AgOpenGPS
{
    public partial class Form_Help : Form
    {
        public Form_Help()
        {
            InitializeComponent();
        }
        private readonly FormGPS mf;
        private string culture;
        //constructor
        public Form_Help(FormGPS _f)
        {
            mf = _f;
            //if (mf != null)
            //{
            //    gl = _gl;
            //}
        }



        private void Form_Help_Load(object sender, EventArgs e)
        {
            
            bool notFound = false;
            try
            {
                switch (Settings.Default.setF_culture)
                {
                    case "en":
                        culture = "Manual.pdf";
                        break;

                    case "ru":
                        culture = "Manual.ru.pdf";
                        break;

                    case "da":
                        culture = "Manual.da.pdf";
                        break;

                    case "de":
                        culture = "Manual.de.pdf";
                        break;

                    case "nl":
                        culture = "Manual.nl.pdf";
                        break;

                    case "it":
                        culture = "Manual.it.pdf";
                        break;

                    case "es":
                        culture = "Manual.es.pdf";
                        break;

                    case "fr":
                        culture = "Manual.fr.pdf";
                        break;

                    case "uk":
                        culture = "Manual.uk.pdf";
                        break;

                    case "sk":
                        culture = "Manual.sk.pdf";
                        break;

                    case "pl":
                        culture = "Manual.pl.pdf";
                        break;

                    case "af":
                        culture = "Manual.af.pdf";
                        break;

                    default:
                        culture = "Manual.pdf";
                        break;
                }

            }
            catch
            {
                notFound = true;
            }

            if (notFound)
            {
                try
                {
                    culture = "Manual.pdf";
                }
                catch
                {
                    mf.TimedMessageBox(2000, "No File Found", "Can't Find Manual.pdf");
                }
            }


            string directoryName = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

            HelpBrowser.Url = new Uri(directoryName+"\\"+culture);
            
           


           
        }

      

        //private void AOGHelpBtn_Click(object sender, EventArgs e)
        //{
        //    string directoryName = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

        //    HelpBrowser.Url = new Uri(directoryName + "\\" + culture);
        //    AOGHelpBtn.Enabled = false;
        //    treeHelpBtn.Enabled = !AOGHelpBtn.Enabled;

        //}
    }
}