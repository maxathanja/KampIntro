using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
          // type safety
          // DRY
          // Alias
          string categoryLabel = "Category";
          int numberOfStudents = 32000;
          double interestRate = 1.45;
          bool isLoggedIn = true;
          double dollarYesterday = 7.35;
          double dollarToday = 7.45;

          if (dollarYesterday>dollarToday)
          {
            Console.WriteLine("Down button");
          }
          else if (dollarYesterday<dollarToday)
          {
            Console.WriteLine("Up button");
          }
          else
          {
            Console.WriteLine("Nothing changed button");
          }

          if (isLoggedIn == true)
          {
            Console.WriteLine("User Settings button");
          }
          else
          {
            Console.WriteLine("Login button");
          }

        }
    }
}
