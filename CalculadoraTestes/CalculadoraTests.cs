using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{

    private CalculadoraImp _calc;

    public CalculadoraTests(){
        _calc = new CalculadoraImp();
    }

    [Theory]
    [InlineData(6,2,8)]
    public void TesteDeSoma(int num1, int num2, int result)
    {
        // Act - Agir chamando a função para executar
        int resultado = _calc.Somar(num1, num2);

        // Assert - validação do resultado
        Assert.Equal(result, resultado);
    }

    [Theory]
    [InlineData(6,2,4)]
    public void TesteDeSub(int num1, int num2, int result)
    {
        // Act - Agir chamando a função para executar
        int resultado = _calc.Subtrair(num1, num2);

        // Assert - validação do resultado
        Assert.Equal(result, resultado);
    }
    [Theory]
    [InlineData(6,2,12)]
    public void TesteDeMult(int num1, int num2, int result)
    {
        // Act - Agir chamando a função para executar
        int resultado = _calc.Multiplicar(num1, num2);

        // Assert - validação do resultado
        Assert.Equal(result, resultado);
    }

    [Theory]
    [InlineData(6,2,3)]
    public void TesteDeDiv(int num1, int num2, int result)
    {
        // Act - Agir chamando a função para executar
        int resultado = _calc.Dividir(num1, num2);

        // Assert - validação do resultado
        Assert.Equal(result, resultado);
    }

    [Fact]
    public void TesteDeDivPor0()
    {
        Assert.Throws<DivideByZeroException>(
            () => _calc.Dividir(3,0)
        );
    }

    [Fact]
    public void TesteHistory()
    {
        _calc.Somar(1, 2);
        _calc.Somar(1, 3);
        _calc.Somar(1, 4);

        var lista = _calc.history();

        Assert.NotEmpty(lista);
    }
}