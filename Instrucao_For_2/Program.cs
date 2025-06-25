// Console.WriteLine("Instrucao Loop laco for 2\n");

// for (int i = 0, j = 0; i + j <= 20; i++, j++)
// {
//     Console.WriteLine($"{i} = i, {j} = j");
// }

int i = 1;
for (; i <= 10;)
{
    Console.WriteLine($"i = {i}");
    i++;
}

for (int x = 0; x <5.0; x++)
{
    for (int y = 0; y < 5.0; y++)
    {
        Console.Write($"{x}, {y}");
    }
    Console.WriteLine();
    
}


Console.WriteLine("Fim do processamento... \n");

