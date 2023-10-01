using System.Globalization;
using System.Text;

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;
using System.Runtime.InteropServices;

Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

while (true)
{
    Console.WriteLine("Выберите действие: \n 1 - Игра Угадай число \n 2 - Таблица умножения \n 3 - Вывод делителей числа \n 4 - Выйти из программы");
    int deistviya = Convert.ToInt32(Console.ReadLine());
    if (deistviya == 1)
    {
        Console.WriteLine("Игра угадай число");
        Console.WriteLine("Слабо угадать число от 1 до 100?");
        Random num = new Random();
        int randomnoe = num.Next(1, 101);
        while (true)
        {
            int chislo = Convert.ToInt32(Console.ReadLine());
            if (chislo < randomnoe)
            {
                Console.WriteLine("Мимо! Число должно быть больше :)");
                continue;
            }
            if (chislo > randomnoe)
            {
                Console.WriteLine("Мимо! Число должно быть меньше :)");
            }
            if (chislo == randomnoe)
            {
                Console.WriteLine("Победа! Поздравляю :0");
                break;
            }
        }
    }
    if (deistviya == 2)
    {
        Console.WriteLine("Вот таблица умножения по-твоему запросу :3");
        for (int l = 1; l <= 10; l++)
        {
            for (int r = 1; r <= 10; r++)
            {
                Console.Write($"{l * r,4}");
            }
            Console.WriteLine();
        }
    }
    if (deistviya == 3)
    {
        while (true)
        {
            Console.WriteLine("Пиши число, которое интересует");
            int chislodel = Convert.ToInt32(Console.ReadLine());
            for (int delchisla = 0; delchisla <= chislodel; delchisla++)
            {
                while (delchisla <= chislodel)
                {
                    delchisla++;
                    if (chislodel % delchisla == 0)
                    {
                        Console.WriteLine(delchisla);
                    }
                }
            }
            Console.WriteLine("Если надоело пиши 'poka', иначе - пиши 'go'  :3"); string txt = Console.ReadLine(); 
            if (txt == "go")
            {
                Console.WriteLine("окей!");
                continue;
            }
            if (txt == "poka")
            {
                Console.WriteLine("Ждем тебя еще!"); 
                break;
            }
        }
    }
    if (deistviya == 4)
    {
        Console.WriteLine("Спасибо, что использовал мой код, пока <3");
        break;
    }
}