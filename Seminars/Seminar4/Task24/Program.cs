// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine());

int count = 0;

int Sum (int sum)
{
    for (int i = 0; i <= sum; i++)
    {
        count += i;
    }
    return count;
}
Console.WriteLine($"Сумма чисел от 1 до {A} равна {Sum(A)} ");