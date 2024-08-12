using PrimeNumber.Finder.Alg;
using System.Diagnostics;

namespace PrimeNumber.Finder.Test
{
    public class FindPNTest
    {
        [Fact]
        public void FindPNLinar_to20_working_test()
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

        [Fact]
        public void FindPNLinar_to20_Time()
        {
            FindPN pn = new FindPN();
            Stopwatch sw = new();
            sw.Start();
            var result = pn.FindLinar(20);
            sw.Stop();
            TimeSpan elapsed = sw.Elapsed;

            string elapsedTime = $" {elapsed.Milliseconds} ms, {elapsed.Ticks % 10_000} ns";
            Assert.Empty("Verstrichene Zeit: " + elapsedTime);

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

        [Fact]
        public void Find_excludeMultiple_to20_working_test()
        {
            FindPN pn = new FindPN();

            var result = pn.Find_excludeMultiple(20);


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

        [Fact]
        public void Find_excludeMultiple_to20_Time()
        {
            FindPN pn = new FindPN();
            Stopwatch sw = new();
            sw.Start();
            var result = pn.Find_excludeMultiple(20);
            sw.Stop();
            TimeSpan elapsed = sw.Elapsed;

            string elapsedTime = $" {elapsed.Milliseconds} ms, {elapsed.Ticks % 10_000} ns";
            Assert.Empty("Verstrichene Zeit: " + elapsedTime);

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