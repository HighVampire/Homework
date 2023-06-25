// int [] CreateRandomArray(int size, int min, int max)
// {
//     int [] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min,max);
//     }
//     return array;
// }
// void  PrintArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//      System.Console.Write (array[i] + " ");
//     }
// System.Console.WriteLine ();
// }

// void PosNegSum (int[] array)
// {
//     int SumPos = 0;
//     int SumNeg = 0;
//     for (int i =0; i <= array.Length; i++)
//         if (array[i] > 0) SumPos += array[i];
//         else SumNeg += array[i];
//     else SumNeg += array[i];
// }

// System.Console.WriteLine ("Input array size: ");
// int size = Convert.ToInt32 (Console.ReadLine());
// System.Console.WriteLine ("Input min: ");
// int min = Convert.ToInt32 (Console.ReadLine());
// System.Console.WriteLine ("Input max: ");
// int max = Convert.ToInt32 (Console.ReadLine());

// PrintArray(CreateRandomArray(size, min, max));


// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// bool TrueNumber (int[] array, int num)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == num) return true;
//     }
//     return false;
// }

// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());


// int [] array1 = CreateArray(size);

// PrintArray(array1);

// System.Console.WriteLine(TrueNumber(array1, num));



// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     } 
//     return array;
// }

// int TrueDigits(int [] array)
// {
//     int current = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 10 && array[i] <= 99)
//         {
//             current ++;
//         }
//     }
//     return current;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int [] array1 = CreateRandomArray(size, minValue, maxValue);
// PrintArray(array1);

// System.Console.WriteLine($"В этом массиве количество элементов значения которых лежат в отрезке [10,99] = {TrueDigits(array1)}");