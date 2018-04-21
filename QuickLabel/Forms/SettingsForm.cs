using System;
using System.Windows.Forms;
using QuickLabel.Configuration;
using NLog;
using System.Configuration;
using System.Drawing.Text;
using System.Drawing.Printing;
namespace QuickLabel.Forms
{
    public partial class SettingsForm : Form
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

        public delegate void SettingsChanged(SettingsChangedEventArgs section);
        public event SettingsChanged OnSettingsChanged;
        System.Configuration.Configuration exeConfiguration;
        QuickLabelSection section;

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void LabelPrinterSelector_OnSelectionChanged()
        {
            Log.Info("Paper selected");
            NotifyChanges();
        }

        public SettingsForm(PrintDocument printer)
        {
            InitializeComponent();
            exeConfiguration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            section = (QuickLabelSection)exeConfiguration.GetSection(Constants.configSectionName);
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Log.Info("Loading settings.");
            LoadPrinterSettings();
            LoadInputSettings();
            LoadLabelSettings();

            FontFamily.SelectedIndexChanged += FontFamily_SelectedIndexChanged;
            FontSize.TextChanged += FontSize_TextChanged;
            this.LabelPrinterSelector.OnSelectionChanged += LabelPrinterSelector_OnSelectionChanged;
            Log.Info("Settings loaded.");
        }

        private void LoadLabelSettings()
        {
            InstalledFontCollection installedFontCollection = new InstalledFontCollection();
            foreach (var family in installedFontCollection.Families)
            {
                FontFamily.Items.Add(family.Name);
            }
            FontFamily.SelectedItem = section.Label.Font.Name;
            FontSize.Text = section.Label.Font.Size.ToString();
        }

        private void LoadInputSettings()
        {
            this.NaamAdressenbestand.Text = section.Invoer.AdressenFile;
            this.AdressenBestandFieldSeparator.Text = section.Invoer.AdressenSeparator;
            this.NaamContainerBestand.Text = section.Invoer.ContainersFile;
            this.ContainerBestandFieldSeparator.Text = section.Invoer.ContainersSeparator;
        }

        private void LoadPrinterSettings()
        {
            LabelPrinterSelector.Settings = new UserPrinterSettings
            {
                AlwaysShowPrintDialog = section.Printer.AlwaysShowPrintDialog,
                Landscape = section.Printer.Landscape,
                Paper = section.Printer.Paper,
                Printer = section.Printer.Printer
            };
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            try
            {
                Log.Info("Saving settings.");
                UpdateSettings();

                exeConfiguration.Save(ConfigurationSaveMode.Minimal);
                ConfigurationManager.RefreshSection(Constants.configSectionName);

                Close();
                Log.Info("Settings saved.");
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                MessageBox.Show(ex.Message, "Fout bij opslaan instellingen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateSettings()
        {
            section.Printer.Printer = LabelPrinterSelector.Settings.Printer;
            section.Printer.Paper = LabelPrinterSelector.Settings.Paper;
            section.Printer.Landscape = LabelPrinterSelector.Settings.Landscape;
            section.Printer.AlwaysShowPrintDialog = LabelPrinterSelector.Settings.AlwaysShowPrintDialog;
            section.Label.Font.Name = FontFamily.Text;
            section.Label.Font.Size = int.Parse(FontSize.Text);

            section.Invoer.AdressenFile = NaamAdressenbestand.Text;
            section.Invoer.AdressenSeparator = AdressenBestandFieldSeparator.Text;
            section.Invoer.ContainersFile = NaamContainerBestand.Text;
            section.Invoer.ContainersSeparator = ContainerBestandFieldSeparator.Text;
        }

        private SettingsChangedEventArgs GetChanges()
        {
            return new SettingsChangedEventArgs
            {
                Printer = LabelPrinterSelector.Settings.Printer,
                Paper = LabelPrinterSelector.Settings.Paper,
                Landscape = LabelPrinterSelector.Settings.Landscape,
                AlwaysShowDialog = LabelPrinterSelector.Settings.AlwaysShowPrintDialog,
                FontFamily = FontFamily.Text,
                FontSize = int.Parse(FontSize.Text),

                AdressenFile = NaamAdressenbestand.Text,
                AdressenSeparator = AdressenBestandFieldSeparator.Text,
                ContainerFile = NaamContainerBestand.Text,
                ContainerSeparator = ContainerBestandFieldSeparator.Text
            };
        }

        private void ButtonAnnuleren_Click(object sender, EventArgs e)
        {
            var changes = new SettingsChangedEventArgs
            {
                AdressenFile = section.Invoer.AdressenFile,
                AdressenSeparator = section.Invoer.AdressenSeparator,
                ContainerFile = section.Invoer.ContainersFile,
                ContainerSeparator = section.Invoer.ContainersSeparator,
                Landscape = section.Printer.Landscape,
                AlwaysShowDialog = section.Printer.AlwaysShowPrintDialog,
                Printer = section.Printer.Printer,
                Paper = section.Printer.Paper,
                FontFamily = section.Label.Font.Name,
                FontSize = section.Label.Font.Size
            };

            Close();
            OnSettingsChanged?.Invoke(changes);
        }

        public void SelectTab(string name)
        {
            TabPage page = tabControl.TabPages[name];
            int index = tabControl.TabPages.IndexOf(page);
            tabControl.SelectedIndex = index;
        }

        private void FontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            NotifyChanges();
        }

        private void FontSize_TextChanged(object sender, EventArgs e)
        {
            NotifyChanges();
        }

        private void NotifyChanges()
        {
            var changes = GetChanges();
            OnSettingsChanged?.Invoke(changes);
        }
    }
}
