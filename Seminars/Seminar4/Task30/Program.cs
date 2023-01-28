// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

int[] array = new int [8]; 
for (int i = 0; i < 8; i++)
{
    array[i] = new Random().Next(0,2);
    Console.Write(array[i]+", ");
}
Console.Write("\b\b  ");

// int[] array = new int[8];
// FillArray(array);
// ShowArray(array);

// void FillArray(int[] arr)
// {
//     foreach (int element in arr)
//     {
//         arr[element] = new Random().Next(0, 2);
//     }
// }
// void ShowArray(int[] arr)
// {
//     foreach (int element in arr)
//     {
//         Console.Write($"{element} ");
//     }
// }
