using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTask
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
    Створіть структуру, що описує точку в тривимірній системі координат. 
    Організуйте можливість додавання двох точок, через використання перевантаження оператора +.
     */
    internal class Program
    {
        static void Main(string[] args)
        {

            Point a = new Point(1, 1, 1);
            Point b = new Point(2, 2, 2);

            Point c = a + b;

            Console.WriteLine("Координаты точки с равны " + c.X + " " + c.Y + " " + c.Z);

            // Delay.
            Console.ReadKey();
        }
    }
}
