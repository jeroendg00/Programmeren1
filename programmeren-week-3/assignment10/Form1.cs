using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment10
{
    public partial class Form1 : Form
    {
        const double DefaultPrice = 12;

        public Form1()
        {
            InitializeComponent();

            // first clear the result label
            LabelResult.Text = "";
        }

        private void ButtonCalcPrice_Click(object sender, EventArgs e)
        {
            int age = int.Parse(TextboxAge.Text);
            double price = DefaultPrice;

            if (age < 5 || age > 55)
            {
                price = 0;
            }
            else if (Enumerable.Range(5, 8).Contains(age)) {
                price = price / 2;
            }

            LabelResult.Text = "€ " + price.ToString("0.00");
        }
    }
}
