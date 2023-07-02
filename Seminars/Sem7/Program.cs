// Двумерный массив

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

// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input min number : ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input max number: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// Print2DArray(Create2DArray (rows, columns, minValue, maxValue));



// Random r = new Random();

// Console.CursorVisible = false;
// while(true)
// {
//     Console.SetCursorPosition(
//         left: r.Next(Console.WindowWidth),
//         top: r.Next(Console.WindowHeight)
//     );
//     Console.Write(r.Next(10));
//     Thread.Sleep(1000);
// }