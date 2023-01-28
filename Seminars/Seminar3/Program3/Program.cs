// Кейсы. 
//Напишите вывод прописью цифры, введенной пользователем. От 1 до 3.

Console.Write("Введите X: ");
int num = int.Parse(Console.ReadLine());

switch (num)
{
    
    case 1:
    {
       Console.WriteLine("один");
       break;
    }

    case 2:
    {
      Console.WriteLine("два");
      break;  
    }
    case 3:
    {
      Console.WriteLine("три");
      break;  
    }
    default:
    {
       Console.WriteLine("Нет данных");
      break;  
    }
}
