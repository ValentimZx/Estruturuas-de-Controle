Console.WriteLine("## Instrucao Switch Case ##\n");

int compra = 600;
Console.WriteLine("Valor da compra foi de 600 R$");
Console.WriteLine("\nInforme o Numero de Parcelas (1 a 3): \t");
var numeroParcelas = Convert.ToInt32(Console.ReadLine());

switch (numeroParcelas)
{
    case 1:
        Console.WriteLine($"\nPrestacao R$ {compra / numeroParcelas}");
        break;
    case 2:
        Console.WriteLine($"Prestacao R$ {compra / numeroParcelas}");
        break;
    case 3:
        Console.WriteLine($"Prestacao R$ {compra / numeroParcelas}");
        break;
    default:
        Console.WriteLine("\nValor invalido! Por favor, defina 1, 2 ou 3.");
        break;
}

Console.WriteLine("\nFim do Processamento...\n");

//Avaliando o valor de uma expressao: Par o Impar
Console.WriteLine("Informe um numero inteiro: ");
var numero = Convert.ToInt32(Console.ReadLine());

switch (numero % 2)
{
    case 1:
        Console.WriteLine("\n" + numero + " e PAR");
        break;
    case 2:
        Console.WriteLine("\n" + numero + " E IMPAR");
        break;
}

Console.ReadKey();