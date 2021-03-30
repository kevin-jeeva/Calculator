namespace Calculator
{
    interface ICalculator
    {
        void Add(decimal d);
        void Subtract(decimal d);
        void Multiply(decimal d);
        void Divide(decimal d);     
        void Equals(decimal d);
        void Clear();
    }
}
