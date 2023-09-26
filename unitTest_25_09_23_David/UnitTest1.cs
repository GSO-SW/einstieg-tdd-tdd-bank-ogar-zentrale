using Bank; //namespace-verweis
using System;

namespace unitTest_25_09_23_David
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1_KannKontoKannMitPositivemGuthabenErstelltWerden()
        {
            Konto k = new Konto(123);   
        }
    }
}