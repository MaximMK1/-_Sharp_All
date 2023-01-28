// Программа, которая принимает на вход координаты двух точек и находит расстояние между ними.

Console.WriteLine("Введите координаты точки A: ");
Console.Write("x: ");
int Ax = int.Parse(Console.ReadLine());
Console.Write("y: ");
int Ay = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки В: ");
Console.Write("x: ");
int Bx = int.Parse(Console.ReadLine());
Console.Write("y: ");
int By = int.Parse(Console.ReadLine());

int diffX = Ax-Bx;
int diffY = Ay-By;

double S = Math.Sqrt(Math.Pow(diffX, 2) + Math.Pow(diffY, 2));
Console.Write("Расстояние между точками равно {0}", Math.Round(S, 3));

