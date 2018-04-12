namespace QuickLabel.Forms
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.PrinterTab = new System.Windows.Forms.TabPage();
            this.LabelPrinterSelector = new QuickLabel.Controls.PrinterSelector();
            this.InvoerTab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ContainerBestandFieldSeparator = new System.Windows.Forms.TextBox();
            this.NaamContainerBestand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AdressenBestandFieldSeparator = new System.Windows.Forms.TextBox();
            this.NaamAdressenbestand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelTab = new System.Windows.Forms.TabPage();
            this.ExampleLabel = new QuickLabel.Controls.QuickLabelControl();
            this.FontSize = new QuickLabel.Controls.NumericFieldControl();
            this.FontFamily = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ButtonAnnuleren = new System.Windows.Forms.Button();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.PrinterTab.SuspendLayout();
            this.InvoerTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.LabelTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.PrinterTab);
            this.tabControl.Controls.Add(this.InvoerTab);
            this.tabControl.Controls.Add(this.LabelTab);
            this.tabControl.Location = new System.Drawing.Point(22, 15);
            this.tabControl.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(728, 591);
            this.tabControl.TabIndex = 20;
            // 
            // PrinterTab
            // 
            this.PrinterTab.BackColor = System.Drawing.SystemColors.Control;
            this.PrinterTab.Controls.Add(this.LabelPrinterSelector);
            this.PrinterTab.Location = new System.Drawing.Point(4, 33);
            this.PrinterTab.Margin = new System.Windows.Forms.Padding(6);
            this.PrinterTab.Name = "PrinterTab";
            this.PrinterTab.Padding = new System.Windows.Forms.Padding(6);
            this.PrinterTab.Size = new System.Drawing.Size(720, 554);
            this.PrinterTab.TabIndex = 0;
            this.PrinterTab.Text = "Printer";
            // 
            // LabelPrinterSelector
            // 
            this.LabelPrinterSelector.Location = new System.Drawing.Point(17, 11);
            this.LabelPrinterSelector.Margin = new System.Windows.Forms.Padding(11);
            this.LabelPrinterSelector.Name = "LabelPrinterSelector";
            this.LabelPrinterSelector.Settings = null;
            this.LabelPrinterSelector.Size = new System.Drawing.Size(374, 354);
            this.LabelPrinterSelector.TabIndex = 22;
            // 
            // InvoerTab
            // 
            this.InvoerTab.BackColor = System.Drawing.SystemColors.Control;
            this.InvoerTab.Controls.Add(this.groupBox2);
            this.InvoerTab.Controls.Add(this.groupBox1);
            this.InvoerTab.Location = new System.Drawing.Point(4, 33);
            this.InvoerTab.Name = "InvoerTab";
            this.InvoerTab.Size = new System.Drawing.Size(720, 554);
            this.InvoerTab.TabIndex = 1;
            this.InvoerTab.Text = "Invoer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ContainerBestandFieldSeparator);
            this.groupBox2.Controls.Add(this.NaamContainerBestand);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 127);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Containerbestand";
            // 
            // ContainerBestandFieldSeparator
            // 
            this.ContainerBestandFieldSeparator.Location = new System.Drawing.Point(197, 75);
            this.ContainerBestandFieldSeparator.Name = "ContainerBestandFieldSeparator";
            this.ContainerBestandFieldSeparator.Size = new System.Drawing.Size(36, 29);
            this.ContainerBestandFieldSeparator.TabIndex = 3;
            // 
            // NaamContainerBestand
            // 
            this.NaamContainerBestand.Location = new System.Drawing.Point(197, 31);
            this.NaamContainerBestand.Name = "NaamContainerBestand";
            this.NaamContainerBestand.Size = new System.Drawing.Size(468, 29);
            this.NaamContainerBestand.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Naam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Scheidingsteken";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AdressenBestandFieldSeparator);
            this.groupBox1.Controls.Add(this.NaamAdressenbestand);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 127);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adressenbestand";
            // 
            // AdressenBestandFieldSeparator
            // 
            this.AdressenBestandFieldSeparator.Location = new System.Drawing.Point(197, 75);
            this.AdressenBestandFieldSeparator.Name = "AdressenBestandFieldSeparator";
            this.AdressenBestandFieldSeparator.Size = new System.Drawing.Size(36, 29);
            this.AdressenBestandFieldSeparator.TabIndex = 3;
            // 
            // NaamAdressenbestand
            // 
            this.NaamAdressenbestand.Location = new System.Drawing.Point(197, 31);
            this.NaamAdressenbestand.Name = "NaamAdressenbestand";
            this.NaamAdressenbestand.Size = new System.Drawing.Size(468, 29);
            this.NaamAdressenbestand.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Scheidingsteken";
            // 
            // LabelTab
            // 
            this.LabelTab.BackColor = System.Drawing.SystemColors.Control;
            this.LabelTab.Controls.Add(this.ExampleLabel);
            this.LabelTab.Controls.Add(this.FontSize);
            this.LabelTab.Controls.Add(this.FontFamily);
            this.LabelTab.Controls.Add(this.label7);
            this.LabelTab.Location = new System.Drawing.Point(4, 33);
            this.LabelTab.Name = "LabelTab";
            this.LabelTab.Size = new System.Drawing.Size(720, 554);
            this.LabelTab.TabIndex = 2;
            this.LabelTab.Text = "Label";
            // 
            // ExampleLabel
            // 
            this.ExampleLabel.Location = new System.Drawing.Point(31, 200);
            this.ExampleLabel.Name = "ExampleLabel";
            this.ExampleLabel.Size = new System.Drawing.Size(481, 221);
            this.ExampleLabel.TabIndex = 6;
            this.ExampleLabel.Text = "quickLabelControl1";
            // 
            // FontSize
            // 
            this.FontSize.Label = "Grootte";
            this.FontSize.Location = new System.Drawing.Point(19, 60);
            this.FontSize.Margin = new System.Windows.Forms.Padding(6);
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(323, 37);
            this.FontSize.TabIndex = 5;
            // 
            // FontFamily
            // 
            this.FontFamily.FormattingEnabled = true;
            this.FontFamily.Location = new System.Drawing.Point(162, 19);
            this.FontFamily.Name = "FontFamily";
            this.FontFamily.Size = new System.Drawing.Size(307, 32);
            this.FontFamily.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Lettertype";
            // 
            // ButtonAnnuleren
            // 
            this.ButtonAnnuleren.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonAnnuleren.Location = new System.Drawing.Point(175, 633);
            this.ButtonAnnuleren.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonAnnuleren.Name = "ButtonAnnuleren";
            this.ButtonAnnuleren.Size = new System.Drawing.Size(138, 42);
            this.ButtonAnnuleren.TabIndex = 8;
            this.ButtonAnnuleren.Text = "Annuleren";
            this.ButtonAnnuleren.UseVisualStyleBackColor = true;
            this.ButtonAnnuleren.Click += new System.EventHandler(this.ButtonAnnuleren_Click);
            // 
            // ButtonOk
            // 
            this.ButtonOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonOk.Location = new System.Drawing.Point(26, 633);
            this.ButtonOk.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(138, 42);
            this.ButtonOk.TabIndex = 7;
            this.ButtonOk.Text = "OK";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 690);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.ButtonAnnuleren);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SettingsForm";
            this.Text = "Instellingen";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.tabControl.ResumeLayout(false);
            this.PrinterTab.ResumeLayout(false);
            this.InvoerTab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.LabelTab.ResumeLayout(false);
            this.LabelTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage PrinterTab;
        private System.Windows.Forms.Button ButtonAnnuleren;
        private System.Windows.Forms.Button ButtonOk;
        private QuickLabel.Controls.PrinterSelector LabelPrinterSelector;
        private System.Windows.Forms.TabPage InvoerTab;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ContainerBestandFieldSeparator;
        private System.Windows.Forms.TextBox NaamContainerBestand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox AdressenBestandFieldSeparator;
        private System.Windows.Forms.TextBox NaamAdressenbestand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage LabelTab;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox FontFamily;
        private Controls.NumericFieldControl FontSize;
        private Controls.QuickLabelControl ExampleLabel;
    }
}