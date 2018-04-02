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
            this.logo = new System.Windows.Forms.PictureBox();
            this.settings = new System.Windows.Forms.Button();
            this.quickLabelControl = new QuickLabel.Controls.QuickLabelControl();
            this.Print = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
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
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Margin = new System.Windows.Forms.Padding(0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(488, 90);
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
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
            // quickLabelControl
            // 
            this.quickLabelControl.Location = new System.Drawing.Point(222, 242);
            this.quickLabelControl.Name = "quickLabelControl";
            this.quickLabelControl.Size = new System.Drawing.Size(480, 218);
            this.quickLabelControl.TabIndex = 1;
            this.quickLabelControl.Text = "quickLabelControl";
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(380, 562);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 870);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.quickLabelControl);
            this.Controls.Add(this.GenereerAanvraag);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "QuickLabel";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GenereerAanvraag;
        private Controls.QuickLabelControl quickLabelControl;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}

