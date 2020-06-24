using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
б) *Сделать задание, только вывод организовать в центре экрана.
в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
*/
namespace Lesson15
{
    class Program
    {
        static public void Print(string F, string S, string C, int Length, int posX)
        {
            Console.SetCursorPosition((Console.WindowWidth - Length) / 2, posX);
            Console.WriteLine($"{F}, {S}, {C}");
        }
        static void Main(string[] args)
        {
            const string FirstName = "Фёдор";
            const string SecondName = "Глушков";
            const string City = "Йошкар-Ола";

            Console.WriteLine("Обычный вывод на экран");
            Console.WriteLine($"{FirstName}, {SecondName}, {City}");

            Console.WriteLine("\nВывод на экран по центру");
            int Count = FirstName.Length + SecondName.Length + City.Length + 6;//по 3 символа запятой и пробела
            Console.SetCursorPosition((Console.WindowWidth - Count) / 2, 4);
            Console.WriteLine($"{FirstName}, {SecondName}, {City}");
            Console.SetWindowPosition(0, Console.WindowHeight);

            Console.WriteLine("\nВывод на экран посредством метода");
            Print(FirstName, SecondName, City, Count, 7);
            Console.ReadKey();
        }
    }
}
