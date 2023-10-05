/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */


/*
Console.WriteLine("Рады приветствовать вас!");
Console.WriteLine();
Console.WriteLine("Введите какое количество чисел вы бы хотели ввести: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] CreateArray(int size)
{
    int[] array = new int[size];
    Console.Write("Введите числа: ");
    for(int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array; 
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int sizeNumber(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] > 0)
            count++; 
    return count;
}

int[] myArray = CreateArray(size);
ShowArray(myArray);
int result = sizeNumber(myArray);
Console.WriteLine("Чисел больше 0: " + result);
Console.WriteLine();
Console.WriteLine("Спасибо за выбор!");
*/


/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

/*
Console.WriteLine("Уравнение:y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine();
Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
 
double x = (b2 - b1) / (k1 - k2);
double y = k2 * x + b2;
if(y == k1 * x + b1)
    Console.WriteLine($"Координаты точки пересечения прямых:({Math.Round(x, 3)}, {Math.Round(y, 3)})");
else
    Console.WriteLine("Прямые не пересекаютсяю");

Console.WriteLine();
Console.WriteLine("Спасибо за выбор! Всегда к вашим услугам!");
*/






