
namespace Oefening_8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelAskTshirts = new System.Windows.Forms.Label();
            this.LabelAskJeans = new System.Windows.Forms.Label();
            this.TbInputTees = new System.Windows.Forms.TextBox();
            this.TbInputJeans = new System.Windows.Forms.TextBox();
            this.ButtonCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LabelDisplayDate = new System.Windows.Forms.Label();
            this.LabelDisplayPrice = new System.Windows.Forms.Label();
            this.LabelDisplayVAT = new System.Windows.Forms.Label();
            this.LabelDisplayTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelAskTshirts
            // 
            this.LabelAskTshirts.AutoSize = true;
            this.LabelAskTshirts.Location = new System.Drawing.Point(13, 13);
            this.LabelAskTshirts.Name = "LabelAskTshirts";
            this.LabelAskTshirts.Size = new System.Drawing.Size(205, 20);
            this.LabelAskTshirts.TabIndex = 0;
            this.LabelAskTshirts.Text = "Number of T-shirst ( x $30.00)";
            // 
            // LabelAskJeans
            // 
            this.LabelAskJeans.AutoSize = true;
            this.LabelAskJeans.Location = new System.Drawing.Point(13, 53);
            this.LabelAskJeans.Name = "LabelAskJeans";
            this.LabelAskJeans.Size = new System.Drawing.Size(195, 20);
            this.LabelAskJeans.TabIndex = 1;
            this.LabelAskJeans.Text = "Number of jeans (x $100.00)";
            // 
            // TbInputTees
            // 
            this.TbInputTees.Location = new System.Drawing.Point(224, 10);
            this.TbInputTees.Name = "TbInputTees";
            this.TbInputTees.Size = new System.Drawing.Size(125, 27);
            this.TbInputTees.TabIndex = 2;
            // 
            // TbInputJeans
            // 
            this.TbInputJeans.Location = new System.Drawing.Point(224, 50);
            this.TbInputJeans.Name = "TbInputJeans";
            this.TbInputJeans.Size = new System.Drawing.Size(125, 27);
            this.TbInputJeans.TabIndex = 3;
            // 
            // ButtonCalculate
            // 
            this.ButtonCalculate.Location = new System.Drawing.Point(13, 95);
            this.ButtonCalculate.Name = "ButtonCalculate";
            this.ButtonCalculate.Size = new System.Drawing.Size(336, 39);
            this.ButtonCalculate.TabIndex = 4;
            this.ButtonCalculate.Text = "Calculate";
            this.ButtonCalculate.UseVisualStyleBackColor = true;
            this.ButtonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Invoice";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(13, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 2);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(13, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 2);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "VAT:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Total:";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(12, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(2, 163);
            this.label8.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(347, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(2, 163);
            this.label9.TabIndex = 13;
            // 
            // LabelDisplayDate
            // 
            this.LabelDisplayDate.AutoSize = true;
            this.LabelDisplayDate.Location = new System.Drawing.Point(187, 222);
            this.LabelDisplayDate.Name = "LabelDisplayDate";
            this.LabelDisplayDate.Size = new System.Drawing.Size(126, 20);
            this.LabelDisplayDate.TabIndex = 14;
            this.LabelDisplayDate.Text = "LabelDisplayDate";
            // 
            // LabelDisplayPrice
            // 
            this.LabelDisplayPrice.AutoSize = true;
            this.LabelDisplayPrice.Location = new System.Drawing.Point(187, 252);
            this.LabelDisplayPrice.Name = "LabelDisplayPrice";
            this.LabelDisplayPrice.Size = new System.Drawing.Size(126, 20);
            this.LabelDisplayPrice.TabIndex = 15;
            this.LabelDisplayPrice.Text = "LabelDisplayPrice";
            // 
            // LabelDisplayVAT
            // 
            this.LabelDisplayVAT.AutoSize = true;
            this.LabelDisplayVAT.Location = new System.Drawing.Point(187, 283);
            this.LabelDisplayVAT.Name = "LabelDisplayVAT";
            this.LabelDisplayVAT.Size = new System.Drawing.Size(119, 20);
            this.LabelDisplayVAT.TabIndex = 16;
            this.LabelDisplayVAT.Text = "LabelDisplayVAT";
            // 
            // LabelDisplayTotal
            // 
            this.LabelDisplayTotal.AutoSize = true;
            this.LabelDisplayTotal.Location = new System.Drawing.Point(187, 313);
            this.LabelDisplayTotal.Name = "LabelDisplayTotal";
            this.LabelDisplayTotal.Size = new System.Drawing.Size(127, 20);
            this.LabelDisplayTotal.TabIndex = 17;
            this.LabelDisplayTotal.Text = "LabelDisplayTotal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 391);
            this.Controls.Add(this.LabelDisplayTotal);
            this.Controls.Add(this.LabelDisplayVAT);
            this.Controls.Add(this.LabelDisplayPrice);
            this.Controls.Add(this.LabelDisplayDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonCalculate);
            this.Controls.Add(this.TbInputJeans);
            this.Controls.Add(this.TbInputTees);
            this.Controls.Add(this.LabelAskJeans);
            this.Controls.Add(this.LabelAskTshirts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAskTshirts;
        private System.Windows.Forms.Label LabelAskJeans;
        private System.Windows.Forms.TextBox TbInputTees;
        private System.Windows.Forms.TextBox TbInputJeans;
        private System.Windows.Forms.Button ButtonCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LabelDisplayDate;
        private System.Windows.Forms.Label LabelDisplayPrice;
        private System.Windows.Forms.Label LabelDisplayVAT;
        private System.Windows.Forms.Label LabelDisplayTotal;
    }
}

