// Declare a variável e inicialize com 0
int num1 = 0; int num2 = 0;

Console.WriteLine("Calculadora C# \r");
Console.WriteLine("-------------- \r");

// Digite o primeiro número.
Console.WriteLine("Digite um número e aperte ENTER");
num1 = Convert.ToInt32(Console.ReadLine());

// Digite o segundo número.
Console.WriteLine("Digite outro número e aperte ENTER");
num2 = Convert.ToInt32(Console.ReadLine());

// Escolha uma opção
Console.WriteLine("Escolha uma opção da lista: ");
Console.WriteLine("\ta - Adição");
Console.WriteLine("\ts - Subtracao");
Console.WriteLine("\tm - Multiplicacao");
Console.WriteLine("\td - Divisao");

// Use a instrução
switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Seu resultado: {num1} + {num2} = " + (num1 + num2));
        break;
    case "s":
        Console.WriteLine($"Seu resultado: {num1} - {num2} = " + (num1 - num2));
        break;
    case "m":
        Console.WriteLine($"Seu resultado: {num1} * {num2} = " + (num1 * num2));
        break;
    case "d":
        Console.WriteLine($"Seu resultado: {num1} / {num2} = " + (num1 / num2));
        break;
}

// Aguarde o resultado
Console.WriteLine("Pressione qualquer tecla para sair do programa...");
Console.ReadKey();