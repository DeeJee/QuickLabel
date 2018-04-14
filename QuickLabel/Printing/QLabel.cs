using QuickLabel.Entities;
using System;
using System.Drawing;

namespace QuickLabel.Printing
{
    public class QLabel
    {
        public Font Font { get; set; }
        Brush blackBrush = Brushes.Black;
        Brush whiteBrush = Brushes.White;
        QuickLabelData data;
        public Size Size { get;  set; }

        public QLabel(QuickLabelData data)
        {
            this.Size = new Size(480, 218);
            this.data = data;
        }

        public virtual void Print(Graphics g, int top, int left)
        {
            if (Font == null)
            {
                throw new Exception("Font must be set before calling Print()");
            }

            Rectangle rect = new Rectangle(new Point(left, top), Size);
            g.FillRectangle(whiteBrush, rect);

            PointF endPosition;
            var adres = data.Adres;
            endPosition = DrawLine(g, new PointF(left, top), $"{adres.Bedrijfsnaam}");
            endPosition = DrawLine(g, new PointF(left, endPosition.Y), $"{adres.Contactpersoon}");
            endPosition = DrawLine(g, new PointF(left, endPosition.Y), $"{adres.Straatnaam} {adres.Huisnummer}{adres.Huisletter} {adres.Huistoevoeging}");
            endPosition = DrawLine(g, new PointF(left, endPosition.Y), $"{adres.Postcode} {adres.Plaatsnaam}");
            endPosition = DrawLine(g, new PointF(left, endPosition.Y), " ");
            var container = data.Container;
            endPosition = DrawLine(g, new PointF(left, endPosition.Y), "Extra lediging");

            var containerline = $"{data.Aantal} stuks, {container.Volume} {container.Omschrijving}, {container.Fractie}";
            endPosition = DrawFittedLine(g, new PointF(left, endPosition.Y), containerline);
        }

        private PointF DrawLine(Graphics graphics, PointF location, string text)
        {
            graphics.DrawString(text, Font, blackBrush, location);
            var size = graphics.MeasureString(text, Font);
            return new PointF(location.X + size.Width, location.Y + size.Height);
        }

        private PointF DrawFittedLine(Graphics graphics, PointF location, string text)
        {
            var lines = PrinterHelper.FitString(graphics, text, Font, Size);
            foreach(string line in lines)
            {
                location.X = 0;
                location= DrawLine(graphics, location, line);
            }
            return location;
        }
    }
}
