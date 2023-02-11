// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексаими (0,0) (1,1) и тд)

Console.Write("Введите размер m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер n ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m,n];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1) ; j++)
    {
       arr[i,j] = new Random().Next(-9, 10); 
    }
}
Console.WriteLine("Заданный массив");
PrintArr(arr);

void PrintArr(int[,] arry)
{
   for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1) ; j++)
        {
            Console.Write($"{arry[i, j],4}");
        }
        Console.WriteLine();
    } 
}

Console.Write("Сумма элементов главной диагонали:");
SumElements(arr);
void SumElements (int [,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j) 
            {
                sum = sum + array[i,j]; 
                Console.Write ($"{array[i,j]} + ");
            }    
            else;
        }
    }
    Console.Write($"\b\b= {sum}");
} 
