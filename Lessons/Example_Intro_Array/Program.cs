// Нахождение максимума из 9 чисел с помощью массива

int max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;  
}

int [] array = {11, 332, 23, 44, 56, 74, 32, 45, 53};

int maxFinal = max (max (array[0], array[1], array[2]), max (array[3], array[4], array[5]), max (array[6], array[7], array[8])); // тут в качестве аргументов функции выступают сами функции

Console.WriteLine(maxFinal);
