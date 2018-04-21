//using System;
//using System.Configuration;
//using System.Diagnostics;
//using System.IO;
//using System.Xml.Serialization;
//using NLog;

//namespace QuickLabel.Configuration
//{
//    [Serializable]
//    public class Settings
//    {
//        private static Logger Log = LogManager.GetCurrentClassLogger();
//        private static string SettingsFile = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\settings.xml";

//        private static UserSettings settings;
//        public static UserPrinterSettings PrinterSettings
//        {
//            get
//            {
//                Init();
//                return settings.PrinterSettings;
//            }
//            set { settings.PrinterSettings = value; }
//        }

//        private static LabelSettings labelSettings;
//        public static LabelSettings LabelSettings
//        {
//            get
//            {
//                Init();
//                return settings.LabelSettings;
//            }
//            set { settings.LabelSettings = value; }
//        }

//        public static void Init(bool force = false)
//        {
//            if (settings != null && !force)
//            {
//                return;
//            }
//            Log.Info("Loading settings");
//            QuickLabelSection config =
//                (QuickLabelSection)System.Configuration.ConfigurationManager.GetSection(Constants.configSectionName);

//            settings = new UserSettings {
//                LabelSettings=new LabelSettings
//                {
//                    FontFamily=config.Label.Font.Name,
//                    Size=config.Label.Font.Size
//                },
//                PrinterSettings=new UserPrinterSettings
//                {
//                    AlwaysShowPrintDialog=config.Printer.AlwaysShowPrintDialog,
//                    Landscape = config.Printer.Landscape,
//                    Paper = config.Printer.Paper,
//                    Printer = config.Printer.Printer,
//                }
//            };
//            //using (FileStream file = File.OpenRead(SettingsFile))
//            //{
//            //    XmlSerializer serializer = new XmlSerializer(typeof(UserSettings));
//            //    settings = (UserSettings)serializer.Deserialize(file);
//            //}
//            Log.Info("Settings loaded");

//        }

//        public static void Save()
//        {
//            System.Configuration.Configuration exeConfiguration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
//            QuickLabelSection section = (QuickLabelSection)exeConfiguration.GetSection("quicklabelSettings");

//            section.Printer.Printer = Settings.PrinterSettings.Printer;
//            section.Printer.Paper = Settings.PrinterSettings.Paper;
//            section.Label.Font.Name = Settings.LabelSettings.FontFamily;
//            section.Label.Font.Size = Settings.LabelSettings.Size;
//            //section.Invoer.AdressenFile=Settings.
//            exeConfiguration.Save();


//            try
//            {
//                using (StreamWriter file = File.CreateText(SettingsFile))
//                {
//                    XmlSerializer serializer = new XmlSerializer(typeof(UserSettings));
//                    serializer.Serialize(file, settings);
//                }
//            }
//            catch (Exception ex)
//            {
//                Log.Error(ex);
//            }

//        }
//    }
//}
