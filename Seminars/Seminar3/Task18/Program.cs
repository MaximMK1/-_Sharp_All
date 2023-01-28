// Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат точек 
//в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
int num = int.Parse(Console.ReadLine());

switch (num)
{
    case 1: Console.WriteLine("Возможные значения X>0, Y>0"); break;
    case 2: Console.WriteLine("Возможные значения X<0, Y>0"); break;  
    case 3: Console.WriteLine("Возможные значения X<0, Y<0"); break;  
    case 4: Console.WriteLine("Возможные значения X>0, Y<0"); break; 
    default: Console.WriteLine("Цифра должна быть от 1 до 4"); break;  
}