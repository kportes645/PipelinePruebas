using Calculadora;

namespace Calculadora.Tests;

public class CalculadoraTest
{
    [Fact]
    public void Sumar_DosNumeros_RetornaResultadoCorrecto()
    {
        // Arrange
        var calculadora = new Operaciones();

        // Act
        int resultado = calculadora.Sumar(2, 3);

        // Assert
        Assert.Equal(5, resultado);
    }
}