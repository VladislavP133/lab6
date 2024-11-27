using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        var зоопарк = new Зоопарк();
        зоопарк.ДодатиТварину(new Тварина("Лев", 190, 1.2));
        зоопарк.ДодатиТварину(new Тварина("Слон", 5400, 3.2));
        зоопарк.ДодатиТварину(new Тварина("Зебра", 400, 1.5));
        зоопарк.ДодатиТварину(new Тварина("Кенгуру", 90, 1.7));

        var тварини = new List<Тварина>(зоопарк);
        тварини.Sort();
        Console.WriteLine("Список тварин за вагою:");
        foreach (var тварина in тварини)
        {
            Console.WriteLine(тварина);
        }
        Console.WriteLine("\nСписок тварин за вагою та зростом:");
        тварини.Sort(new ТваринаComparer());
        foreach (var тварина in тварини)
        {
            Console.WriteLine(тварина);
        }

        Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
        Console.ReadKey();
    }
}
