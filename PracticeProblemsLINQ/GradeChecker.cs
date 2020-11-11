using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemsLINQ
{
    public class GradeChecker
    {
        public delegate bool IntToBoolFunction(int number);

        //100, 61, 97, 85, 55, 89
        public static IEnumerable<int> CheckGrades(List<int> grades, IntToBoolFunction gradesToCheck)
        {
            foreach (int grade in grades)
            {
                if (gradesToCheck(grade))
                {
                    yield return grade;
                }
            }
        }

        public static bool LessThanSeventy(int grade)
        {
            return grade <= 70;
        }
        public static bool LessThanEighty(int grade)
        {
            return grade <= 80;
        }
        public static bool GreaterThanSeventy(int grade)
        {
            return grade >= 70;
        }
    }
}
