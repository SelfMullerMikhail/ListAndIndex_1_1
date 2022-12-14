using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashFunction_2_3
{


    public class MyClass
    {
        public static int IndexOf(string text, string substring)
        {
            if (text.Length < substring.Length) return -1;

            long prime = 1000;
            long maxPower = 1;
            for (int i = 0; i < substring.Length - 1; i++)
                maxPower *= prime;

            long substringHash = 0;
            long hash = 0;
            for (int i = 0; i < substring.Length; i++)
            {
                hash = hash * prime + text[i];
                substringHash = substringHash * prime + substring[i];
            }

            for (int i = substring.Length; i < text.Length; i++)
            {
                if (hash == substringHash)
                {
                    bool equals = true;
                    for (int j = 0; j < substring.Length; j++)
                        if (text[i - substring.Length + j] != substring[j])
                        {
                            equals = false;
                            break;
                        }
                    if (equals) return i - substring.Length;
                }
                var lastLetterHash = maxPower * text[i - substring.Length];
                hash -= lastLetterHash;
                hash = hash * prime + text[i];
            }
            return -1;
        }
        private static void Main()
        {
            Console.WriteLine(IndexOf("abcdefgh", "cde"));

        }
    }
}
