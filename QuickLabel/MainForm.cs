using NLog;
using QuickLabel.Configuration;
using QuickLabel.Data;
using QuickLabel.Forms;
using QuickLabel.Printing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace QuickLabel
{
    public partial class MainForm : Form
    {
        private static Logger Logger = LogManager.GetCurrentClassLogger();
        LabelManager labelManager;
        QLabel label;
        AantalForm aantalForm;
        PrintDocument printer;

        public MainForm()
        {
            InitializeComponent();
            //adapt the label size to the paper
            printer = new PrintDocument();

            UpdateLabel();
        }

        private void UpdateLabel()
        {
            this.quickLabelControl.Label.Font = new Font(Settings.LabelSettings.FontFamily, Settings.LabelSettings.Size);



            printer.PrinterSettings.PrinterName = Settings.PrinterSettings.Printer;

            var selectedPaper = Settings.PrinterSettings.Paper;
            foreach (PaperSize paperSize in printer.PrinterSettings.PaperSizes)
            {
                if (paperSize.PaperName == selectedPaper)
                {
                    this.quickLabelControl.Height = paperSize.Height;
                    this.quickLabelControl.Width = paperSize.Width;
                    this.quickLabelControl.Refresh();
                    Logger.Info("Label updated");
                    break;
                }
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                labelManager = new LabelManager();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
                MessageBox.Show(ex.Message);
            }
            GenereerAanvraag_Click(null, e);
        }

        private void GenereerAanvraag_Click(object sender, EventArgs e)
        {
            var quickLabelData = labelManager.GetRandom();
            Font font = GetFont();

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
            catch (Exception ex)
            {
                Logger.Error(ex);
                font = new Font("Arial", 10);
            }
            return font;
        }

        private void settings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(this.printer);
            settingsForm.OnSettingsChanged += SettingsForm_OnSettingsChanged;
            settingsForm.Show();
        }

        private void SettingsForm_OnSettingsChanged(object sender, EventArgs e)
        {
            UpdateLabel();
        }


        private void Print_Click(object sender, EventArgs e)
        {
            PrintLabels(new List<QLabel> { label });

        }
        private void PrintLabels(IList<QLabel> labels)
        {
            PageSetupDialog pageDialog1 = new PageSetupDialog();

            //string title = string.Format("Labels voor batch {0}", labelRol.BatchNumber);
            LabelPrinter labelPrinter = new LabelPrinter(labels, "QuickLabel document");
            pageDialog1.Document = labelPrinter;

            //eventueel standaard printer instellen
            bool printerAndPaperSelected = PrinterHelper.HandlePrinterAndPaperSettings(pageDialog1, labelPrinter, Settings.PrinterSettings);

            printDialog1.Document = labelPrinter;
            printDialog1.Document.DefaultPageSettings.Landscape = Settings.PrinterSettings.Landscape;
            printDialog1.AllowSelection = false;
            printDialog1.AllowSomePages = false;

            PrinterHelper.PrintWithOrWithoutDialog(Settings.PrinterSettings, printerAndPaperSelected, labelPrinter, printDialog1);
        }

        private void PrintAanvragen_Click(object sender, EventArgs e)
        {
            aantalForm = new AantalForm();
            aantalForm.ShowDialog();
            if (aantalForm.Aantal == null)
            {
                return;
            }

            List<QLabel> labels = new List<QLabel>();
            for (int index = 0; index < aantalForm.Aantal; index++)
            {
                var label = labelManager.GetRandom();
                var qLabel = new QLabel(label);
                qLabel.Font = GetFont();
                labels.Add(qLabel);
            }
            PrintLabels(labels);
        }
    }
}


