Console.WriteLine("## Intrucao If e Else ##\n");

// Console.WriteLine("Informe a nota do Aluno: \n");
// var nota = Convert.ToInt32(Console.ReadLine());

// if (nota > 5)
// {
// Console.WriteLine("Aluno aprovado!");
// }
// else
// {
// Console.WriteLine("Aluno reprovado!");
// }

// Console.WriteLine("\nFim do processamento...");

// Comparar se X e maior, menor ou igual a y com if-else

Console.WriteLine("Defina um valor a X: \n");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\tDefina um valor a Y: \n");
int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.WriteLine("X e maior que Y");
}
else
{
    if (x < y)
    {
        Console.WriteLine("Y e maior que X");
    }
    else
    {
        Console.WriteLine("X e igual a Y");
    }
}

Console.WriteLine("Fim do processamento...");


Console.ReadKey();