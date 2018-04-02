using System;

namespace QuickLabel.Configuration
{
    [Serializable]
    public class LabelSettings
    {
        public int Size { get; set; }
        public string FontFamily { get; set; }
        public LabelSettings()
        {
        }
    }
}
