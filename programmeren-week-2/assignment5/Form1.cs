using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening_5
{
    public partial class Form1 : Form
    {
        const int divideAmount = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(TbNum1.Text);
            double num2 = double.Parse(TbNum2.Text);
            double num3 = double.Parse(TbNum3.Text);

            double average = (num1 + num2 + num3) / divideAmount;

            LabelResult.Text = "average: " + average.ToString("0.000");

            TbNum1.Text = "";
            TbNum2.Text = "";
            TbNum3.Text = "";
        }
    }
}
