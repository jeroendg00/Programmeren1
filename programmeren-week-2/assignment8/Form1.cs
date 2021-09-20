using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening_8
{
    public partial class Form1 : Form
    {
        const double TeePrice = 30.00;
        const double JeansPrice = 100.00;
        const double VAT = 0.21;

        public Form1()
        {
            InitializeComponent();

            // Erase label text
            LabelDisplayDate.Text = "";
            LabelDisplayPrice.Text = "";
            LabelDisplayVAT.Text = "";
            LabelDisplayTotal.Text = "";
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            double teePrice = int.Parse(TbInputTees.Text) * TeePrice;
            double jeansPrice = int.Parse(TbInputJeans.Text) * JeansPrice;

            double priceExclVat = teePrice + jeansPrice;
            double vatPrice = priceExclVat * VAT;
            double totalPrice = priceExclVat + vatPrice;

            LabelDisplayDate.Text = DateTime.Now.ToString("HH:mm:ss MM/dd/yyyy");
            LabelDisplayPrice.Text = priceExclVat.ToString("0.00");
            LabelDisplayVAT.Text = vatPrice.ToString("0.00");
            LabelDisplayTotal.Text = totalPrice.ToString("0.00");
        }
    }
}
