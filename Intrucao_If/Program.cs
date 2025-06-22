Console.WriteLine("## Instrucao de controle If ##\n");

// Console.WriteLine("Cliente Especial S/N \n");
// var resposta = Console.ReadLine();

// if (resposta == "S")
// {
// Console.WriteLine("Desconte de 10%");
// }
// Console.WriteLine("Fim do processamento");

//Parte 2

// Console.WriteLine("Cliente Especial True/false");
// var resposta = Convert.ToBoolean(Console.ReadLine());

// if (resposta)

// Console.WriteLine("Desconto de 10%");

// Console.WriteLine("Fim do processamento!");

//Parte 3

Console.WriteLine("Informe o valor de x: \t");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe valor de y: \t");
int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.WriteLine("X e maior que Y");
}

if (x < y)
{
    Console.WriteLine("X e menor que Y");
}

if (x == y)
{
    Console.WriteLine("X e igual a Y");
}

Console.WriteLine("Fim do processamento.");

Console.ReadKey();