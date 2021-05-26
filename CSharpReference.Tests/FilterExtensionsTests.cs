using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CSharpReference.Tests {
    public class FilterExtensionsTests {


        [Fact]
        public void StringsThatStartWithTest() {
            IEnumerable<string> cities = new[] { "Denver", "Toronto", "Greenville", "Gatlinburg", "Greer" };
            IEnumerable<string> query = cities.StringsThatStartWith("Gree");

            IEnumerable<string> correctResponse = new[] { "Greenville" , "Greer" };
            Assert.Equal<IEnumerable<string>>(correctResponse, query);
        }
    }
}
