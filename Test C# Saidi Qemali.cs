using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
          
        {
            int age = 15;
            string name = "Saidi";
            int x = 6;
            int y = 9;
            string Vorname = "Saidi ";
            string Name = "Qemali";
            string MeinName = Vorname + Name;
            int zeit = 18;
            int i = 1;

            Console.WriteLine("Hello World!");
            Console.WriteLine("This is my new code !");
            Console.WriteLine("I am " + age + " years old");
            Console.WriteLine("My name is " + name);
            Console.WriteLine(x + y);
            Console.WriteLine("Enter your age to see all the code");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);
            Console.WriteLine(MeinName);

            if(10 < 11)
            {
                Console.WriteLine("10 ist grosser als 11");
            }

       
            if (zeit < 18)
            {
                Console.WriteLine("Es ist Dunkel");
            }
            else
            {
                Console.Write("Du musst schlafen");
                Console.WriteLine("  Gute Nacht");
            }

            Console.WriteLine("Ich zhäle bis 4 und du wirst schon schlafen");

   
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);



            Console.ReadKey();
        }
       

    }
}
