using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace mortgageCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            try
            {
                double loan;
                double interest;
                double years;
                double count = 0.0;
                double monthlyPayment;
                double totalMonPay=0.0;
                double totalLoans = 0.0;
                double avgMonPay = 0.0;

                if (double.TryParse(loanBox1.Text, out loan))
                {
                    count += loan;
                }

                else
                {
                    //Incorrect Loan
                    MessageBox.Show("The Loan input is incorrect");
                }

                if (double.TryParse(interestBox2.Text, out interest))
                {
                    interest = interest / 100;
                    interest = interest / 12;
                    count += interest;
                }

                else
                {
                    //Incorrect Interest
                    MessageBox.Show("The Interest Rate Value is Incorrect");
                }

                if (double.TryParse(yearsBox3.Text, out years))
                {
                     years = years*12;
                }

                else
                {
                    //Incorrect Years
                    MessageBox.Show("Number of Years are incorrect");
                }


                monthlyPayment = Finacial.Pmt(interest, years, -loan);
                payment.Text = "Your monthly payment is:" + monthlyPayment;


                totalMonPay += monthlyPayment;
                paymentDisplay.Text = "Your Total Monthly Payment is:" + totalMonPay;

                totalLoans += loan;
                loanDisplay.Text = "Your Total loans Amount is:" + totalLoans;

                avgMonPay = totalLoans / totalMonPay;
                avgMonPayDisplay.Text = "Your Average Monthly Payment is" + avgMonPay;















            }

            catch(Exception ex)
            {

                //Display Error Message
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clears all texts
            loanBox1.Text = "";
            interestBox2.Text = "";
            yearsBox3.Text = "";
            payment.Text = "";
            loanDisplay.Text = "";
            paymentDisplay.Text = "";
            avgMonPayDisplay.Text = "";

            //Resets Focus
            loanBox1.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Exits Program
            this.Close();
        }
    }

    internal class Finacial
    {
        internal static double Pmt(double interest, double years, double v)
        {
            throw new NotImplementedException();
        }
    }
}
