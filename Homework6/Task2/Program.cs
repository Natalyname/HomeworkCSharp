// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using static System.Console;
Clear();

Write("Введите b1: ");
var b1 = Convert.ToDouble(ReadLine()!);
Write("Введите k1: ");
var k1 = Convert.ToDouble(ReadLine()!);
Write("Введите b2: ");
var b2 = Convert.ToDouble(ReadLine()!);
Write("Введите k2: ");
var k2 = Convert.ToDouble(ReadLine()!);

if (k1==k2)
{
    WriteLine("Не имеют точки пересечения");
}
else
{
var x = Math.Round(-(b1 - b2) / (k1 - k2), 1);
var y = Math.Round(k1 * x + b1, 1);

WriteLine($"Пересечение в точке: ({x}; {y})");
}