﻿// Задача 35: Задайте одномерный массив из 123 случайных чисел.
//  Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] arr = new int [123];  // задаем пустой массив размерности 123
int count = 0;     // тк нам по условию надо найти кол-во элементов, мы создаем переменную счетчик
                    //в которой будем подсчитывать это кол-во
Console.Write($"[");
for (int i = 0; i < arr.Length; i++)  // цикл пробегает по всем индексам массива
{
    arr[i] = new Random().Next (0, 256);   // заполняем каждый индекс массива ранд. значениями от 0 по 255 поэлементно
    Console.Write($"{arr[i]}, ");    // выводим этот массив в консоль по-элементно
    if (arr [i] >= 10 && arr[i] <= 99) count++;  // проверяем каждый индекс массива на условие 10<=arr[i]<=99
                                                // увеличиваем счетчик count на 1 если условие верно, далее цикл повторяется
}    // цикл повторяется пока проверяемый индекс массива не выйдет за пределы длины массива
Console.Write("\b\b] -> {0}", count);  // выводим полученное значение count

