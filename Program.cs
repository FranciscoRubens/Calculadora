using Calculadora;
// Alteração feita por outro desenvolvedor diretamente no GitHub.
var calculadora = new CalculadoraMatematica();
bool executando = true;

while (executando)
{
    Console.WriteLine("\n=== CALCULADORA ===");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha uma opção: ");

    string? opcao = Console.ReadLine();

    if (opcao == "0")
    {
        executando = false;
        continue;
    }

    if (opcao is not ("1" or "2" or "3" or "4"))
    {
        Console.WriteLine("Opção inválida!");
        continue;
    }

    Console.Write("Digite o primeiro número: ");

    if (!double.TryParse(Console.ReadLine(), out double a))
    {
        Console.WriteLine("Número inválido!");
        continue;
    }

    Console.Write("Digite o segundo número: ");

    if (!double.TryParse(Console.ReadLine(), out double b))
    {
        Console.WriteLine("Número inválido!");
        continue;
    }

    try
    {
        double resultado = opcao switch
        {
            "1" => calculadora.Somar(a, b),
            "2" => calculadora.Subtrair(a, b),
            "3" => calculadora.Multiplicar(a, b),
            "4" => calculadora.Dividir(a, b),
            _ => 0
        };

        Console.WriteLine($"Resultado: {resultado}");
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

Console.WriteLine("Sistema encerrado!");
