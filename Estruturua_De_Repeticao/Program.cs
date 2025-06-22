using System.Runtime.InteropServices;

Console.WriteLine("$$ Estruturas de Repeticao! ##\n");

//Estrutura de repeticao goto e label

int i = 1;

repetir:

Console.WriteLine($"i={i}");

i++;
if (i <= 10)
    goto repetir;

    //nao esquecer de incrementar para nao entar em laco infinito de repeticao!

Console.WriteLine("Fim do processameto...");
Console.ReadKey();