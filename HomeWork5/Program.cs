/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array; 
}
*/
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
/*
int FindNegativeSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] < 0)
            sum += array[i];
    
    return sum;
}
Console.Write("Input a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
int negativeSum = FindNegativeSum(myArray);
Console.WriteLine($"Sum of negative elements is "+ negativeSum);
*/

/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/


/*
int PolNumbers(int[] array)
{   
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine("Рады что вы выбрали нас!");
Console.Write("Введите количество чисел в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int min = 100;
int max = 999;
int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
int countnumbers = PolNumbers(myArray);
Console.WriteLine($"Количество четных чисел в массиве: {countnumbers}");
Console.WriteLine("Мы рады что вы выбрали нас!");
*/


/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

/*
int SumPolNumbers(int[] array)
{
    int sumpolnum = 0;
    for(int i = 1; i < array.Length; i += 2)
    {
        sumpolnum += array[i];
    }
    return sumpolnum;
}   

Console.WriteLine("Рады вас приветствовать!");
//Console.Write("Введите количество чисел в масиве: ");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите мин число масива: ");
//int min = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите максимальное число массива: ");
//int max = Convert.ToInt32(Console.ReadLine());

//int[] myArray = CreateRandomArray(n, min, max);
//ShowArray(myArray);
int SumNUmbers = SumPolNumbers(myArray);
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях в массиве равна: {SumNUmbers}");
Console.WriteLine("Мы рады что вы выбрали нас!");
*/


/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue);
    return array; 
}

int MinNumber(int[] array)
{
    int minnum = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(minnum > array[i])
        {
            minnum = array[i];
        }
    }
    return minnum;
    
}   

int MaxNumber(int[] array)
{
    int maxnum = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(maxnum < array[i])
        {
            maxnum = array[i];
        }
    }   
    return maxnum;
     
}

Console.Write("Введите количество чисел в масиве: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите мин число масива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
int minnum = MinNumber(myArray);
int maxnum = MaxNumber(myArray);
Console.Write($"Максимальное число масива: {maxnum} ");
Console.Write($"Минимальное число массива: {minnum} ");
int comparison = maxnum - minnum;
Console.Write($"Разница между {maxnum} и {minnum} равна: {comparison}");