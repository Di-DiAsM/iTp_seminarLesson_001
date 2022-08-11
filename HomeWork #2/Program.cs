// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if(n1 > n2)
{
    Console.WriteLine("Число " + n1 + " больше числа " + n2);
}
else if(n1 == n2)
{
    Console.WriteLine("Число " + n1 + " равно числу " + n2);
}
else
{
    Console.WriteLine("Число " + n2 + " больше числа " + n1);
}
