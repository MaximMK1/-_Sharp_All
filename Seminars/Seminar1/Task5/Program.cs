// Программа, которая на вход принимает одно число N, а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
if (N < 0)
N = N *(-1);

int number2 = N * (-1);
while (number2 <= N) 
{
    Console.Write(number2 + ", ");
    number2 = number2 + 1;
} 
Console.Write("\b\b  ");

