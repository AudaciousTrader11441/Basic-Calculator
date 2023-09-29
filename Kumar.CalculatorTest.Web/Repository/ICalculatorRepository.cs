namespace Kumar.CalculatorTest.Web.Repository
{
    public interface ICalculatorRepository
    {
        int Add(int number1, int number2);
        int Subtract(int number1, int number2);
    }
    public class CalculatorRepository : ICalculatorRepository
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }
    }

}
