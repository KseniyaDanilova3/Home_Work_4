// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11; 82 -> 10; 9012 -> 12

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма цифр в числе {num} = {FindSum()}");

int FindSum()
{
    int result = 0;
    while (num > 0)
    {
        int digit = num % 10;
        num = num / 10;
        result += digit;
    }
    return result;
}
