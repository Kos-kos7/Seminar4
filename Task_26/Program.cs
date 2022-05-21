// принимает число и выдает число цифр в числе
Console.WriteLine("Введите натуральное число");
int number = int.Parse(Console.ReadLine());
int count = 0;
Console.Write($"Количество цифр в числе {number} = ");
while(number > 0)
{
    number = number / 10;
    count++;
}
Console.WriteLine(count);
