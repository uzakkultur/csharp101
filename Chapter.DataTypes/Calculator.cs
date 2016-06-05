namespace Chapter.DataTypes
{
    public class Calculator
    {
        public int CalTotal(byte a, byte b)
        {
            return a + b;
        }
        public int CalImpact(int a, int b)
        {
            var result = a*b;
            return result;
        }

        public long CalMinus(int a, int b)
        {
            var result = a - b;
            return result;
        }
    }
}
