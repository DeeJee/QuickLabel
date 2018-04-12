namespace QuickLabel.Forms
{
    partial class AantalForm
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
            this.TxtAantal = new QuickLabel.Controls.NumericFieldControl();
            this.Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtAantal
            // 
            this.TxtAantal.Label = "";
            this.TxtAantal.Location = new System.Drawing.Point(15, 15);
            this.TxtAantal.Margin = new System.Windows.Forms.Padding(6);
            this.TxtAantal.Name = "TxtAantal";
            this.TxtAantal.Size = new System.Drawing.Size(192, 37);
            this.TxtAantal.TabIndex = 0;
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(216, 15);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 35);
            this.Ok.TabIndex = 1;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // AantalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 75);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.TxtAantal);
            this.Name = "AantalForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.NumericFieldControl TxtAantal;
        private System.Windows.Forms.Button Ok;
    }
}