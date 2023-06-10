// Задача 2

Console.Write ("Введите 1-ое целое число для сравнения ");
int num1 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите 2-ое целое число для сравнения ");
int num2 = Convert.ToInt32 (Console.ReadLine());
if (num1 > num2)
   {
     Console.WriteLine ($"{num1} больше {num2}");
   }
    else
   {
       Console.WriteLine ($"{num2} больше {num1}");
   }