// Задача 47. Напишите программу реализующую метод, который возвращает массив размером m×n, 
//заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

using static System.Console;
Clear();

Write("Введите размер матрицы через пробел: ");
string[] parameters = ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);

double[,] array = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]));
PrintMatrixArray(array);


double[,] GetMatrixArray(int rows, int columns)
{
    Random rand = new Random();
    double[,] resultArray = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i,j] = Math.Round ((((rand.NextDouble()*2)-1)*10), 1);
        }
    }
    return resultArray;
}


void PrintMatrixArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],6} ");  
        }
        WriteLine();
    }
}
