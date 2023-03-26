using System;

namespace Task2
{
    /*
    Створіть клас Block із 4 полями сторін, перевизначте в ньому методи: 
    Equals - здатний порівнювати блоки між собою, 
    ToString - повертає інформацію про поля блоку.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Block block1 = new Block(15, 12, 5, 7);
            Block block2 = new Block(7, 12, 5, 15);

            Console.WriteLine(block1.ToString());
            Console.WriteLine(block2.ToString());

            Console.WriteLine(new string(' ', 30));

            Console.WriteLine("Блок1 равно блок2 = {0} ", block1.Equals(block2));

            if (block1.GetHashCode() == block2.GetHashCode())
            {
                Console.WriteLine("Периметры двух блоков равны");
            }
            else
            {
                Console.WriteLine("Периметры блоков не равны");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}

