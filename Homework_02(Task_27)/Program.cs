// Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе. Задачу решить без использования строк (string).
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите натуральное число");
int number = int.Parse(Console.ReadLine());

int countnum = number;

int secnum = 0;

int sum = 0;
while (countnum != 0)
{
   secnum = countnum % 10;
   sum = sum + secnum;
   countnum = countnum / 10; 
}

Console.WriteLine("Сумма цифр в числе: " + sum);