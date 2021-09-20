
namespace Oefening_7
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
            this.LabelAskStart = new System.Windows.Forms.Label();
            this.LabelEndKM = new System.Windows.Forms.Label();
            this.LabelPricePerKM = new System.Windows.Forms.Label();
            this.TextBoxStart = new System.Windows.Forms.TextBox();
            this.TextBoxEnd = new System.Windows.Forms.TextBox();
            this.TextBoxPriceKM = new System.Windows.Forms.TextBox();
            this.LabelStaticPriceExclVAT = new System.Windows.Forms.Label();
            this.ButtonErase = new System.Windows.Forms.Button();
            this.ButtonCalculate = new System.Windows.Forms.Button();
            this.LabelStaticVAT = new System.Windows.Forms.Label();
            this.LabelStaticPriceInclVAT = new System.Windows.Forms.Label();
            this.Line = new System.Windows.Forms.Label();
            this.LabelResultPriceExclVAT = new System.Windows.Forms.Label();
            this.LabelResultVAT = new System.Windows.Forms.Label();
            this.LabelResultPriceInclVAT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelAskStart
            // 
            this.LabelAskStart.AutoSize = true;
            this.LabelAskStart.Location = new System.Drawing.Point(13, 13);
            this.LabelAskStart.Name = "LabelAskStart";
            this.LabelAskStart.Size = new System.Drawing.Size(69, 20);
            this.LabelAskStart.TabIndex = 0;
            this.LabelAskStart.Text = "Start KM:";
            // 
            // LabelEndKM
            // 
            this.LabelEndKM.AutoSize = true;
            this.LabelEndKM.Location = new System.Drawing.Point(13, 61);
            this.LabelEndKM.Name = "LabelEndKM";
            this.LabelEndKM.Size = new System.Drawing.Size(63, 20);
            this.LabelEndKM.TabIndex = 2;
            this.LabelEndKM.Text = "End KM:";
            // 
            // LabelPricePerKM
            // 
            this.LabelPricePerKM.AutoSize = true;
            this.LabelPricePerKM.Location = new System.Drawing.Point(13, 109);
            this.LabelPricePerKM.Name = "LabelPricePerKM";
            this.LabelPricePerKM.Size = new System.Drawing.Size(96, 20);
            this.LabelPricePerKM.TabIndex = 4;
            this.LabelPricePerKM.Text = "Price per KM:";
            // 
            // TextBoxStart
            // 
            this.TextBoxStart.Location = new System.Drawing.Point(166, 10);
            this.TextBoxStart.Name = "TextBoxStart";
            this.TextBoxStart.Size = new System.Drawing.Size(125, 27);
            this.TextBoxStart.TabIndex = 5;
            // 
            // TextBoxEnd
            // 
            this.TextBoxEnd.Location = new System.Drawing.Point(166, 58);
            this.TextBoxEnd.Name = "TextBoxEnd";
            this.TextBoxEnd.Size = new System.Drawing.Size(125, 27);
            this.TextBoxEnd.TabIndex = 6;
            // 
            // TextBoxPriceKM
            // 
            this.TextBoxPriceKM.Location = new System.Drawing.Point(166, 106);
            this.TextBoxPriceKM.Name = "TextBoxPriceKM";
            this.TextBoxPriceKM.Size = new System.Drawing.Size(125, 27);
            this.TextBoxPriceKM.TabIndex = 7;
            // 
            // LabelStaticPriceExclVAT
            // 
            this.LabelStaticPriceExclVAT.AutoSize = true;
            this.LabelStaticPriceExclVAT.Location = new System.Drawing.Point(13, 190);
            this.LabelStaticPriceExclVAT.Name = "LabelStaticPriceExclVAT";
            this.LabelStaticPriceExclVAT.Size = new System.Drawing.Size(100, 20);
            this.LabelStaticPriceExclVAT.TabIndex = 8;
            this.LabelStaticPriceExclVAT.Text = "Price excl VAT";
            // 
            // ButtonErase
            // 
            this.ButtonErase.Location = new System.Drawing.Point(372, 9);
            this.ButtonErase.Name = "ButtonErase";
            this.ButtonErase.Size = new System.Drawing.Size(94, 29);
            this.ButtonErase.TabIndex = 9;
            this.ButtonErase.Text = "Erase";
            this.ButtonErase.UseVisualStyleBackColor = true;
            this.ButtonErase.Click += new System.EventHandler(this.ButtonErase_Click);
            // 
            // ButtonCalculate
            // 
            this.ButtonCalculate.Location = new System.Drawing.Point(372, 105);
            this.ButtonCalculate.Name = "ButtonCalculate";
            this.ButtonCalculate.Size = new System.Drawing.Size(94, 29);
            this.ButtonCalculate.TabIndex = 10;
            this.ButtonCalculate.Text = "Calculate";
            this.ButtonCalculate.UseVisualStyleBackColor = true;
            this.ButtonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // LabelStaticVAT
            // 
            this.LabelStaticVAT.AutoSize = true;
            this.LabelStaticVAT.Location = new System.Drawing.Point(194, 190);
            this.LabelStaticVAT.Name = "LabelStaticVAT";
            this.LabelStaticVAT.Size = new System.Drawing.Size(34, 20);
            this.LabelStaticVAT.TabIndex = 11;
            this.LabelStaticVAT.Text = "VAT";
            // 
            // LabelStaticPriceInclVAT
            // 
            this.LabelStaticPriceInclVAT.AutoSize = true;
            this.LabelStaticPriceInclVAT.Location = new System.Drawing.Point(369, 190);
            this.LabelStaticPriceInclVAT.Name = "LabelStaticPriceInclVAT";
            this.LabelStaticPriceInclVAT.Size = new System.Drawing.Size(97, 20);
            this.LabelStaticPriceInclVAT.TabIndex = 12;
            this.LabelStaticPriceInclVAT.Text = "Price incl VAT";
            // 
            // Line
            // 
            this.Line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Line.Location = new System.Drawing.Point(12, 221);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(453, 2);
            this.Line.TabIndex = 13;
            // 
            // LabelResultPriceExclVAT
            // 
            this.LabelResultPriceExclVAT.AutoSize = true;
            this.LabelResultPriceExclVAT.Location = new System.Drawing.Point(13, 237);
            this.LabelResultPriceExclVAT.Name = "LabelResultPriceExclVAT";
            this.LabelResultPriceExclVAT.Size = new System.Drawing.Size(100, 20);
            this.LabelResultPriceExclVAT.TabIndex = 14;
            this.LabelResultPriceExclVAT.Text = "Price excl VAT";
            // 
            // LabelResultVAT
            // 
            this.LabelResultVAT.AutoSize = true;
            this.LabelResultVAT.Location = new System.Drawing.Point(194, 237);
            this.LabelResultVAT.Name = "LabelResultVAT";
            this.LabelResultVAT.Size = new System.Drawing.Size(89, 20);
            this.LabelResultVAT.TabIndex = 15;
            this.LabelResultVAT.Text = "VAT amount";
            // 
            // LabelResultPriceInclVAT
            // 
            this.LabelResultPriceInclVAT.AutoSize = true;
            this.LabelResultPriceInclVAT.Location = new System.Drawing.Point(369, 237);
            this.LabelResultPriceInclVAT.Name = "LabelResultPriceInclVAT";
            this.LabelResultPriceInclVAT.Size = new System.Drawing.Size(97, 20);
            this.LabelResultPriceInclVAT.TabIndex = 16;
            this.LabelResultPriceInclVAT.Text = "Price incl VAT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 272);
            this.Controls.Add(this.LabelResultPriceInclVAT);
            this.Controls.Add(this.LabelResultVAT);
            this.Controls.Add(this.LabelResultPriceExclVAT);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.LabelStaticPriceInclVAT);
            this.Controls.Add(this.LabelStaticVAT);
            this.Controls.Add(this.ButtonCalculate);
            this.Controls.Add(this.ButtonErase);
            this.Controls.Add(this.LabelStaticPriceExclVAT);
            this.Controls.Add(this.TextBoxPriceKM);
            this.Controls.Add(this.TextBoxEnd);
            this.Controls.Add(this.TextBoxStart);
            this.Controls.Add(this.LabelPricePerKM);
            this.Controls.Add(this.LabelEndKM);
            this.Controls.Add(this.LabelAskStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAskStart;
        private System.Windows.Forms.Label LabelEndKM;
        private System.Windows.Forms.Label LabelPricePerKM;
        private System.Windows.Forms.TextBox TextBoxStart;
        private System.Windows.Forms.TextBox TextBoxEnd;
        private System.Windows.Forms.TextBox TextBoxPriceKM;
        private System.Windows.Forms.Label LabelStaticPriceExclVAT;
        private System.Windows.Forms.Button ButtonErase;
        private System.Windows.Forms.Button ButtonCalculate;
        private System.Windows.Forms.Label LabelStaticVAT;
        private System.Windows.Forms.Label LabelStaticPriceInclVAT;
        private System.Windows.Forms.Label Line;
        private System.Windows.Forms.Label LabelResultPriceExclVAT;
        private System.Windows.Forms.Label LabelResultVAT;
        private System.Windows.Forms.Label LabelResultPriceInclVAT;
    }
}

