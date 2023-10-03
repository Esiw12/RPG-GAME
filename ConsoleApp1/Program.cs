using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Введите первое число: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите третье число: ");
        int number3 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите четвертое число: ");
        int number4 = Convert.ToInt32(Console.ReadLine());

        int sum = number1 + number2 + number3 + number4;
        double sr = (double)sum / 4;

        Console.WriteLine("Среднее значение: " + sr);
    }
}