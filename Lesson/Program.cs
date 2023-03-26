/* 
1) Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на себя).
Например:
* 4 -> 16
* -3 -> 9
* -7 -> 49 



string input = Console.ReadLine();

int number = int.Parse(input);


Console.WriteLine(number * number);
-------------------------------------
Задача No1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет a = 9, b = -3 -> да a = -3 b = 9 -> нет

*/

Console.WriteLine("Вывести текст на экран");

int a = int.Parse(Console.ReadLine());

int b = int.Parse(Console.ReadLine());

if (a == b * b){
    Console.WriteLine("Первое число является квадратом второго");
}

else  {
    Console.WriteLine("Первое число не являетмя квадратом второго");
}

