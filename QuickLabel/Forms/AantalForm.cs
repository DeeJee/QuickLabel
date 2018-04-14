using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickLabel.Forms
{
    public partial class AantalForm : Form
    {
        public int? Aantal { get; set; }
        public AantalForm()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty( TxtAantal.Text ))
            {
                this.Aantal = int.Parse(TxtAantal.Text);
            }
            Close();
        }
        private void OK_Closed(object sender, System.EventArgs e)
        {
            this.Aantal = null;
        }

        private void AantalForm_Load(object sender, EventArgs e)
        {
            TxtAantal.Text = "1";
            TxtAantal.Focus();
        }
    }
}
