// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.


Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

int count (int A)
{
int count = 0; 
    while (A > 0)
{
    A /= 10;   // A = A / 10
    count++;
}
return count;
}

Console.WriteLine($"Количество цифр в числе = {count(A)}");


// Console.Write("Введите число А: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int count = 0; 

// while (A > 0)
// {
//     A /= 10;   // A = A / 10
//     count++;
// }
// Console.WriteLine($"Количество цифр в числе = {count}");