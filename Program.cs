using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Масив чисел
        int[] numbers = { 2, 12, 14, 18, 25, 15 };

        // Обчислення середнього арифметичного
        double average = numbers.Average();

        // Виведення результату
        Console.WriteLine($"Середнє арифметичне чисел: {average}");
    }
}


