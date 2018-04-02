using System;

namespace QuickLabel.Configuration
{
    [Serializable]
    public class UserSettings
    {
        public LabelSettings LabelSettings { get; set; }
        public UserPrinterSettings PrinterSettings { get; set; }
        public UserSettings()
        {
            PrinterSettings = new UserPrinterSettings();
            LabelSettings = new LabelSettings();
        }
    }
}