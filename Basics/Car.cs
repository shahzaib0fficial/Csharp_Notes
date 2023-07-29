using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Car
    {
        public string carName;
        public string carModel;
        public Car()
        {
            Console.WriteLine("Enter Car Name: ");
            carName = Console.ReadLine();
            Console.WriteLine("Enter Car Model: ");
            carModel = Console.ReadLine();
        }
        public void display()
        {
            Console.WriteLine($"{carName} : {carModel}");
        }
    }
}
