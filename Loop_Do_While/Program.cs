using System.Xml;

Console.WriteLine("## Instrucao do loop do while ##\n");

var i = 1;

do
{
    Console.WriteLine($"i = {i}");
    i++;
}
while (i <= 10);

var l = 2;
do
{
    Console.WriteLine($"l = {l}");
    l++;

    if (l > 7)
        break;
}
while (l <= 10);

Console.WriteLine("----------------------------------------------------------------------------------------------------------------");

int x = 0;
do
{
    int y = 0;
    do
    {
        Console.Write($"({x}, {y}) ");
        y++;

    } while (y < 5);
    x++;

} while (x < 5);

    Console.WriteLine("Fim do processamento!\n");
    Console.ReadKey();