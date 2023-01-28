// Напишите программу, которая принимает на вход число 
// и проверяет, кратно ли оно одновременно 7 и 23.
Console.WriteLine("Введите число: "); 
int num = Convert.ToInt32(Console.ReadLine()); // Я не помню как там
int ostatok7 = num % 7;
int ostatok23 = num % 23;
if (ostatok7==0 && ostatok23==0) Console.WriteLine($"Число {num} одновременно кратно 7 и 23"); 
else Console.WriteLine($"Число {num} не кратно одновременно 7 и 23");
