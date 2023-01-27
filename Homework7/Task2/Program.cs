// Задача 52. Напишите программу реализующую методы, формирования двумерного массива и
// массива средних арифметических значений каждого столбца.

//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using static System.Console;
Clear();

WriteLine("Введите размер матрицы: ");
int N = int.Parse(ReadLine()!);
int M = int.Parse(ReadLine()!);
int[,] array = GetMatrixArray(N, M);

PrintMatrixArray(array);
WriteLine("Среднее арифметическое каждого столбца:  ");
Sum(array);


double Sum(int[,] array)
        {
            double Sum = 0;

            for (int j = 0; j < M; j++)
            {
                for (int i = 0; i < N; i++)
                { 
                Sum = Sum + array[i,j];
                }
                
                Sum = Math.Round(Sum/N, 1);
                Write($"{Sum}  ");
                Sum = 0;
            }
            return Sum;
        }

int[,] GetMatrixArray(int rows, int columns)
{
    Random rand = new Random();
    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
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
