using PrimeNumber.Finder.Alg;

namespace PrimeNumber.Finder.Test
{
    public class FindPNTest
    {
        [Fact]
        public void Test1()
        {
            FindPN pn = new FindPN();
            var result = pn.FindLinar(20);

            string resultS = "";
            foreach (var s in result)
            {
                resultS = resultS + Environment.NewLine + s;
            }

            Assert.True(result.Count == 8);
            
            List<int> primes = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19 };

            foreach (var r in result)
            {
                Assert.True(primes.Contains(r));
            }
            foreach (var p in primes)
            {
                Assert.True(result.Contains(p));
            }

        }

    }
}