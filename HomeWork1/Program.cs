//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Введите первое число: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());
double max = a;
double min = b;

if(max > min)
{
    Console.WriteLine("Наибольшее число: " + max);
    Console.WriteLine("Наименьшее число: " + min);
}

else 
{
    Console.WriteLine("Наибольшее число: " + min);
    Console.WriteLine("Наименьшее число: " + max);
}
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Введите первое число: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите третье число: ");
double c = Convert.ToDouble(Console.ReadLine());
double max = 0;
 
if(a > b)
{
    max = a;
}
else
{
    max = b;
}
 
if(max > c)
{
    
}
else 
{
    max = c;
}

Console.WriteLine("Наибольшее число: " + max);
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Введите число: ");
double a = Convert.ToDouble(Console.ReadLine());
double b = a % 2;

if(a > 0)
{
    if(b == 0)
    {
        Console.WriteLine($"Число: {a} является четным.");
    }
    else 
    {
        Console.WriteLine($"Число: {a} не является четным.");
    }
}
else 
{
    Console.WriteLine($"Число: {a} не является положительным.");
}
*/
   

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

/*
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int current = 2;

while(current <= n)
{
    Console.Write(current + " ");
    current += 2;
}
*/