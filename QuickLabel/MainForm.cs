using NLog;
using QuickLabel.Configuration;
using QuickLabel.Data;
using QuickLabel.Forms;
using QuickLabel.Printing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Reflection;
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
        QuickLabelSection config;

        public MainForm()
        {
            InitializeComponent();
            config = (QuickLabelSection)System.Configuration.ConfigurationManager.GetSection("quicklabelSettings");

            //adapt the label size to the paper
            printer = new PrintDocument();
            Version version = Assembly.GetEntryAssembly().GetName().Version;
            toolStripStatusLabel1.Text = version.ToString();
        }

        private void UpdateLabel(SettingsChangedEventArgs section)
        {
            this.quickLabelControl.Label.Font = new Font(section.FontFamily, section.FontSize);
            quickLabelControl.Label.Landscape = section.Landscape;
            printer.PrinterSettings.PrinterName = section.Printer;

            var selectedPaper = section.Paper;
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
            config = (QuickLabelSection)System.Configuration.ConfigurationManager.GetSection("quicklabelSettings");

            try
            {
                labelManager = new LabelManager(
                    config.Invoer.AdressenFile,
                    config.Invoer.AdressenSeparator,
                    config.Invoer.ContainersFile,
                    config.Invoer.ContainersSeparator);

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
            var paperSize = PrinterHelper.GetPaperSize(printer, config.Printer);
            var size = new Size(paperSize.Width, paperSize.Height);
            this.label.Size = size;
            label.Landscape = config.Printer.Landscape;
            quickLabelControl.Size = size;
            quickLabelControl.Refresh();
        }

        private Font GetFont()
        {
            Font font;
            try
            {
                var fontFamily = config.Label.Font.Name;
                var fontSize = config.Label.Font.Size;
                font = new Font(fontFamily, fontSize);
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
            settingsForm.ShowDialog();
        }

        private void SettingsForm_OnSettingsChanged(SettingsChangedEventArgs section)
        {
            UpdateLabel(section);
        }


        private void Print_Click(object sender, EventArgs e)
        {
            PrintLabels(new List<QLabel> { label });

        }
        private void PrintLabels(IList<QLabel> labels)
        {
            PageSetupDialog pageDialog1 = new PageSetupDialog();

            LabelPrinter labelPrinter = new LabelPrinter(labels, "QuickLabel document");
            pageDialog1.Document = labelPrinter;

            //eventueel standaard printer instellen
            bool printerAndPaperSelected = PrinterHelper.HandlePrinterAndPaperSettings(pageDialog1, labelPrinter, config.Printer);

            printDialog1.Document = labelPrinter;
            printDialog1.Document.DefaultPageSettings.Landscape = config.Printer.Landscape;
            printDialog1.AllowSelection = false;
            printDialog1.AllowSomePages = false;

            PrinterHelper.PrintWithOrWithoutDialog(config.Printer, printerAndPaperSelected, labelPrinter, printDialog1);
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


