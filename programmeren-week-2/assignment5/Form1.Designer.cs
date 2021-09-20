
namespace Oefening_5
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
            this.LabelNum1 = new System.Windows.Forms.Label();
            this.LabelNum2 = new System.Windows.Forms.Label();
            this.ThirdNumLabel = new System.Windows.Forms.Label();
            this.TbNum1 = new System.Windows.Forms.TextBox();
            this.TbNum2 = new System.Windows.Forms.TextBox();
            this.TbNum3 = new System.Windows.Forms.TextBox();
            this.ButtonCalculate = new System.Windows.Forms.Button();
            this.LabelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelNum1
            // 
            this.LabelNum1.AutoSize = true;
            this.LabelNum1.Location = new System.Drawing.Point(11, 10);
            this.LabelNum1.Name = "LabelNum1";
            this.LabelNum1.Size = new System.Drawing.Size(97, 15);
            this.LabelNum1.TabIndex = 0;
            this.LabelNum1.Text = "Enter 1st number";
            // 
            // LabelNum2
            // 
            this.LabelNum2.AutoSize = true;
            this.LabelNum2.Location = new System.Drawing.Point(10, 42);
            this.LabelNum2.Name = "LabelNum2";
            this.LabelNum2.Size = new System.Drawing.Size(102, 15);
            this.LabelNum2.TabIndex = 1;
            this.LabelNum2.Text = "Enter 2nd number";
            // 
            // ThirdNumLabel
            // 
            this.ThirdNumLabel.AutoSize = true;
            this.ThirdNumLabel.Location = new System.Drawing.Point(11, 76);
            this.ThirdNumLabel.Name = "ThirdNumLabel";
            this.ThirdNumLabel.Size = new System.Drawing.Size(99, 15);
            this.ThirdNumLabel.TabIndex = 2;
            this.ThirdNumLabel.Text = "Enter 3rd number";
            // 
            // TbNum1
            // 
            this.TbNum1.Location = new System.Drawing.Point(131, 8);
            this.TbNum1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbNum1.Name = "TbNum1";
            this.TbNum1.Size = new System.Drawing.Size(110, 23);
            this.TbNum1.TabIndex = 3;
            // 
            // TbNum2
            // 
            this.TbNum2.Location = new System.Drawing.Point(131, 40);
            this.TbNum2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbNum2.Name = "TbNum2";
            this.TbNum2.Size = new System.Drawing.Size(110, 23);
            this.TbNum2.TabIndex = 4;
            // 
            // TbNum3
            // 
            this.TbNum3.Location = new System.Drawing.Point(131, 74);
            this.TbNum3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbNum3.Name = "TbNum3";
            this.TbNum3.Size = new System.Drawing.Size(110, 23);
            this.TbNum3.TabIndex = 5;
            // 
            // ButtonCalculate
            // 
            this.ButtonCalculate.Location = new System.Drawing.Point(11, 109);
            this.ButtonCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonCalculate.Name = "ButtonCalculate";
            this.ButtonCalculate.Size = new System.Drawing.Size(229, 28);
            this.ButtonCalculate.TabIndex = 6;
            this.ButtonCalculate.Text = "Calculate Average";
            this.ButtonCalculate.UseVisualStyleBackColor = true;
            this.ButtonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // LabelResult
            // 
            this.LabelResult.AutoSize = true;
            this.LabelResult.Location = new System.Drawing.Point(11, 152);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(56, 15);
            this.LabelResult.TabIndex = 7;
            this.LabelResult.Text = "Average: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 178);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.ButtonCalculate);
            this.Controls.Add(this.TbNum3);
            this.Controls.Add(this.TbNum2);
            this.Controls.Add(this.TbNum1);
            this.Controls.Add(this.ThirdNumLabel);
            this.Controls.Add(this.LabelNum2);
            this.Controls.Add(this.LabelNum1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNum1;
        private System.Windows.Forms.Label LabelNum2;
        private System.Windows.Forms.Label ThirdNumLabel;
        private System.Windows.Forms.TextBox TbNum1;
        private System.Windows.Forms.TextBox TbNum2;
        private System.Windows.Forms.TextBox TbNum3;
        private System.Windows.Forms.Button ButtonCalculate;
        private System.Windows.Forms.Label LabelResult;
    }
}

