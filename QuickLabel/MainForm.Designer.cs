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
            this.GenereerAanvraag.Location = new System.Drawing.Point(15, 562);
            this.GenereerAanvraag.Margin = new System.Windows.Forms.Padding(6);
            this.GenereerAanvraag.Name = "GenereerAanvraag";
            this.GenereerAanvraag.Size = new System.Drawing.Size(159, 80);
            this.GenereerAanvraag.TabIndex = 0;
            this.GenereerAanvraag.Text = "Genereer aanvraag";
            this.GenereerAanvraag.UseVisualStyleBackColor = true;
            this.GenereerAanvraag.Click += new System.EventHandler(this.GenereerAanvraag_Click);
            // 
            // settings
            // 
            this.settings.Location = new System.Drawing.Point(790, 562);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(141, 80);
            this.settings.TabIndex = 3;
            this.settings.Text = "Instellingen";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(270, 562);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(150, 80);
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
            this.PrintAanvragen.Location = new System.Drawing.Point(445, 562);
            this.PrintAanvragen.Name = "PrintAanvragen";
            this.PrintAanvragen.Size = new System.Drawing.Size(188, 80);
            this.PrintAanvragen.TabIndex = 7;
            this.PrintAanvragen.Text = "Print aanvraag...";
            this.PrintAanvragen.UseVisualStyleBackColor = true;
            this.PrintAanvragen.Click += new System.EventHandler(this.PrintAanvragen_Click);
            // 
            // logoControl2
            // 
            this.logoControl2.Location = new System.Drawing.Point(12, 12);
            this.logoControl2.Logo = ((System.Drawing.Image)(resources.GetObject("logoControl2.Logo")));
            this.logoControl2.Name = "logoControl2";
            this.logoControl2.Size = new System.Drawing.Size(479, 150);
            this.logoControl2.TabIndex = 6;
            // 
            // logoControl1
            // 
            this.logoControl1.Location = new System.Drawing.Point(933, 12);
            this.logoControl1.Logo = ((System.Drawing.Image)(resources.GetObject("logoControl1.Logo")));
            this.logoControl1.Name = "logoControl1";
            this.logoControl1.Size = new System.Drawing.Size(189, 163);
            this.logoControl1.TabIndex = 5;
            // 
            // quickLabelControl
            // 
            this.quickLabelControl.Location = new System.Drawing.Point(222, 242);
            this.quickLabelControl.Name = "quickLabelControl";
            this.quickLabelControl.Size = new System.Drawing.Size(480, 270);
            this.quickLabelControl.TabIndex = 1;
            this.quickLabelControl.Text = "quickLabelControl";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 870);
            this.Controls.Add(this.PrintAanvragen);
            this.Controls.Add(this.logoControl2);
            this.Controls.Add(this.logoControl1);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.quickLabelControl);
            this.Controls.Add(this.GenereerAanvraag);
            this.Margin = new System.Windows.Forms.Padding(6);
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

