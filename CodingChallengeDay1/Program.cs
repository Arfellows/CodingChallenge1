using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallengeDay1
{
    class Program
    {
        static void Main(string[] args)
        {

            var listA = new[] { "abc", "xyz", "klm", "xyz", "abc", "abc", "rst" };
            var listB = new[] { "abc", "xyz", "klm", "rst" };
            var listC = listB.Where(x => listA.Where(y => y == x).Count() == 1);
            foreach(var item in listC)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
