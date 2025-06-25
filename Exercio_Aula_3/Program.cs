//1- Escreva um programa para receber 3 números inteiros e a seguir calcular e exibir qual deles é o maior



int num1, num2, num3;
Console.WriteLine("Encontre o maior numero\n");

Console.WriteLine("Digite 3 numeros: \n");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o segundo numero: \n");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o terceiro numero: \n");
num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    if (num1 > num3)
        Console.WriteLine($"O {num1} e o maior");
    else
        Console.WriteLine($"O {num2} e o maior");
}
else if (num2 > num3)
    Console.WriteLine($"O {num2} e o maior");
else
    Console.WriteLine($"O {num3} e o maior");

//2 - Escreva um programa para calcular a raiz da equação quadrática : ax^2 +bx + x = 0
// - Considere a, b e c números inteiros apenas
// - Para calcular as raízes use a fórmula de Báskara : x = (-b +- sqrt(delta))/2.a delta = b^2 -4.a.c
// - Solicite a entrada de a , b e c e informe se existe ou não raiz real.

int a, b, c;
double d, x1, x2;

Console.WriteLine("Calculo de equacao de segundo grau\n");

Console.Write("Informe o valor de a: \t");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o valor de b: \t");
b = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o valor de c: \t");
c = Convert.ToInt32(Console.ReadLine());

d = b * b - 4 * a * c;
if (b == 0)
{
    Console.Write("As duas raizes sao iguais\n");
    x1 = -b / (2.0 * a);
    x2 = x1;
    Console.Write($"A primeira raiz {x1}\n");
    Console.Write($"A segunda raiz {x2}\n");
}
else if (d > 0)
{
    Console.Write("Ambas raizes sao reais e diferentes \n");
    x1 = (-b + Math.Sqrt(d)) / (2 * a);
    x2 = (-b - Math.Sqrt(d)) / (2 * a);
    Console.Write($"Primeira raiz {x1}\n");
    Console.Write($"Segunda raiz {x2}\n");
}
else
    Console.Write("As raizes sao imaginarias.\nSem solucao para os numeros reais.\n");

// 3 - Escreva um programa para exibir os 10 primeiros números naturais e calcular a sua soma usando os loop
// while, do-while e for. 

//loop while
int i = 1, soma = 0;

Console.Write("Os primeiros 10 numeros naturais e sua soma sao: ");
while (i <= 10)
{
    soma = soma + i;
    Console.Write($"{i}");
    i++;
}
Console.Write("A soma dos numeros e: \n");

//loop do while
int ii = 1, soma1 = 0;
do
{
    soma1 = soma + ii;
    Console.WriteLine($"{ii}");
    ii++;
} while (ii <= 10);
Console.WriteLine($"A soma dos numeros e:{soma} \n");

//loop do for
int l, soma2 = 0;
Console.Write($"Os 10 primeiros numeros naturais sao:{soma1} \n");
for (l = 1; l <= 10; l++)
{
    soma2 = soma2 + l;
    Console.Write($"{l}");
}
Console.Write($"A soma dos numeros e:{soma2} \n");