//Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
//а первый - на последнем и т.д.)

//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
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
// //12567
// int[] ReverseArray(int[] array)
// {
//     for (int i = 0; i < array.Length/2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - i - 1];
//         array[array.Length - i - 1] = temp;
//     }
//     return array;
// }


// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);

// PrintArray(myArray);

// myArray = ReverseArray(myArray);
// PrintArray(myArray);

// перевод в двоичную числа

// string DecimalToBinary(int num)
// {
//     string result = string.Empty;
//     while(num > 0)
//     {
//         result = num % 2 + result ;
//         num = num / 2;
//     }
//     return result;
// }


// System.Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"Number {num} in binary system -> {DecimalToBinary(num)}");


//Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
//числа фибоначчи последовательность чисел в которой первые 2 числа это 0 и 1, а последубщие это сумма двух передыдущих
//[0, 1,2, 3, 5, 8, 13, ... ]


// void Fibannachi (int size, int a, int b)
// {
//     int[] array = new int[size];
//     array[0] = a;
//     array[1] = b;
//     int i = 2;
//     while (i < size)
//     {
//         array[i] = array[i-1]+array[i-2];
//         i++; 
//     }
//     System.Console.WriteLine();
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// System.Console.WriteLine("Input fibonachi lenght: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input b: ");
// int b = Convert.ToInt32(Console.ReadLine());


// PrintArray (Fibannachi (size, a, b));

// int [] Fibanacci( int size , int num1, int num2)
// {
//     int [] array = new int [size];
//     array[0] = num1;
//     array[1] = num2;
//     for (int i=2 ; i< array.Length; i++)
//     {
//       array [i] = array[(i-1)]+array[(i-2)];
//     }
  
//    return array;
// }
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// System.Console.WriteLine("Input num1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input num2: ");
//  int num2 = Convert.ToInt32(Console.ReadLine());  
//  PrintArray(Fibanacci (10,num1, num2));


//Задача 2.Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//самое важное знать правило, какждая сторона должна быть меньше(строго) суммы двух других сторон


Double[] FindArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
        }
    return numbers;
}

Double FindMinMax(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    System.Console.WriteLine($"Maximal element {max}, minimal element {min}");
    return max - min;
}

void PrintArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        System.Console.Write(numbers[i] + " ");
    }
    System.Console.WriteLine();
}
Console.WriteLine("Enter array size  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FindArray(numbers);
Console.WriteLine("array is: ");
PrintArray(numbers);
System.Console.WriteLine($"the difference between maximal and minimal elements -> {FindMinMax(numbers)}");