// Задайте двумерный массив размера m на n,
// каждый элемент массива находится по формуле Amn = m+n
// Выведите полученный массив на экран.

Console.Write("Введите размер m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер n ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m,n];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1) ; j++)
    {
       arr[i,j] = i + j; 
    }
}

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
