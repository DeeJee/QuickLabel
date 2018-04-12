using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickLabel.Controls
{
    public partial class LogoControl : UserControl
    {
        public Image Logo { get; set; }
        public LogoControl()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            if (Logo == null)
            {
                return;
            }
            var ratio = Logo.Width / Logo.Height;
            var newWidth = this.Width;
            var calculatedHeight = newWidth / ratio;
            if (calculatedHeight > this.Height)
            {
                var newHeight = this.Height;
                var calculatedWidth = ratio * newHeight;
                pe.Graphics.DrawImage(Logo, new RectangleF(0,0,calculatedWidth, newHeight));
            }
            else
            {
                pe.Graphics.DrawImage(Logo, new RectangleF(0,0,newWidth, calculatedHeight));
            }
            
        }
    }
}
