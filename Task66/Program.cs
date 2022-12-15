// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



Console.Clear();
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"{m};{n} -> {SumNumbers(m,n)}");

int SumNumbers(int number1, int number2)
{
    if (number1 == number2)
        return number1;
    return (number1 + SumNumbers(number1+1,number2));
}