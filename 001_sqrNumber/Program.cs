// Напишите программу, которая на вход принимает число 
// и выдаёт его квадрат (число умноженное на само себя).

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sqrNumber = number * number;
Console.WriteLine(number + " в квадрате равно " + sqrNumber);
