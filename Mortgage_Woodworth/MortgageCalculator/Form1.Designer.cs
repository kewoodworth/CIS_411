namespace MortgageCalculator
{
    partial class mortgageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.homePriceTextBox = new System.Windows.Forms.TextBox();
            this.homePriceLabel = new System.Windows.Forms.Label();
            this.downPaymentTextBox = new System.Windows.Forms.TextBox();
            this.downPaymentLabel = new System.Windows.Forms.Label();
            this.interestRateTextBox = new System.Windows.Forms.TextBox();
            this.interestRateLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.mortgageTermLabel = new System.Windows.Forms.Label();
            this.TermNumeric = new System.Windows.Forms.NumericUpDown();
            this.yearsLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.monthlyPaymentLabel = new System.Windows.Forms.Label();
            this.paymentTextBox = new System.Windows.Forms.TextBox();
            this.downPaymentPercentLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.amortDataGrid = new System.Windows.Forms.DataGridView();
            this.pmtInterval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pmtAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pmtInterest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pmtPrincipal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interestTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.principalTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TermNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amortDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // homePriceTextBox
            // 
            this.homePriceTextBox.Location = new System.Drawing.Point(25, 74);
            this.homePriceTextBox.Name = "homePriceTextBox";
            this.homePriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.homePriceTextBox.TabIndex = 0;
            // 
            // homePriceLabel
            // 
            this.homePriceLabel.AutoSize = true;
            this.homePriceLabel.Location = new System.Drawing.Point(22, 59);
            this.homePriceLabel.Name = "homePriceLabel";
            this.homePriceLabel.Size = new System.Drawing.Size(62, 13);
            this.homePriceLabel.TabIndex = 1;
            this.homePriceLabel.Text = "Home Price";
            // 
            // downPaymentTextBox
            // 
            this.downPaymentTextBox.Location = new System.Drawing.Point(25, 127);
            this.downPaymentTextBox.Name = "downPaymentTextBox";
            this.downPaymentTextBox.Size = new System.Drawing.Size(100, 20);
            this.downPaymentTextBox.TabIndex = 2;
            // 
            // downPaymentLabel
            // 
            this.downPaymentLabel.AutoSize = true;
            this.downPaymentLabel.Location = new System.Drawing.Point(22, 111);
            this.downPaymentLabel.Name = "downPaymentLabel";
            this.downPaymentLabel.Size = new System.Drawing.Size(79, 13);
            this.downPaymentLabel.TabIndex = 3;
            this.downPaymentLabel.Text = "Down Payment";
            // 
            // interestRateTextBox
            // 
            this.interestRateTextBox.Location = new System.Drawing.Point(25, 194);
            this.interestRateTextBox.Name = "interestRateTextBox";
            this.interestRateTextBox.Size = new System.Drawing.Size(59, 20);
            this.interestRateTextBox.TabIndex = 4;
            this.interestRateTextBox.Text = "3.95";
            // 
            // interestRateLabel
            // 
            this.interestRateLabel.AutoSize = true;
            this.interestRateLabel.Location = new System.Drawing.Point(22, 178);
            this.interestRateLabel.Name = "interestRateLabel";
            this.interestRateLabel.Size = new System.Drawing.Size(68, 13);
            this.interestRateLabel.TabIndex = 5;
            this.interestRateLabel.Text = "Interest Rate";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(25, 295);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 6;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // mortgageTermLabel
            // 
            this.mortgageTermLabel.AutoSize = true;
            this.mortgageTermLabel.Location = new System.Drawing.Point(22, 236);
            this.mortgageTermLabel.Name = "mortgageTermLabel";
            this.mortgageTermLabel.Size = new System.Drawing.Size(79, 13);
            this.mortgageTermLabel.TabIndex = 9;
            this.mortgageTermLabel.Text = "Mortgage Term";
            // 
            // TermNumeric
            // 
            this.TermNumeric.Location = new System.Drawing.Point(25, 252);
            this.TermNumeric.Name = "TermNumeric";
            this.TermNumeric.Size = new System.Drawing.Size(59, 20);
            this.TermNumeric.TabIndex = 10;
            this.TermNumeric.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // yearsLabel
            // 
            this.yearsLabel.AutoSize = true;
            this.yearsLabel.Location = new System.Drawing.Point(91, 254);
            this.yearsLabel.Name = "yearsLabel";
            this.yearsLabel.Size = new System.Drawing.Size(34, 13);
            this.yearsLabel.TabIndex = 11;
            this.yearsLabel.Text = "Years";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(53, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(171, 25);
            this.titleLabel.TabIndex = 13;
            this.titleLabel.Text = "Mortgage Calculator";
            // 
            // monthlyPaymentLabel
            // 
            this.monthlyPaymentLabel.AutoSize = true;
            this.monthlyPaymentLabel.Location = new System.Drawing.Point(22, 340);
            this.monthlyPaymentLabel.Name = "monthlyPaymentLabel";
            this.monthlyPaymentLabel.Size = new System.Drawing.Size(88, 13);
            this.monthlyPaymentLabel.TabIndex = 14;
            this.monthlyPaymentLabel.Text = "Monthly Payment";
            // 
            // paymentTextBox
            // 
            this.paymentTextBox.Location = new System.Drawing.Point(47, 356);
            this.paymentTextBox.Name = "paymentTextBox";
            this.paymentTextBox.ReadOnly = true;
            this.paymentTextBox.Size = new System.Drawing.Size(100, 20);
            this.paymentTextBox.TabIndex = 15;
            // 
            // downPaymentPercentLabel
            // 
            this.downPaymentPercentLabel.AutoSize = true;
            this.downPaymentPercentLabel.ForeColor = System.Drawing.Color.Maroon;
            this.downPaymentPercentLabel.Location = new System.Drawing.Point(22, 150);
            this.downPaymentPercentLabel.Name = "downPaymentPercentLabel";
            this.downPaymentPercentLabel.Size = new System.Drawing.Size(0, 13);
            this.downPaymentPercentLabel.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "$";
            // 
            // amortDataGrid
            // 
            this.amortDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.amortDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pmtInterval,
            this.pmtAmount,
            this.pmtInterest,
            this.pmtPrincipal,
            this.interestTotal,
            this.principalTotal,
            this.remainder});
            this.amortDataGrid.Location = new System.Drawing.Point(255, 59);
            this.amortDataGrid.Name = "amortDataGrid";
            this.amortDataGrid.Size = new System.Drawing.Size(759, 327);
            this.amortDataGrid.TabIndex = 20;
            // 
            // pmtInterval
            // 
            this.pmtInterval.HeaderText = "Payment Interval";
            this.pmtInterval.Name = "pmtInterval";
            this.pmtInterval.ReadOnly = true;
            // 
            // pmtAmount
            // 
            this.pmtAmount.HeaderText = "Payment Amount";
            this.pmtAmount.Name = "pmtAmount";
            this.pmtAmount.ReadOnly = true;
            // 
            // pmtInterest
            // 
            this.pmtInterest.HeaderText = "Payment to Interest";
            this.pmtInterest.Name = "pmtInterest";
            this.pmtInterest.ReadOnly = true;
            // 
            // pmtPrincipal
            // 
            this.pmtPrincipal.HeaderText = "Payment to Principal";
            this.pmtPrincipal.Name = "pmtPrincipal";
            this.pmtPrincipal.ReadOnly = true;
            // 
            // interestTotal
            // 
            this.interestTotal.HeaderText = "Total Paid to Interest";
            this.interestTotal.Name = "interestTotal";
            this.interestTotal.ReadOnly = true;
            // 
            // principalTotal
            // 
            this.principalTotal.HeaderText = "Total Paid to Principal";
            this.principalTotal.Name = "principalTotal";
            this.principalTotal.ReadOnly = true;
            // 
            // remainder
            // 
            this.remainder.HeaderText = "Remainder";
            this.remainder.Name = "remainder";
            this.remainder.ReadOnly = true;
            // 
            // mortgageForm
            // 
            this.AcceptButton = this.calcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1026, 398);
            this.Controls.Add(this.amortDataGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.downPaymentPercentLabel);
            this.Controls.Add(this.paymentTextBox);
            this.Controls.Add(this.monthlyPaymentLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.yearsLabel);
            this.Controls.Add(this.TermNumeric);
            this.Controls.Add(this.mortgageTermLabel);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.interestRateLabel);
            this.Controls.Add(this.interestRateTextBox);
            this.Controls.Add(this.downPaymentLabel);
            this.Controls.Add(this.downPaymentTextBox);
            this.Controls.Add(this.homePriceLabel);
            this.Controls.Add(this.homePriceTextBox);
            this.Name = "mortgageForm";
            this.Text = "Mortgage Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.TermNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amortDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox homePriceTextBox;
        private System.Windows.Forms.Label homePriceLabel;
        private System.Windows.Forms.TextBox downPaymentTextBox;
        private System.Windows.Forms.Label downPaymentLabel;
        private System.Windows.Forms.TextBox interestRateTextBox;
        private System.Windows.Forms.Label interestRateLabel;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label mortgageTermLabel;
        private System.Windows.Forms.NumericUpDown TermNumeric;
        private System.Windows.Forms.Label yearsLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label monthlyPaymentLabel;
        private System.Windows.Forms.TextBox paymentTextBox;
        private System.Windows.Forms.Label downPaymentPercentLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView amortDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn pmtInterval;
        private System.Windows.Forms.DataGridViewTextBoxColumn pmtAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn pmtInterest;
        private System.Windows.Forms.DataGridViewTextBoxColumn pmtPrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn principalTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainder;
    }
}

