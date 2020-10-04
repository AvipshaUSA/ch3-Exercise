using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;

namespace ch3_Exercise
{
    class WordCount
    {
        public static List<string> stringList;


        public static string Print(string user)
        {
            stringList = new List<string>();
            Console.WriteLine("Enter Word");
            string input;
            string newString;
            do
            {

                input = UserStringHandle;
                stringList.Add(input);
                // newString =input;

                // foreach (string word in stringList)
                for (int i = 0; i< stringList.Count; i++)
                {
                    if (Equals(stringList[i].Length, 5))
                    {
                        Console.WriteLine(input);
                        break;
                                             
                        
                    }
                    else
                    {
                        Console.WriteLine("not a 5 letter no");
                        break;
                    }
                }
              //Console.WriteLine(newString);
            } while (!Equals(input,""));

            var result = stringList.GroupBy(word => word.Length,
                (key, data) => $"Letters: {key} Count: {data.Count()}");

            return string.Empty;//string.Join(Environment.NewLine, result);  

        }
    }
}