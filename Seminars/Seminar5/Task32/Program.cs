// Задача 32: Напишите программу замены элементов массива: положительные элементы замените
//  на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 



int[] arr1 = new int[new Random().Next(3, 13)];  // тут создаём пустой массив с рандомным количеством элементов от 3 до 13

Console.Write("[");
for (int i = 0; i < arr1.Length; i++)
{
    arr1[i] = new Random().Next(-9, 10);  //заполняем массив arr1 рандомными значениями от -9 до 10
    Console.Write($"{arr1[i]}, ");  //выводим получившийся массив в консоль
    arr1[i] = -1 * arr1[i];  // меняем знак у каждого элемента, по очереди по мере прохождения цикла "for"
}
Console.Write("\b\b] -> ");  //убираем лишнюю запятую в конце вывода массива в консоль


Console.Write("[");        
for (int i = 0; i < arr1.Length; i++)     // в этом цикле мы выводим измененный массив в консоль
{
    Console.Write($"{arr1[i]}, ");      // проще вывести массив можно так Console.WriteLine($"[{string.Join(", ", array)}]");
}                              
Console.Write("\b\b]");

// 2 способ

// int[] array = new int[5];
// FillArray(array);
// Console.Write("массив ");
// PrintArray(array);
// Console.Write("\nВведите число, которое нужно найти: ");
// int number = Convert.ToInt32(Console.ReadLine());
// CheckNumberAndNumberModule(array, number);

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-4, 11);
//     }
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.Write(" ]");
// }

// void CheckNumberAndNumberModule(int[] array, int number)
// {
//     if (array.Contains(number) || array.Contains(number * -1)) Console.Write("Да");
//     else Console.Write("Нет");
//     // for (int i = 0; i < array.Length; i++)
//     // {
//     //     if (number == array[i] || number * -1 == array[i])
//     //     {
//     //         Console.Write("Да");
//     //         return;
//     //     }
//     // }
//     // Console.Write("Нет");
// }