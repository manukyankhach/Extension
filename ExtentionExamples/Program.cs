using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;
            string name = "Khachatur";
            Console.WriteLine(name.GetFirstAndLastLatters());
            Console.WriteLine("===========================");
            Console.WriteLine(name._IsNullOrEmpty());
            Console.WriteLine("===========================");
            List<int> vs = new List<int>() { 1,2,3,4,5,6,7};
            Console.WriteLine(vs.GetBetweenListParameter());
            Console.WriteLine("===========================");
            Console.WriteLine(vs.GetOddElementsSum(out input));
            Console.WriteLine("===========================");
            Console.WriteLine(input);
            Console.ReadLine();
        }
    }
}
