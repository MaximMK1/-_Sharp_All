// // Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
//  второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] arr = new int[new Random().Next(3, 12)]; // задаем пустой массив ранд. размерности от 3 до 12
int index = (arr.Length % 2 == 0) ? (arr.Length / 2) : (arr.Length / 2 + 1);  //тоже самое что и if else, эту строчку
// можно переписать так:
// int index = arr.Length % 2;
// if (arr.Length % 2 == 0) index = arr.Length / 2;
// else index = arr.Length / 2 + 1;
//тут мы проверяем если длина массива четная,
//то перем. index равна половине от длины, если нечетная то index равен половине + 1

int[] arrM = new int[index]; // задаем новый пустой массив с кол-вом элементов =index,
                             //в него мы будем записывать результат задачи

Console.Write($"[");
for (int i = 0; i < arr.Length; i++)  // запускаем цикл по всем индексам заданного пустого массива arr
{
    arr[i] = new Random().Next(0, 10);  // заполняем его ранд. значениями от 0 по 9
    Console.Write($"{arr[i]}, ");  // выводим его в консоль
}
Console.Write("\b\b] -> "); // удаляем запятую в конце

Console.Write($"[");
for (int i = 0; i < arrM.Length; i++) // запускаем цикл по всем элементам нового массива arrM, даллее заполняем его
{
    if(i == (arr.Length - i - 1)) arrM[i] = arr[i]; // тут заполняется последний элемент массива arrM в случае,
                                                   //  если заданный массив arr имеет нечетное кол-во элементов,
                                                   // он равен сам себе arrM[i] = arr[i]
    else    arrM[i] = arr[i] * arr[arr.Length - i - 1]; // тут заполняются остальные элементы массива arrM, путем перемножения
                                                    //соответствующих элементов массива arr, как этого требует условие задачи
   Console.Write($"{arrM[i]}, "); //выводим полученный массив arrM в консоль
}    
Console.Write("\b\b]");
// 2 способ

//     Console.Write("Введите колличество элементов в массиве: ");
// int arrayLength = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[arrayLength];
// FillArray(array);
// PrintArray(array);
// Console.Write(" -> ");
// Console.Write(String.Join(", ", GetProductionPair(array)));

// List<int> GetProductionPair(int[] array)
// {
//     int lastElement = array.Length - 1;
//     int prod = 0;
//     List<int> result = new List<int>();

//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         prod = array[i] * array[lastElement - i];
//         result.Add(prod);
//     }
    
//     if (array.Length % 2 == 1) result.Add(array[array.Length / 2]);
//     return result;
// }


// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 100);
//     }
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.Write("\b]");
// }
