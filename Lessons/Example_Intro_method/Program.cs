// Нахождение максимума из 9 чисел классичесим методом

// int a1 = 15;
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 23;
// int c2 = 33;
// int a3 = 4356;
// int b3 = 23;
// int c3 = 33;

// int max = a1;
// if (b1 > max)  max = b1;    
// if (c1 > max)  max = c1;   
// if (a2 > max)  max = a2; 
// if (b2 > max)  max = b2;   
// if (c2 > max)  max = c2; 
// if (a3 > max)  max = a3; 
// if (b3 > max)  max = b3;   
// if (c3 > max)  max = c3;

// Console.WriteLine (max);


// Нахождение максимума из 9 чисел с помощью функций

int max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;  
}
int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 6754;
int b2 = 23;
int c2 = 33;
int a3 = 435;
int b3 = 23;
int c3 = 33;

// int max1 = max (a1, b1, c1);
// int max2 = max (a2, b2, c2);
// int max3 = max (a3, b3, c3);
// int maxFinal = max (max1, max2, max3);

int maxFinal = max (max (a1, b1, c1), max (a2, b2, c2), max (a3, b3, c3)); // тут в качестве аргументов функции выступают сами функции

Console.WriteLine(maxFinal);