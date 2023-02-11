// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


int[] array = new int [new Random().Next(4, 10)];

for (int i = 0; i < array.Length; i++)
    {
    array[i] = new Random().Next(1, 10);
    // Console.Write($"{array[i]},"); 
    }
Console.WriteLine("Массив [{0}", String.Join(" ", array) +"]");

int [] arrayCopy = new int[array.Length];
for (int i = 0; i < array.Length; i++)
    {
    arrayCopy[i] = array[i];
    }
Console.WriteLine("Массив копия [{0}", String.Join(" ", arrayCopy) +"]");    