/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да


void Numbers(int number)
{
    while (number > 99999 || number <= 9999)
    {
        Console.WriteLine("Введено неверное число. Попробуйте снова.");
        Console.Write("Введите пятизначное число ");
        number = Convert.ToInt32(Console.ReadLine());
    }
    int num1 = number % 10;
    int num2 = number / 10 % 10;
    int num4 = number / 1000 % 10;
    int num5 = number / 10000 % 10;
    if (num1 == num5)
    {
        if (num2 == num4)
        {
            Console.WriteLine("Число является полиндромом.");
        }
        else Console.WriteLine("Число не является полиндромом.");
    }
    else Console.WriteLine("Число не является полиндромом.");
}
Console.Write("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());
Numbers(number);
--------------------------------------------------------
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53


int x1 = ReadInt("Введите координату первой точки Х ");
int y1 = ReadInt("Введите координату первой точки Y ");
int z1 = ReadInt("Введите координату первой точки Z ");
int x2 = ReadInt("Введите координату второй точки X ");
int y2 = ReadInt("Введите координату второй точки Y ");
int z2 = ReadInt("Введите координату второй точки Z ");

int A = x2 - x1;
int B = y2 - y1;
int Z = z1 - z2;

double length = Math.Sqrt(A * A + B * B + Z * Z);
Console.WriteLine($"Длинна отрезка {length}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
---------------------------------------------------------

Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125


int number = ReadInt("Введите число ");

for (int i = 1; i <= number; i++)
{
    Console.Write($"{i * i * i}  ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/
