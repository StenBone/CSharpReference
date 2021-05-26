using System;
using Xunit;

namespace CSharpReference.Tests {
    public class MethodsTests {
        [Fact]
        public void Test1() {
            //arrange
            //act
            //assert
        }

        [Fact]
        public void ExtensionMethodsTest() {
            var christmasDay = new DateTime(2022, 12, 25);
            Assert.True(christmasDay.IsChristmas());
        }


    }
}
