//  Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.

Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Ваши числа {number1} и {number2}");

int result = 1;
for (int i = 1; i <= number2; i++)
{
result = result * number1;
}
Console.WriteLine($" {number1} в степени {number2} будет {result}");
