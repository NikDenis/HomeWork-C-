/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/
/*
int SqureNumber(int numbera, int numberb)
{
    int current = 0;
    int squre = 1;

    while(current < numberb)
    {
        squre *= numbera;
        current ++;
       
    }
    return squre;
}

Console.WriteLine("Здравствуйте! Рады помочь вам!");
Console.WriteLine("");

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Натуральна степень числа {a} это {SqureNumber(a,b)}");

Console.WriteLine("");

Console.WriteLine("Мы рады что вы выбрали нас!");
*/
/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

/*
int SumNum(int number)
{
    int result = 0;

    while(number != 0)
    {
        int sum = number % 10;
        result += sum;
        number = number / 10;

    }
    return result;
}

Console.WriteLine("Здравствуйте! Рады помочь вам!");

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр числа: {a} равна {SumNum(a)}");
Console.WriteLine("Мы рады что вы выбрали нас!");
*/


/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]

int[] arr = new int[8];

void PrintArray (int[] array)
{
    int count = array.Length;

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите первое число масива: ");
int a = Convert.ToInt32(Console.ReadLine()); 
arr[0] = a;
Console.WriteLine("Введите второе число масива: ");
int b = Convert.ToInt32(Console.ReadLine());
arr[1] = b;
Console.WriteLine("Введите третье число масива: ");
int c = Convert.ToInt32(Console.ReadLine()); 
arr[2] = c;
Console.WriteLine("Введите четвертое число масива: ");
int d = Convert.ToInt32(Console.ReadLine());
arr[3] = d;
Console.WriteLine("Введите пятое число масива: ");
int e = Convert.ToInt32(Console.ReadLine());
arr[4] = e;
Console.WriteLine("Введите шестое число масива: ");
int f = Convert.ToInt32(Console.ReadLine());
arr[5] = f;
Console.WriteLine("Введите седьмое число масива: ");
int g = Convert.ToInt32(Console.ReadLine());
arr[6] = g;
Console.WriteLine("Введите восьмое число масива: ");
int h = Convert.ToInt32(Console.ReadLine());
arr[7] = h;


PrintArray(arr);
*/

