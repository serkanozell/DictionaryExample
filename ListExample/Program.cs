using System;
using System.Collections.Generic;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            

            MyList<string,string> liste = new MyList<string,string>();
            liste.Add("Araba","Yeşil");
            liste.Add("Ev", "Turuncu");

            Console.WriteLine(liste.KLength);
            Console.WriteLine(liste.VLength);

            foreach (var item in liste.key)
            {
                Console.WriteLine(item);
            }

            foreach (var item in liste.value)
            {
                Console.WriteLine(item);
            }
        }
    }
}
