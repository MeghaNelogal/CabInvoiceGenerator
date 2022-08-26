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

        [TestMethod]
        public void InputInInteger_ShouldReturn_MultipleRides_TotalFare()
        {
            InvoiceGenerator invoice = new InvoiceGenerator();
            Ride[] rides = { new Ride(2, 3), new Ride(4, 5) };
            double result = invoice.CalculateMultipleRides(rides);
            Assert.AreEqual(result, 23, 45);
        }

        [TestMethod]
        public void InputInInteger_ShouldReturn_MultipleRides_TotalFair_InvoiceSummary()
        {
            InvoiceGenerator invoice = new InvoiceGenerator();
            Ride[] rides = { new Ride(2, 3), new Ride(4, 5), new Ride(5, 6) };
            InvoiceSummary result = invoice.MultipleRides(rides);
            Assert.AreEqual(result.totalNumberOfRides, rides.Length);
        }
    }
}

