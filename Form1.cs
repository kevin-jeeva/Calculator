using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {

            txtOutput.Text = memory.MemoryRecall().ToString();


        }

        private void Button5_Click(object sender, EventArgs e)
        {//Memory Save
            lblMemory.Text = "M";

            if(empty(txtOutput,"Value"))
            {
                if(validate.check(txtOutput.Text))
                {
                    memory.MemoryStore(decimal.Parse(txtOutput.Text));
                    txtOutput.Text =memory.MemoryValue.ToString();
                    txtOutput.Focus();
                    
                    cl += 1;
                }
                else
                {
                    MessageBox.Show("Please enter a valid number format");
                }
            }
            else

            {
                txtOutput.Text = "";
                txtOutput.Focus();
            }
            
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            d = 0;
            if (cl > 0)
            {
                txtOutput.Text = "";
                cl = 0;
            }

            clearkeys('7');
            KeyResult('7');
        }

        //Global variables : 

        int cl = 0;
        int d = 0;
        int ck = 0;
        int eq = 0;
        int Showsmb = 0; 
        //Declaration of instance of class 

        Calculator Calc = new Calculator();
        Validate validate = new Validate();
        Memory memory = new Memory();
       


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            Showsmb = 0;
            clearkeys('6');
            KeyResult('6');
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            Showsmb = 0;
            clearkeys('8');
            KeyResult('8');
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            Showsmb = 0;
            clearkeys('9');
            KeyResult('9');
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            Showsmb = 0;
            clearkeys('4');
            KeyResult('4');
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            Showsmb = 0;
            clearkeys('5');
            KeyResult('5');
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Showsmb = 0;
            clearkeys('1');
            KeyResult('1');
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Showsmb = 0;
            clearkeys('2');
            KeyResult('2');
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Showsmb = 0;
            clearkeys('3');
            KeyResult('3');
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            //d = 0;
            //if (cl > 0)
            //{
            //    txtOutput.Text = "";
            //    cl = 0;
            //}
            Showsmb = 0;
            clearkeys('0');
            KeyResult('0');
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            KeysAdd();
            
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            KeysSubtract();
            
        }

        private void BtnMultiplication_Click(object sender, EventArgs e)
        {
            KeysMultiply();

        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            KeysDivide();
        }

        private void BtnDecimal_Click(object sender, EventArgs e)
        {
            if(!(d > 0))
            {
                txtOutput.Text += ".";
            }
            
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            Showsmb = 0;
            Calc.Clear();
        }
        private bool empty(TextBox tx,string st)
        {
            if(tx.Text == "")
            {
                MessageBox.Show("Please enter the value for" + st );
                return false;
            }
            return true;
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            Equal();
           
        }

        private void BtnInvert_Click(object sender, EventArgs e)
        {
            if(empty(txtOutput,"operand"))
            {
                if (validate.check(txtOutput.Text))
                {
                    txtOutput.Text = (-(decimal.Parse(txtOutput.Text))).ToString();
                   
                }
                else
                {
                    MessageBox.Show("Please enter a valid number");
                    txtOutput.Focus();
                }
            }
            else
            {
                txtOutput.Focus();
            }
        }

        private void Btn1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void BtnSqrt_Click(object sender, EventArgs e)
        {
            if(empty(txtOutput,"Operand1"))
            {
                double sq = 0;
                if (double.TryParse(txtOutput.Text,out sq))
                {                    
                    txtOutput.Text = Calc.SquareRoot(sq).ToString();
                }
                else
                {
                    MessageBox.Show("Please enter a valid number format");
                    txtOutput.Text = "";
                    txtOutput.Focus();
               }
            }
            else
            {
                txtOutput.Focus();
            }
        }
        double reciprocal = 0;
        int r = 0;
        private void Button24_Click(object sender, EventArgs e)
        {
            try
            { 

                if (r > 0)
                {
                    txtOutput.Text =  reciprocal.ToString();
                    r = 0;
                }
                else
                {
                    reciprocal = double.Parse(txtOutput.Text);
                    txtOutput.Text = (1 / reciprocal).ToString();
                    r += 1;
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "Please enter a valid input");
            }

            //txtOutput.Text = (1 / decimal.Parse(txtOutput.Text)).ToString();
        }

        private void BtnMemClear_Click(object sender, EventArgs e)
        {
            memory.MemoryClear();
            lblMemory.Text = " ";
        }

        private void BtnMemAdd_Click(object sender, EventArgs e)
        {
            if(empty(txtOutput,"Value"))
            {
                if(validate.check(txtOutput.Text))
                {
                     memory.MemoryAdd(decimal.Parse(txtOutput.Text));
                    txtOutput.Text = memory.MemoryValue.ToString();
                    cl += 1;
                }
                else
                {
                    MessageBox.Show("Please enter a valid number format");
                    txtOutput.Text = "";
                    txtOutput.Focus();
                }
            }
            else
            {
                txtOutput.Text = "";
                txtOutput.Focus();
            }
            
        }

        private void Btn0_KeyDown(object sender, KeyEventArgs e)
        {
            txtOutput.Text = e.KeyCode.ToString();
        }

        private void Btn0_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
       
        private void TxtOutput_KeyPress(object sender, KeyPressEventArgs e)
        {
            
           if(e.KeyChar == '+')
           {
                Showsmb += 1;
                KeysAdd();
           }
           if(e.KeyChar == '-')
            {
                Showsmb += 1;
                KeysSubtract();
            }
           if(e.KeyChar == '*')
            {
                Showsmb += 1;
                KeysMultiply();
            }
           if(e.KeyChar == '/')
            {
                Showsmb += 1;
                KeysDivide();
            }

           if(e.KeyChar == (char)Keys.Enter)
            {
                Equal();
                Console.WriteLine(e.KeyChar);
            }
            clearkeys(e.KeyChar);
           
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '0')
            {
                txtOutput.Text += 0;
            }
            if (e.KeyChar == '1')
            {
                txtOutput.Text += 1;
            }
            if (e.KeyChar == '2')
            {
                txtOutput.Text += 2;
            }
            if (e.KeyChar == '3')
            {
                txtOutput.Text += 3;
            }
            if (e.KeyChar == '4')
            {
                txtOutput.Text += 4;
            }
            if (e.KeyChar == '5')
            {
                txtOutput.Text += 5;
            }
            if (e.KeyChar == '6')
            {
                txtOutput.Text += 6;
            }
            if (e.KeyChar == '7')
            {
                txtOutput.Text += 7;
                Console.WriteLine(7);
            }
            if (e.KeyChar == '8')
            {
                txtOutput.Text += 8;
            }
            if (e.KeyChar == '9')
            {
                txtOutput.Text += 9;
                Console.WriteLine(9);
            }
        }
    }
}
