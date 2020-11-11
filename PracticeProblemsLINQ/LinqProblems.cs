using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemsLINQ
{
    public static class LinqProblems
    {
        //Weighted project points: /10
        //Project points: /25

        #region Problem 1 
        //(5 points) Problem 1
        //Using LINQ, write a method that takes in a list of strings and returns all words that contain the substring “th” from a list.
        public static List<string> RunProblem1(List<string> words)
        {
            //code
            List<string> wordSearch = words.FindAll(w => w.Contains("th"));

            //return
            return wordSearch;

        }
        #endregion

        #region Problem 2 
        //(5 points) Problem 2
        //Using LINQ, write a method that takes in a list of strings and returns a copy of the list without duplicates.
        public static List<string> RunProblem2(List<string> names)
        {
            //code
            List<string> namesDuplicateRemoval = names.Distinct().ToList();
            //return
            return namesDuplicateRemoval;

        }
        #endregion

        #region Problem 3
        //(5 points) Problem 3
        //Using LINQ, write a method that takes in a list of customers and returns the lone customer who has the name of Mike. 
        public static Customer RunProblem3(List<Customer> customers)
        {
            //code
            // Added additional code to turn this into a search function for the user.

            bool askAgain = true;

            do
            {
                Console.WriteLine("Search Customer by First Name: ");
                string findMike = Console.ReadLine();
                var uniquecustomer = customers.Find(c => c.FirstName == findMike);

                try
                {
                    if (uniquecustomer == null)
                    {
                        Console.WriteLine("Customer Not Found");
                        askAgain = true;
                    }
                    else
                    {
                        return uniquecustomer;
                    }

                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Error");
                    throw;
                }

            } while (askAgain == true);
            return null;

        }
        #endregion

        #region Problem 4
        //(5 points) Problem 4
        //Using LINQ, write a method that takes in a list of customers and returns the customer who has an id of 3. 
        //Then, update that customer's first name and last name to completely different names and return the newly updated customer from the method.
        public static Customer RunProblem4(List<Customer> customers, int uID)
        {
            //code
            Console.WriteLine("Enter New First Name");
            string newFirstName = Console.ReadLine();

            Console.WriteLine("Enter New Second Name");
            string newLastName = Console.ReadLine();

            // solution found here: https://stackoverflow.com/questions/30055651/how-to-update-value-in-a-list-using-linq
            customers = customers.Where(c => c.Id == uID)
                .Select(c => { c.FirstName = newFirstName; return c; })
                .Select(c => { c.LastName = newLastName; return c; })
                .ToList();

            //return
            return null;
        }
        #endregion

        #region Problem 5
        //(5 points) Problem 5
        //Using LINQ, write a method that calculates the class grade average after dropping the lowest grade for each student.
        //The method should take in a list of strings of grades (e.g., one string might be "90,100,82,89,55"), 
        //drops the lowest grade from each string, averages the rest of the grades from that string, then averages the averages.
        //Expected output: 86.125
        public static double RunProblem5(List<string> classGrades)
        {
            //code
           
            var studentGrades = NumericalGradeParser(classGrades);
            var returnAfterDrop = DropMin(studentGrades);
            var returnAfterStudentAvg = Average(returnAfterDrop); 

            //return
            return default;

        }

        public static List<int[]> DropMin(List<int[]> classNumGrades)
        {   // I gave up
            int sum;
            //foreach (var sg in classNumGrades)
            //{
            //    sum = sg.Min();
            //    sum = sum
            //    classNumGrades.Remove(sg.removsum);
            //}

            return classNumGrades;
        }
        
        public static List<int[]> NumericalGradeParser(List<string> classGrade)
        {
            List<int[]> classGradeNumericals = new List<int[]>();

            foreach (var studentGrades in classGrade)
            {
                classGradeNumericals.Add(studentGrades.Split(',').Select(int.Parse).ToArray());
                
            }

            return classGradeNumericals;

        }

        public static List<int> Average(List<int[]> classNumGrades)
        {
            foreach (var studentGrade in classNumGrades)
            {
                studentGrade.Average();
            }
            return null;
        }


        public static List<int[]> IntergerParse(List<string[]> classGradeValues)
        {
            List<int[]> classGradeNumericals = new List<int[]>();
            
            foreach (var grade in classGradeValues)
            {
                classGradeNumericals.Add(grade.Select(int.Parse).ToArray());
            }

            return classGradeNumericals;
        }


        public static List<string[]> StringParse(List<string> classGrade)
        {
            List<string[]> gradeParse = new List<string[]>();
           
            foreach (var studentGrades in classGrade)
            {
                gradeParse.Add(studentGrades.Split(','));
            }

            return gradeParse;
        }

        #endregion

        #region Bonus Problem 1
        //(5 points) Bonus Problem 1
        //Write a method that takes in a string of letters(i.e. “Terrill”) 
        //and returns an alphabetically ordered string corresponding to the letter frequency(i.e. "E1I1L2R2T1" result 1t1e2r1i2l)
        public static string RunBonusProblem1(string word)
        {
            //code
                      
            word = word.ToUpper();
            string uncompressedString = SortString(word);
            
            string compressedString = "";
            int letterCounter = 1;

            for (int i = 0; i < uncompressedString.Length; i++)
            {
                if (i == uncompressedString.Length - 1)
                {
                    compressedString += uncompressedString[i];
                    compressedString += letterCounter;
                }
                else if (uncompressedString[i] == uncompressedString[i + 1])
                {
                    letterCounter++;
                }
                else
                {
                    compressedString += uncompressedString[i];
                    compressedString += letterCounter;
                    letterCounter = 1;
                }
            }
            
            //return
            return compressedString;
        }

        public static string SortString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Sort(arr);
            return new string(arr);
        }

        #endregion
    }
}
