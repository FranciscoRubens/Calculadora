```csharp
namespace Calculadora;

// Classe com as operações matemáticas.
public class CalculadoraMatematica
{
    public double Somar(double a, double b)
    {
        return a + b;
    }

    public double Subtrair(double a, double b)
    {
        return a - b;
    }

    public double Multiplicar(double a, double b)
    {
        return a * b;
    }

    public double Dividir(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException(
                "Não é possível dividir por zero.");
        }

        return a / b;
    }

    // Nova funcionalidade adicionada pelo outro desenvolvedor.
    public double Potencia(double baseNumero, double expoente)
    {
        return Math.Pow(baseNumero, expoente);
    }

    // Nova funcionalidade desenvolvida na sua branch.
    public double PotenciaComExpoenteDobrado(
        double baseNumero, double expoente)
    {
        return Potencia(baseNumero, expoente * 2);
    }
}
```
