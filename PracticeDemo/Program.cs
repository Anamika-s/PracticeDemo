using System;

namespace PracticeDemo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            CommonFunctions.NumericFunctions numericFunctions = new CommonFunctions.NumericFunctions();
            Console.WriteLine(numericFunctions.Add(10,90));

            
            CommonFunctions.StringFunctions stringFunctions = new CommonFunctions.StringFunctions();
            Console.WriteLine(stringFunctions.GetStringLength("ABC"));
        }
    }
}
