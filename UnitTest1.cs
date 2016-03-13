using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ss.RealEstate.Library2.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var scorer = new BasicScorer();
            var addressList = scorer.GetAddresses("irvine", "50000", "500000", "1930", "2016");

            foreach (var address in addressList)
            {
                var propInfo = scorer.GetBasicScore(address);
                Console.WriteLine(string.Format("{0}\t{1}", propInfo.Address.Address1, propInfo.DesirabilityScore));
                //Console.WriteLine($"{propInfo.Address.Address1}\t{propInfo.DesirabilityScore}");
            }
        }

        [TestMethod]
        public void TestQuandi()
        {
            Console.WriteLine(QuandlApi.GetSalePricePerSqft("Cerritos", "CA"));
        }
    }
}
