namespace QuickLabel
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.GenereerAanvraag = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.Print = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.PrintAanvragen = new System.Windows.Forms.Button();
            this.logoControl2 = new QuickLabel.Controls.LogoControl();
            this.logoControl1 = new QuickLabel.Controls.LogoControl();
            this.quickLabelControl = new QuickLabel.Controls.QuickLabelControl();
            this.SuspendLayout();
            // 
            // GenereerAanvraag
            // 
            this.GenereerAanvraag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GenereerAanvraag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.GenereerAanvraag.Location = new System.Drawing.Point(17, 938);
            this.GenereerAanvraag.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.GenereerAanvraag.Name = "GenereerAanvraag";
            this.GenereerAanvraag.Size = new System.Drawing.Size(202, 97);
            this.GenereerAanvraag.TabIndex = 0;
            this.GenereerAanvraag.Text = "Genereer aanvraag";
            this.GenereerAanvraag.UseVisualStyleBackColor = true;
            this.GenereerAanvraag.Click += new System.EventHandler(this.GenereerAanvraag_Click);
            // 
            // settings
            // 
            this.settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.settings.Location = new System.Drawing.Point(1003, 938);
            this.settings.Margin = new System.Windows.Forms.Padding(4);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(179, 97);
            this.settings.TabIndex = 3;
            this.settings.Text = "Instellingen";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // Print
            // 
            this.Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Print.Location = new System.Drawing.Point(231, 938);
            this.Print.Margin = new System.Windows.Forms.Padding(4);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(173, 97);
            this.Print.TabIndex = 4;
            this.Print.Text = "Print aanvraag";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // PrintAanvragen
            // 
            this.PrintAanvragen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PrintAanvragen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintAanvragen.Location = new System.Drawing.Point(548, 938);
            this.PrintAanvragen.Margin = new System.Windows.Forms.Padding(4);
            this.PrintAanvragen.Name = "PrintAanvragen";
            this.PrintAanvragen.Size = new System.Drawing.Size(179, 97);
            this.PrintAanvragen.TabIndex = 7;
            this.PrintAanvragen.Text = "Print aanvraag...";
            this.PrintAanvragen.UseVisualStyleBackColor = true;
            this.PrintAanvragen.Click += new System.EventHandler(this.PrintAanvragen_Click);
            // 
            // logoControl2
            // 
            this.logoControl2.Location = new System.Drawing.Point(15, 15);
            this.logoControl2.Logo = ((System.Drawing.Image)(resources.GetObject("logoControl2.Logo")));
            this.logoControl2.Margin = new System.Windows.Forms.Padding(4);
            this.logoControl2.Name = "logoControl2";
            this.logoControl2.Size = new System.Drawing.Size(610, 125);
            this.logoControl2.TabIndex = 6;
            // 
            // logoControl1
            // 
            this.logoControl1.Location = new System.Drawing.Point(1187, 15);
            this.logoControl1.Logo = ((System.Drawing.Image)(resources.GetObject("logoControl1.Logo")));
            this.logoControl1.Margin = new System.Windows.Forms.Padding(4);
            this.logoControl1.Name = "logoControl1";
            this.logoControl1.Size = new System.Drawing.Size(241, 125);
            this.logoControl1.TabIndex = 5;
            // 
            // quickLabelControl
            // 
            this.quickLabelControl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.quickLabelControl.Location = new System.Drawing.Point(177, 217);
            this.quickLabelControl.Margin = new System.Windows.Forms.Padding(4);
            this.quickLabelControl.Name = "quickLabelControl";
            this.quickLabelControl.Size = new System.Drawing.Size(611, 326);
            this.quickLabelControl.TabIndex = 1;
            this.quickLabelControl.Text = "quickLabelControl";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 1051);
            this.Controls.Add(this.PrintAanvragen);
            this.Controls.Add(this.logoControl2);
            this.Controls.Add(this.logoControl1);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.quickLabelControl);
            this.Controls.Add(this.GenereerAanvraag);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "MainForm";
            this.Text = "QuickLabel";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GenereerAanvraag;
        private Controls.QuickLabelControl quickLabelControl;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.PrintDialog printDialog1;
        private Controls.LogoControl logoControl1;
        private Controls.LogoControl logoControl2;
        private System.Windows.Forms.Button PrintAanvragen;
    }
}

