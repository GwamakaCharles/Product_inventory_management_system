using System;
using library;
using Xunit;

namespace test_library
{
    public class ProductTests
    {
        [Fact]
        public void SayHelloTest()
        {
        //Given
            var currentProduct = new Product(1, "Saw", "15-inch steel blade hand Saw");
            var expected = "Hello Saw (1): 15-inch steel blade hand Saw";

        //When
            var actual = currentProduct.SayHello();

        //Then
            Assert.Equal(expected, actual);
        }
    }
}
