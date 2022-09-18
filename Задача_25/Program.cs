// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵); 2, 4 -> 16

Console.WriteLine("Введите число, которое будем возводить в степень: ");
int numA = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Введите в какую степень будем возводить число {numA}: ");
int numB = int.Parse(Console.ReadLine()!);
double result = 1;

for (int i = 1; i <= numB; i++)
{
    result *= numA;
}

Console.Write($"{numA} в степени {numB} = {result}");