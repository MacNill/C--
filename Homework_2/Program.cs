/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого 
числа.

456 -> 5
782 -> 8
918 -> 1


int Promt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Promt("Введите 3-х значное число - ");
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Введено не 3-х значное число! Пожалуйста, повторно введите число.");
    return;
}
Console.WriteLine($"Введите число '{number}'");
int secondRank = number / 10 % 10;
Console.WriteLine($"Вторая цифра '{secondRank}'");
-----------------------------------------------------------------
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
int Promt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int GetThirdRank(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}
bool ValidateNumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("3-ей цифры нет");
        return false;
    }
    return true;
}
int number = Promt("Введите число > ");
if (ValidateNumber(number))
{
    Console.WriteLine(GetThirdRank(number));
}



