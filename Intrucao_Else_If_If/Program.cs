Console.WriteLine("## Intrucao else if ## \n");

Console.WriteLine("Qual a nota do Aluno?");
var nota = Convert.ToDouble(Console.ReadLine());

if (nota < 5)
{
    Console.WriteLine("\nAluno reprovado!");
}
else if (nota >= 5 && nota < 6)
{
    Console.WriteLine("\nAluno em recuperacao!");
}
else if (nota >= 6 && nota <= 9)
{
    Console.WriteLine("\nAluno Aprovado!");
}
else if (nota > 9)
{
    Console.WriteLine("\nAluno Aprovado com Distincao!");
}

Console.WriteLine("\n Fim do processamento...");

Console.ReadKey();