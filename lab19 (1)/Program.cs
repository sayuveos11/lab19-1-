using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        int k = 1234; // трьохзначне число

        // Отримання рядка з числа
        string numberString = k.ToString();

        // Перевірка, чи число має три цифри
        if (numberString.Length == 3)
        {
            // Отримання лівої, середньої та правої цифри
            char C2 = numberString[0];
            char C1 = numberString[1];
            char C0 = numberString[2];

            // Виведення результатів
            Console.WriteLine($"Ліва цифра: {C2}");
            Console.WriteLine($"Середня цифра: {C1}");
            Console.WriteLine($"Права цифра: {C0}");
        }
        else
        {
            Console.WriteLine("Введіть трьохзначне число.");
        }
    }
}
