using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FutureValue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // TODO: Declare the rectangular array and the row index here
        private string[,] valuesArray = new string[3, 4]; // change row index for changing dataset numbers
        private int row = 0;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    decimal monthlyInvestment =
                        Convert.ToDecimal(txtMonthlyInvestment.Text);
                    decimal interestRateYearly =
                        Convert.ToDecimal(txtInterestRate.Text);
                    int years = Convert.ToInt32(txtYears.Text);

                    int months = years * 12;
                    decimal interestRateMonthly = interestRateYearly / 12 / 100;

                    decimal futureValue = CalculateFutureValue(
                        monthlyInvestment, interestRateMonthly, months);
                    txtFutureValue.Text = futureValue.ToString("c");
                    txtMonthlyInvestment.Focus();

                    // TODO: Add the calculation to the rectangular array here
                    if (row < 3)
                    {
                        valuesArray[row, 0] = monthlyInvestment.ToString("c"); // first is for monthlyInvestment and so on. 
                        valuesArray[row, 1] = interestRateYearly + "%".ToString();
                        valuesArray[row, 2] = years.ToString();
                        valuesArray[row, 3] = futureValue.ToString("c");
                        row++;
                    }
                    else
                    {
                        MessageBox.Show("You have entered the MAX datasets. Please exit.", "Entry Error");

                    }

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");
            }
        }

        public bool IsValidData()
        {
            return
                // Validate the Monthly Investment text box
                IsPresent(txtMonthlyInvestment, "Monthly Investment") &&
                IsDecimal(txtMonthlyInvestment, "Monthly Investment") &&
                IsWithinRange(txtMonthlyInvestment, "Monthly Investment", 1, 1000) &&

                // Validate the Yearly Interest Rate text box
                IsPresent(txtInterestRate, "Yearly Interest Rate") &&
                IsDecimal(txtInterestRate, "Yearly Interest Rate") &&
                IsWithinRange(txtInterestRate, "Yearly Interest Rate", 1, 20) &&

                // Validate the Number of Years text box
                IsPresent(txtYears, "Number of Years") &&
                IsInt32(txtYears, "Number of Years") &&
                IsWithinRange(txtYears, "Number of Years", 1, 40);
        }

        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsDecimal(TextBox textBox, string name)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(name + " must be a decimal value.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public bool IsInt32(TextBox textBox, string name)
        {
            try
            {
                Convert.ToInt32(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(name + " must be an integer.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public bool IsWithinRange(TextBox textBox, string name,
            decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min
                    + " and " + max + ".", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        private decimal CalculateFutureValue(decimal monthlyInvestment,
           decimal monthlyInterestRate, int months)
        {
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment)
                    * (1 + monthlyInterestRate);
            }

            return futureValue;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            String output;
            // Check if there is at least one dataset entered before Exit clicked.
            if (valuesArray[0, 0] == null)
            {
                output = "No data entered. Do you really want to exit?";
                // page 307
                DialogResult button = MessageBox.Show(output, "Entry Error, Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (button == DialogResult.Yes)
                {
                    this.Close(); // exit app.
                }
                if (button == DialogResult.No)
                {
                    this.txtMonthlyInvestment.Focus(); // focus on the first iuput box.
                }
            }
            else
            {
                // TODO: Display the rectangular array in a dialog box here
                output = "Inv/Mo.\tRate\tYears\tFuture Value\n";
                for (int i = 0; i < valuesArray.GetLength(0); i++)
                {
                    if (valuesArray[i, 0] != null)
                    {
                        for (int j = 0; j < valuesArray.GetLength(1); j++)
                        {
                            output += valuesArray[i, j] + "\t";
                        }
                        output += "\n";
                    }
                }
                MessageBox.Show(output, "Future Value Calculations - Save early and be rich!");

                this.Close();
            }
        }// end of btnExit_Click()

    }
}