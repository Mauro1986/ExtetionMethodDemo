using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtetionMethodSimpel
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExtensionSimple.Print("hallo");
            string str = "hello fom extention method, realy cwoool";
           int woordCount = str.CountWords();
            Console.WriteLine($"Zin: {str} has {woordCount} words");
            Console.WriteLine("******************");
            string lijn = new string('*', 50);

            int nr = 100;
            if (nr.IsEven())
            {
                Console.WriteLine($"the value {nr} is even");
            }
            else
            {
                Console.WriteLine($"the value {nr} is NOT even");
            }
        }
    }

    public static class IntegerExtentions
    {
        public static bool IsEven(this int i)           //this intiger
        {
            return ((i % 2) == 0);              //EVEN GETAL OF NIET
        }

    }

    public static class ExtensionSimple
    {
        public static void Print(this string message)       //this
        {
            Console.WriteLine(message);
        }
        public static int CountWords(this string input)       //this
        {
            if (!string.IsNullOrEmpty(input))
            {
                string[] strArray = input.Split(' ');
                return strArray.Count();
            }
            else
            {
                return 0;
            }
        }
    }

}
