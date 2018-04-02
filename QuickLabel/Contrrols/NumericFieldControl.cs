using System;
using System.Windows.Forms;
using System.Drawing;

namespace QuickLabel.Controls
{
    public class NumericFieldControl:FieldControl
    {
        public NumericFieldControl()
        {
            this.FieldLabel.Text = "NumericFieldControl";
        }

        protected override void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsAllowed(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                TextBox textBox = sender as TextBox;
                textBox.BackColor = Color.White;
            }
        }

        private bool IsAllowed(char c)
        {
            if (Char.IsDigit(c))
                return true;

            if(c.Equals('\b'))
                return true;

            return false;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // NumericFieldControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.Name = "NumericFieldControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
