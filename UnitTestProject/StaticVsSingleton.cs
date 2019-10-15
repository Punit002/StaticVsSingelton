using Microsoft.VisualStudio.TestTools.UnitTesting;
using StaticVsSingleton;
namespace UnitTestProject
{
    [TestClass]
    public class StaticVsSingleton_Unit_Test
    {
        private readonly ICalculatorService Singleton_obj;
        public StaticVsSingleton_Unit_Test()
        {
            Singleton_obj = new Singleton_CalculatorService();
        }
        [TestMethod]
        public void Addition_Service_Test()
        {
            var res = Singleton_obj.Addition(10, 20);
            Assert.IsNotNull(res);
        }
    }
}
