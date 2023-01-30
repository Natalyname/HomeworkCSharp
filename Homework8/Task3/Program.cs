// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using static System.Console;
Clear();

Write("Введите количество строк 1 массива: ");
int rowsA = int.Parse(ReadLine()!);
Write("Введите количество столбцов 1 массива: ");
int columnsA = int.Parse(ReadLine()!);
Write("Введите количество строк 2 массива: ");
int rowsB = int.Parse(ReadLine()!);
Write("Введите количество столбцов 2 массива: ");
int columnsB = int.Parse(ReadLine()!);
if (columnsA != rowsB)
{
  WriteLine();
  WriteLine("Данные матрицы нельзя умножить!");
  return;
}
    int[,] arr1 = GetArray(rowsA, columnsA, 0, 10);
    int[,] arr2 = GetArray(rowsB, columnsB, 0, 10);
    WriteLine();
    WriteLine("Первая матрица: ");
    PrintArray(arr1);
    WriteLine();
    WriteLine("Вторая матрица: ");
    PrintArray(arr2);
    WriteLine();
    WriteLine("Произведение двух матриц: ");
    PrintArray(GetMultiplicationMatrix(arr1,arr2));

    int[,] GetArray(int m, int n, int min, int max)
    {
      int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
      for (int j = 0; j < n; j++)
      {
        result[i, j] = new Random().Next(min, max + 1);
      }
      
    }
      return result;
    }

    void PrintArray(int[,] inArray)
    {
     for (int i = 0; i < inArray.GetLength(0); i++)
     {
       for (int j = 0; j < inArray.GetLength(1); j++)
       {
         Write($"{inArray[i, j]} ");
       }
      WriteLine();
     }
    }

    int [,] GetMultiplicationMatrix(int[,] arrayA, int[,] arrayB)
    {
      int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
      for (int i = 0; i < arrayA.GetLength(0); i++)
      {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
          for (int k = 0; k < arrayA.GetLength(1); k++)
          {
            arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
          }
        }
      }
      return arrayC;
    }
  