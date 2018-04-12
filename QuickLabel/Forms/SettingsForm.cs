using System;
using System.Windows.Forms;
using QuickLabel.Configuration;
using NLog;
using System.Configuration;
using System.Drawing.Text;
using System.Drawing.Printing;
using System.Linq;
using System.Linq.Expressions;
namespace QuickLabel.Forms
{
    public partial class SettingsForm : Form
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();
        PrintDocument printer;
        PaperSize paperSize;

        public delegate void SettingsChanged(PaperSize paperSize);
        public event SettingsChanged OnSettingsChanged;

        public SettingsForm()
        {
            InitializeComponent();
           
        }

        private void LabelPrinterSelector_OnSelectionChanged()
        {
            var selectedPaper = this.LabelPrinterSelector.Settings.Paper;
            Log.Info("Selecting paper");
            foreach (PaperSize paperSize in printer.PrinterSettings.PaperSizes)
            {
                if (paperSize.PaperName == selectedPaper)
                {
                    this.paperSize = paperSize;
                    break;
                }
            }

            Log.Info("Paper selected");
            ThrowEvent();
        }

        public SettingsForm(PrintDocument printer)
        {
            InitializeComponent();
            this.printer = printer;
            this.LabelPrinterSelector.OnSelectionChanged += LabelPrinterSelector_OnSelectionChanged;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Log.Info("Loading settings.");
            LoadPrinterSettings();
            LoadInputSettings();
            LoadLabelSettings();

            FontFamily.SelectedIndexChanged += FontFamily_SelectedIndexChanged;
            FontSize.TextChanged += FontSize_TextChanged;

            Log.Info("Settings loaded.");
        }

       

        private void LoadLabelSettings()
        {
            InstalledFontCollection installedFontCollection = new InstalledFontCollection();
            foreach(var family in installedFontCollection.Families)
            {
                FontFamily.Items.Add(family.Name);
            }
            FontFamily.SelectedItem= Settings.LabelSettings.FontFamily;
            FontSize.Text = Settings.LabelSettings.Size.ToString();
        }

        private void LoadInputSettings()
        {
            this.NaamAdressenbestand.Text = ConfigurationManager.AppSettings.Get(Constants.AdressenFileName);
            this.AdressenBestandFieldSeparator.Text= ConfigurationManager.AppSettings.Get(Constants.AdressenbestandFieldSeparator);
            this.NaamContainerBestand.Text = ConfigurationManager.AppSettings.Get(Constants.ContainersFileName);
            this.ContainerBestandFieldSeparator.Text = ConfigurationManager.AppSettings.Get(Constants.ContainerbestandFieldSeparator);
        }

        private void LoadPrinterSettings()
        {
            LabelPrinterSelector.Settings = Settings.PrinterSettings;
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            try
            {
                Log.Info("Saving settings.");
                SavePrinterSettings();
                SaveAppSettings();
             
                Close();
                Log.Info("Settings saved.");
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                MessageBox.Show(ex.Message, "Fout bij opslaan instellingen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveAppSettings()
        {
           System.Configuration. Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            ChangeAppSetting(config, Constants.AdressenFileName, NaamAdressenbestand.Text);
            ChangeAppSetting(config, Constants.ContainersFileName, NaamContainerBestand.Text);
            ChangeAppSetting(config, Constants.AdressenbestandFieldSeparator, AdressenBestandFieldSeparator.Text);
            ChangeAppSetting(config, Constants.ContainerbestandFieldSeparator, ContainerBestandFieldSeparator.Text);
            ChangeAppSetting(config, Constants.FontFamily, FontFamily.Text);
            ChangeAppSetting(config, Constants.FontSize, FontSize.Text);
            config.Save(ConfigurationSaveMode.Minimal);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void ChangeAppSetting(System.Configuration.Configuration config, string key, string value)
        {
            var setting = config.AppSettings.Settings[key];
            if (setting == null)
            {
                config.AppSettings.Settings.Add(key, value);
            }
            else
            {
                setting.Value = value;
            }
        }

        private void SavePrinterSettings()
        {
            Settings.PrinterSettings = LabelPrinterSelector.Settings;
            Settings.LabelSettings.FontFamily = FontFamily.Text;
            Settings.LabelSettings.Size = int.Parse(FontSize.Text);
            Settings.Save();
        }

        private void ButtonAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SelectTab(string name)
        {
            TabPage page = tabControl.TabPages[name];
            int index = tabControl.TabPages.IndexOf(page);
            tabControl.SelectedIndex = index;
        }

        private void FontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateExampleLabel();
        }

        private void FontSize_TextChanged(object sender, EventArgs e)
        {
            UpdateExampleLabel();
        }

        private void ThrowEvent()
        {
            OnSettingsChanged?.Invoke(paperSize);
        }

        private void UpdateExampleLabel()
        {
            ExampleLabel.Label.Font = new System.Drawing.Font(FontFamily.Text, int.Parse(FontSize.Text));
            ExampleLabel.Refresh();
        }
    }
}
