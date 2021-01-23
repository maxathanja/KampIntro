using System;

namespace ClassIntro
{
  class Program
  {
    static void Main(string[] args)
    {
      string name = "Maksat";
      int age = 28;

      Course course1 = new Course();
      course1.CourseName = "C#";
      course1.Tutor = "Engin Demiroğ";
      course1.ViewRate = 68;

      Course course2 = new Course();
      course2.CourseName = "Python";
      course2.Tutor = "Kerem Varış";
      course2.ViewRate = 64;

      Course course3 = new Course();
      course3.CourseName = "Javascript";
      course3.Tutor = "Berkay Bilgin";
      course3.ViewRate = 80;

      Course course4 = new Course();
      course4.CourseName = "C++";
      course4.Tutor = "Murat Kurtboğan";
      course4.ViewRate = 100;

      //Console.WriteLine(course1.CourseName + " : " + course1.Tutor);

      Course[] courses = new Course[] {course1, course2, course3, course4};

      foreach (Course course in courses)
      {
        Console.WriteLine(course.CourseName + " : " + course.Tutor);
      }
    }
  }

  class Course
  {
    public string CourseName { get; set; }
    public string Tutor { get; set; }
    public int ViewRate { get; set; }
  }
}