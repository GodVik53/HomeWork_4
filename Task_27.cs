//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12




Console.WriteLine("Введите число: ");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (i > 0)
{
    sum += i % 10;
    i /= 10;
}
Console.WriteLine(sum) ;
