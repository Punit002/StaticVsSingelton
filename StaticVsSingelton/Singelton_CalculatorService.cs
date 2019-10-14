using System;
using System.Collections.Generic;
using System.Text;

namespace StaticVsSingelton
{
    class Singelton_CalculatorService : CalculatorService
    {
        private static Singelton_CalculatorService calculatorObj;
        static void constructor()
        {
            calculatorObj = new Singelton_CalculatorService();
        }

        public int Addition(int x, int y)
        {
            return x + y;
        }

    }
}
