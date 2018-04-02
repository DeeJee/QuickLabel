using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickLabel.Configuration
{
    public class SettingsValidator
    {
        public bool Validate()
        {
            ValidatePrinterSettings(Settings.PrinterSettings);
            return true;
        }

        private void ValidatePrinterSettings(UserPrinterSettings userPrinterSettings)
        {

        }
    }
}
