using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evenodd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = 12345;
            Console.WriteLine("The number entered is:" + n);
            int even_count = 0;
            int odd_count = 0;
            int rem=0,s1=0,s2=0;
            while(n>0)
            {
                rem = n % 10;
                if (rem % 2 == 0)
                {
                    even_count++;
                    Console.Write("{0}", rem);
                    s1 = s1 + rem;
                }
                else
                { odd_count++;
                    Console.WriteLine("\n{0}", rem);
                    s2 = s2 + rem;
                }
                n = n / 10;
            }
            
            Console.WriteLine("Even count is:" + even_count);
            Console.WriteLine("Odd count is:" + odd_count);
            Console.WriteLine("The sum of even numbers is:{0} \n The sum of all odd numbers is:{1}",s1,s2 );
           
        }
        
    }
}
