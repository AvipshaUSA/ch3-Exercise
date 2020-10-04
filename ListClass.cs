using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ch3_Exercise
{
   class ListClass
    {
        public static List<int> numList; //= new List<int> //{ 1, 1, 2, 4, 5, 9, 8 };
        public static List<string> stringList;

        public static int SumEven()
        {
            numList = new List<int> { 1, 1, 2, 4, 5, 9, 8 };
            int sum = 0;
            for (int i = 0; i < numList.Count; i++)
            // for (int i = 0; i < numList.Count; i++)

            {
                int num = numList[i];
                if (num % 2 == 0)
                {
                    sum = sum + num;
                }
            }

            return sum;
            
        }
        //public static string WordPrint()
        //{
        //        stringList = new List<string>();
        //        Console.WriteLine("Enter Word");
        //    do
        //    {
        //        string input = Console.ReadLine();
        //        stringList.Add(input);
        //        // stringList.Count = stringList.Count+1;
        //    } while (stringList.Count < 10);

        //        //string inputNewUser = Console.ReadLine();
        //        //stringList.Add(inputNewUser);
        //        foreach (string word in stringList)
        //        {
        //            return word;
        //        }

        //}
    }
}
