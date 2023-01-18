// Задача 38: Напишите программу реализующую методы формирования массива, заполненного 
//случайными вещественными числами и вычисления разницы между максимальным и минимальным элементов массива.

using static System.Console;
Clear();

Write("Введите размер массива: ");
int x = int.Parse(ReadLine()!);
double [] array = GetArray(x);
PrintArray(array);
WriteLine();
WriteLine($"Разница между максимальным и мнимальным элементом массива равна {Dif(array)}");


double Dif (double [] array1)
{
double res;
double minnum = array1[0];
double maxnum = array1[0];

foreach (var a in array1)
{
    if (a < minnum) 
    {
        minnum = a;
    }
    if (a > maxnum)
    {
        maxnum = a;
    }
}
res = Math.Round(maxnum-minnum, 1);
return res;
}


double[] GetArray (int size) 
{
    double[] resultArray = new double [size];       
    Random rnd = new Random();               
    for (int i = 0; i < size; i++)
    {
         resultArray [i] = Math.Round((rnd.NextDouble() * 100), 1);
    }
    return resultArray;
}


void PrintArray(double[] inArray)   
{
    Write("[");
    for (int i = 0; i < inArray.Length-1; i++)
    {
       Write($"{inArray[i]}, ");
    }
    Write($"{inArray[inArray.Length-1]}]");
    

}
