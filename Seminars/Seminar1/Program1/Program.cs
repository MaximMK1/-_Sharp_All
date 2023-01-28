//Напишите программу, которая принимает число и выдает его квадрат.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int result = number * number;

// Вывод в лоб
Console.Write("Квадрат числа ");
Console.Write(number);
Console.Write(" равен ");
Console.WriteLine(result);
//Вывод с $
Console.WriteLine($"Квадрат числа {number} равен {result}");
//Вывод с обращением к переменным
Console.WriteLine("Квадрат числа {0} равен {1}", number, result);
//Вывод с использованнием библиотеки Math
int result1 = Convert.ToInt32(Math.Pow(number,2));
Console.WriteLine("Квадрат числа {0} равен {1}", number, result1);
//Вывод с использованием знака +
Console.WriteLine("Квадрат числа " + number + " равен " + result1);
