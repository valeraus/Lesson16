using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /*
    Створіть клас, який буде містити інформацію про дату (день, місяць, рік). 
    За допомогою механізму перевантаження операторів, визначте операцію різниці двох дат 
    (результат у вигляді кількості днів між датами), 
    а також операцію збільшення дати на певну кількість днів.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDate date1 = new MyDate(DateTime.Now);
            Console.WriteLine(date1.ToString());

            MyDate date2 = new MyDate(new DateTime(2022, 02, 24));
            Console.WriteLine(date2.ToString());

            Console.WriteLine(MyDate.Sub(date1, date2).ToString());
            Console.WriteLine(MyDate.Add(date1, date2).ToString());

            // Delay.
            Console.ReadKey();
        }
    }
}
