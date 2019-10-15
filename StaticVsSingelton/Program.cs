using System;

namespace StaticVsSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Static_CalculatorService.Addition(10, 20);

            ICalculatorService Singleton_obj = new Singleton_CalculatorService();

            Singleton_obj.Addition(10, 20);

            Console.ReadKey();
        }
    }
}
