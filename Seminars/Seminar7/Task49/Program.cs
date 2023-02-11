// Задайте двумерный массив. Найдите элементы, у
// которых оба индекса не четные и замените эти элементы на их квадраты.


Console.Write("Введите размер m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер n ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m,n];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1) ; j++)
    {
       arr[i,j] = new Random().Next(-9, 10); 
    }
}
Console.WriteLine("Заданный массив");
PrintArr(arr);

void PrintArr(int[,] arry)
{
   for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1) ; j++)
        {
            Console.Write($"{arry[i, j],4}");
        }
        Console.WriteLine();
    } 
}
Console.WriteLine("Полученный массив");
PrintArrResult(arr);

void PrintArrResult(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) ; j++)
        {
            if (i % 2 != 0 && j % 2 != 0) array[i,j] = Convert.ToInt32(Math.Pow(array[i,j],2));
           
            Console.Write($"{array[i, j],4}");
        }
        Console.WriteLine();
    } 
}
