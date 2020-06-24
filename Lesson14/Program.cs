using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Написать программу обмена значениями двух переменных:
а) с использованием третьей переменной;
б) * без использования третьей переменной.
*/
namespace Lesson14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Обмен значениями");
            Console.Write("Введите a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            double temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"Значения после обмена: a = {a}, b = {b}\n");
            Console.ReadKey();

            Console.WriteLine("Обмен значениями без буферной переменной");
            Console.Write("Введите a = ");
            double av = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b = ");
            double bv = Convert.ToDouble(Console.ReadLine());
            av = av + bv;
            bv = av - bv;
            av = av - bv;
            Console.WriteLine($"Значения после обмена: a = {av}, b = {bv}");
            Console.ReadKey();
        }
    }
}
