using CShp_UnitTestMoq;
using Moq;
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
            mock.Setup(x => x.Calcular(It.IsAny<string>(), It.IsAny<double>(), It.IsAny<double>())).Returns(("somar", 7.7));
            MaquinaCalculadora maqCalc = new MaquinaCalculadora(mock.Object);
            // Act
            (string operacao, double resultado) op = maqCalc.Calcular("somar", 3.2, 4.5);
            // Assert
            Assert.Equal("somar", op.operacao);
            Assert.Equal(7.7, op.resultado);
        }
    }
}
