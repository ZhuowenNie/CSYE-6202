using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication4;
using Airline.Business;
namespace UnitTestProject1
{
    [TestClass]
    public class ArgumentOutOfRangeException
    {
        [TestMethod]
        public void TestMethod1()
        {
           
            FlightOrderBusiness fob = new FlightOrderBusiness();
            fob.Purchase("cf1", DateTime.Now,100.00000, "Empty", "suitcase", "business", "1");
            double actual = fob.Purchase(100.000);
            Assert.IsNotNull(actual);

        }


    }
}
