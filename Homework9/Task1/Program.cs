// Задача 64: Напишите программу, которая реализует рекурсивный метод вывода 
// всех натуральных числел в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using static System.Console;
Clear();

Write("Введите число: ");
int N = int.Parse(ReadLine()!);

PrintNumbers(N);

void PrintNumbers(int numN)
{
    if (numN >= 1)
    {
        Write($"{numN} ");
        numN--;
        PrintNumbers(numN);
    }
}