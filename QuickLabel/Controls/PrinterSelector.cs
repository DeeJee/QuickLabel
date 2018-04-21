using System;
using System.Windows.Forms;
using QuickLabel.Configuration;
using System.Drawing.Printing;
using System.Linq;
using System.Collections.Generic;

namespace QuickLabel.Controls
{
    public partial class PrinterSelector : UserControl
    {
        public delegate void SelectionChanged();
        public event SelectionChanged OnSelectionChanged;

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
                    List<PaperSize> sizes = new List<PaperSize>();
                    
                    foreach (PaperSize paperSize in selectedPrinter.PaperSizes)
                    {
                        sizes.Add(paperSize);
                     //   Paper.Items.Add(paperSize.PaperName);
                    }
                    foreach (PaperSize paperSize in sizes.OrderBy(o=>o.PaperName))
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
            ThrowEvent();
        }

        private void AlwaysShowPrintDialog_CheckedChanged(object sender, EventArgs e)
        {
            printerSettings.AlwaysShowPrintDialog = AlwaysShowPrintDialog.Checked;
        }

        private void cbxLandscape_CheckedChanged(object sender, EventArgs e)
        {
            printerSettings.Landscape = cbxLandscape.Checked;
            ThrowEvent();
        }

        private void ThrowEvent()
        {
            OnSelectionChanged?.Invoke();
        }
    }
}
