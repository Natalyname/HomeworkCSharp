// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using static System.Console;
Clear();

WriteLine("Введите размер массива: ");
int m = int.Parse(ReadLine()!);
int n = int.Parse(ReadLine()!);
int[,] array = GetMatrixArray(m, n);

PrintMatrixArray(array);
WriteLine();
WriteLine("Элементы по убыванию в каждой строке массива: ");
SortedArray(array);
PrintMatrixArray(array);


void SortedArray(int[,] inArray)
{
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    for (int j = 0; j <inArray.GetLength(1); j++)
    {
      for (int k = 0; k < inArray.GetLength(1) - 1; k++)
      {
        if (inArray[i, k] < inArray[i, k + 1])
        {
          int temp = inArray[i, k + 1];
          inArray[i, k + 1] = inArray[i, k];
          inArray[i, k] = temp;
        }
      }
    }
  }
}


int[,] GetMatrixArray(int rows, int columns)
{
    Random rand = new Random();
    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i,j] = rand.Next(1, 100);
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
