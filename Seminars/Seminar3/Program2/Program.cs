// Напишите программу которая будет выводить в строку все цифры от 0 до num. С помощью цикла for.

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

for (int i = 0; i <= num; i++)
{
    Console.Write($"{i} ");
}


