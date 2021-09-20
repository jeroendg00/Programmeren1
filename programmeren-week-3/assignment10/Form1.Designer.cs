
namespace assignment10
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
            this.LabelAge = new System.Windows.Forms.Label();
            this.TextboxAge = new System.Windows.Forms.TextBox();
            this.ButtonCalcPrice = new System.Windows.Forms.Button();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.LabelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelAge
            // 
            this.LabelAge.AutoSize = true;
            this.LabelAge.Location = new System.Drawing.Point(23, 29);
            this.LabelAge.Name = "LabelAge";
            this.LabelAge.Size = new System.Drawing.Size(28, 15);
            this.LabelAge.TabIndex = 0;
            this.LabelAge.Text = "Age";
            // 
            // TextboxAge
            // 
            this.TextboxAge.Location = new System.Drawing.Point(207, 26);
            this.TextboxAge.Name = "TextboxAge";
            this.TextboxAge.Size = new System.Drawing.Size(133, 23);
            this.TextboxAge.TabIndex = 1;
            // 
            // ButtonCalcPrice
            // 
            this.ButtonCalcPrice.Location = new System.Drawing.Point(23, 83);
            this.ButtonCalcPrice.Name = "ButtonCalcPrice";
            this.ButtonCalcPrice.Size = new System.Drawing.Size(317, 38);
            this.ButtonCalcPrice.TabIndex = 2;
            this.ButtonCalcPrice.Text = "Calculate Price";
            this.ButtonCalcPrice.UseVisualStyleBackColor = true;
            this.ButtonCalcPrice.Click += new System.EventHandler(this.ButtonCalcPrice_Click);
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Location = new System.Drawing.Point(23, 133);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(65, 15);
            this.LabelPrice.TabIndex = 3;
            this.LabelPrice.Text = "Price ticket";
            // 
            // LabelResult
            // 
            this.LabelResult.AutoSize = true;
            this.LabelResult.Location = new System.Drawing.Point(207, 133);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(67, 15);
            this.LabelResult.TabIndex = 4;
            this.LabelResult.Text = "LabelResult";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 168);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.LabelPrice);
            this.Controls.Add(this.ButtonCalcPrice);
            this.Controls.Add(this.TextboxAge);
            this.Controls.Add(this.LabelAge);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAge;
        private System.Windows.Forms.TextBox TextboxAge;
        private System.Windows.Forms.Button ButtonCalcPrice;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Label LabelResult;
    }
}

