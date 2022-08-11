// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int n3 = Convert.ToInt32(Console.ReadLine());
int max = n1;

if(n2 > max)
{
    max = n2;
}
if(n3 > max)
{
    max = n3;
}
Console.WriteLine("Максимальное число: " + max);




















