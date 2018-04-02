using System.Drawing.Printing;

namespace QuickLabel.Printing
{
    public class LabelPrinter : PrintDocument
    {
        private int labelIndex = 0;
        private QLabel label;
        public LabelPrinter(QLabel label, string title)
        {
            this.label = label;
            this.DefaultPageSettings.Landscape = false;
            this.DocumentName = title;
        }

        protected override void OnPrintPage(PrintPageEventArgs e)
        {
            label.Print(e.Graphics,0,0);
            e.HasMorePages = false;
        }
    }
}
