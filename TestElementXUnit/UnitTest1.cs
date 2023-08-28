global using Xunit;
using Projeto_teste_operacoes;

namespace TestElementXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void SomarDoisNUmeros()
        {
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            var resultado = operacoes.Somar(pNum, sNum);

            Assert.Equal(rNum, resultado);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(3, 3, 6)]
        [InlineData(7, 7, 14)]
        [InlineData(6, 6, 12)]

        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            var resultado = operacoes.Somar(pNum, sNum);

            Assert.Equal(rNum, resultado);
        }

    }
}