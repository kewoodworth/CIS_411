using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MortgageCalculator
{
    public partial class mortgageForm : Form
    {
        public mortgageForm()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            // math for monthly payment
            double homePrice = Convert.ToDouble(homePriceTextBox.Text);
            double downPayment = Convert.ToDouble(downPaymentTextBox.Text);
            double annualInterest = Convert.ToDouble(interestRateTextBox.Text) / 100;
            double mortgageTerm = Convert.ToDouble(TermNumeric.Value) * 12;

            // math for amortization table
            double principal = homePrice - downPayment;
            double n = mortgageTerm;
            double monthlyInterestPerecentage = annualInterest / 12;
            double monthlyPayment = (homePrice - downPayment) * (Math.Pow((1 + annualInterest / 12), mortgageTerm) * annualInterest) / (12 * (Math.Pow((1 + annualInterest / 12), mortgageTerm) - 1));
            double totalInterest = 0;
            double totalToPrincipal = 0;

            CalculateMortgage(downPayment, homePrice, mortgageTerm, annualInterest);

            amortDataGrid.ColumnCount = 7;
            amortDataGrid.Columns[0].HeaderText = "Payment Interval";
            amortDataGrid.Columns[1].HeaderText = "Payment Amount";
            amortDataGrid.Columns[2].HeaderText = "Payment to Interest";
            amortDataGrid.Columns[3].HeaderText = "Payment to Principal";
            amortDataGrid.Columns[4].HeaderText = "Total Paid to Interest";
            amortDataGrid.Columns[5].HeaderText = "Total Paid to Principal";
            amortDataGrid.Columns[6].HeaderText = "Remaining Balance";

            amortDataGrid.Rows.Clear();

            for (int payments = 1; payments <= mortgageTerm; payments++)
            {
                amortDataGrid.Rows.Add();
                amortDataGrid.Rows[payments - 1].Cells[0].Value = payments;                                 // Payment interval
                amortDataGrid.Rows[payments - 1].Cells[1].Value = monthlyPayment.ToString("c");             // Monthly payment amount
                double monthlyInterestPayment = monthlyInterestPerecentage * principal;
                amortDataGrid.Rows[payments - 1].Cells[2].Value = monthlyInterestPayment.ToString("c");     // Payment to interest
                double principalOnly = monthlyPayment - monthlyInterestPayment;
                amortDataGrid.Rows[payments - 1].Cells[3].Value = principalOnly.ToString("c");              // Payment to principal
                totalInterest += monthlyInterestPayment;
                amortDataGrid.Rows[payments - 1].Cells[4].Value = totalInterest.ToString("c");              // Total paid to interest
                totalToPrincipal += principalOnly;
                amortDataGrid.Rows[payments - 1].Cells[5].Value = totalToPrincipal.ToString("c");           // Total paid to principal
                principal -= principalOnly;
                amortDataGrid.Rows[payments - 1].Cells[6].Value = principal.ToString("c");                  // Remaining balance
            }
        }
        public void CalculateMortgage(double downPayment, double homePrice, double mortgageTerm, double interestRate)
        { 
            string downPaymentPercent = Convert.ToString(Math.Round(((downPayment / homePrice) * 100), 2));

            downPaymentPercentLabel.Text = $"Down Payment is " + downPaymentPercent + "% of home price";

            double payment = (homePrice - downPayment) * (Math.Pow((1 + interestRate / 12), mortgageTerm) * interestRate) / (12 * (Math.Pow((1 + interestRate / 12), mortgageTerm) - 1));
            payment = Math.Round((double)payment, 2);

            paymentTextBox.Text = Convert.ToString(payment);
        }
    }
}
