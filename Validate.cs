namespace Calculator
{
    public class Validate
    {
       
        public bool check(string st)
        {
            try
            {
                decimal.Parse(st);
                return true;
            }
            catch
            {
                return false;
            }
        }

        
    }
}
