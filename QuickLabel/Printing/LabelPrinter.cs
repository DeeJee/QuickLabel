using System.Collections.Generic;
using System.Drawing.Printing;

namespace QuickLabel.Printing
{
    public class LabelPrinter : PrintDocument
    {
        private int labelIndex = 0;
        private IList<QLabel> labels;
        public LabelPrinter(IList<QLabel> labels, string title)
        {
            this.labels = labels;
            this.DefaultPageSettings.Landscape = false;
            this.DocumentName = title;
        }

        protected override void OnPrintPage(PrintPageEventArgs e)
        {
            QLabel label = labels[labelIndex];
            label.Print(e.Graphics, 0, 0);
            labelIndex++;
            if (labelIndex < labels.Count)
            {
                e.HasMorePages = true;
            }
        }
    }
}
