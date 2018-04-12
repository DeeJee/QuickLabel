using QuickLabel.Configuration;
using QuickLabel.Entities;
using QuickLabel.Printing;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Linq;

namespace QuickLabel.Controls
{
    public partial class QuickLabelControl : Control
    {
        public QLabel Label { get; set; }

        public QuickLabelControl()
        {
            //adapt the label size to the paper
            //PrintDocument engine = new PrintDocument();

            //var selectedPrinter = Settings.PrinterSettings.Printer;
            //engine.PrinterSettings.PrinterName = selectedPrinter;

            //var selectedPaper = Settings.PrinterSettings.Paper;

            //for (int index = 0; index < engine.PrinterSettings.PaperSizes.Count; index++)
            //{
            //    if (engine.PrinterSettings.PaperSizes[index].PaperName == selectedPaper)
            //    {
            //        PaperSize size = engine.PrinterSettings.PaperSizes[index];
            //        this.Height = size.Height;
            //        this.Width = size.Width;
            //        this.Refresh();
            //        break;
            //    }
            //}

            Label = new QLabel(               
            new QuickLabelData
            {
                Adres = new Adres
                {
                    Bedrijfsnaam = "Bakkerij het stoepje",
                    Contactpersoon = "Peter Bakker",
                    Huisnummer = "124",
                    Huisletter = "b",
                    Huistoevoeging = "hs",
                    Postcode = "1234AB",
                    Straatnaam = "Markt",
                    Plaatsnaam = "Gouda"
                },
                Aantal = 3,
                Container = new Entities.Container
                {
                    Fractie = "Restafval",
                    Omschrijving = "rolcontainer",
                    Typenummer = "fdf",
                    Volume = "240 liter"
                }
            });
            Label.Font = new Font("Arial", 10);
            //Label.Size = this.Size;
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            if (Label != null)
            {
                Label.Print(pe.Graphics, 0, 0);
            }



            //Rectangle rect = new Rectangle(new Point(0, 0), this.Size);
            //pe.Graphics.FillRectangle(whiteBrush, rect);
            //////pe.Graphics.DrawRectangle(new Pen(blackBrush, 5), rect);

            //if (Label != null)
            //{
            //    PointF endPosition;
            //    var adres = Label.Adres;
            //    endPosition = DrawLine(pe.Graphics, new PointF(0, 0), $"{adres.Bedrijfsnaam}");
            //    endPosition = DrawLine(pe.Graphics, new PointF(0, endPosition.Y), $"{adres.Contactpersoon}");
            //    endPosition = DrawLine(pe.Graphics, new PointF(0, endPosition.Y), $"{adres.Straatnaam} {adres.Huisnummer}");
            //    endPosition = DrawLine(pe.Graphics, new PointF(0, endPosition.Y), $"{adres.Postcode} {adres.Plaatsnaam}");
            //    endPosition = DrawLine(pe.Graphics, new PointF(0, endPosition.Y), " ");
            //    var container = Label.Container;
            //    endPosition = DrawLine(pe.Graphics, new PointF(0, endPosition.Y), "Extra lediging");
            //    endPosition = DrawLine(pe.Graphics, new PointF(0, endPosition.Y), $"{Label.Aantal} stuks, {container.Volume} {container.Omschrijving}, {container.Fractie}");
            //}
        }
        //private PointF DrawLine(Graphics graphics, PointF location, string text)
        //{
        //    graphics.DrawString(text, font, blackBrush, location);
        //    var size = graphics.MeasureString(text, font);
        //    return new PointF(location.X + size.Width, location.Y + size.Height);
        //}
    }
}
