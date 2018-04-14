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
            this.Ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAantal = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAantal)).BeginInit();
            this.SuspendLayout();
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(276, 61);
            this.Ok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(95, 42);
            this.Ok.TabIndex = 1;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aantal:";
            // 
            // TxtAantal
            // 
            this.TxtAantal.Location = new System.Drawing.Point(149, 61);
            this.TxtAantal.Name = "TxtAantal";
            this.TxtAantal.Size = new System.Drawing.Size(120, 35);
            this.TxtAantal.TabIndex = 3;
            // 
            // AantalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 151);
            this.Controls.Add(this.TxtAantal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ok);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AantalForm";
            this.Load += new System.EventHandler(this.AantalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtAantal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown TxtAantal;
    }
}