using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickLabel.Configuration
{
    public class SettingsChangedEventArgs:EventArgs
    {
        public string Printer { get; set; }
        public string Paper { get; set; }
        public bool Landscape { get; set; }
        public bool AlwaysShowDialog { get; set; }
        public string FontFamily { get; set; }
        public int FontSize { get; set; }
        public string AdressenFile { get; set; }
        public string AdressenSeparator { get; set; }
        public string ContainerFile { get; set; }
        public string ContainerSeparator { get; set; }
    }
}
