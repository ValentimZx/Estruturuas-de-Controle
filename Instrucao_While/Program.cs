// Console.WriteLine("## Estruturuas de Repeticao While ## \n");

// //Instrcao do While

// var i = 1;
// while (i <= 10)
// {
//     Console.WriteLine($"i={i}");
//     i++;
// }

// //Outra abordagem

// var l = 10;
// while (l > 0)
// {
//     Console.WriteLine($"i={l}");
//     l--;

// }

// //imprimir a tabuada maior que zero

// int numero;
// int contatdor = 1;

// Console.WriteLine("\nDigite um numero maior que zero: \t");
// numero = Convert.ToInt32(Console.ReadLine());

// if (numero > 0)
// {
//     //Loop While
//     Console.WriteLine($"\n## Tabuada do {numero} ## \n");
//     while (contatdor < 11)
//     {
//         Console.WriteLine($"{numero} x {contatdor} = {numero*contatdor}");
//         contatdor++;
//     }
// }
// else
// {
//     Console.WriteLine("Numero deve ser maior que zero!");
// }

// Console.WriteLine("Fim do Processamento!");

//Saindo do loop com break

//Plano cartesiano

int x = 0;
while (x < 5)
{
    int y = 0;
    while (y < 5)
    {
        Console.WriteLine($"{x},{y}" );
        y++;
    }
    x++;
    Console.WriteLine();

}