/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */

/*
double[,] CreateRandomArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i, j] = new Random().NextDouble() + new Random().Next(minValue, maxValue);
    return array;
}
void ShowArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(Math.Round(array[i, j], 2) + "  ");
        
        Console.WriteLine();
    }
    
    
}
Console.WriteLine("Input a rows: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a colums: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possition value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possition value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandomArray(a, b, min, max);
ShowArray(myArray);
*/

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1 7 -> числа с такими индексами в массиве нет */

/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
} 

Console.WriteLine("Input a rows: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a colums: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possition value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possition value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] myArray = CreateRandom2dArray(a, b, min, max);
ShowArray(myArray);
Console.WriteLine();
Console.WriteLine("Введите номер столбца для вывода элемента: ");
int r = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine("Введите номер строки для вывода элемента: ");
int c = Convert.ToInt32(Console.ReadLine()) - 1;

if(c < b && r < a)
{
    int result = myArray[c, r];
    Console.WriteLine("Ваше число: " + result);

}
else
{
    Console.WriteLine("Элемента с таким индексом нету!");
}
Console.WriteLine();
Console.WriteLine("Спасибо за выбор!");
*/ 

/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
             array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}
void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}
void Arifmet(int[,] array)
{
    double result = 0;
    int current = 1;
    for(int j = 0; j < array.GetLength(1); j++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            result = result + array[i, j];
            
        }    
    Console.Write("В стобце: №" + current + "(");
    Console.Write(Math.Round(result / array.GetLength(0), 1) + ") ");
    current++;
    result = 0;
    }
}
Console.WriteLine("Input a rows: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a colums: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a min possition value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a max possition value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] myArray = CreateRandom2dArray(a, b, min, max);
ShowArray(myArray);
Console.WriteLine();
Console.Write("Среднее арифметическое каждого столбца: ");
Arifmet(myArray);
Console.WriteLine();
*/