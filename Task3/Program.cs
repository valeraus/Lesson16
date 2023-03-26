using System;

namespace Task3
{
    /*
    Створіть клас House з двома полями та властивостями. 
    Створіть два методи Clone() та DeepClone(), які виконують поверхневе та глибоке копіювання відповідно. 
    Реалізуйте найпростіший спосіб перевірки.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            var house = new House(new Street("Евгения Сверстюка"), "Киев");

            House clone;
            //clone = house.Clone();
            clone = house.DeepClone();

            Console.WriteLine("Original: {0}, {1}", house.City, house.Street.Str);
            Console.WriteLine("Clone   : {0}, {1}", clone.City, clone.Street.Str);
            Console.WriteLine(new string('-', 50));

            clone.City = "Одесса";
            clone.Street = new Street("Дерибасовская");

            Console.WriteLine("Original: {0}, {1}", house.City, house.Street.Str);
            Console.WriteLine("Clone   : {0}, {1}", clone.City, clone.Street.Str);

            // Delay.
            Console.ReadKey();
        }
    }
}

