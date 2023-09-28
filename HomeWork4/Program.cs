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


Console.WriteLine("Мы рады что вы выбрали нас!");

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

for(int index = 0; index <= 7; index++)
{
    Console.WriteLine("Введите число масива: ");
    arr[index] = Convert.ToInt32(Console.ReadLine());
}

PrintArray(arr);

Console.WriteLine("Рады были помочь!");
*/
