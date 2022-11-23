/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue);
 return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();  
    } 
}
/*
void SortingArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            for(int z = 0; z < array.GetLength(1) - 1; z++)
                if(array[i, z] < array[i, z + 1])
                {
                    int temp = array[i, z];
                    array[i, z] = array[i, z + 1];
                    array[i, z + 1] = temp;
                }
}
*/
/*Console.Write("Введите количество строк: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите мин колиство: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите макс количество: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray(r, c, min, max);
Show2dArray(myArray);
Console.WriteLine();
//SortingArray(myArray);
//Show2dArray(myArray);*/

/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int MinSumNumbers(int[,] array)
{
    int minSum = 0;
    int minRow = 0;
    for(int j = 0; j < array.GetLength(1); j++)
    {
        minSum += array[0, j]; 
    }
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int minSum2 = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            minSum2 += array[i, j];
        }
        if(minSum2 < minSum)
        {
            minRow = i;
            minSum = minSum2;
        }
    }
    return minRow + 1;
}

//int result = MinSumNumbers(myArray);
//Console.Write("Наименьшая сумма в строке: " + result);
/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
void MatrixMultiplication(int[,] firstArray, int[,] secondArray)
{
    int[,] array = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
    if(firstArray.GetLength(0) == secondArray.GetLength(1))
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                for(int l = 0; l < firstArray.GetLength(1); l++)
                {
                    array[i, j] += (firstArray[i, l] * secondArray[l, j]);
                }
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }          
    else
    {
        Console.WriteLine("Невозможно найти произведение двух матриц!");
    }
}
Console.Write("Введите количество строк: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите мин колиство: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите макс количество: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray(r, c, min, max);

Console.WriteLine();
Console.Write("Введите количество строк: ");
int r2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int c2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите мин колиство: ");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите макс количество: ");
int max2 = Convert.ToInt32(Console.ReadLine());
int[,] myArray2 = CreateRandom2dArray(r2, c2, min2, max2);
Show2dArray(myArray);
Console.WriteLine();
Show2dArray(myArray2);
Console.WriteLine();
MatrixMultiplication(myArray, myArray2);
/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/