using Xunit;

namespace LibraryCalc22.Tests
{
    public class CalculadoraTests
    {
        [Theory]
        [InlineData(1, 2)]
        [InlineData(10, 21)]
        [InlineData(15, 23)]
        [InlineData(16, 24)]
        [InlineData(0, 2)]
        [InlineData(19, 0)]
        public void SubtrairSucesso(int valor1, int valor2)
        {
            var calculadora = new Calculadora();

            var resultado = calculadora.Sutrair(valor1, valor2);
            Assert.True((valor1 - valor2) == resultado);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(10, 21)]
        [InlineData(15, 23)]
        [InlineData(16, 24)]
        [InlineData(0, 2)]
        [InlineData(19, 0)]
        public void SomarSucesso(int valor1, int valor2)
        {
            var calculadora = new Calculadora();

            var resultado = calculadora.Somar(valor1, valor2);
            Assert.True((valor1 + valor2) == resultado);
        }

        [Theory]
        [InlineData(1, 2, 5)]
        [InlineData(10, 21, 7)]
        [InlineData(15, 23, 9)]
        [InlineData(16, 24, 0)]
        [InlineData(0, 2, 3)]
        [InlineData(19, 0, 5)]
        public void SomarSucessoTresParametros(int valor1, int valor2, int valor3)
        {
            var calculadora = new Calculadora();

            var resultado = calculadora.Somar(valor1, valor2, valor3);
            Assert.True((valor1 + valor2+valor3) == resultado);
        }



        [Theory]
        [InlineData(1, 2)]
        [InlineData(10, 21)]
        [InlineData(15, 23)]
        [InlineData(16, 24)]
        [InlineData(0, 2)]
        [InlineData(19, 0)]
        public void SomarErro(int valor1, int valor2)
        {
            var calculadora = new Calculadora();

            var resultado = calculadora.Somar(valor1, valor2);
            Assert.False((valor1 + valor2) != resultado);
        }



        [Theory]
        [InlineData(1, 2)]
        [InlineData(10, 21)]
        [InlineData(15, 23)]
        [InlineData(16, 24)]
        [InlineData(0, 2)]
        [InlineData(19, 0)]
        public void DividirSucesso(int valor1, int valor2)
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.Dividir(valor1, valor2);
            Assert.True((valor1 / valor2) == resultado);

        }



        [Fact]
        public void MultiplicarSucesso()
        {
            var calculadora = new Calculadora();
            var valor1 = 5;
            var valor2 = 10;

            var resultado = calculadora.Multiplicar(valor1, valor2);
            Assert.True((valor1 * valor2) == resultado);

        }
    }
}
