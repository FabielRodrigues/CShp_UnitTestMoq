using CShp_UnitTestMoq;
using System;
using Xunit;

namespace CShp_XUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Somar_Dois_Numeros()
        {
            // Arrange
            Moq.Mock<ICalculadora> mock = new Moq.Mock<ICalculadora>();
        }
    }
}
