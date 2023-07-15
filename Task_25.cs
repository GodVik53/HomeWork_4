//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень, в котороую хотите возвести число: ");
int num2 = Convert.ToInt32(Console.ReadLine() );

if (num2 >0)
  Console.WriteLine($" {Math.Pow(num,num2) } ");
else
 Console.WriteLine("Введите натуральную степень числа");
 
