// Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.

Console.WriteLine("Введеите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введеите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if(n2 == n1 * n1)
{
    Console.WriteLine(n2 + " является квадратом " + n1);
}
else
{
    Console.WriteLine(n2 + " не является квадратом " + n1);
}