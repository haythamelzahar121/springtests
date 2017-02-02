using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NewProject11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of Web-Browsers:");
            string webbBrowsers = Console.ReadLine();
            int numberWebbrowsers = Convert.ToInt32(webbBrowsers);
            string[] browserNames = ExecuteWebbrowser(numberWebbrowsers);

            Console.WriteLine("Number of Operating Systems:");
            string operatingSystems = Console.ReadLine();
            int numberOperatingSystems = Convert.ToInt32(operatingSystems);
            string[] osesNames = ExecuteOperatingSystems(numberOperatingSystems);

            Console.WriteLine("Run test combinations (Y/N):");
            string inputCombAnswer = Console.ReadLine();
            if (inputCombAnswer.Equals("Y") || inputCombAnswer.Equals("y"))
            {
                ExecuteCombinations(browserNames, osesNames);
            }
            else
            {
              Environment.Exit(0);
            }          
            Console.WriteLine("Number of Tests (Y/N):");
            string inputTestAnswer = Console.ReadLine();
            if (inputTestAnswer.Equals("Y") || inputTestAnswer.Equals("y"))
            {
                CountCombinationTests(browserNames, osesNames);
            }
            else
            {
              Environment.Exit(0);
            }  
        }

        public static string[] ExecuteWebbrowser(int webCt)
        {
            string[] inputWebBrowsers = new string[webCt];
            for (int i = 0; i < inputWebBrowsers.Length; i++)
            {
                Console.WriteLine("Please input Web-Browser " + (i + 1) + ":");
                inputWebBrowsers[i] = Console.ReadLine();
            }
            return inputWebBrowsers;
        }

        public static string[] ExecuteOperatingSystems(int osCt)
        {
            string[] inputOses = new string[osCt];
            for (int i = 0; i < inputOses.Length; i++)
            {
                Console.WriteLine("Operating Systems: " + (i + 1));
                inputOses[i] = Console.ReadLine();
            }
            return inputOses;
        }

        public static void ExecuteCombinations(string[] browserNames, string[] osesNames)
        {
            foreach (var browser in browserNames)
            {
                foreach (var operatingSystem in osesNames)
                {
                    Console.WriteLine(browser + ", " + operatingSystem);
                }
            }
        }

        public static void CountCombinationTests(string[] browserNames, string[] osesNames)
        {
            Console.WriteLine(browserNames.Count() * osesNames.Count());
            Console.ReadLine();
        }
    }
}
