using System;

class Program
{
    static void Main()
    {
        // Запрашиваем у пользователя имя
        Console.Write("Введите ваше имя: ");
        string firstName = Console.ReadLine();

        // Запрашиваем у пользователя фамилию
        Console.Write("Введите вашу фамилию: ");
        string lastName = Console.ReadLine();

        // Выводим результат в формате "Фамилия, Имя"
        Console.WriteLine($"{lastName}, {firstName}");
    }
}