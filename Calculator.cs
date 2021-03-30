using System;
using System.Windows.Forms;
using static Enumeration.Enum;

namespace Calculator
{
    public class Calculator : ICalculator
    {
        private decimal currentValue;
        private decimal operand1;
        private decimal operand2;
        private int op;      

       
        public decimal CurrentValue { get => currentValue; set => currentValue = value; }
        public decimal Operand1 { get => operand1; set => operand1 = value; }
        public decimal Operand2 { get => operand2; set => operand2 = value; }
        public int Op { get => op; set => op = value; }
       

        public Calculator ()
        {
            Operand1 = 0;
            Operand2 = 0;
            Op = 0;
        }

        public void Equals(decimal op2)
        {
            this.Operand2 = op2;
        }

        public void Result ()
        {
            switch(Op)
            {
                case (0):
                    CurrentValue = this.Operand1 + this.Operand2;
                    break;

                case (1):
                    
                    CurrentValue = this.Operand1 - this.Operand2;
                    break;

                case (3):
                    try
                    {
                        CurrentValue = this.Operand1 / this.Operand2;
                        break;
                    }
                    catch(DivideByZeroException d )
                    {
                        //MessageBox.Show(d.Message.ToString());
                        CurrentValue = 0;
                        throw new DivideByZeroException("Attempted to divide by zero");
                       //break;
                    }                   
                   
                 case (2):
                    CurrentValue = this.Operand1 * this.Operand2;
                    break;
               
                    
                default:
                    CurrentValue = 0;
                    break;

            }
        }

        public void EqualsRepeat(decimal r)  
        {
            switch (Op)
            {
                case (0):
                    CurrentValue = r + Operand2;
                    break;
                case (1):

                   CurrentValue =r - Operand2;
                    break;
                case (2):
                    currentValue = r * Operand2;
                    break;
                case (3):
                    try
                    {
                        CurrentValue = r / Operand2;
                        break;
                    }
                    catch (DivideByZeroException de)
                    {
                       
                      //  MessageBox.Show(de.Message.ToString());
                        CurrentValue = 0;
                        throw new DivideByZeroException("Attempted to divide by zero");
                      //  break;

                    }

                default:
                    CurrentValue = 0;
                    break;
            }
        }
        public double SquareRoot(double op1)
        {
          return Math.Sqrt(op1);
        }

        public void Add(decimal d)
        {
            this.Operand1 = d;
            this.Op = (int) Operator.ADD;
        }

        public void Subtract(decimal d)
        {
           this.Operand1 = d;
            this.Op = (int) Operator.SUBTRACT;
        }

        public void Multiply(decimal d)
        {
            this.Operand1 = d;
            this.Op = (int) Operator.MULTIPLY;
        }

        public void Divide(decimal d)
        {
            this.Operand1 = d;
            this.Op = (int)Operator.DIVIDE;
        }

       
        public void Clear()
        {
            Operand1 = 0;
            Operand2 = 0;
            CurrentValue = 0;
            Op = 0;
            
        }
    }
}
