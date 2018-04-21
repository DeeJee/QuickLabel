using QuickLabel.Entities;
using System;
using System.Drawing;

namespace QuickLabel.Printing
{
    public class QLabel
    {
        public Font Font { get; set; }
        
        public Size Size { get;  set; }
        public bool Landscape { get; set; }
        QuickLabelData data;

        public QLabel(QuickLabelData data)
        {
            //this.Size = new Size(480, 218);
            this.data = data;
        }

        public virtual void Print(Graphics g, int top, int left)
        {
            if (Font == null)
            {
                throw new Exception("Font must be set before calling Print()");
            }

            Rectangle rect = new Rectangle(new Point(left, top), Size);
            g.FillRectangle(Brushes.White, rect);

            if (!Landscape)
            {
                //90 graden draaien. De translatie is nodig omdat de rotatie plaats vindt
                //vanaf de linker boven hoek. Alles draait dus buiten beeld.
                g.TranslateTransform(Size.Width, 0.0F);
                g.RotateTransform(90.0F);
                this.Size = new Size(Size.Height, Size.Width);//nodig om te kunnen berekeken of alles nog past.
            }

            PointF endPosition;
            var adres = data.Adres;
            endPosition = DrawFittedLine(g, new PointF(left, top), $"{adres.Bedrijfsnaam}");
            endPosition = DrawFittedLine(g, new PointF(left, endPosition.Y), $"{adres.Contactpersoon}");
            endPosition = DrawFittedLine(g, new PointF(left, endPosition.Y), $"{adres.Straatnaam} {adres.Huisnummer}{adres.Huisletter} {adres.Huistoevoeging}");
            endPosition = DrawFittedLine(g, new PointF(left, endPosition.Y), $"{adres.Postcode} {adres.Plaatsnaam}");
            endPosition = DrawFittedLine(g, new PointF(left, endPosition.Y), " ");
            var container = data.Container;
            endPosition = DrawLine(g, new PointF(left, endPosition.Y), "Extra lediging");

            var containerline = $"{data.Aantal} stuks, {container.Volume} {container.Omschrijving}, {container.Fractie}";
            endPosition = DrawFittedLine(g, new PointF(left, endPosition.Y), containerline);
        }

        private PointF DrawLine(Graphics graphics, PointF location, string text)
        {
            graphics.DrawString(text, Font, Brushes.Black, location);
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
