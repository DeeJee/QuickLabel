using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuickLabel.Controls
{
    public partial class FieldControl : UserControl
    {
        public new delegate void OnTextChanged(object sender, EventArgs e);
        public new event OnTextChanged TextChanged;

        public FieldControl()
        {
            InitializeComponent();
        }

        private void LabelledTextBox_Resize(object sender, EventArgs e)
        {
            TextBox.Left = this.Width - TextBox.Width;
        }

        public override string Text
        {
            get { return TextBox.Text; }
            set { TextBox.Text = value; }
        }

        public string Label
        {
            get { return FieldLabel.Text; }
            set { FieldLabel.Text = value; }
        }

        public new void Invalidate()
        {
            TextBox.BackColor = Color.OrangeRed;
        }

        protected virtual void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = sender as TextBox;
            textbox.BackColor = Color.White;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextChanged?.Invoke(sender,e);
        }
    }
}
