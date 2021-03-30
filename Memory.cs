namespace Calculator
{
    public  class Memory : Calculator
    {

        private decimal memoryValue;

        public decimal MemoryValue { get => memoryValue; set => memoryValue = value; }

        public void MemoryStore(decimal memvalue)
        {
            MemoryValue = memvalue;
           
        }

        public decimal MemoryRecall()
        {
            return MemoryValue;
        }

       
        public void MemoryAdd(decimal val)
        {
            MemoryValue = this.MemoryValue + val;
           
        }

        public void MemoryClear()
        {
            MemoryValue = 0;
        }
    }
}
