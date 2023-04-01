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
Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
*/

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

