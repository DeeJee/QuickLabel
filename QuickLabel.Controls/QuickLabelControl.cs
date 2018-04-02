using QuickLabel.Entities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuickLabel.Controls
{
    public partial class QuickLabelControl : Control
    {
        private Font font = new Font("Arial", 10);
        Brush blackBrush = new SolidBrush(Color.Black);
        Brush whiteBrush = new SolidBrush(Color.White);

        public QuickLabelData Label { get; set; }
        public QLabel qLabel

        public QuickLabelControl()
        {
            Label = new QuickLabelData
            {
                Adres = new Adres
                {
                    Bedrijfsnaam = "Bakkerij het stoepje",
                    Contactpersoon = "Peter Bakker",
                    Huisnummer = "huisnummer",
                    Huisletter = "a",
                    Huistoevoeging = "hs",
                    Postcode = "Postcode",
                    Straatnaam = "Straat",
                    Plaatsnaam = "Woonplaats"
                },
                Aantal = 1,
                Container = new Entities.Container
                {
                    Fractie = "fractie",
                    Omschrijving = "omschrijving",
                    Typenummer = "fdf",
                    Volume = "250L"
                }
            };
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Rectangle rect = new Rectangle(new Point(0, 0), this.Size);
            pe.Graphics.FillRectangle(whiteBrush, rect);
            ////pe.Graphics.DrawRectangle(new Pen(blackBrush, 5), rect);

            if (Label != null)
            {
                PointF endPosition;
                var adres = Label.Adres;
                endPosition = DrawLine(pe.Graphics, new PointF(0, 0), $"{adres.Bedrijfsnaam}");
                endPosition = DrawLine(pe.Graphics, new PointF(0, endPosition.Y), $"{adres.Contactpersoon}");
                endPosition = DrawLine(pe.Graphics, new PointF(0, endPosition.Y), $"{adres.Straatnaam} {adres.Huisnummer}");
                endPosition = DrawLine(pe.Graphics, new PointF(0, endPosition.Y), $"{adres.Postcode} {adres.Plaatsnaam}");
                endPosition = DrawLine(pe.Graphics, new PointF(0, endPosition.Y), " ");
                var container = Label.Container;
                endPosition = DrawLine(pe.Graphics, new PointF(0, endPosition.Y), "Extra lediging");
                endPosition = DrawLine(pe.Graphics, new PointF(0, endPosition.Y), $"{Label.Aantal} stuks, {container.Volume} {container.Omschrijving}, {container.Fractie}");
            }
        }
        private PointF DrawLine(Graphics graphics, PointF location, string text)
        {
            graphics.DrawString(text, font, blackBrush, location);
            var size = graphics.MeasureString(text, font);
            return new PointF(location.X + size.Width, location.Y + size.Height);
        }
    }
}
