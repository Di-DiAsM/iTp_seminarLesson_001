// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.
//	456 -> 6
//	782 -> 2
//	918 -> 8

Console.WriteLine("Введите трехзначное числоЖ ");
int num = Convert.ToInt32(Console.ReadLine());
int lastDigit = num % 10;

if (num < 99)
{
    Console.WriteLine("неправильный ввод");
}
else if (num > 999)
{
    Console.WriteLine("неправильный ввод");
}
else
{
    Console.WriteLine(lastDigit);
}
