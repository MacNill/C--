/* // Вид 1. Ничего не принимают, ничего не возвращают. 
void Method1 () 
{
    Console.WriteLine ("Автор ...");
}
Method1(); 

// Вид 2. Что-то принимают, ничего не возвращают.

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения"); // Method2(msg:"Текст сообщения"); - именованные аргументы.

void Method21 (string msg, int count)
{
    int i =0;
    while ( i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст", 4);

// Вид 3. Ничего не принимают, что-то возвращают. 

int Method3()
{
    return DataTime.Now.Yerar;
}
int year = Method3();
Console.WriteLine(year);

// Вид 4. Что-то принимают, что-то возвращают. 

string Method4 (int count, string c)
{
    int i =0;
    string result = string.Empty;

    while (i< count)
    {
        result = result + text;
        i++;
    }
        return result;
    
}
string res = Method4(10, "asdf");
Console.WriteLine(res);

// Цикл с for

string Method4 (int count, string c)
{
    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    
        return result;
    }
}
string res = Method4(10, "z");
Console.WriteLine(res); 

// Цикл в цикле

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($" {i} x {j} = {i * j}");
    }
    Console.WriteLine();
}
--------------------------------
// Задача 1.
//Дан текст. В тексте нужно все пробелы заменить черточками,
//маленькие буквы “к” заменить большими “К”, а большие “С” заменить
//маленькими “с”.

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
= "ежели бы вас послали вместо нашего милого"
+ "Винценгероде, вы бы взяли приступом согласие"
+ "прусского короля. Вы так красноречивы."
+ "Вы дадите мне чаю?";

//             0,1,2,3,...
// string s = "qwerty"
// s [3] = r [3]

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int lenght = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text [i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);


int[] arr = { 1, 5, 4, 2, 4, 7, 1, 2, 3 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort();
void SelectionSort(int[] array);
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;

        for (int j = i+1; j < array.Lenght - 1; j++)
        {
         if(array[j] < array[minPosition])  minPosition = j;
        }

        int temporary = array[i];
        array[i] = array [minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr); */