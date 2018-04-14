using System;
using System.Windows.Forms;
using System.Drawing;

namespace QuickLabel.Controls
{
    public class NumericFieldControl:TextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!IsAllowed(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                BackColor = Color.White;
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
            // NumericTextBox
            // 
            this.Name = "NumericTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
