// Задача 36: Напишите программу реализующую методы формирования массива, 
//заполненного случайными числами и подсчета суммы элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19

using static System.Console;
Clear();

Write("Введите размер массива, min и max через пробел: ");
string [] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int [] array=GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));

PrintArray(array);
WriteLine();
Write($"Сумма элементов, стоящих на нечетных позициях равна {Sum(array)}");

int Sum (int[] array) 
{
    int res=0;
   for (int i = 1; i < array.Length; i+=2)
   {
     res=res+array[i];
   }
   return res;
}


int[] GetArray (int size, int MinValue, int MaxValue) 
{
    int[] resultArray = new int [size];       
    Random rnd = new Random();               
    for (int i = 0; i < size; i++)
    {
        resultArray [i] = rnd.Next(MinValue, MaxValue+1);
    }
    return resultArray;
}


void PrintArray(int[] inArray)   
{
    Write("[");
    for (int i = 0; i < inArray.Length-1; i++)
    {
       Write($"{inArray[i]}, ");
    }
    Write($"{inArray[inArray.Length-1]}]");
}
