// // Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.




Console.Write("Задайте колличество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте колличество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[row, col];

FillArray(array);
PrintArray(array);
ChangeElements(array);
PrintArray(array);

void ChangeElements(int[,] arr)
{
    int j = 0;
    int k = arr.GetLength(1) - 1;
    int temp = 0;

    for (int i = 0; i < arr.GetLength(1); i++)
    {
        temp = arr[j, i];
        arr[j, i] = arr[arr.GetLength(0) - 1, i];
        arr[arr.GetLength(0) - 1, i] = temp;
    }
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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine("");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],3}");
        }
    }
    Console.WriteLine("");
}