using QuickLabel.Configuration;
using QuickLabel.Data;
using QuickLabel.Forms;
using QuickLabel.Printing;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuickLabel
{
    public partial class MainForm : Form
    {
        LabelManager labelManager;
        QLabel label;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            logo.Width = 488;
            logo.Height = 90;
            try
            {
                labelManager = new LabelManager();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            GenereerAanvraag_Click(null, e);
        }

        private void GenereerAanvraag_Click(object sender, EventArgs e)
        {
            var quickLabelData = labelManager.GetRandom();
            Font font=GetFont();

       
            label = new QLabel(quickLabelData);
            label.Font = font;
            quickLabelControl.Label = label;
            quickLabelControl.Refresh();
        }

        private Font GetFont()
        {
            Font font;
            try
            {
                var fontFamily = Configuration.AppSettings.GetString(Constants.FontFamily);
                var fontSize = Configuration.AppSettings.GetString(Constants.FontSize);
                font = new Font(fontFamily, int.Parse(fontSize));
            }
            catch (Exception)
            {
                font = new Font("Arial", 10);
            }
            return font;
        }

        private void settings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.FormClosed += SettingsForm_FormClosed;
            settingsForm.Show();
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            labelManager = new LabelManager();
            Font font = GetFont();
            label.Font = font;
            quickLabelControl.Refresh();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            PageSetupDialog pageDialog1 = new PageSetupDialog();
            //string title = string.Format("Labels voor batch {0}", labelRol.BatchNumber);
            LabelPrinter labelPrinter = new LabelPrinter(label, "QuickLabel document");
            pageDialog1.Document = labelPrinter;

            //eventueel standaard printer instellen
            bool printerAndPaperSelected = PrinterHelper.HandlePrinterAndPaperSettings(pageDialog1, labelPrinter, Settings.PrinterSettings);

            printDialog1.Document = labelPrinter;
            printDialog1.Document.DefaultPageSettings.Landscape = Settings.PrinterSettings.Landscape;
            printDialog1.AllowSelection = false;
            printDialog1.AllowSomePages = false;

            PrinterHelper.PrintWithOrWithoutDialog(Settings.PrinterSettings, printerAndPaperSelected, labelPrinter, printDialog1);
        }
    }
}
