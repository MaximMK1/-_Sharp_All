// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

int Proisv (int N)
{
    int count = 1;
    for (int i = 1; i <= N; i++)
    {
        count = count * i;  
    }
    return count;
}
Console.WriteLine($"Произведение чисел от 1 до {N} равна {Proisv (N) } ");