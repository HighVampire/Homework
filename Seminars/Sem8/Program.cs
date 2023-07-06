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

// // Вывод 2D массива
// // array.GetLenght(0) - измеряет длину строк; array.GetLenght(1) - измеряет длину столбцов

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

// int [,] ChnageRows (int [,] array, int row1, int row2)
// {
//     if (row1 >= array.GetLength(0) || row2 >= array.GetLength(0))
//     {
//         System.Console.WriteLine("Указанные строки выходят за пределы массива!");
//         return array;
//     }
//     else
//         {
//             for (int j = 0; j < array.GetLength (1); i++)
//             {
//                 int temp = array [row1, j];
//                 array [i,j] = array [row2,j];
//                 array [row2,j] = temp;
//             }
//             return array;
//         }
// }

// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input min number : ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input max number: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of row 1: ");
// int row1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of row 2: ");
// int row2 = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);
// Print2DArray(ChangeRows(myArray, row1, row2));

//Задание 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//В итоге получается вот такой массив:

//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7



// int[,] Create2DArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// Архип Чижанов  кому  Все 14:43
// int[,] RowsToColumns(int[,] array)
// {
//     if(array.GetLength(0) != array.GetLength(1))
//     {
//         System.Console.WriteLine("Не квадратный массив!");
//         return array;
//     }
//     else
//     {
//         for (int i = 0; i < array.GetLength(0)-1; i++)
//         {
//             for (int j = i+1; j < array.GetLength(1); j++)
//             {
//                 int temp = array[i,j];
//                 array[i,j] = array[j,i];
//                 array[j,i] = temp;
//             }
//         }
//     }
//     return array;
// }

// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] RowsToColumns(int[,] array)
// {
//     if (array.GetLength(0) != array.GetLength(1))
//     {
//         System.Console.WriteLine("Массив не квадратный");
//         return array;
//     }
//     else
//     {
//         for (int i = 0; i < array.GetLength(0) - 1; i++)
//         {
//             for (int j = i + 1; j < array.GetLength(1); j++)
//             {
//                 int temp = array[i, j];
//                 array[i, j] = array[j, i];
//                 array[j, i] = temp;
//             }
//         }
//     }
//     return array;
// }

// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);
// Print2DArray(RowsToColumns(myArray));



// Задание 3. Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
// то есть удалаем и строку и столбец в которой находится этот элемент


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

// void SearchMin (array)
// {
//    {
//     int min = array [0,0];
//     for (int i = 0; i < array.GetLength (0); i++)
//     {
//         for (int j = 0; j < array.GetLength (1); j++)
//         {
//             if (min < array[i,j])
//             {
//                 min = array[i,j];
//                 minI = i;
//                 minJ = j;
//             }
//         }
//         System.Console.WriteLine();

//     }
//     return min;
// }
// }


int[,] MinValue(int[,] array)
{
    int minI = 0;
    int minJ = 0;
    int minnum = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] <= minnum)
            {
                minnum = array[i, j];
            minI = i;
            minJ = j;
            }
        }
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i, minJ] = 0;

    }

    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[minI, j] = 0;
    }

    return array;
}
System.Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal value of array element: ");
int minValue = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal value of array element: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
Print2DArray(myArray);
Print2DArray(MinValue(myArray));
