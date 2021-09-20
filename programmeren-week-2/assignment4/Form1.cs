using System;
using System.Windows.Forms;

namespace Oefening_4
{
    public partial class Form1 : Form
    {
        const double vatValue = 0.21;
        public Form1()
        {
            InitializeComponent();
            DisplayPrice.Text = "";
            DisplayVAT.Text = "";
            DisplayTotal.Text = "";
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            // Ask input price
            string input = InputTextbox.Text;
            // Convert input price
            double price = double.Parse(input);
            // Do calculation
            double vat = price * vatValue;
            double total = price + vat;

            // Display result
            DisplayPrice.Text = price.ToString("0.00");
            DisplayVAT.Text = vat.ToString("0.00");
            DisplayTotal.Text = total.ToString("0.00");

            // Reset input field
            InputTextbox.Text = "";
        }
    }
}
