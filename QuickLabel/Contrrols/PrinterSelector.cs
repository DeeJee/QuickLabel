using System;
using System.Windows.Forms;
using QuickLabel.Configuration;
using System.Drawing.Printing;

namespace QuickLabel.Controls
{
    public partial class PrinterSelector : UserControl
    {
        private UserPrinterSettings printerSettings;
        public UserPrinterSettings Settings
        {
            get { return printerSettings; }
            set
            {
                printerSettings = value;
                if (printerSettings != null)
                    Initialise();
            }
        }

        private void Initialise()
        {
            AlwaysShowPrintDialog.Checked = printerSettings.AlwaysShowPrintDialog;            
            InitialisePrinter();
            InitialisePaper();
            cbxLandscape.Checked = printerSettings.Landscape;
        }

        private void InitialisePaper()
        {
            LoadPaper();
            Paper.SelectedItem = printerSettings.Paper;
        }

        private void InitialisePrinter()
        {
            LoadPrinters();
            Printer.SelectedItem = printerSettings.Printer;
        }

        public PrinterSelector()
        {
            InitializeComponent();
            Console.WriteLine("printerselector");
        }

        private void LoadPaper()
        {
            Paper.Items.Clear();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                //Zoekt geselecteerde printer op
                if (printer == (string)Printer.SelectedItem)
                {
                    PrinterSettings selectedPrinter = new PrinterSettings();
                    selectedPrinter.PrinterName = printer;

                    //vult lijst met papierformaten die bij de geselecteerde printer horen
                    foreach (PaperSize paperSize in selectedPrinter.PaperSizes)
                    {
                        Paper.Items.Add(paperSize.PaperName);
                    }
                }
            }
        }

        private void LoadPrinters()
        {
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                Printer.Items.Add(printer);
            }
        }

        private void Printer_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPaper();
            Paper.Text = null;

            printerSettings.Printer = (string)Printer.SelectedItem;
        }

        private void Paper_SelectedIndexChanged(object sender, EventArgs e)
        {
            printerSettings.Paper= (string)Paper.SelectedItem;
        }

        private void AlwaysShowPrintDialog_CheckedChanged(object sender, EventArgs e)
        {
            printerSettings.AlwaysShowPrintDialog = AlwaysShowPrintDialog.Checked;
        }

        private void cbxLandscape_CheckedChanged(object sender, EventArgs e)
        {
            printerSettings.Landscape = cbxLandscape.Checked;
        }
    }
}
