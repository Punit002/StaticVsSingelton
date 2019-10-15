namespace StaticVsSingelton
{
    public class Singelton_CalculatorService : ICalculatorService
    {
        private static Singelton_CalculatorService calculatorObj;

        static Singelton_CalculatorService()
        {
            calculatorObj = new Singelton_CalculatorService();
        }

        public int Addition(int x, int y)
        {
            return x + y;
        }
    }
}
