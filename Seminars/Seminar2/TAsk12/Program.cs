// Программа которая будет принимать два числа. Выводить кратно ли первое число второму. Если нет выводить остаток от деления.

Console.WriteLine("Введите первое число: "); 
int num1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите второе число: "); 
int num2 = Convert.ToInt32(Console.ReadLine());
int ostatok = num1 % num2;
if (ostatok==0)
{
Console.WriteLine("первое число кратно второму "); 
}
else 
{
    Console.Write("Первое число не кратно второму, остаток = "); 
    Console.WriteLine (ostatok);
}