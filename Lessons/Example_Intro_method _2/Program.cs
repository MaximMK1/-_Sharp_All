// Имеется одномерный массив array из n элементов, требуется найти элемент массива равный find

int [] array = {1, 2, 3, 4, 5, 6, 1, 4, 7, 8};

int n = array.Length; // переменной n присваиваем значение равное количеству элементов массива
int find = 4;

int index = 0;

while (index < n) 
{
  if(array[index] == find)
  {
    Console.WriteLine(index);
    break;  // оператор остановки (прервать дальнейшее выполнение кода)
  }
  index=index+1;
}
