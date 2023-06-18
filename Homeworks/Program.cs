// Seminar №1

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

// Задача 4

// Console.Write ("Введите 1-ое целое число ");
// int num1 = Convert.ToInt32 (Console.ReadLine());
// Console.Write ("Введите 2-ое целое число ");
// int num2 = Convert.ToInt32 (Console.ReadLine());
// Console.Write ("Введите 3-ье целое число ");
// int num3 = Convert.ToInt32 (Console.ReadLine());
// int max = num1;
// if (num2 > max)
//    {
//     max = num2;
//    }
// if (num3 > max)
//    {
//     max = num3;
//    }
// Console.Write ($"Максимальное число из 3-х -> {max}");

// Задача 6

// Console.Write ("Введите целое число ");
// int num = Convert.ToInt32 (Console.ReadLine());
// if (num % 2 == 0)
//    {
//     Console.Write ($"{num} -> Число чётное");
//    }
// else
//    {
//     Console.Write ($"{num} -> Число нечётное");
//    }

// Задача 8

// Console.Write ("Введите целое число ");
// int num = Convert.ToInt32 (Console.ReadLine());
// int count = 1;
// Console.WriteLine ($"Все четные числа от 1 до {num}: ");
// while (count <= num)
//     {
//     if (count % 2 == 0)
//        {   
//         Console.Write ($" {count}");
//        }
//     count ++;}



//Seminar №3

// Задача 19


// void Palindrome_5 (int num)
// {
//     if (num / 10000 == num % 10 && (num / 1000) % 10 == (num % 100)/10)
//     {
//         System.Console.WriteLine($"{num} -> да");
//     }
//     else
//     {
//        System.Console.WriteLine($"{num} -> нет"); 
//     }
// }

// System.Console.WriteLine("Введите 5-и значное число, для проверки является ли оно палиндромом");
// int num = Convert.ToInt32 (System.Console.ReadLine ());
// Palindrome_5 (num);


// Задача 21

// double Distance_3D(double xa, double ya, double za, double xb, double yb, double zb)
//    {
//       return Math.Sqrt (Math.Pow (xb - xa, 2) + Math.Pow (yb - ya, 2) + Math.Pow (zb - za, 2));
//    }

// System.Console.WriteLine("Введите координату x первой точки");
// double xa = Convert.ToDouble (System.Console.ReadLine ());
// System.Console.WriteLine("Введите координату y первой точки");
// double ya = Convert.ToDouble (System.Console.ReadLine ());
// System.Console.WriteLine("Введите координату z первой точки");
// double za = Convert.ToDouble (System.Console.ReadLine ());
// System.Console.WriteLine("Введите координату x второй точки");
// double xb = Convert.ToDouble (System.Console.ReadLine ());
// System.Console.WriteLine("Введите координату y второй точки");
// double yb = Convert.ToDouble (System.Console.ReadLine ());
// System.Console.WriteLine("Введите координату z второй точки");
// double zb = Convert.ToDouble (System.Console.ReadLine ());

// System.Console.WriteLine ($"A ({xa},{ya},{za}); B ({xb},{yb},{zb}) -> {Distance_3D(xa,ya,za,xb,yb,zb)}");

// Задача 23


void TablOfSquaresN (int N)
{
   int count = 1;
    while (count <= N)
    {    
      System.Console.Write($"{count} -> ");
      int count1 = 1;
      while (count1 <= count)
      {
         System.Console.Write($"{count1 * count1},");
         count1 ++;
      }
     count ++;
     System.Console.WriteLine(";"); 
    }
}

System.Console.Write ("Введите число N: ");
int N = Convert.ToInt32 (System.Console.ReadLine ());
TablOfSquaresN (N);