using System;

namespace OperatorExercise
{
    class program
    {
        static void Main(string[] args)
        {     //Exercise 1

            int a = 17;
             int b = 4;

             int quotient = a / b;
             int remainder = a % b;

             if (a == 17 && b == 4)
             {
                 
                 Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

             }

             // exercise 2 

            double radius, area;
            Console.WriteLine("Enter the radius of the circle");
            radius = Convert.ToDouble(Console.ReadLine());
            area = Math.PI * radius * radius;
            Console.WriteLine("Area of the Circle with radius {0} is {1}", radius, area);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey(); 

            var i = 3;
            var j = 4;

            var k = ++i * j++;
            Console.WriteLine($"{k}");














        }
    }

}
    