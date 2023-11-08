

using System.Collections;
using Calculadora.Services;

CalculadoraImp calc = new CalculadoraImp();

bool exibirMenu = true;

int valor1 = 0;
int valor2 = 0;

// Queue<int> history = new Queue<int>();

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("5 - Mostrar histórico");



    switch (Console.ReadLine())
    {
        case "1":
            valor1 = Convert.ToInt32(Console.ReadLine());
            valor2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{calc.Somar(valor1, valor2)}");
            break;

        case "2":
            valor1 = Convert.ToInt32(Console.ReadLine());
            valor2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{calc.Subtrair(valor1, valor2)}");
            break;

        case "3":
            valor1 = Convert.ToInt32(Console.ReadLine());
            valor2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{calc.Multiplicar(valor1, valor2)}");
            break;

        case "4":
            valor1 = Convert.ToInt32(Console.ReadLine());
            valor2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{calc.Dividir(valor1, valor2)}");
            break;

        case "5":
            valor1 = Convert.ToInt32(Console.ReadLine());
            valor2 = Convert.ToInt32(Console.ReadLine());
            calc.Multiplicar(valor1, valor2);
            break;

        default:
            Console.WriteLine($"Valor inválido");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
