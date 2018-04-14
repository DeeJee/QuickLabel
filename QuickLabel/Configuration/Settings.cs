using System;
using System.IO;
using System.Xml.Serialization;
using NLog;

namespace QuickLabel.Configuration
{
    [Serializable]
    public class Settings
    {
        private static Logger Log = LogManager.GetCurrentClassLogger();
        private static string SettingsFile = AppSettings.GetString("SettingsFile");

        private static UserSettings settings;
        public static UserPrinterSettings PrinterSettings
        {
            get
            {
                Init();
                return settings.PrinterSettings;
            }
            set { settings.PrinterSettings = value; }
        }

        private static LabelSettings labelSettings;
        public static LabelSettings LabelSettings
        {
            get
            {
                Init();
                return settings.LabelSettings;
            }
            set { settings.LabelSettings = value; }
        }

        public static void Init(bool force=false)
        {
            if (settings != null && !force)
            {
                return;
            }
            if (File.Exists(SettingsFile))
            {
                Log.Info("Loading file {0}", SettingsFile);
                using (FileStream file = File.OpenRead(SettingsFile))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(UserSettings));
                    settings = (UserSettings)serializer.Deserialize(file);
                }
                Log.Info("Settingsfile loaded");
            }
            else
            {
                Log.Info("Creating new settingsfile {0}", SettingsFile);
                settings = new UserSettings();
                //CreateNewSettings();
            }
        }

        //private static Settings CreateNewSettings()
        //{
        //    return new Settings
        //    {
        //        Label = new LabelSettings
        //        {
        //            ComponentType = "",
        //            NumberOfProjectLabels = 1,
        //            OverleveringAbsoluut = 1,
        //            Overleveringrelatief = 1,
        //            PrinterSettings = new PrinterSettings
        //            {
        //                SpecificPaper = "62mm x 29mm",
        //                SpecificPrinter = "Brother QL-500",
        //                UseSpecificPaper = true,
        //                UseSpecificPrinter = true
        //            }
        //        },
        //        Paspoort = new PaspoortSettings
        //        {
        //            PrinterSettings = new PrinterSettings
        //            {
        //                UseSpecificPrinter = true,
        //                SpecificPrinter = "aap",
        //                UseSpecificPaper = true,
        //                SpecificPaper = "noot"
        //            }
        //        }
        //    };
        //}

        public static void Save()
        {
            try
            {
                using (StreamWriter file = File.CreateText(SettingsFile))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(UserSettings));
                    serializer.Serialize(file, settings);
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex);
            }

        }
    }
}
