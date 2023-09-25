/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

int CutNumber(int number)
{
    int ed = number / 10;
    int dec = ed % 10;
    return dec;
}

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 100 && num < 1000)
{
    int result = CutNumber(num);
    Console.WriteLine($"Вторая цифра числа: {num} это: {result}.");
}
else
{
    Console.WriteLine($"Число: {num} не является трухзначным.");
}
Console.WriteLine("Спасибо за доверие!");
*/

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6


int CutNumber(int number)
{
    int sot = number % 10;
    return sot;
}
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num;
while(num1 > 100)
{
    if(num1 < 1000)
    {
    int result = CutNumber(num1);
    Console.WriteLine($"Третье цифра числа: {num} это цифра: {result}");
    num1 = num1 / 10;
    }
    else
    {
     num1 = num1 / 10;
    }
}
if(num < 100)
{
    Console.WriteLine($"В числе: {num} нет третьей цифрыю");
}
Console.WriteLine("Спасибо за выбор!");
*/

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

bool WeekDay(int number)
{
    if(number == 6 || number == 7)
    {
        return true;
    }
    else
    {
        return false;
    }
}
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
bool result = WeekDay(num);
Console.WriteLine(result);
*/
