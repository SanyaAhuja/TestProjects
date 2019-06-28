using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeatingletters
{
    class Program
    {
        public int Count(string str,char ch)
        {
            var count = 0;
            for(int i=0;i<str.Length;i++)
            {
                if(ch==str[i])
                {
                    count++;
                }
            }
            return count;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            Console.WriteLine("Enter to know the occurance of characters");
            char ch = Convert.ToChar(Console.ReadLine());
            Program obj = new Program();
            int p = obj.Count(str, ch);
            Console.WriteLine(p);
            Console.ReadLine();
            Console.WriteLine(count);
        }
    }
}
