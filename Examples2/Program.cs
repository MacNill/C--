/*Console.WriteLine("Hello, World");
int x = int.Parse(Console.ReadLine());

int y = int.Parse(Console.ReadLine());

if (x == 0 || y == 0)
{
    Console.WriteLine("X или Y равны нулю. Данные введены неправильно.");
    return;
    ----------------------------------------------------------------------
}

Console.WriteLine("Ведите X");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Ведите Y");
int y = int.Parse(Console.ReadLine());

int result = GetNumberOfQuarter(x, y);
if (result == 0)

{
    Console.WriteLine("X или Y равны нулю. Данные введены неправильно.");
    return;
}
Console.WriteLine(result);

int GetNumberOfQuarter(int x, int y)
{

    if (x > 0 && y > 0)
    {
        return 1;
    }

    if (y > 0 && x < 0)
    {
        return 2;
    }

    if (y < 0 && x < 0)
    {
        return 3;
    }

    if (y < 0 && x < 0)
    {
        return 4;
    }

    return 0;
}
---------------------------------------------
Задача No18. Общее обсуждение
Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой 
четверти (x и y).


Console.WriteLine("Введите номер четверти");
int x = int.Parse(Console.ReadLine());
string range = GetRangeByQuarter(x);

Console.WriteLine(range);

string GetRangeByQuarter(int x)
{
    if (x == 1)
    {
        return "x > 0 и y > 0";
    }

       if (x == 2)
    {
        return "x < 0 и y > 0";
    }

        if (x == 3)
    {
        return "x < 0 и y < 0";
    }

        if (x == 4)
    {
        return "x < 0 и y < 0";
    }
    return " ";
}


int a = int.Parse(Console.ReadLine());
int sum = GetSumToNumber(a);
Console.WriteLine(sum);

int GetSumToNumber(int number)
{
    int sum = 0;

    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;

}
----------------------------------------------------
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 5 -> 120


Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int fact = Factorial(a);
Console.WriteLine(fact);

int Factorial(int a)
{
    int factorial = 1;
    for (int i = 1; i <= a; i++)
    {
        factorial = factorial * i;
    }
    return factorial;
}
-------------------------------------------------
Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.




int [] array = RandomArray();
PrintArray(array);
int[] RandomArray()
{
    int[] array = new int[8];
    Random rang = new Random();

    for (int i = 0; i < array.Length; i++)
        array[i] = rang.Next(0, 2);
  
    return array;
}
void PrintArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}
---------------------------------------

int size = int.Parse(Console.ReadLine());
int min = int.Parse(Console.ReadLine());
int max = int.Parse(Console.ReadLine());
int[] array = RandomArray(size, min, max);
PrintArray(array);
int[] RandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
        array[i] = rand.Next(min, max);
    
    return array;

}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

*/