// using System.Security.Cryptography.X509Certificates;

// Console.WriteLine("Break e Continue\n");

// for (; ; )
// {
//     Console.WriteLine("Tecle algo ( X Sai)");
//     var opcao = Console.ReadLine();

//     Console.WriteLine(opcao.ToUpper());

//     if (opcao == "x" || opcao == "X")
//     {
//         Console.WriteLine("Tchau!");
//         break;
//     }

// }

//Continue 

// for (int i = 1; i <= 10; i++)
// {
//     if (4 == i)

//         continue;
//     Console.WriteLine(i);


// }

// //Continue com loop While

// int n = 1;
// while (n <= 10)
// {
//     if (n == 5)
//     {
//         n++;
//         continue;
//     }
//     Console.WriteLine($"n={n}");
//     n++;
// }

//Utilizar Break e Continue no mesmo laco

for (int i = 1; i <= 10; i++)
{
    if (i == 5)
    {
        continue;
    }
    if (i > 8)
    {
        break;
    }
    Console.WriteLine($"i={i}");
}


Console.WriteLine("\nFim do processamento...");