using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
б) * Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
*/
namespace Lesson13
{
    class Program
    {
        static public double Distance(double dx1, double dx2, double dy1, double dy2)
        {
            return Math.Sqrt(Math.Pow(dx2 - dx1, 2) + Math.Pow(dy2 - dy1, 2));
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Расстояние между двумя точками на слоскости:");
            Console.WriteLine("Введите координаты x1, y1 (через кнопку ввода):");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты x1, y1 (через кнопку ввода):");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double Result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Результат вычисления: {0:0.00}", Result);

            double ResultMethod = Distance(x1, x2, y1, y2);
            Console.WriteLine("Результат вычисления методом: {0:0.00}", ResultMethod);
            Console.ReadKey();
        }
    }
}
