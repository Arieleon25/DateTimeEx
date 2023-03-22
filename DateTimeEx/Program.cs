using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeEx
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime timenow = DateTime.Now;
            Console.WriteLine(timenow);

            Console.WriteLine("Please input a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            int[] hours = { userInput };

            foreach (int input in hours)
            {
                Console.WriteLine("{0} + {1} hour(s) = {2}", timenow, input, timenow.AddHours(input));
            }

            Console.ReadLine();


        }
    }
}
