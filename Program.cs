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
            Console.WriteLine("give int");
            int num = Convert.ToInt32(Console.ReadLine());

            string[] stringArr = new string[num];

            Console.WriteLine("give {0} string(s)", num);


            // loop through user input adding to string array at index 0, 1, 2, etc....
            int i = 0;
            while (i < num)
            {
                stringArr[i] = Console.ReadLine();
                i++;
            }

            // loop through the strings in string array
            foreach (string a in stringArr)
            {
                string evens = "";
                string odds = "";
                bool isEven = true;

                // loop through the letters in each string
                for (int j = 0; j < a.Length; j++)
                {
                    if (isEven)
                    {
                        evens = evens + a[j];
                    } else
                    {
                        odds = odds + a[j];
                    }

                    // toggle the bool isEven to true or false to keep loop going until completion
                    isEven =! isEven;
                }
                Console.WriteLine($"{evens} {odds}");
            }
        }   
    }
}
