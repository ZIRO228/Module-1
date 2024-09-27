using System;

class Program
{
    static void Main()
    {
        // Запрашиваем у пользователя возраст
        Console.Write("Введите ваш возраст: ");
        int age = Convert.ToInt32(Console.ReadLine());

        // Проверяем, может ли пользователь получить водительские права
        if (age >= 18)
        {
            Console.WriteLine("Вы можете получить водительские права.");
        }
        else
        {
            Console.WriteLine("Вы не можете получить водительские права. Вам должно быть не менее 18 лет.");
        }
    }
}