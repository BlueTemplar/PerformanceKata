using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PerformanceTests
{
    public class FactorialsTest
    {
        [Fact]
        public void ReturnsCorrectSum()
        {
            var result = new Factorials.Factorials().CalculateSum();
            Assert.Equal(40730, result);
        }
    }
}
