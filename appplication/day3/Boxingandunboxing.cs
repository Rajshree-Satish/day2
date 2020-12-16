using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    class Boxingandunboxing
    {
        static void ss(object s)
        {
            Console.WriteLine(s);
        }
        public static void Main(string[] args)
        {
            int x = 789;
            object ox = x;
            Console.WriteLine($" x int value is {x}\n ox object value is {ox}");
            object ob1 = 45;
            ss(ob1);
            int a = (int)ob1;
            Console.WriteLine($"ob1 value is {ob1} \n a int value is { a} ");

        }
    }
}
