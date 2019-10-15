using Microsoft.VisualStudio.TestTools.UnitTesting;
using StaticVsSingelton;
namespace UnitTestProject
{
    [TestClass]
    public class StaticVsSingelton_Unit_Test
    {
        private readonly ICalculatorService singelton_obj;
        public StaticVsSingelton_Unit_Test()
        {
            singelton_obj = new Singelton_CalculatorService();
        }
        [TestMethod]
        public void Addition_Service_Test()
        {
            var res = singelton_obj.Addition(10, 20);
            Assert.IsNotNull(res);
        }
    }
}
