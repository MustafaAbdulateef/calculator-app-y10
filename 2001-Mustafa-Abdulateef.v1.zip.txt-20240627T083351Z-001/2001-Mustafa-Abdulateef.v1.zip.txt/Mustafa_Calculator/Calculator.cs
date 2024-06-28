using System;
using System.Linq.Expressions;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mustafa_Calculator
{
    public partial class Calculator : Form
    {
        // The following establishes variables and values.

        private decimal valueFirst = 0.0m;
        // This line sets a variable called "valueFirst" equal to 0.0m.
        // The 'm' makes sure that the value is decimal rather than a double.

        private decimal valueSecond = 0.0m;

        private decimal Result = 0.0m;



        // The following stores the operator that is currently in use.

        private string currentOperator = "+";
        // The variable is "currentOperators", the data type is a string and value is "+".
        // When used in an if statement such as "if add button is clicked" the currentOperator would be equal to '+' else the currentOperator is equal to '-' .

        private string input = string.Empty;

        private string operand1 = string.Empty;

        private string operand2 = string.Empty;

        private double results = 0.0;

        private bool nonNumberEntered = false;

        //The following is necessary for the program to run.
        public Calculator()
        // This is required for the program to run and call procedures.
        {
            InitializeComponent();
            //This is necessary for object properties to run and initialise for windows such as buttons and text boxes used in my design.

        }
        // The following is an operations switch sets the method for how all operations are reacted to when clicked.
        // A form of method for when the equals button is clicked the program knows what to do.
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            switch (currentOperator)
            // The switch searches the value of operators for the one that has been clicked.
            {
                case "-":
                    // "case" is saying if the case is minus then do this etc.
                    // "textBoxDisplay.Text" retrives the current state of what the textbox holds or has inside it.
                    // "decimal.parse" converts the string into decimal.
                    // If successful the decimal value is assigned to the variable "valueSecond".


                    valueSecond = decimal.Parse(textBoxDisplay.Text);

                    // The result is the variable firstvalue minus the second value.
                    Result = valueFirst - valueSecond;

                    // Then it displays it in the textbox.
                    textBoxDisplay.Text = Result.ToString();

                    break;



                case "+":

                    valueSecond = decimal.Parse(textBoxDisplay.Text);

                    Result = valueFirst + valueSecond;

                    textBoxDisplay.Text = Result.ToString();

                    break;



                case "×":

                    valueSecond = decimal.Parse(textBoxDisplay.Text);

                    Result = valueFirst * valueSecond;

                    textBoxDisplay.Text = Result.ToString();

                    break;



                case "÷":

                    try
                    {
                        valueSecond = decimal.Parse(textBoxDisplay.Text);

                        Result = valueFirst / valueSecond;

                        textBoxDisplay.Text = Result.ToString();
                    }
                    catch (DivideByZeroException)
                    // This creates an exception to catch out errors.
                    // If there is a "try" there is a "catch".
                    {
                        MessageBox.Show ("Cannot divide by zero");

                        // This makes sure that the actual text box displays the error.
                    }
                    break;



                case "poy":

                    valueSecond = decimal.Parse(textBoxDisplay.Text);

                    Result = Convert.ToDecimal(Math.Pow(Convert.ToDouble(valueFirst), Convert.ToDouble(valueSecond)));
                    // "valueFirst" and "valueSecond" are converted into the data type double.
                    // This is needed for math.pow to run.
                    // The values are then converted back into decimals and inputted into math.pow.

                    textBoxDisplay.Text = Result.ToString();

                    break;
            }
        }



        // The following are methods if a "buttonOne" is clicked.
        private void buttonOne_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0")
            // This is checking if the value in the text box is 0.
            {
                textBoxDisplay.Text = "1";
                // If it is then the textbox display in string needs to be 1.
            }
            else
            {
                textBoxDisplay.Text += "1";
                // If it is not then it adds one to the current value.
            }
        }



        // The following number pad methods for each number and some functions.
        private void buttonZero_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0")
            {
                textBoxDisplay.Text = "0";
            }
            else
            {
                textBoxDisplay.Text += "0";
            }
        }



        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            if (!textBoxDisplay.Text.Contains("."))
            {
                textBoxDisplay.Text += ".";
            }
        }



        private void buttonTwo_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0")
            {
                textBoxDisplay.Text = "2";
            }
            else
            {
                textBoxDisplay.Text += "2";
            }
        }



        private void buttonThree_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0")
            {
                textBoxDisplay.Text = "3";
            }
            else
            {
                textBoxDisplay.Text += "3";
            }
        }



        private void buttonFour_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0")
            {
                textBoxDisplay.Text = "4";
            }
            else
            {
                textBoxDisplay.Text += "4";
            }
        }



        private void buttonFive_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0")
            {
                textBoxDisplay.Text = "5";
            }
            else
            {
                textBoxDisplay.Text += "5";
            }
        }



        private void buttonSix_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0")
            {
                textBoxDisplay.Text = buttonSix.Text;
            }
            else
            {
                textBoxDisplay.Text += "6";
            }
        }



        private void buttonSeven_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0")
            {
                textBoxDisplay.Text = "7";
            }
            else
            {
                textBoxDisplay.Text += "7";
            }
        }



        private void buttonEight_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0")
            {
                textBoxDisplay.Text = "8";
            }
            else
            {
                textBoxDisplay.Text += "8";
            }
        }



        private void buttonNine_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text == "0")
            {
                textBoxDisplay.Text = "9";
            }
            else
            {
                textBoxDisplay.Text += "9";
            }
        }



        private void buttonPlusorMinus_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text.StartsWith("-"))
            {
                textBoxDisplay.Text = textBoxDisplay.Text.Trim('-');
            }
            else
            {
                textBoxDisplay.Text = "-" + textBoxDisplay.Text;
            }
        }



        // The following code blocks clear the text box when the operators are clicked.
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(textBoxDisplay.Text);

            textBoxDisplay.Clear();

            currentOperator = "-";
        }



        private void buttonAdd_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(textBoxDisplay.Text);

            textBoxDisplay.Clear();

            currentOperator = "+";
        }



        private void buttonDivide_Click(object sender, EventArgs e)
        {

            valueFirst = decimal.Parse(textBoxDisplay.Text);

            textBoxDisplay.Clear();

            currentOperator = "÷";
        }



        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(textBoxDisplay.Text);

            textBoxDisplay.Clear();

            currentOperator = "×";
        }



        // The following two code blocks are used to clear or remove integers in the calculator textbox.
        private void buttonClear_Click(object sender, EventArgs e)
        {
            valueFirst = 0.0m;

            valueSecond = 0.0m;

            textBoxDisplay.Text = "0";
        }



        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text.Length > 0)
            {
                textBoxDisplay.Text = textBoxDisplay.Text.Remove(textBoxDisplay.Text.Length - 1, 1);
            }
            if (textBoxDisplay.Text == "")
            {
                textBoxDisplay.Text = "0";
            }
        }



        // These are some extra operations for the calculator that are being called.
        private void textBoxDisplay_TextChanged(object sender, EventArgs e)
        {

        }



        private void buttonSquare_Click(object sender, EventArgs e)
        {
            try
            {
                double currentNumber = Convert.ToDouble(textBoxDisplay.Text);
                // This converts display to a double(decimal number) data type.

                double result = Math.Pow(currentNumber, 2);
                // This line Uses math. pow but raises the current number to power of 2

                textBoxDisplay.Text = Convert.ToString(result);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input.Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void buttonPowerofY_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(textBoxDisplay.Text);

            textBoxDisplay.Clear();

            currentOperator = "poy";
        }



        private void buttonSquareRoot_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxDisplay.Text, out double number))
            {
                if (number >= 0)
                {
                    textBoxDisplay.Text = Math.Sqrt(number).ToString();
                }
            }
        }



        private void buttonSin_Click(object sender, EventArgs e)
        {
            double degrees;
            if (double.TryParse(textBoxDisplay.Text, out degrees))
            {
                double radians = degrees * (Math.PI / 180);

                double Sin = Math.Sin(radians);
                textBoxDisplay.Text = Sin.ToString();
            }

        }



        private void buttonRootpoy_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(textBoxDisplay.Text);

            textBoxDisplay.Clear();

            currentOperator = "poy";
        }



        private void buttonInverseSin_Click(object sender, EventArgs e)
        {
            double inverseS = Convert.ToDouble(textBoxDisplay.Text);

            inverseS = Math.Asin(inverseS);

            double degrees = inverseS * (180 / Math.PI);

            textBoxDisplay.Text = degrees.ToString();
        }



        private void buttonPi_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = "3.141592653589793238462643383279502884197";
        }



        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;

            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)

            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        nonNumberEntered = true;
                        textBoxDisplay.Text += "0";
                    }
                }

            }
        }

        private void textBoxDisplay_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;

            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)

            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        nonNumberEntered = true;
                    }
                }

            }
        }

        private void textBoxDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                MessageBox.Show  ("Please enter a number");
                e.Handled = true;
            }
        }
    }
}
