
namespace Oefening_4
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
            this.LabelAskInput = new System.Windows.Forms.Label();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.LabelVAT = new System.Windows.Forms.Label();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.InputTextbox = new System.Windows.Forms.TextBox();
            this.DisplayPrice = new System.Windows.Forms.Label();
            this.DisplayVAT = new System.Windows.Forms.Label();
            this.DisplayTotal = new System.Windows.Forms.Label();
            this.ButtonCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelAskInput
            // 
            this.LabelAskInput.AutoSize = true;
            this.LabelAskInput.Location = new System.Drawing.Point(13, 16);
            this.LabelAskInput.Name = "LabelAskInput";
            this.LabelAskInput.Size = new System.Drawing.Size(99, 20);
            this.LabelAskInput.TabIndex = 0;
            this.LabelAskInput.Text = "Enter a price: ";
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Location = new System.Drawing.Point(12, 222);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(44, 20);
            this.LabelPrice.TabIndex = 1;
            this.LabelPrice.Text = "Price:";
            // 
            // LabelVAT
            // 
            this.LabelVAT.AutoSize = true;
            this.LabelVAT.Location = new System.Drawing.Point(13, 246);
            this.LabelVAT.Name = "LabelVAT";
            this.LabelVAT.Size = new System.Drawing.Size(41, 20);
            this.LabelVAT.TabIndex = 2;
            this.LabelVAT.Text = "VAT: ";
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Location = new System.Drawing.Point(13, 270);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(42, 20);
            this.LabelTotal.TabIndex = 3;
            this.LabelTotal.Text = "Total";
            // 
            // InputTextbox
            // 
            this.InputTextbox.Location = new System.Drawing.Point(233, 13);
            this.InputTextbox.Name = "InputTextbox";
            this.InputTextbox.Size = new System.Drawing.Size(173, 27);
            this.InputTextbox.TabIndex = 4;
            // 
            // DisplayPrice
            // 
            this.DisplayPrice.AutoSize = true;
            this.DisplayPrice.Location = new System.Drawing.Point(233, 222);
            this.DisplayPrice.Name = "DisplayPrice";
            this.DisplayPrice.Size = new System.Drawing.Size(90, 20);
            this.DisplayPrice.TabIndex = 5;
            this.DisplayPrice.Text = "DisplayPrice";
            // 
            // DisplayVAT
            // 
            this.DisplayVAT.AutoSize = true;
            this.DisplayVAT.Location = new System.Drawing.Point(233, 246);
            this.DisplayVAT.Name = "DisplayVAT";
            this.DisplayVAT.Size = new System.Drawing.Size(83, 20);
            this.DisplayVAT.TabIndex = 6;
            this.DisplayVAT.Text = "DisplayVAT";
            // 
            // DisplayTotal
            // 
            this.DisplayTotal.AutoSize = true;
            this.DisplayTotal.Location = new System.Drawing.Point(233, 268);
            this.DisplayTotal.Name = "DisplayTotal";
            this.DisplayTotal.Size = new System.Drawing.Size(91, 20);
            this.DisplayTotal.TabIndex = 7;
            this.DisplayTotal.Text = "DisplayTotal";
            // 
            // ButtonCalculate
            // 
            this.ButtonCalculate.Location = new System.Drawing.Point(13, 60);
            this.ButtonCalculate.Name = "ButtonCalculate";
            this.ButtonCalculate.Size = new System.Drawing.Size(392, 44);
            this.ButtonCalculate.TabIndex = 8;
            this.ButtonCalculate.Text = "Calculate";
            this.ButtonCalculate.UseVisualStyleBackColor = true;
            this.ButtonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 305);
            this.Controls.Add(this.ButtonCalculate);
            this.Controls.Add(this.DisplayTotal);
            this.Controls.Add(this.DisplayVAT);
            this.Controls.Add(this.DisplayPrice);
            this.Controls.Add(this.InputTextbox);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.LabelVAT);
            this.Controls.Add(this.LabelPrice);
            this.Controls.Add(this.LabelAskInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAskInput;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Label LabelVAT;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.TextBox InputTextbox;
        private System.Windows.Forms.Label DisplayPrice;
        private System.Windows.Forms.Label DisplayVAT;
        private System.Windows.Forms.Label DisplayTotal;
        private System.Windows.Forms.Button ButtonCalculate;
    }
}

