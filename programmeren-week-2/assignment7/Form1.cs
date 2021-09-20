using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening_7
{
    public partial class Form1 : Form
    {
        const double VAT = 0.21;

        public Form1()
        {
            InitializeComponent();
            // Erase output labels on init app
            LabelResultPriceExclVAT.Text = "";
            LabelResultVAT.Text = "";
            LabelResultPriceInclVAT.Text = "";
        }

        private void ButtonErase_Click(object sender, EventArgs e)
        {
            // Erase textboxes and output labels
            TextBoxStart.Text = "";
            TextBoxEnd.Text = "";
            TextBoxPriceKM.Text = "";

            LabelResultPriceExclVAT.Text = "";
            LabelResultVAT.Text = "";
            LabelResultPriceInclVAT.Text = "";
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            // Read input textboxes and parse string input to the correct type
            int startKM = int.Parse(TextBoxStart.Text);
            int endKM = int.Parse(TextBoxEnd.Text);
            double priceKM = double.Parse(TextBoxPriceKM.Text);

            // Calculate prices
            double priceExcl = (endKM - startKM) * priceKM;
            double vat = priceExcl * VAT;
            double priceIncl = priceExcl + vat;

            // Display result
            LabelResultPriceExclVAT.Text = priceExcl.ToString("0.00");
            LabelResultVAT.Text = vat.ToString("0.00");
            LabelResultPriceInclVAT.Text = priceIncl.ToString("0.00");
        }
    }
}
