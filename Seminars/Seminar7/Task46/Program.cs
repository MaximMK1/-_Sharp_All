// Задача 46. Задайте двумерный массив размером mxn, заполненный случайными целыми числами.
// m = 3, n =4.
//1 4 8 19
//5 -2 33 -2
// 77 3 8 1

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

PrintArr(arr);

void PrintArr(int[,] arry)
{
   for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1) ; j++)
        {
            Console.Write($"{arry[i, j],4}");
        }
        Console.WriteLine();
    } 
}

//Попробовать сделать эту задачу с помощью одного цикла.
// Решение:

// Console.Write("Введите размер m ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размер n ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] arr = new int[m,n];
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1) ; j++)
//     {
//        arr[i,j] = new Random().Next(-9, 10); 
//        Console.Write($"{arr[i, j],4}");
//     }
//         Console.WriteLine();
// }
