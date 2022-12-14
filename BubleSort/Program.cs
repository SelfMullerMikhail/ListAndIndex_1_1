using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BubleSort
{
    public delegate string FormForFunction(string one, string second);
    public static class Test {
        public static string Func(string one, string second) { return one + second; }

    }


    public static class BubleSort
    {


        public static void FuncMain(FormForFunction FunFun, string one, string two) {
            Console.WriteLine(FunFun(one, two));
        }

        public static int[] Sort(this int[] SortObj)
        {
            for (int i = 0; i < SortObj.Length; i++)
            {
                for (int b = 0; b < SortObj.Length - i - 1; b++)
                {
                    var obj1 = SortObj[b];
                    var obj2 = SortObj[b + 1];
                    if (obj1 > obj2)
                    {
                        SortObj[b] = obj2;
                        SortObj[b + 1] = obj1;

                    }


                }
            }
            return SortObj;

        }

    }


    public class OneMore{
        public static string myfunction( string str, Func<int, int, int> myFunc) {

            var obj = myFunc(33, 3);
            return $"{obj}";
        }

    }

    public delegate int Mish(int one, int two);
    internal class Program
    {
        public int MyFinc(int one, int two) { return one + two;}
        static void Main(string[] args)
        {
            var obj = new int[] { 1, 4, 3, 10, 13, 2, 5, 11 };
            foreach (var i in obj.Sort()) { Console.WriteLine(i); }
            BubleSort.FuncMain(Test.Func, "sicj", "ishmek");
            Console.WriteLine(Test.Func("1", "2"));
            Console.WriteLine("+=+===+=++=");
            var ii = new Program();
            //Mish Prg = ii.MyFinc; Либо так либо так
            var Prg = new Mish(ii.MyFinc);
            Console.WriteLine("==========================");
            var obj10 = OneMore.myfunction("alla", delegate(int x, int y) { return x + y; });
            Console.WriteLine(obj10);

            
        }

    }

}
