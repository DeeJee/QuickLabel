using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace QuickLabel.Configuration
{
    public static class AppSettings
    {
        public static string GetString(string settingName){
            var value= ConfigurationManager.AppSettings[settingName];
            if (value == null)
            {
                throw new Exception(string.Format("De AppSetting '{0}' ontbreekt in de app.config", settingName));
            }
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception(string.Format("De AppSetting '{0}' heeft geen waarde", settingName));
            }
            return value;
        }
    }
}
