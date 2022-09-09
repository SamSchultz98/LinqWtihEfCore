using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodTutorial
{
    public static class IntegerExtensionMethods
    {
        public static int Add(this int i, int term)
        {
            return i + term;
        }

        public static int Sub(this int i, int term)
        {
            return i - term;
        }

        public static int Mult(this int i, int term)
        {
            return i * term;
        }
        public static int Div(this int i, int term)
        {
            if (term == 0)
            {
                Console.WriteLine("Unable to Divide By Zero");
          
            }
            return i / term;
        }  


        public static void CW(this int i)
        {
            Console.WriteLine($"{i}");
        }







    }
    public static class StringExtensionMethods
    {
        public static void CWL(this string str)
        {
          Console.WriteLine($"{str}");

        }

        public static string AppendString(this string str,string appendStr )
        {
            return $"{str} {appendStr}";
        }
    }
}
