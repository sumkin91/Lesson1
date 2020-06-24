using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). 
В результате вся информация выводится в одну строчку:
а) используя склеивание;
б) используя форматированный вывод;
в) используя вывод со знаком $.
*/
namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Анкета");
            Console.WriteLine("Введите имя:");
            String FirstName = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            String SecondName = Console.ReadLine();
            Console.WriteLine("Введите возраст:");
            Int32 Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите рост:");
            Int32 Height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вес:");
            double Weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n");
            Console.WriteLine("1 Способ вывода:");
            Console.WriteLine(FirstName + ", " + SecondName + ", " + Age + ", " + Height + ", " + Weight + "\n");
            Console.WriteLine("2 Способ вывода:");
            Console.WriteLine("{0}, {1}, {2}, {3}, {4:0.0}\n",FirstName, SecondName, Age, Height, Weight);
            Console.WriteLine("3 Способ вывода:");
            Console.WriteLine($"{FirstName}, {SecondName}, {Age}, {Height}, {Weight}");
            Console.ReadKey();
        }
    }
}
