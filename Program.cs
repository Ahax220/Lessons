using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    abstract class Person
    {
        int a;
        public abstract void Display(int a, string name);

    }


    class Program : Person
    {



        static void Main(string[] args)
        {
            Console.WriteLine("qwe");
            Console.WriteLine();
        }

        public override void Display(int a, string name)
        {
            Console.WriteLine(a + name);

        }

        public static void Display2(string str)
        {
            Console.WriteLine("эта строка исправлена - " + str);
            Console.WriteLine("test");

        }
    }
}


