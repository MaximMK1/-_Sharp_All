// Напишите программу которая будет возвращать последний символ от введенного числа. Например ввод 3456, вывод программы 6.

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int lastSimbol = N % 10;
Console.WriteLine(lastSimbol);