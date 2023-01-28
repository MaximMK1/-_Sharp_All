//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int num = new Random().Next(10,100);
//Console.WriteLine(num);
int num1 = num / 10;
int num2 = num % 10;
//Console.WriteLine (num1);
//Console.WriteLine (num2);
if(num1 > num2)
{
    Console.WriteLine("Наибольшая цифра числа {0} равна {1}",num, num1);
}
else
{
    Console.WriteLine("Наибольшая цифра числа {0} равна {1}",num, num2);
}