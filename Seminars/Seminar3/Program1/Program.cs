// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X не равен 0 и Y не равен 0 и выдает номер четверти плоскости, в которой находится эта точка.

Console.Write("Введите X: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите Y: ");
int y = int.Parse(Console.ReadLine());

if(x > 0 && y > 0) Console.WriteLine("1");
else if (x < 0 && y > 0) Console.WriteLine("2");
else if (x < 0 && y < 0) Console.WriteLine("3");
else if (x > 0 && y < 0) Console.WriteLine("4");
else Console.WriteLine("Ошибка ввода");