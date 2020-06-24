using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); 
где m — масса тела в килограммах, h — рост в метрах.
*/
namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Расчет индекса массы");
            Console.WriteLine("Введите рост:");
            Int32 Height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вес:");
            double Weight = Convert.ToDouble(Console.ReadLine());
            double Result = Weight*10000 / Math.Pow(Height,2);
            Console.WriteLine("Результат вычисления: {0:0.00}",Result);
            Console.ReadKey();
        }
    }
}
