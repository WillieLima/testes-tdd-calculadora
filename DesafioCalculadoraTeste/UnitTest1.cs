using DesafioCalculadora;
using System;
using Xunit;

namespace DesafioCalculadoraTeste
{
    public class UnitTest1
    {
        public Calculadora construirClasse()
        {
            string data = "28/10/2023";
            Calculadora calc = new Calculadora(data);
            
            return calc;
        }
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(5, 4, 9)]
        public void TestSomar(int num1, int num2, int res)
        {
            Calculadora calc = construirClasse();

            int resultado = calc.Somar(num1, num2);

            Assert.Equal(res, resultado);

        }
        [Theory]
        [InlineData(10, 2, 8)]
        [InlineData(5, 4, 1)]
        public void TestSubtrair(int num1, int num2, int res)
        {
            Calculadora calc = construirClasse();

            int resultado = calc.Subtrair(num1, num2);

            Assert.Equal(res, resultado);

        }
        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(5, 4, 20)]
        public void TestMultiplicar(int num1, int num2, int res)
        {
            Calculadora calc = construirClasse();

            int resultado = calc.Multiplicar(num1, num2);

            Assert.Equal(res, resultado);

        }
        [Theory]
        [InlineData(11, 2, 5)]
        [InlineData(20, 4, 5)]
        public void TestDividir(int num1, int num2, int res)
        {
            Calculadora calc = construirClasse();

            int resultado = calc.Dividir(num1, num2);

            Assert.Equal(res, resultado);

        }
        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = construirClasse();

            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
        }
        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = construirClasse();

            calc.Somar(1, 2);
            calc.Somar(3, 5);
            calc.Somar(2, 6);
            calc.Somar(5, 9);
            calc.Somar(5, 10); // inserindo 5 métodos

            var lista = calc.HistoricoLista();

            Assert.NotEmpty(lista); //a lista não pode voltar vazia
            Assert.Equal(3, lista.Count);
        }
    }
}
