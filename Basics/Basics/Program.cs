using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        static void Greet(string name)
        {
            Console.WriteLine("Assalam o Aliqum " + name);
        }
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        static void Main(string[] args)
        {
            /*
            // Writing a line
            Console.WriteLine("Hello World");
            //writing
            Console.Write("Hello Shahzaib");
            //Writing another line
            Console.WriteLine("Learning C#");
            */

            /*
            //datatypes
            string myName;
            int age = 18;
            Console.WriteLine("Enter your Name : ");
            myName = Console.ReadLine();
            Console.WriteLine("Name is " + myName);
            Console.WriteLine("Age is " + age);

            int a = 5;
            float b = 5.5F;
            double c = 5.5;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            */

            /*
            //TypeCasting

            //Implicit Casting
            // char to int to long to float to double
            int a = 5;
            float b = a;
            Console.WriteLine(b);

            //Explicit Casting
            double c = 5.5;
            int d = (int)c;
            Console.WriteLine(d);

            string s = "10";
            Console.WriteLine("Value is : " + (Convert.ToInt64(s) + 5));
            */

            //Operators
            //Arithmetic(+,-,*,/,%)
            /*
            int a = 5;
            int b = 10;
            Console.WriteLine("Sum = " + (a + b));
            */

            //Asingnment Operators
            /*
            int c = 5;
            c += 10;
            Console.WriteLine("Adding 10 in c: " + c);
            */

            //Logical Operators
            //AND(&&)
            /*
            Console.WriteLine(true && true);
            Console.WriteLine(true && false);
            Console.WriteLine(false && true);
            Console.WriteLine(false && false);
            */
            //OR(||)
            /*
            Console.WriteLine(true || true);
            Console.WriteLine(true || false);
            Console.WriteLine(false || true);
            Console.WriteLine(false || false);
            */
            //NOT(!)
            /*
            Console.WriteLine(!true);
            Console.WriteLine(!false);
            */

            //Relational Operators
            /*
            Console.WriteLine(5 > 10);
            Console.WriteLine(5 < 10);
            Console.WriteLine(5 < 5);
            Console.WriteLine(5 <= 5);
            Console.WriteLine(5 == 5);
            Console.WriteLine(5 != 5);
            */

            /*
            //Math class
            //int a = Math.Max(10, 20);
            //int a = Math.Min(10, 20);
            //int a = Math.Abs(-1);
            //Console.WriteLine(a);
            */

            /*
            //String Methods
            string s = "My Name is Shahzaib";
            Console.WriteLine(s.Length);
            Console.WriteLine(s.ToLower());
            Console.WriteLine(s.ToUpper());
            Console.WriteLine(string.Concat(s," I am 18 year old"));

            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Name: {name} Age: {age}");
            */

            /*
            //accesing string index
            string s = "My Name is Shahzaib";
            Console.WriteLine(s[0]);
            Console.WriteLine(s.IndexOf("Name"));
            Console.WriteLine(s.Substring(3));
            */

            /*
            //Escape Sequences
            Console.WriteLine("My name is \t \"Shahzaib\" \nAge is 18");
            */

            /*
            //else if
            int marks  = 95;
            if(marks>=80)
            {
                Console.WriteLine("A");
            }
            else if(marks<80&& marks>=50)
            {
                Console.WriteLine("B");
            }
            else
            {
                Console.WriteLine("F");
            }
            */

            /*
            //switch statement
            int marks = 90;
            switch(marks)
            {
                case 90:
                    Console.WriteLine("A");
                    break;
                case 60:
                    Console.WriteLine("B");
                    break;
                case 40:
                    Console.WriteLine("F");
                    break;
            }
            */

            /*
            //Loops
            //For loop
            for(int i = 0;i<5;i++)
            {
                if (i == 0)
                {
                    continue;
                }
                Console.WriteLine("i = " + i);
            }
            int j = 0;
            //While loop
            while(j<5)
            {
                Console.WriteLine("j = " + j);
                j++;
                break;
            }
            //Do-while loop
            int k = 0;
            do
            {
                Console.WriteLine("k = " + k);
                k++;
            } while(k > 5);
            */

            /*
            //Methods
            string name = "Muhammad Shahzaib";
            Greet(name);

            int sum = Sum(5, 10);
            Console.WriteLine("Sum of two numbers: " + sum);
            Console.WriteLine("Sum of three numbers: " +  Sum(5, 10, 15));
            */

            /*
            //OOP -> Object and classes

            Car c = new Car();
            c.display();
            */

            //Reading line from user
            Console.ReadLine();
        }
    }
}
