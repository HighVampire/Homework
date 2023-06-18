// int FindSum (int num1, int num2)
// {
//     int sum = num1 + num2;
//     return sum;
// }

// int x = 5;
// int y = 6;
// int result = FindSum (x,y);

// System.Console.WriteLine(FindSum(x,y));

// void CheckEven (int num1, int num2)
// {
//     if (num1 % num2 == 0)
//     {
//         System.Console.WriteLine($"Число {num2} кратно {num1}");
//     }
//     else
//     {
//        System.Console.WriteLine($"Число {num2} не кратно {num1}, остаток от деления {num1 % num2}"); 
//     }
// }

// Console.Write ("Введите 1-ое целое число ");
// int num1 = Convert.ToInt32 (Console.ReadLine());
// Console.Write ("Введите 2-ое целое число ");
// int num2 = Convert.ToInt32 (Console.ReadLine());
// CheckEven (num1, num2);

// bool CheckEven (int num)
// {
//     if (num % 7 == 0 && num % 23 == 0) return true;
//     else return false;
// }
// Console.Write ("Введите целое число ");
// int num = Convert.ToInt32 (Console.ReadLine());
// Console.Write (CheckEven(num));

// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// int num = new Random(100).Next(999);
// void ResNum (int num)
// {
//  int ed = num % 10;
//  int sot = num / 100;
//  int res = (sot*10) + ed;
// }

// ResNum (num);


// System.Console.Write ("Введите 3-х значное целое число ");
// int num1 = Convert.ToInt32 (Console.ReadLine());












// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.


void CheckSquare (int num1, int num2)
{
    if (num1 == num2 * num2)
    {
        System.Console.WriteLine($"Число {num1} является квадратом {num2}");
    }
    else if (num2 == num1 * num1)
    {
       System.Console.WriteLine($"Число {num2} является квадратом {num1}");
    }
    else
    {
       System.Console.WriteLine($"Числа не являются квадратом друг друга"); 
    }
}

CheckSquare (3, 8);
