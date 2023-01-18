// Задача 34: Напишите программу реализующую методы формирования массива, заполненного 
//случайными положительными трёхзначными числами, и подсчета количества чётных чисел в массиве.

using static System.Console;
Clear();

Write("Введите размер массива: ");
int x = int.Parse(ReadLine()!);
int [] arr = GetArray(x);
PrintArray(arr);
WriteLine();
WriteLine($"Количество четных чисел в массиве - {Sum(arr)}");

int Sum (int[] arr) 
{
int res = 0;
for (int i = 0; i < arr.Length; i++)
{
 if (arr[i]%2==0) res ++;
}
return res;
}


int [] GetArray (int size)
{
    int [] array=new int [size];
    for (int i=0; i<array.Length; i++)
    {
        array [i] = new Random().Next(100, 1000);
    }
    return array;
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
