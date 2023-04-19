// Двумерные массивы
// string[,]table = new string[2,3]; 2- строки, 3 - столбцы.

/*string[,]table = new string[2,5];
table[1, 2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
    
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}
----------------------------




void PrintArray(int [,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++) // где 0 - количество строк.
//(int i = 0; i < 3; i++)(int i = 0; i < matrix.GetLength(0); i++), 

    {
        for (int j = 0; j < matr.GetLength(1); j++) // или  (int j = 0; j < 4; j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine(); // переход на новую строчку
    }
}

void FillArray(int[,]matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10); // генератор случайных чисел 
        }
    }
}
int[,]matrix = new int [3,4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix); 
-----------------

где-то ошибка

double Factorial(int n)
{
    // 1! = 1
    // 0! = 1
    if (n == 1) return 1;
    else return n * Factorial(n-1);
}
for (int i = 0; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}"); 
}
*/