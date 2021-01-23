using System;
using System.Threading.Channels;

namespace Loops
{
  class Program
  {
    static void Main(string[] args)
    {
      string course1 = "Yazılım Geliştirici Yetiştirme Kampı";
      string course2 = "Programlamaya başlangıç için temel kurs";
      string course3 = "Python";

      // array
      string[] courses = new string[]
        {"Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs", "Python", "Javascript"};

      for (int i = 0; i < courses.Length; i++)
      {
        Console.WriteLine(courses[i]);
      }
      
      foreach (string course in courses)
      {
        Console.WriteLine(course);
      }

      Console.WriteLine("End of the courses");
    }
  }
}