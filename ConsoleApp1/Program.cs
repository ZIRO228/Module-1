using System;

class Program
{
    static void Main()
    {
        // Запрашиваем у пользователя ввод числа
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Проверяем, является ли число четным
        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} является четным числом.");
        }
        else
        {
            Console.WriteLine($"{number} является нечетным числом.");
        }
    }
}