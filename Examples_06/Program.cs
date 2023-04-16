/*
 Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₙₙ = m+n. 
Выведите полученный массив на экран.
m = 3, n = 4. 
0 1 23
1 2 34
2 3 45

int[,] array = Generate2DArray(3, 23);
PrintArray(array);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
           Console.Write(array[i,j]);
           Console.Write(" ");

        }
        Console.WriteLine();
    }
}

int[,] Generate2DArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }

    return array;
}
----------------------------------

*/
