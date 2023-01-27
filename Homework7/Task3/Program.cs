// Задача 50. Напишите программу реализующую метод,принимающий позиции элемента в двумерном массиве, 
// и возвращающий значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1;7 -> такого элемента в массиве нет
// 1;1 -> 9

using static System.Console;
Clear();

WriteLine("Введите позицию элемента в двумерном массиве: ");
int N = Convert.ToInt32(ReadLine()!);
int M = Convert.ToInt32(ReadLine()!);
int[,] array = GetMatrixArray();

PrintMatrixArray(array);
WriteLine();
Num (N, M);

void Num (int a, int b)
{
        if ( a > 5 || b > 6 || a < 0 || b < 0 )
        {
            WriteLine("Такого элемента в массиве нет");
        }
        else    
        { 
            WriteLine($"Значение элеменnа с индексами [{a}, {b}] = {array[a,b]}");
        }
    return;    
}    


int[,] GetMatrixArray()
{
    Random rand = new Random();
    int[,] resultArray = new int[5, 6];
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 6; j++)
        {
            resultArray[i,j] = rand.Next(0,10);
        }
    }
    return resultArray;
}


void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],3} ");  
        }
        WriteLine();
    }
}
