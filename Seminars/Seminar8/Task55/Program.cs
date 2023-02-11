
// / Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//  В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// 1 способ

// Console.WriteLine("Hello, World!");

// Console.Write("Задайте колличество строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Задайте колличество столбцов: ");
// int col = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[row, col];

// if (row != col)
// {
//     Console.Write("Введите квадратную матрицу");
//     return;
// }

// FillArray(array);
// PrintArray(array);
// ChangeColumnsAndRows(array);
// PrintArray(array);


// void ChangeColumnsAndRows(int[,] arr)
// {
//     int temp = 0;
//     int[,] secondArray = new int[arr.GetLength(0), arr.GetLength(1)];

//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             secondArray[i, j] = arr[j, i];
//         }
//     }
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = secondArray[i, j];
//         }
//     }
// }

// void FillArray(int[,] arr)
// {
//     Random random = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = random.Next(1, 11);
//         }
//     }
// }

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.WriteLine("");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j],3}");
//         }
//     }
//     Console.WriteLine("");
// }    

// 2 способ правильный: сама функция для замены строк на столбцы.  Доделать! 

void ModifyArray(int [,] arr)
{ 
    for (int row = 0; row < arr.GetLength(0); row++)
    {
      for (int col = row+1; col < arr.GetLength(1); col++)
      {
        int temp = arr[row,col];
        arr[row,col] = arr[col,row];
        arr[col,row] = temp;
      }
    }
}

