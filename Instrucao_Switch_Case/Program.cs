using System.Collections;

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
    case 0:
        Console.WriteLine("\n" + numero + " e PAR");
        break;
    case 1:
        Console.WriteLine("\n" + numero + " E IMPAR");
        break;
}

//Executar o mesmo Codigo para valores diferentes

Console.WriteLine("Informe o nome do mes: \n");
var mes = Console.ReadLine().ToLower();
switch (mes)
{
    case "janeiro":
    case "marco":
    case "maio":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":
        Console.WriteLine("Este mes tem 31 dias");
        break;
    case "fevereiro":
        Console.WriteLine("Este mes tem 28 a 29 dias");
        break;
    default:
        Console.WriteLine("Este mes tem 30 dias");
        break;
}
Console.WriteLine("\nFim do Processamento...");

//Instrucao Switch Aninhadas

int cargo = 0;
int funcao = 0;
Console.WriteLine("Voce e gerente(1) ou Programador(2)");
cargo = Convert.ToInt32(Console.ReadLine());

if (cargo == 2)
{
    Console.WriteLine("Voce e Junior(1) ou Senior(2)");
    funcao = Convert.ToInt32(Console.ReadLine());
}
switch (cargo)
{
    case 1:
        Console.WriteLine("\nBem vindo Gerente!");
        break;
    case 2:
        Console.WriteLine("\nBem Vindo Progamador!");
        switch (funcao)
        {
            case 1:
                Console.WriteLine("\nVoce e Junior!");
                break;
            case 2:
                Console.WriteLine("\nVoce e Senior!");
                break;
            default:
                Console.WriteLine("\nFuncao Desconhecida!");
                break;

        }
        break;
    default:
        Console.WriteLine("\nNao consigo te identificar!");
        break;

}

Console.ReadKey();