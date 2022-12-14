using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyamda
{
    public class Test {
        public static void MyFunc<T>(T[] array, Func<int, int, int> func){

            Console.WriteLine(array.Length);
            Console.WriteLine(func(1,2));
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            var obj = new[] { 1, 3, 4, 2, 10 };
            Test.MyFunc(obj, (x,y)=>(x+y));

            Func<int, int, int> func = (x, y) => ((x + 2)*y);
            Console.WriteLine(func(100, 10));

        }
    }
}
