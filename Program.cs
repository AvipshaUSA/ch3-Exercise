using System;
using System.Linq;
using System.Collections.Generic;

namespace ch3_Exercise
{
    class Program
    {
        static void Main(string[] args)

        { //1.Loop through the array and print out each value.

           //2. Modify the loop to only print the odd numbers from the array.


            int[] num = { 1, 1, 2, 3, 5, 8 };
            
            foreach(int i in num)
            {
                Console.WriteLine(i);
                
            }
            Console.WriteLine("-------------------------Print odd number-----------------------------------");
            foreach (int i in num)
            {
                if (i % 2 != 0)
                {
                   
                    Console.Write(" {0}", i);
                    Console.WriteLine("\n");
                }
            }

            //String Practice
            Console.WriteLine("------------------------split by space------------------------------------");
            string strs = "I would not, could not, in a box. I would not, could not with a fox.I will not eat them in a house. I will not eat them with a mouse.";
            string[] newArray = strs.Split(" ");
            foreach(string str in newArray)
            {
                Console.WriteLine("{0}",str);
                //Console.WriteLine( newString);

            }
            Console.WriteLine("-----------------------join by comma(,)-------------------------------------");
            string joinString= string.Join(",", newArray);
            Console.WriteLine(joinString);
            Console.WriteLine("------------------------split by o------------------------------------");


            newArray = strs.Split("o");
            foreach (string str in newArray)
            {
                Console.WriteLine("{0}", str);
                //Console.WriteLine( newString);

            }
            Console.WriteLine("--------------------------join by -  -----------------------------------");
            joinString = string.Join("-", newArray);
            Console.WriteLine(joinString);
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("the sum of even number {0}",ListClass.SumEven());
            string input= Console.ReadLine();
            Console.WriteLine("the word List : {0}",WordCount.Print(input));

        }
    }
}
