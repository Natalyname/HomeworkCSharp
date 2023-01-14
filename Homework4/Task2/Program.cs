// Задача 27: Напишите программу, реализующую метод, который принимает на вход число и выдаёт 
//сумму цифр в числе.

using static System.Console;
Clear();

WriteLine("Введите число: ");
int number = int.Parse(ReadLine()!);

int Sum = GetSum(number);
WriteLine($"Сумма цифр в числe {number} - {Sum}");

int GetSum(int A)

 {
    int result = 0;
    result += A % 10;
    A /= 10;
        if(A > 0)
        {
        result += GetSum(A);
        }
        return result;
}