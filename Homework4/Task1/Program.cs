// Напишите программу, реализующую метод,который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B с использованием цикла.

using static System.Console;
Clear();

Write("Введите первое число: ");
int number1 = int.Parse(ReadLine()!);
Write("Введите второе число: ");
int number2 = int.Parse(ReadLine()!);
int pow = GetPow (number1, number2);
WriteLine($"Квадрат числа {number1} равен {pow}");


int GetPow (int X, int N)
{
int result = 1;
int i = 1;
while (i<=N)
{
   result *=X;
    i++;
}

return result;
}