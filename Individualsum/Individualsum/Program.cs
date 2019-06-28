using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individualsum
{
    public class Program
    {
        public static int SumCal(int n)
        {
            string n1 = Convert.ToString(n);
            int sum = 0;
            for (int i = 0; i < n1.Length; i++)
                sum += Convert.ToInt32(n1.Substring(i, 1));
            return sum;
        }
        public static void Main()
        {
            int num;
            Console.Write("\nFunction: To calculate sum of individual digits of a number:\n");
            Console.Write("Enter your number:");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of digits of the number {0} is : {1}\n", num, SumCal(num));

        }
    }
}
