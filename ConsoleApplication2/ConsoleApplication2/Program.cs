using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            class1 t = new class3();
            t.rapper();
            Console.Read();
        }
    }

    class class1
    {
        public class1()
        { 
            Console.Write("Hello");
        }

        public void rapper()
        {
            Console.Write("dj");
        }

    }

    sealed class class2 : class1
    {
        public class2()
        {
            Console.Write("World!");
        }
    }

    class class3:class2
    {
        public class3()
        {
            Console.Write("Sunshine!");
        }
    }


}
