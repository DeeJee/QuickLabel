namespace QuickLabel.Controls
{
    partial class FieldControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FieldLabel = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FieldLabel
            // 
            this.FieldLabel.AutoSize = true;
            this.FieldLabel.Location = new System.Drawing.Point(0, 7);
            this.FieldLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FieldLabel.Name = "FieldLabel";
            this.FieldLabel.Size = new System.Drawing.Size(117, 25);
            this.FieldLabel.TabIndex = 0;
            this.FieldLabel.Text = "FieldControl";
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(169, 0);
            this.TextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(180, 29);
            this.TextBox.TabIndex = 1;
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // FieldControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.FieldLabel);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FieldControl";
            this.Size = new System.Drawing.Size(359, 37);
            this.Resize += new System.EventHandler(this.LabelledTextBox_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.TextBox TextBox;
        protected System.Windows.Forms.Label FieldLabel;
    }
}
