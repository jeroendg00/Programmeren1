
namespace assignment9
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
            this.LabelSport = new System.Windows.Forms.Label();
            this.LabelAge = new System.Windows.Forms.Label();
            this.RadioButtonFootbal = new System.Windows.Forms.RadioButton();
            this.RadioButtonHandball = new System.Windows.Forms.RadioButton();
            this.LabelMembership = new System.Windows.Forms.Label();
            this.TextboxAge = new System.Windows.Forms.TextBox();
            this.TextboxMembership = new System.Windows.Forms.TextBox();
            this.ButtonCalcFee = new System.Windows.Forms.Button();
            this.LabelFee = new System.Windows.Forms.Label();
            this.LabelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelSport
            // 
            this.LabelSport.AutoSize = true;
            this.LabelSport.Location = new System.Drawing.Point(26, 29);
            this.LabelSport.Name = "LabelSport";
            this.LabelSport.Size = new System.Drawing.Size(35, 15);
            this.LabelSport.TabIndex = 0;
            this.LabelSport.Text = "Sport";
            // 
            // LabelAge
            // 
            this.LabelAge.AutoSize = true;
            this.LabelAge.Location = new System.Drawing.Point(26, 97);
            this.LabelAge.Name = "LabelAge";
            this.LabelAge.Size = new System.Drawing.Size(28, 15);
            this.LabelAge.TabIndex = 1;
            this.LabelAge.Text = "Age";
            // 
            // RadioButtonFootbal
            // 
            this.RadioButtonFootbal.AutoSize = true;
            this.RadioButtonFootbal.Location = new System.Drawing.Point(214, 27);
            this.RadioButtonFootbal.Name = "RadioButtonFootbal";
            this.RadioButtonFootbal.Size = new System.Drawing.Size(68, 19);
            this.RadioButtonFootbal.TabIndex = 2;
            this.RadioButtonFootbal.TabStop = true;
            this.RadioButtonFootbal.Text = "Football";
            this.RadioButtonFootbal.UseVisualStyleBackColor = true;
            // 
            // RadioButtonHandball
            // 
            this.RadioButtonHandball.AutoSize = true;
            this.RadioButtonHandball.Location = new System.Drawing.Point(214, 52);
            this.RadioButtonHandball.Name = "RadioButtonHandball";
            this.RadioButtonHandball.Size = new System.Drawing.Size(73, 19);
            this.RadioButtonHandball.TabIndex = 3;
            this.RadioButtonHandball.TabStop = true;
            this.RadioButtonHandball.Text = "Handball";
            this.RadioButtonHandball.UseVisualStyleBackColor = true;
            // 
            // LabelMembership
            // 
            this.LabelMembership.AutoSize = true;
            this.LabelMembership.Location = new System.Drawing.Point(26, 132);
            this.LabelMembership.Name = "LabelMembership";
            this.LabelMembership.Size = new System.Drawing.Size(122, 15);
            this.LabelMembership.TabIndex = 4;
            this.LabelMembership.Text = "Membership duration";
            // 
            // TextboxAge
            // 
            this.TextboxAge.Location = new System.Drawing.Point(208, 94);
            this.TextboxAge.Name = "TextboxAge";
            this.TextboxAge.Size = new System.Drawing.Size(116, 23);
            this.TextboxAge.TabIndex = 5;
            // 
            // TextboxMembership
            // 
            this.TextboxMembership.Location = new System.Drawing.Point(208, 129);
            this.TextboxMembership.Name = "TextboxMembership";
            this.TextboxMembership.Size = new System.Drawing.Size(116, 23);
            this.TextboxMembership.TabIndex = 6;
            // 
            // ButtonCalcFee
            // 
            this.ButtonCalcFee.Location = new System.Drawing.Point(26, 167);
            this.ButtonCalcFee.Name = "ButtonCalcFee";
            this.ButtonCalcFee.Size = new System.Drawing.Size(298, 44);
            this.ButtonCalcFee.TabIndex = 7;
            this.ButtonCalcFee.Text = "Calculate Fee";
            this.ButtonCalcFee.UseVisualStyleBackColor = true;
            this.ButtonCalcFee.Click += new System.EventHandler(this.ButtonCalcFee_Click);
            // 
            // LabelFee
            // 
            this.LabelFee.AutoSize = true;
            this.LabelFee.Location = new System.Drawing.Point(26, 233);
            this.LabelFee.Name = "LabelFee";
            this.LabelFee.Size = new System.Drawing.Size(81, 15);
            this.LabelFee.TabIndex = 8;
            this.LabelFee.Text = "Fee to be paid";
            // 
            // LabelResult
            // 
            this.LabelResult.AutoSize = true;
            this.LabelResult.Location = new System.Drawing.Point(208, 233);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(67, 15);
            this.LabelResult.TabIndex = 9;
            this.LabelResult.Text = "LabelResult";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 280);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.LabelFee);
            this.Controls.Add(this.ButtonCalcFee);
            this.Controls.Add(this.TextboxMembership);
            this.Controls.Add(this.TextboxAge);
            this.Controls.Add(this.LabelMembership);
            this.Controls.Add(this.RadioButtonHandball);
            this.Controls.Add(this.RadioButtonFootbal);
            this.Controls.Add(this.LabelAge);
            this.Controls.Add(this.LabelSport);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelSport;
        private System.Windows.Forms.Label LabelAge;
        private System.Windows.Forms.RadioButton RadioButtonFootbal;
        private System.Windows.Forms.RadioButton RadioButtonHandball;
        private System.Windows.Forms.Label LabelMembership;
        private System.Windows.Forms.TextBox TextboxAge;
        private System.Windows.Forms.TextBox TextboxMembership;
        private System.Windows.Forms.Button ButtonCalcFee;
        private System.Windows.Forms.Label LabelFee;
        private System.Windows.Forms.Label LabelResult;
    }
}

