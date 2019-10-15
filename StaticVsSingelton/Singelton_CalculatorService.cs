namespace StaticVsSingleton
{
    public class Singleton_CalculatorService : ICalculatorService
    {
        private static Singleton_CalculatorService calculatorObj;

        static Singleton_CalculatorService()
        {
            calculatorObj = new Singleton_CalculatorService();
        }

        public int Addition(int x, int y)
        {
            return x + y;
        }
    }
}
