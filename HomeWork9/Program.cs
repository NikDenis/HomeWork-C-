void ShowNumbers(int n)  //Вывод чисел от N до 1. 
{
    Console.Write(n + " ");
    if(n > 1) ShowNumbers(n - 1);
}
void ShowSumNumbers(int m, int n, int sum)  //Метод нахождения суммы натуральных элементов в промежутке от M до N
{
    if (m> n) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (m++);
    ShowSumNumbers(m, n, sum);
}
int Ackermann(int m, int n)  //Вычисление функции Аккерманна.
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return Ackermann(m - 1, 1);
    if (m > 0 && n > 0) return Ackermann(m - 1, Ackermann(m, n - 1));
return Ackermann(m, n);
}

/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

/*
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Числа от {n} до 1: ");
ShowNumbers(n);
*/

/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

/*
Console.WriteLine("Введите начальное число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начальное число n:");
int n = Convert.ToInt32(Console.ReadLine());

ShowSumNumbers(m, n, 0);
*/

/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

/*
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введитe число n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Число Аккерманна: {Ackermann(m, n)}");
*/
