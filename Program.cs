using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            car car = new car();
            car.Model = "Мерсидес";
            car.Year = 2025;

            Console.WriteLine("Введте марку бренд");
            string brand1 = Console.ReadLine();
            int years1 = int.Parse(Console.ReadLine());

            car car1 = new car(brand1, years1);
            car car2 = new car("АМГ", 2025);
            car car12 = new car("Мерсидес", 2025);
            car car13 = new car("БМВ", 2025);
            car car14 = new car("Ролс Ройс", 2025);
            Console.WriteLine($"{car12.Model}{car12.Year}");
            Console.ReadKey();

        }
    }
}
