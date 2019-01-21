using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingCharsAtIndicesInStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("number of strings to expect");
            int T = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("type that number of strings");
            string input = Console.ReadLine();

            StringBuilder outputOdd = new StringBuilder();
            StringBuilder outputEven = new StringBuilder();

            if (numOfArgs == 1)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        outputEven.Append(input[i]);
                    }
                }

                for (int i = 0; i < input.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        outputOdd.Append(input[i]);
                    }
                }

                Console.Write(outputEven + " ");
                Console.WriteLine(outputOdd);
            }

           

        }
    }
}
