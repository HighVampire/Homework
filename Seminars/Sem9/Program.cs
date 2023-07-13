// Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"

// void printNum(int n)
// {
//     if (n >= 1)
//     {
//         printNum(n-1);
//         System.Console.Write(n + " ");
//     }
// }

// printNum(8);

//Задание 2. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

//453 -> 12
//45 -> 9

// int FindSum(int num)
// {
//     if (num>0)
//         {
//             return FindSum(num / 10) + num % 10;
//         } 
//         else return num;
// }

// System.Console.Write(FindSum(99999));

//Задача 3. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 5, 6, 7, 8"

// void FromMtoN(int M, int N)
// {
//     if (M != N)
//     {   
//         if (M >= N)
//         {
//         FromMtoN(M - 1, N); 
//         System.Console.Write(M + " ");
//         }
    
//         else
//         {
//         FromMtoN(M + 1, N);    
//         System.Console.Write(M + " ");
//         }
//     }
    
// }

// System.Console.Write ("Input number M ");
// int M = Convert.ToInt32 (Console.ReadLine());
// System.Console.Write ("Input number N ");
// int N = Convert.ToInt32 (Console.ReadLine());

// FromMtoN(M, N);

void FindNumbres(int m, int n) 
{
    if (m != n )
    {
        if (m < n )
        {
           FindNumbres(m,n-1);
           System.Console.Write(n + " ");
        }
        else
        {
            System.Console.Write(m + " ");
            FindNumbres(m-1,n);
        }
    }
    else System.Console.Write(n + " ");

    
}
FindNumbres(3,15);

//Задача 4.Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.


// int printNum(int a, int b)
// {
//     if (b > 0)
//     {
//     return printNum(a, b-1)*a;
//     }
//     else return 1;
// }


// System.Console.Write (printNum(2, 6));