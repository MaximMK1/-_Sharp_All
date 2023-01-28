// Возведение числа в степень, квадратный корень из числа, округление чисел, модуль числа.

Console.Write("Введите число: ");
double num = double.Parse(Console.ReadLine());  // тип переменной double - дробный тип.
Console.WriteLine(Math.Pow(num,3));  //возведение переменной в степень 3
Console.WriteLine(Math.Sqrt(num)); //корень квадратный из переменной
Console.WriteLine(Math.Round(num)); //округление до целого
Console.WriteLine(Math.Round(num,3)); // округление до третьей цифры после запятой
Console.WriteLine(Math.Abs(num)); // модуль числа