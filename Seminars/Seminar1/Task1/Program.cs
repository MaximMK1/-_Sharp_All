//Программа, которая проверяет является ли первое число квадратом второго.

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
int number2 = int.Parse(Console.ReadLine());
if (number1 == Math.Pow(number2, 2))
{
    Console.Write("Первое число является квадратом второго");
}
else
{
    Console.Write("Первое число не является квадратом второго");
}
