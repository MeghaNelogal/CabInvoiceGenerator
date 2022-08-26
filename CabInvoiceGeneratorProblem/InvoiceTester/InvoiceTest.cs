using CabInvoiceGeneratorProblem;

namespace InvoiceTester
{
    [TestClass]
    public class InvoiceTest
    {
        [TestMethod]       
        public void GivenTimeAndDistance_ShouldReturnTotalFare()
        {
            InvoiceGenerator invoice = new InvoiceGenerator();
            double actual = invoice.CalculateFare(6, 5);
            Assert.AreEqual(actual, 65);
        }
    }
}