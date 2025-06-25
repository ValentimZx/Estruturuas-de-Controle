// // using System.Diagnostics.Contracts;

// // Console.WriteLine("## Instrucao do Loop For ##\n");

// // int resultado, numero;

// // Console.WriteLine("Digite um numero inteiro\n");
// // numero = Convert.ToInt32(Console.ReadLine());

// // for (int i = 1; i <= 10; i++)
// // {
// //     resultado = numero * i;
// //     Console.WriteLine(numero + " X " + i + " = " + resultado);
// // }
// // Console.WriteLine("Fim do processamnto...");
// // Console.ReadKey();

// double resultado, numero;
// double i;
// Console.WriteLine("Digite um numero inteiro: \t");
// numero = Convert.ToInt32(Console.ReadLine());
// for (i = 1.01; i <= 10.10; i += 0.1)
// {
//     resultado = numero * i;
//     Console.WriteLine($"{numero} x {i} = {resultado}");
// }

// Console.WriteLine("Fim do processamento...");

int resultado, numero;
int i;
Console.WriteLine("Digite um numero inteiro maior que zero: \t");
numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0)
{
    for (i = 1; i <= 10; i++)
    {
        resultado = numero * i;
        Console.WriteLine($"{numero} X {i} = {resultado}");

    }


}
else
{
    Console.WriteLine("Numero invalido!");
}
