using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening_6
{
    public partial class Form1 : Form
    {
        const int DivisionNumber = 60;
        public Form1()
        {
            InitializeComponent();
            // Set label to empty string
            LabelResult.Text = "";
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            // Read and parse input
            int seconds = int.Parse(TextBoxInputSeconds.Text);

            // Calculate seconds, minutes and hours
            int leftOverSeconds = seconds % DivisionNumber;
            int minutes = (seconds - leftOverSeconds) / DivisionNumber;
            int leftOverMinutes = minutes % DivisionNumber;
            int hours = (minutes - leftOverMinutes) / DivisionNumber;
            
            // Display result
            LabelResult.Text = $"{hours.ToString("00")}:{leftOverMinutes.ToString("00")}:{leftOverSeconds.ToString("00")}";

            // Reset textbox
            TextBoxInputSeconds.Text = "";
        }
    }
}
