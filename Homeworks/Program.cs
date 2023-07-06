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


// void TablOfSquaresN (int N)
// {
//    int count = 1;
//     while (count <= N)
//     {    
//       System.Console.Write($"{count} -> ");
//       int count1 = 1;
//       while (count1 <= count)
//       {
//          System.Console.Write($"{count1 * count1},");
//          count1 ++;
//       }
//      count ++;
//      System.Console.WriteLine(";"); 
//     }
// }

// System.Console.Write ("Введите число N: ");
// int N = Convert.ToInt32 (System.Console.ReadLine ());
// TablOfSquaresN (N);

// Задача 34


// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100, 999);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
// }

// int CheckEven (int[] array)
// {  
//    int count = 0;
//    for (int i = 0; i < array.Length; i ++)
//    {
//         if (array[i] % 2 == 0)
//         {
//          count ++;
//         }
//    }
//    return count;      
// }


// System.Console.WriteLine ("Input lenght of array");
// int size = Convert.ToInt32 (Console.ReadLine());
// int[] array = CreateRandomArray (size);
// System.Console.Write ("[");
// PrintArray (array);
// System.Console.Write ($"] -> {CheckEven (array)}");


// Задача 36


// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(-100, 100);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
// }

// int SumOfUnevenPosition (int[] array)
// {  
//    int sum = 0; 
//    for (int i = 0; i < array.Length; i ++)
//    {
//         if (i % 2 != 0)
//         {
//          sum = sum + array[i];
//         }
//    }
//    return sum;      
// }

// System.Console.WriteLine ("Input lenght of array");
// int size = Convert.ToInt32 (Console.ReadLine());
// int[] array = CreateRandomArray (size);
// System.Console.Write ("[");
// PrintArray (array);
// System.Console.Write ($"] -> {SumOfUnevenPosition (array)}");


// Задача 38

// double[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//    double[] array = new double[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = Math.Round ((new Random ().Next(minValue, maxValue) + new Random ().NextDouble()), 2);
//     }
//     return array;
// }

// void PrintArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
// }

// double MaxInArray(double[] array)
// {
//    double max = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//       if (array[i] > max)
//       max = array[i];
//     }
//     return max;
// }
// double MinInArray(double[] array)
// {
//    double min = array[0];
//    for (int i = 0; i < array.Length; i++)
//     {
//       if (array[i] < min)
//       min = array[i];
//     }
//     return min;
// }
// System.Console.Write ("Input lenght of array ");
// int size = Convert.ToInt32 (Console.ReadLine());
// System.Console.Write ("Input min value of number in array ");
// int minValue = Convert.ToInt32 (Console.ReadLine());
// System.Console.Write ("Input max value of number in array ");
// int maxValue = Convert.ToInt32 (Console.ReadLine());

// double[] array = CreateRandomArray(size, minValue, maxValue);
// System.Console.Write ($"[");
// PrintArray(array);
// System.Console.Write ($"] => {MaxInArray(array)} - {MinInArray(array)} = {Math.Round(MaxInArray(array) - MinInArray(array), 2)}");

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double [,] Create2DArray (int m, int n, int minValue, int maxValue)
// {
//     double [,] array = new double [m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i,j] = Math.Round ((new Random ().Next(minValue, maxValue) + new Random ().NextDouble()), 1);
//         }

//     }
//     return array;
// }

// void Print2DArray(double [,] array)
// {
//     for (int i = 0; i < array.GetLength (0); i++)
//     {
//         for (int j = 0; j < array.GetLength (1); j++)
//         {
//             System.Console.Write (array[i,j] + " ");
//         }
//         System.Console.WriteLine();

//     }
// }
// System.Console.Write ("Input number of rows in array ");
// int m = Convert.ToInt32 (Console.ReadLine());
// System.Console.Write ("Input number of columns in array ");
// int n = Convert.ToInt32 (Console.ReadLine());
// System.Console.Write ("Input min value of number in array ");
// int minValue = Convert.ToInt32 (Console.ReadLine());
// System.Console.Write ("Input max value of number in array ");
// int maxValue = Convert.ToInt32 (Console.ReadLine());

// System.Console.WriteLine ($"m={m}, n={n}.");
// double[,] myArray = Create2DArray(m, n, minValue, maxValue);
// Create2DArray (m, n, minValue, maxValue);
// Print2DArray (myArray);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.


// int [,] Create2DArray (int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int [rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array [i,j] = new Random().Next(minValue,maxValue);
//         }

//     }
//     return array;
// }

// void Print2DArray(int [,] array)
// {
//     for (int i = 0; i < array.GetLength (0); i++)
//     {
//         for (int j = 0; j < array.GetLength (1); j++)
//         {
//             System.Console.Write (array[i,j] + " ");
//         }
//         System.Console.WriteLine();

//     }
// }

// int SearchByPosition (int x, int y, int[,] array)
// {
//     int res = 0;
//     if (x <= array.GetLength (0) - 1 | y <= array.GetLength (1) - 1)
//         {
//         for (int i = 0; i < array.GetLength (0); i++)
//             {
//             for (int j = 0; j < array.GetLength (1); j++)
//                 {
//                     if (i == x && j == y)
//                     {
//                        res = array[i,j];
//                        System.Console.WriteLine (res); 
//                     }
//                 }
//             }        
//         }     
//     else System.Console.WriteLine($"{x}{y} -> такого числа в массиве нет");
//     return res;
// }

// System.Console.Write ("Input number of rows in array ");
// int m = Convert.ToInt32 (Console.ReadLine());
// System.Console.Write ("Input number of columns in array ");
// int n = Convert.ToInt32 (Console.ReadLine());
// System.Console.Write ("Input min value of number in array ");
// int minValue = Convert.ToInt32 (Console.ReadLine());
// System.Console.Write ("Input max value of number in array ");
// int maxValue = Convert.ToInt32 (Console.ReadLine());
// System.Console.Write ("Input x position in array ");
// int x = Convert.ToInt32 (Console.ReadLine());
// System.Console.Write ("Input y position in array ");
// int y = Convert.ToInt32 (Console.ReadLine());

// int[,] myArray = Create2DArray(m, n, minValue, maxValue);
// Create2DArray (m, n, minValue, maxValue);
// Print2DArray (myArray);
// SearchByPosition(x, y, myArray);



// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.


int [,] Create2DArray (int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array [i,j] = new Random().Next(minValue,maxValue);
        }

    }
    return array;
}

void Print2DArray(int [,] array)
{
    for (int i = 0; i < array.GetLength (0); i++)
    {
        for (int j = 0; j < array.GetLength (1); j++)
        {
            System.Console.Write (array[i,j] + " ");
        }
        System.Console.WriteLine();

    }
}

int ArithmeticMean (int [,] array)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength (1); i++)
    {
        for (int j = 0; j < array.GetLength (0); j++)
        {
            sum = sum + array[j,i];
        }
        System.Console.Write($" {Math.Round(sum / array.GetLength(0),1)} ");
        sum = 0;
    }
    return 0;
}

System.Console.Write ("Input number of rows in array ");
int m = Convert.ToInt32 (Console.ReadLine());
System.Console.Write ("Input number of columns in array ");
int n = Convert.ToInt32 (Console.ReadLine());
System.Console.Write ("Input min value of number in array ");
int minValue = Convert.ToInt32 (Console.ReadLine());
System.Console.Write ("Input max value of number in array ");
int maxValue = Convert.ToInt32 (Console.ReadLine());

int[,] myArray = Create2DArray(m, n, minValue, maxValue);
Create2DArray (m, n, minValue, maxValue);
Print2DArray (myArray);
ArithmeticMean(myArray);