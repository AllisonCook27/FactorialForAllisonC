/*
 * Created by: Allison Cook
 * Created on: 28 March, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #22 - Factorial For loop
 * This program calculates the factorial of a given number and shows the number of times it was multiplied
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorialForAllisonC
{
    public partial class frmFactorialFor : Form
    {
        public frmFactorialFor()
        {
            InitializeComponent();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //close the program when clicked
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //variables 
            int factorialCounter, factorialNumber, factorialAnswer;

            //set number to user input
            factorialNumber = Convert.ToInt32(numFactorial.Value);

            //clear list
            lstNumber.Items.Clear();

            //set answer
            factorialAnswer = 1;

            //looping through to calculate the answer and adding to list
            for (factorialCounter = 1; factorialCounter <= factorialNumber; factorialCounter++)
            {
                //addd to list
                lstNumber.Items.Add(factorialCounter);

                //get next answer
                factorialAnswer = factorialAnswer * factorialCounter;

            }

            //convert to text
            lblAnswer.Text = Convert.ToString(factorialNumber) + "! = " + Convert.ToString(factorialAnswer);
 
        }
    }
}
