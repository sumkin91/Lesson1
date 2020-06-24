using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16
{
    class Program
    {
        public static void Print(string message, int posX, int posY)
        {
            Console.SetWindowPosition(posX, posY);
            Console.WriteLine(message);
        }

        public static void Pause()
        {
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
        }
    }
}
