// Задача 59: Задайте двумерный массив из целых чисел.
//  Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

// Разобраться!

Console.Write("Задайте колличество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте колличество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[row, col];
FillArray(array);
PrintArray(array);
int[,] newArray = DeleteRowsColumns(array);
PrintArray(newArray);

int[,] DeleteRowsColumns(int[,] arr)
{
    int minI = 0;
    int minJ = 0;
    int[,] newArray = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[minI, minJ] > arr[i, j])
            {
                minI = i;
                minJ = j;
            }
        }
    }

    for (int k = 0; k < newArray.GetLength(0); k++)
    {
        // if(k == minI) continue;
        for (int l = 0; l < newArray.GetLength(1); l++)
        {
            //if(l == minJ) continue;
            if (k >= minI && l >= minJ) newArray[k, l] = arr[k + 1, l + 1];
            else if (k >= minI) newArray[k, l] = arr[k + 1, l];
            else if (l >= minJ) newArray[k, l] = arr[k, l + 1];
            else newArray[k, l] = arr[k, l];
        }
    }

    return newArray;
}   

void FillArray(int[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 11);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine("");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],3}");
        }
    }
    Console.WriteLine("");
}

