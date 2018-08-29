using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1
            Console.WriteLine("Urinbasarov Dias");

            //Task2
            int number1;
            int number2;
            int sum;

            Console.WriteLine("Введите 1-ое число");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите 2-ое число");
            number2 = int.Parse(Console.ReadLine());

            sum = number1 + number2;

            Console.WriteLine("Сумма равна: {0}", sum);

            Console.ReadLine();
        }
    }
}
