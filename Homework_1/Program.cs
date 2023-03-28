/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 


Console.WriteLine("Введите 1-ое число");

int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 2-ое число");

int b = int.Parse(Console.ReadLine());

if( a > b){
    Console.WriteLine("Первое число является больше второго");
}

else  {
    Console.WriteLine("Первое число меньше второго");
}
-----------------------------------------------------------------

Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22


Console.WriteLine("Введите 3 числа");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max)
{
    max = b;
}

if (c > max)
{
    max = c;
}
Console.WriteLine("Наибольшее из введённых чисел - " + max);
------------------------------------------------------------------

Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет



Console.WriteLine("Введите число");

int N = Convert.ToInt32(Console.ReadLine());

if (N % 2 == 1)
{
    Console.WriteLine(N + " является нечётным числом");
}
else
{
    Console.WriteLine(N + " является чётным числом");
}
-------------------------------------------------------

Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int a = 1;

while (a <= N)
{
    if (a % 2 == 0)
        Console.Write(a + " , ");
    a++;
}
