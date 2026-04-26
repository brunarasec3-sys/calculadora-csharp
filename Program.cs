string continuar = "S";

while (continuar.ToUpper() == "S")
{

Console.WriteLine("=== CALCULADORA ===\n");
Console.WriteLine("1 - Soma");
Console.WriteLine("2 - Subtração");
Console.WriteLine("3 - Multiplicação");
Console.WriteLine("4 - Divisão");
Console.WriteLine("Escolha uma opção");

int opcao;

if (!int.TryParse(Console.ReadLine(), out opcao))
    {
        Console.WriteLine("Opção inválida! Digite um número.");
        Console.WriteLine("Pressione Enter para tentar novamente");
        Console.ReadLine();
        continue;
    }

double num1;

Console.WriteLine("Digite o primeiro número:");
if (!double.TryParse(Console.ReadLine(), out num1))
    {
        Console.WriteLine("Número inválido!");
        Console.WriteLine("Pressione Enter para tentar novamente");
        Console.ReadLine();
        continue;
    }

double num2;

Console.WriteLine("Digite o segundo número:");
if (!double.TryParse(Console.ReadLine(), out num2))
    {
        Console.WriteLine("Número inválido!");
        Console.WriteLine("Pressione Enter para tentar novamente");
        Console.ReadLine();
        continue;
    }

if (opcao == 1)
{
    Console.WriteLine($"\n{num1} + {num2} = {num1 + num2}");
}
else if (opcao == 2)
{
    Console.WriteLine($"\n{num1} - {num2} = {num1 - num2}");
}
else if (opcao == 3)
{
    Console.WriteLine($"\n{num1} * {num2} = {num1 * num2}");
}
else if (opcao == 4)
{
    if (num2 == 0)
    {
      Console.WriteLine("Não pode dividir por zero");
    }
    else   
    {
       Console.WriteLine($"\n{num1} / {num2} = {num1 / num2}");
    } 
} 
else
{
    Console.WriteLine("Opção inválida");
}

 Console.WriteLine();
 Console.WriteLine("Deseja fazer outra operação? (S/N)");
 continuar = Console.ReadLine()!;

if (continuar.ToUpper() == "S")
    {
        Console.Clear();
    }
}


