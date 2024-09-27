using System;

class Program
{
    static void Main()
    {
        // Запрашиваем у пользователя ввод радиуса круга
        Console.Write("Введите радиус круга: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        // Вычисляем площадь круга по формуле: Площадь = π * r^2
        double area = Math.PI * Math.Pow(radius, 2);

        // Выводим результат на экран
        Console.WriteLine($"Площадь круга с радиусом {radius} равна {area:F2}.");
    }
}