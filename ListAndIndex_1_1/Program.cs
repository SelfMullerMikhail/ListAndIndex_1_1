using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndIndex_1_1
{
    public class MyList<T> : IEnumerable<T>
    {
        T[] list;
        int counter = 0;
        public MyList()
        { list = new T[100]; }

        public void add(T value)
        {
            list[counter] = value;
            counter++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < counter; i++)
            {

                yield return list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index > counter) throw new Exception();
                return list[index];

            }
            set
            {
                if (index < 0 || index > counter) throw new Exception();
                list[index] = value;
            }
        }
    }

    internal class Program
    {


        static void Main(string[] args)
        {
            var list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Console.WriteLine(list[2]);
            foreach (var i in list) { Console.WriteLine(i); }
        }
    }
}
