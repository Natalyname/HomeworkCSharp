// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
//больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2

using static System.Console;
Clear();

Write("Введите числа через пробел: ");
int[] arr = Array.ConvertAll(ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries), int.Parse);

int count = 0; 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
WriteLine($"Кол-во чисел больше нуля: {count}");