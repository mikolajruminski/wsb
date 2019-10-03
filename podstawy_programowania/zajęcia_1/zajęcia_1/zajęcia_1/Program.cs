using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajęcia_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //xDXDXD//
            /*x
             *D
             */
            Console.WriteLine("Janusz XD");

            //zmienne i typy danych pog//
            int x = 13;
            x = 7;
            Console.WriteLine(x);

            int x1, y = 10, z = 15;
            x1 = 2;

            Console.Write("Zmienna x1 wynosi: ");
            Console.WriteLine(x1);

            //konkatenacja
            // \n nowa linia
            Console.WriteLine("y = " + y + "\nz = " + z );

            int a = 10;
            int b = a;
            b = 15;
            Console.WriteLine(a + " " + b);

            //alternatywny sposób delkarazji zmiennej
            //int c = 0;

            int c = new int();  //wartośc domyślna - null (brak referencji)
            Console.WriteLine("wartość zmiennej c:" + c);

            Console.Write("Podaj swoje imię:");
            string name = Console.ReadLine();
            Console.WriteLine("sup: " + name);
            int z1 = 12;

            uint z2 = 20;

            float y1 = 10.55F;
            Console.WriteLine("Zmienna y1 = " + y1);

            double y2 = 15.95;
            Console.WriteLine("zmienna y2 =" + y2);

            //oblicz pole prostokąta, dane użytkownik podaje z klawiatury

            Console.WriteLine("Podaj bok A");
            double bokA = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj bok B:");
            double bokB double.Parse(Console.ReadLine());

            Console.result = bokA * bokB
                Console.WriteLine("Pole wynosi: " + result);
            //nie działa xd?
            Console.ReadKey();
        }
    }
}
