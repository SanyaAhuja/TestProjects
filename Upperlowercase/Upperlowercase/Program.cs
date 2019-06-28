using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upperlowercase
{
    public class Program
    {
        public static void Main()
        {
            string string1;
            char[] array1;
            int l = 0, i;
            char ch;
            Console.Write("\nConvert lowercase characters to uppercase and uppercase characters to lowercase:\n");
            Console.Write("Input the string :");
            string1 = Console.ReadLine();
            l = string1.Length;
            array1 = string1.ToCharArray(0, l);
            Console.Write("\nThe new string becomes:");
            for(i=0;i<l;i++)
            {
                ch = array1[i];
                if (Char.IsLower(ch))
                    Console.Write(Char.ToUpper(ch));
                else
                    Console.Write(Char.ToLower(ch));
            }

        }
    }
}
