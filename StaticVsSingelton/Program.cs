using System;

namespace StaticVsSingelton
{
    class Program
    {
        static void Main(string[] args)
        {
            Static_CalculatorService.Addition(10, 20);

            Singelton_CalculatorService singelton_obj = new Singelton_CalculatorService();
        }
    }
}
