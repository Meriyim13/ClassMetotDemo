using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> myDictionary =new  Dictionary<int, string>();
            myDictionary.Add(868001365, "Milupa");
            myDictionary.Add(23684486, "Bebelac");
            myDictionary.Add(23684489, "Sma");
            myDictionary.Add(23684488, "Aptamil");
            Console.WriteLine(myDictionary.Count);


            foreach (var dictionary in myDictionary)
            {
                Console.WriteLine(dictionary.Key+"----"+dictionary.Value);
            }

        }
    }
}
