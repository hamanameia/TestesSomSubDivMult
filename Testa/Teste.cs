using NomeBao;
using System.Data;

namespace Testa
{
    public class Teste
    {
        [Fact]
        public void Somar()
        {
            Assert.Equal(4, CalculadoraDeUmENoventaENove.Somar(2, 2));
        }
        [Fact]
        public void Subtrair()
        {
            Assert.Equal(0, CalculadoraDeUmENoventaENove.Subtrair(2, 2));
        }
        [Fact]
        public void Dividir()
        {
            Assert.Equal(1, CalculadoraDeUmENoventaENove.Dividir(2, 2));
        }
        [Fact]
        public void Multiplicar()
        {
            Assert.Equal(6, CalculadoraDeUmENoventaENove.Multiplicar(3, 2));
        }
       
    }
}   