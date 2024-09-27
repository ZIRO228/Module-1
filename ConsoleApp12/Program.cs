using System;

class Program
{
    static void Main()
    {
        // Запрашиваем у пользователя числитель
        Console.Write("Введите числитель: ");
        int numerator = int.Parse(Console.ReadLine()); // Преобразуем введенное значение в целое число

        // Запрашиваем у пользователя знаменатель
        Console.Write("Введите знаменатель: ");
        int denominator = int.Parse(Console.ReadLine()); // Преобразуем введенное значение в целое число

        // Вычисляем наибольший общий делитель (НОД)
        int gcd = GCD(numerator, denominator);

        // Сокращаем числитель и знаменатель на НОД
        numerator /= gcd;
        denominator /= gcd;

        // Выводим сокращенную дробь
        Console.WriteLine($"Сокращенная дробь: {numerator}/{denominator}");
    }

    // Метод для вычисления наибольшего общего делителя (НОД) с использованием алгоритма Евклида
    static int GCD(int a, int b)
    {
        // Пока остаток от деления не равен 0
        while (b != 0)
        {
            // Сохраняем текущее значение b
            int temp = b;
            // Присваиваем b остаток от деления a на b
            b = a % b;
            // Присваиваем a значение b (для следующего шага)
            a = temp;
        }
        // Возвращаем НОД (a), когда остаток от деления станет 0
        return a;
    }
}