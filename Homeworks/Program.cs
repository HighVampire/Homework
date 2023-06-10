// Задача 2

// Console.Write ("Введите 1-ое целое число для сравнения ");
// int num1 = Convert.ToInt32 (Console.ReadLine());
// Console.Write ("Введите 2-ое целое число для сравнения ");
// int num2 = Convert.ToInt32 (Console.ReadLine());
// if (num1 > num2)
//    {
//      Console.WriteLine ($"{num1} больше {num2}");
//    }
//     else
//    {
//        Console.WriteLine ($"{num2} больше {num1}");
//    }

﻿// Задача 4

Console.Write ("Введите 1-ое целое число ");
int num1 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите 2-ое целое число ");
int num2 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите 3-ье целое число ");
int num3 = Convert.ToInt32 (Console.ReadLine());
int max = num1;
if (num2 > max)
   {
    max = num2;
   }
if (num3 > max)
   {
    max = num3;
   }
Console.Write ($"Максимальное число из 3-х -> {max}");
