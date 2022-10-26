/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

/*
bool Palindrom(int number)
{
    int palin = number % 10;
    if(palin == number / 10000)
    {
        int palin1 = number % 100 / 10;
        if(palin1 == number / 1000 % 10)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    else
    {
        return false;
    }
}
Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 100000 && num > 10000)
{
    bool result = Palindrom(num);
Console.WriteLine(result);
}
else
{
    Console.WriteLine("Число не является пятизначным.");
}
Console.WriteLine("Спасибо за ваш выбор!");
*/

/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

/*
double Distance(double x1, double x2, double x3, double y1, double y2, double y3)
{
    double gip = Math.Pow((x1 - x2 - x3),2) + Math.Pow((y1  - y2 - y3),2);
    gip = Math.Sqrt(gip);
    return gip;
}
Console.WriteLine("Input x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input x3: ");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y3: ");
int y3 = Convert.ToInt32(Console.ReadLine());
double dist = Distance(x1, x2, x3, y1, y2, y3);
Console.WriteLine($"Дистанция между двумя точками в 3D пространстве: {dist}");
*/

/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125



int index = 1;
int Cub(int N)
{
    int numbera = index * index * index;  
    return numbera;
}
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


while(index <= number)
{
    int result = Cub(number);
    Console.Write(result + ",");
    index++;
}
Console.Write($" - Числа в кубе от 1 до {number}");
*/