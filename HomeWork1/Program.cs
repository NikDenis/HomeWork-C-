﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2) 
// {
//   Console.WriteLine($"Число {num1} большее, а {num2} меньшее");
// }
// else 
// {
//   Console.WriteLine($"Число {num2} большее, а {num1} меньшее");
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int max = num1;

// if (max < num2) 
// {
//   max = num2;
// }
// if (max < num3) 
// {
//   max = num3;
// }

// Console.WriteLine($"Максимальное число: {max}");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num % 2 == 0) {
//   Console.WriteLine($"Число: {num}-чётное");
// } else {
//   Console.WriteLine($"Число: {num}-нечётное");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 2;

while (i <= n)
{
  if (i == n || i == n - 1)
  {
  Console.Write($"{i}.");
  i += 2;
  }
  else 
  {
  Console.Write($"{i}, ");
  i+=2;
  }

}