using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemsLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var wordsReturn = LinqProblems.RunProblem1(words);

            foreach (var word in wordsReturn)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();

            //**************************************************************************

            //Problem 2
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike", "Ian", "Mike" };
            var namesReturn = LinqProblems.RunProblem2(names);
            foreach (var name in namesReturn)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

            //**************************************************************************

            //Problem 3 & 4 Dataset
            List<Customer> customers = new List<Customer>()
            {
                new Customer(1, "Mike", "Rodgers"),
                new Customer(2, "Nick", "Allen"),
                new Customer(3, "Jason", "Ryan"),
                new Customer(4, "Dan", "Laffey")
            };

            //Problem 3
            
            var uniqueCustomerFound = LinqProblems.RunProblem3(customers);
            // works with exact values, reference exception later
            Console.WriteLine($"{uniqueCustomerFound.FirstName} has been found");
            Console.ReadLine();

            // Problem 4
            
            LinqProblems.RunProblem4(customers, 3);
            // works with exact values, reference exception later
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id + customer.FirstName + customer.LastName);
            }
            Console.ReadLine();

            //**************************************************************************
            
            //Problem 5
            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65", 
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };

            //**************************************************************************
      
            //Bonus Problem 1
            string letters = "terrill";

        }
    }
}
