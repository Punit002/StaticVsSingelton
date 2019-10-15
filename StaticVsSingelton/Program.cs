using System;

namespace StaticVsSingelton
{
    class Program
    {
        static void Main(string[] args)
        {
            Static_CalculatorService.Addition(10, 20);

            ICalculatorService singelton_obj = new Singelton_CalculatorService();

            singelton_obj.Addition(10, 20);

            Console.ReadKey();
        }
    }
}
