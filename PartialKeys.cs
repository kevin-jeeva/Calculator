using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        private void KeyResult(char k)
        {
            switch(k)
            {
                case '0':
                    txtOutput.Text += 0.ToString();
                    break;
                case '1':
                    txtOutput.Text += 1.ToString();
                    break;
                case '2':
                    txtOutput.Text += 2.ToString();
                    break;
                case '3':
                    txtOutput.Text += 3.ToString();
                    break;
                case '4':
                    txtOutput.Text += 4.ToString();
                    break;
                case '5':
                    txtOutput.Text += 5.ToString();
                    break;
                case '6':
                    txtOutput.Text += 6.ToString();
                    break;
                case '7':
                    txtOutput.Text += 7.ToString();
                    break;
                case '8':
                    txtOutput.Text += 8.ToString();
                    break;
                case '9':
                    txtOutput.Text += 9.ToString();
                    break;
                case '+':
                    txtOutput.Text += "+";
                    break;
                case '-':
                    txtOutput.Text += "-";
                    break;
                case '*':
                    txtOutput.Text += "*";
                    break;
                case '/':
                    txtOutput.Text += "/";
                    break;
            }
        }
        private void KeysAdd()
        {
            cl += 1;
            d += 1;
            eq = 0;

            if (ck > 0)
            {
                //Calc.Add(Calc.Operand1, "+");
                Calc.Add(Calc.Operand1);
                txtOutput.Text = "";
                if(!(Showsmb > 0))
                    KeyResult('+');
            }

            else if (empty(txtOutput, "Operand 1"))
            {
                if (validate.check(txtOutput.Text))
                {
                    decimal op1 = decimal.Parse(txtOutput.Text);
                    // Calc.Add(op1, "+");
                    Calc.Add(op1);
                    txtOutput.Text = "";
                   if (!(Showsmb > 0))
                        KeyResult('+');
                    ck += 1;
                }
                else
                {
                    d = 0;
                    MessageBox.Show("Please enter a valid input");
                    txtOutput.Focus();
                }
            }

            else
            {
                d = 0;
                txtOutput.Focus();
            }
        }

        private void KeysSubtract()
        {
            cl += 1;
            d += 1;
            eq = 0;


            if (ck > 0)
            {
                // Calc.Subract(Calc.Operand1, "-");
                Calc.Subtract(Calc.Operand1);
                txtOutput.Text = "";
                if (!(Showsmb > 0))
                    KeyResult('-');

            }
            else if (empty(txtOutput, "Operand1"))
            {
                if (validate.check(txtOutput.Text))
                {
                    decimal operand1 = decimal.Parse(txtOutput.Text);
                    //Calc.Subract(operand1, "-");
                    Calc.Subtract(operand1);
                    txtOutput.Text = "";
                    if (!(Showsmb > 0))
                        KeyResult('-');
                    ck += 1;

                }
                else
                {
                    MessageBox.Show("Please enter a valid number format");
                    txtOutput.Focus();
                    d = 0;
                }
            }
            else
            {
                d = 0;
                txtOutput.Focus();
            }
        }

        private void KeysMultiply()
        {
            cl += 1;
            d += 1;
            eq = 0;


            if (ck > 0)
            {
                // Calc.Multiplication(Calc.Operand1, "*");
                Calc.Multiply(Calc.Operand1);
                txtOutput.Text = "";
                if (!(Showsmb > 0))
                    KeyResult('*');

            }

            else if (empty(txtOutput, "Operand1"))
            {
                if (validate.check(txtOutput.Text))
                {
                    decimal operand1 = decimal.Parse(txtOutput.Text);
                    //Calc.Multiplication(operand1, "*");
                    Calc.Multiply(operand1);
                    txtOutput.Text = "";
                    if (!(Showsmb > 0))
                        KeyResult('*');
                    ck += 1;

                }
                else
                {
                    MessageBox.Show("Please enter a valid number format");
                    txtOutput.Focus();
                    d = 0;
                }
            }
            else
            {
                d = 0;
                txtOutput.Focus();
            }
        }

        private void KeysDivide()
        {
            cl += 1;
            d += 1;
            eq = 0;


            if (ck > 0)
            {
                // Calc.Divison(Calc.Operand1, "/");
                Calc.Divide(Calc.Operand1);
                txtOutput.Text = "";
                if (!(Showsmb > 0))
                    KeyResult('/');

            }
            else if (empty(txtOutput, "Operand1"))
            {
                if (validate.check(txtOutput.Text))
                {

                    decimal operand1 = decimal.Parse(txtOutput.Text);
                    // Calc.Divison(operand1, "/");
                    Calc.Divide(operand1);
                    txtOutput.Text = "";
                    if (!(Showsmb > 0))
                        KeyResult('/');
                    ck += 1;
                }
                else
                {
                    d = 0;
                    MessageBox.Show("Please enter a valid number format");
                    txtOutput.Focus();
                }
            }
            else
            {
                d = 0;
                txtOutput.Focus();
            }
        }
        
        public void clearkeys(char c)
        {
            switch(c)
            {
                case '0':
                    d = 0;
                    if (cl > 0)
                    {
                        txtOutput.Text = "";
                        cl = 0;
                    }                    
                    Console.WriteLine(c);
                    break;
                case '1':
                    d = 0;
                    if (cl > 0)
                    {
                        txtOutput.Text = "";
                        cl = 0;
                    }
                   
                    Console.WriteLine(c);
                    break;
                case '2':
                    d = 0;
                    if (cl > 0)
                    {
                        txtOutput.Text = "";
                        cl = 0;
                    }
                    
                    Console.WriteLine(c);
                    break;
                case '3':
                    d = 0;
                    if (cl > 0)
                    {
                        txtOutput.Text = "";
                        cl = 0;
                    }
                  
                    Console.WriteLine(c);
                    break;
                case '4':
                    d = 0;
                    if (cl > 0)
                    {
                        txtOutput.Text = "";
                        cl = 0;
                    }
                    Console.WriteLine(c);
                  
                    break;
                case '5':
                    d = 0;
                    if (cl > 0)
                    {
                        txtOutput.Text = "";
                        cl = 0;
                    }
                    
                    Console.WriteLine(c);
                    break;
                case '6':
                    d = 0;
                    if (cl > 0)
                    {
                        txtOutput.Text = "";
                        cl = 0;
                    }
                    
                    Console.WriteLine(c);
                    break;
                case '7':
                    d = 0;
                    if (cl > 0)
                    {
                        txtOutput.Text = "";
                        cl = 0;
                    }
                  
                    Console.WriteLine(c);
                    break;
                case '8':
                    d = 0;
                    if (cl > 0)
                    {
                        txtOutput.Text = "";
                        cl = 0;
                    }
                   
                    Console.WriteLine(c);
                    break;
                case '9':
                    d = 0;
                    if (cl > 0)
                    {
                        txtOutput.Text = "";
                        cl = 0;
                    }
                    
                    Console.WriteLine(c);
                    break;

            }
        }

        public void Equal()
        {
            if (eq > 0)
            {

                if (validate.check(txtOutput.Text))
                {

                    decimal operand2 = decimal.Parse(txtOutput.Text);
                    txtOutput.Text = " ";
                    Calc.EqualsRepeat(operand2);
                    txtOutput.Text = Calc.CurrentValue.ToString();
                    ck = 0;
                    eq += 1;
                    cl += 1;
                }
                else
                {
                    MessageBox.Show("Please enter a valid number format");
                }

            }
            else if (empty(txtOutput, "Operand2"))
            {
                if (validate.check(txtOutput.Text))
                {
                    decimal operand2 = decimal.Parse(txtOutput.Text);
                    Calc.Equals(operand2);
                    txtOutput.Text = " ";
                    Calc.Result();
                    txtOutput.Text = Calc.CurrentValue.ToString();
                    // Calc.Repeat = Calc.Operand2;
                    ck = 0;
                    eq += 1;
                    cl += 1;
                }
                else
                {
                    MessageBox.Show("Please enter a valid input");
                    txtOutput.Focus();
                }
            }
            else
            {
                txtOutput.Focus();
            }
        }
    }
}
