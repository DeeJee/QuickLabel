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
        private Size size;
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        public QLabel(QuickLabelData data)
        {
            this.size = new Size(480, 218);
            this.data = data;
        }

        public virtual void Print(Graphics g, int top, int left)
        {
            if (Font == null)
            {
                throw new Exception("Font must be set before calling Print()");
            }

            Rectangle rect = new Rectangle(new Point(left, top), size);
            g.FillRectangle(whiteBrush, rect);
            ////g.DrawRectangle(new Pen(blackBrush, 5), rect);

            PointF endPosition;
            var adres = data.Adres;
            endPosition = DrawLine(g, new PointF(left, top), $"{adres.Bedrijfsnaam}");
            endPosition = DrawLine(g, new PointF(left, endPosition.Y), $"{adres.Contactpersoon}");
            endPosition = DrawLine(g, new PointF(left, endPosition.Y), $"{adres.Straatnaam} {adres.Huisnummer}{adres.Huisletter} {adres.Huistoevoeging}");
            endPosition = DrawLine(g, new PointF(left, endPosition.Y), $"{adres.Postcode} {adres.Plaatsnaam}");
            endPosition = DrawLine(g, new PointF(left, endPosition.Y), " ");
            var container = data.Container;
            endPosition = DrawLine(g, new PointF(left, endPosition.Y), "Extra lediging");
            endPosition = DrawLine(g, new PointF(left, endPosition.Y), $"{data.Aantal} stuks, {container.Volume} {container.Omschrijving}, {container.Fractie}");
        }

        private PointF DrawLine(Graphics graphics, PointF location, string text)
        {
            graphics.DrawString(text, Font, blackBrush, location);
            var size = graphics.MeasureString(text, Font);
            return new PointF(location.X + size.Width, location.Y + size.Height);
        }
    }
}
