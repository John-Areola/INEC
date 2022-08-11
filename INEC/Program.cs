using System.Collections;
using System.Collections.Generic;
namespace Inec_Voters_Registration_Database
{
    /// <summary>
    /// this is a program that shows voter names and the number of times they  have prei=viously registered
    /// </summary>
    internal class Program
    {

        static void Main(string[] args)
        {
            string[] voterNames = { "Joseph", "Johnny", "AY", "Tosin", "Ade", "Olu", "peter", "Bose", "Don", "Yusuf", "tolu", };

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            foreach (var elements in voterNames)
            {
                if (dictionary.ContainsKey(elements))
                {
                    dictionary[elements]++;
                }
                else
                {
                    dictionary[elements] = 1;
                }

            }
            Console.WriteLine("names of voters and number of times registered");
            foreach (var element in dictionary)
            {
                if (element.Value > 1)
                {
                    Console.WriteLine(element.Key + ": " + element.Value);
                }
            }

            //This is a solution too avoid duplicates
            Console.WriteLine(" \n\n The Unique List");
            HashSet<string> unique = voterNames.ToHashSet<string>();
            foreach (var element in unique)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();



        }
    }

}