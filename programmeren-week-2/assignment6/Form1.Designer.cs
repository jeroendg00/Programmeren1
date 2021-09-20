
namespace Oefening_6
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
            this.TextBoxInputSeconds = new System.Windows.Forms.TextBox();
            this.ButtonCalculate = new System.Windows.Forms.Button();
            this.LabelOutputFormat = new System.Windows.Forms.Label();
            this.LabelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelAskInput
            // 
            this.LabelAskInput.AutoSize = true;
            this.LabelAskInput.Location = new System.Drawing.Point(13, 13);
            this.LabelAskInput.Name = "LabelAskInput";
            this.LabelAskInput.Size = new System.Drawing.Size(67, 20);
            this.LabelAskInput.TabIndex = 0;
            this.LabelAskInput.Text = "Seconds:";
            // 
            // TextBoxInputSeconds
            // 
            this.TextBoxInputSeconds.Location = new System.Drawing.Point(160, 13);
            this.TextBoxInputSeconds.Name = "TextBoxInputSeconds";
            this.TextBoxInputSeconds.Size = new System.Drawing.Size(217, 27);
            this.TextBoxInputSeconds.TabIndex = 1;
            // 
            // ButtonCalculate
            // 
            this.ButtonCalculate.Location = new System.Drawing.Point(13, 63);
            this.ButtonCalculate.Name = "ButtonCalculate";
            this.ButtonCalculate.Size = new System.Drawing.Size(364, 37);
            this.ButtonCalculate.TabIndex = 2;
            this.ButtonCalculate.Text = "Calculate time";
            this.ButtonCalculate.UseVisualStyleBackColor = true;
            this.ButtonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // LabelOutputFormat
            // 
            this.LabelOutputFormat.AutoSize = true;
            this.LabelOutputFormat.Location = new System.Drawing.Point(13, 176);
            this.LabelOutputFormat.Name = "LabelOutputFormat";
            this.LabelOutputFormat.Size = new System.Drawing.Size(156, 20);
            this.LabelOutputFormat.TabIndex = 3;
            this.LabelOutputFormat.Text = "hours:minutes:seconds";
            // 
            // LabelResult
            // 
            this.LabelResult.AutoSize = true;
            this.LabelResult.Location = new System.Drawing.Point(13, 200);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(102, 20);
            this.LabelResult.TabIndex = 4;
            this.LabelResult.Text = "Display Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 235);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.LabelOutputFormat);
            this.Controls.Add(this.ButtonCalculate);
            this.Controls.Add(this.TextBoxInputSeconds);
            this.Controls.Add(this.LabelAskInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAskInput;
        private System.Windows.Forms.TextBox TextBoxInputSeconds;
        private System.Windows.Forms.Button ButtonCalculate;
        private System.Windows.Forms.Label LabelOutputFormat;
        private System.Windows.Forms.Label LabelResult;
    }
}

