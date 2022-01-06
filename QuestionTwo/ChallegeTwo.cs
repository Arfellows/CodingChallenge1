using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuestionTwo
{
    class ChallegeTwo
    {
        static void Main(string[] args)
        {
            //string pattern1 = @"\b[A-Z]\w+";
            //string pattern2 = @"-\d{.}\z";
            //Regex reg1 = new Regex(pattern1);
            //Regex reg2 = new Regex(pattern2);

        }

        public bool IsValidStatement(string input)
        {
            if (Regex.Match(input, @"\b[A-Z]\w+", RegexOptions.IgnoreCase).Success)
            {
                if (Regex.Match(input, @"-\d{.}\z", RegexOptions.IgnoreCase).Success)
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }


    }
}
