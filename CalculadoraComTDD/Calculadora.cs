namespace CalculadoraComTDD;

public class Calculadora
{
    private List<string> historicoList;

    public Calculadora()
    {
        historicoList = new List<string>();
    }
    public int somar(int numero1, int numero2)
    {
        int resultado = numero1 + numero2;
        historicoList.Insert(0, "resultado = " + resultado);
        return resultado;
    }
    
    public int subtrair(int numero1, int numero2)
    {
        int resultado = numero1 - numero2;
        historicoList.Insert(0, "resultado = " + resultado);
        return resultado;
    }
    
    public int multiplicar(int numero1, int numero2)
    {
        int resultado = numero1 * numero2;
        historicoList.Insert(0, "resultado = " + resultado);
        return resultado;
    }
    
    public int dividir(int numero1, int numero2)
    {
        int resultado = numero1 / numero2;
        historicoList.Insert(0, "resultado = " + resultado);
        return resultado;
    }

    public List<string> historico()
    {
        historicoList.RemoveRange(3, historicoList.Count - 3);
        return historicoList;
    }
}