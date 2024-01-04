using CalculadoraComTDD;

namespace CalculadoraTests;

public class UnitTest1
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(7, 2, 9)]
    public void TestSoma(int n1, int n2, int result)
    {
        Calculadora calc = new Calculadora();

        int resultado = calc.somar(n1, n2);
        
        Assert.Equal(result, resultado);
    }
    
    [Theory]
    [InlineData(5, 2, 3)]
    [InlineData(11, 2, 9)]
    public void TestSubtracao(int n1, int n2, int result)
    {
        Calculadora calc = new Calculadora();

        
        int resultado = calc.subtrair(n1, n2);
        
        Assert.Equal(result, resultado);
    }
    
    [Theory]
    [InlineData(4, 2, 8)]
    [InlineData(3, 3, 9)]
    public void TestMultiplicacao(int n1, int n2, int result)
    {
        Calculadora calc = new Calculadora();

        int resultado = calc.multiplicar(n1, n2);
        
        Assert.Equal(result, resultado);
    }
    
    [Theory]
    [InlineData(15, 5, 3)]
    [InlineData(18, 2, 9)]
    public void TestDivisao(int n1, int n2, int result)
    {
        Calculadora calc = new Calculadora();

        int resultado = calc.dividir(n1, n2);
        
        Assert.Equal(result, resultado);
    }

    [Fact]
    public void TestHistorico()
    {
        Calculadora calc = new Calculadora();

        calc.somar(1, 2);
        calc.somar(5, 2);
        calc.somar(9, 2);
        calc.somar(1, 7);

        var lista = calc.historico();
        
        Assert.NotEmpty(calc.historico());
        Assert.Equal(3, lista.Count);
    }
}