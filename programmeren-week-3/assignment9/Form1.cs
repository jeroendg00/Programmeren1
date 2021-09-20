using System;
using System.Windows.Forms;

namespace assignment9
{
    public partial class Form1 : Form
    {
        const double MemberDiscount = 20;
        const double DiscountAge = 25;

        const int MemberDiscountTime = 10;
        const int DiscountAgeRequired = 40;

        public Form1()
        {
            InitializeComponent();

            // clear result label on start
            LabelResult.Text = "";
        }

        private void ButtonCalcFee_Click(object sender, EventArgs e)
        {
            // read textbox input
            int age = int.Parse(TextboxAge.Text);
            int memberTime = int.Parse(TextboxMembership.Text);

            // calculate and display result for football
            if (RadioButtonFootbal.Checked == true)
            {
                double fee = 175;
                fee = CheckAgeDiscount(age, fee);
                fee = CheckMemberDiscount(memberTime, fee);

                LabelResult.Text = "€ " + fee.ToString("0.00");
            }

            // calculate and display result for handball
            if (RadioButtonHandball.Checked == true)
            {
                double fee = 225;
                fee = CheckAgeDiscount(age, fee);
                fee = CheckMemberDiscount(memberTime, fee);

                LabelResult.Text = "€ " + fee.ToString("0.00");
            }
        }

        private double CheckAgeDiscount(int age, double fee)
        {
            // if age is over 40 return fee incl discount
            if (age > DiscountAgeRequired)
            {
                return fee - DiscountAge;
            }
            // else return default fee
            return fee;
        }

        private double CheckMemberDiscount(int memberTime, double fee)
        {
            // if member time is over 10 years return fee incl discount
            if (memberTime > MemberDiscountTime)
            {
                return fee - MemberDiscount;
            }
            // else return default fee
            return fee;
        }
    }
}
