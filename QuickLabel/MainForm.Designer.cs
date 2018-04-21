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
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GenereerAanvraag
            // 
            this.GenereerAanvraag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GenereerAanvraag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.GenereerAanvraag.Location = new System.Drawing.Point(67, 23);
            this.GenereerAanvraag.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.GenereerAanvraag.Name = "GenereerAanvraag";
            this.GenereerAanvraag.Size = new System.Drawing.Size(136, 69);
            this.GenereerAanvraag.TabIndex = 0;
            this.GenereerAanvraag.Text = "Genereer aanvraag";
            this.GenereerAanvraag.UseVisualStyleBackColor = true;
            this.GenereerAanvraag.Click += new System.EventHandler(this.GenereerAanvraag_Click);
            // 
            // settings
            // 
            this.settings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settings.Location = new System.Drawing.Point(497, 23);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(121, 69);
            this.settings.TabIndex = 3;
            this.settings.Text = "Instellingen";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // Print
            // 
            this.Print.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Print.Location = new System.Drawing.Point(225, 23);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(117, 69);
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
            this.PrintAanvragen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrintAanvragen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintAanvragen.Location = new System.Drawing.Point(359, 23);
            this.PrintAanvragen.Name = "PrintAanvragen";
            this.PrintAanvragen.Size = new System.Drawing.Size(121, 69);
            this.PrintAanvragen.TabIndex = 7;
            this.PrintAanvragen.Text = "Print aanvraag...";
            this.PrintAanvragen.UseVisualStyleBackColor = true;
            this.PrintAanvragen.Click += new System.EventHandler(this.PrintAanvragen_Click);
            // 
            // logoControl2
            // 
            this.logoControl2.Location = new System.Drawing.Point(10, 10);
            this.logoControl2.Logo = ((System.Drawing.Image)(resources.GetObject("logoControl2.Logo")));
            this.logoControl2.Name = "logoControl2";
            this.logoControl2.Size = new System.Drawing.Size(411, 88);
            this.logoControl2.TabIndex = 6;
            // 
            // logoControl1
            // 
            this.logoControl1.Location = new System.Drawing.Point(800, 10);
            this.logoControl1.Logo = ((System.Drawing.Image)(resources.GetObject("logoControl1.Logo")));
            this.logoControl1.Name = "logoControl1";
            this.logoControl1.Size = new System.Drawing.Size(162, 88);
            this.logoControl1.TabIndex = 5;
            // 
            // quickLabelControl
            // 
            this.quickLabelControl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.quickLabelControl.Location = new System.Drawing.Point(18, 224);
            this.quickLabelControl.Name = "quickLabelControl";
            this.quickLabelControl.Size = new System.Drawing.Size(411, 231);
            this.quickLabelControl.TabIndex = 1;
            this.quickLabelControl.Text = "quickLabelControl";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.settings);
            this.panel1.Controls.Add(this.PrintAanvragen);
            this.panel1.Controls.Add(this.Print);
            this.panel1.Controls.Add(this.GenereerAanvraag);
            this.panel1.Location = new System.Drawing.Point(10, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 107);
            this.panel1.TabIndex = 8;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 758);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1017, 30);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(179, 25);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1017, 788);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.quickLabelControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logoControl2);
            this.Controls.Add(this.logoControl1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "MainForm";
            this.Text = "QuickLabel";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

