using tracerco_api.Interfaces;

namespace tracerco_api.Services
{
    public class SimpleCalculatorService : ISimpleCalculator
    {
        public int Add(int start, int amount)
        {
            return start + amount;
        }

        public int Divide(int start, int by)
        {
            return start / by;
        }

        public int Multiply(int start, int by)
        {
            return start * by;
        }

        public int Subtract(int start, int amount)
        {
            return start - amount;
        }
    }
}
