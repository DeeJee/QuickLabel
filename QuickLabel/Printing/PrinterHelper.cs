using QuickLabel.Configuration;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickLabel.Printing
{
    public static class PrinterHelper
    {
        public static bool HandlePrinterAndPaperSettings(PageSetupDialog pageDialog1, PrintDocument labelPrinter, UserPrinterSettings printerSettings)
        {
            bool succes = true;

            if (!string.IsNullOrEmpty(printerSettings.Printer))
            {
                //mainform.UpdateStatus("Selecting printer");
                bool printerSelected = SelectDefaultPrinter(labelPrinter, pageDialog1, printerSettings);
                if (!printerSelected)
                {
                    succes = false;
                }
            }

            //eventueel standaard papier instellen
            if (!string.IsNullOrEmpty(printerSettings.Paper))
            {
                //mainform.UpdateStatus("Selecting label");
                bool paperSelected = SelectDefaultPaper(labelPrinter, pageDialog1, printerSettings);
                if (!paperSelected)
                {
                    succes = false;
                }
            }
            return succes;
        }

        private static bool SelectDefaultPrinter(PrintDocument printDocument, PageSetupDialog pageDialog1, UserPrinterSettings printerSettings)
        {
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                if (printer == printerSettings.Printer)
                {
                    printDocument.PrinterSettings.PrinterName = printerSettings.Printer;
                    return true;
                }
            }
            return false;
        }

        private static bool SelectDefaultPaper(PrintDocument printer, PageSetupDialog pageDialog1, UserPrinterSettings printerSettings)
        {
            foreach (PaperSize paperSize in printer.PrinterSettings.PaperSizes)
            {
                if (paperSize.PaperName == printerSettings.Paper)
                {
                    pageDialog1.PageSettings.PaperSize = paperSize;
                    return true;
                }
            }

            return false;
        }

        public static void PrintWithOrWithoutDialog(UserPrinterSettings printerSettings, bool printerAndPaperSelected, PrintDocument document, PrintDialog printDialog1)
        {
            if (printerSettings.AlwaysShowPrintDialog || !printerAndPaperSelected)
            {
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    document.Print();
                }
            }
            else
            {
                document.Print();
            }
        }
    }
}
