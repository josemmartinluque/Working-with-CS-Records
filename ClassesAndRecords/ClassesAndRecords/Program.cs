using System;

namespace ClassesAndRecords
{
    class Program
    {

        static void PrintCourse(Course course)
        {
            Console.WriteLine(course.Name);
        }

        static void Main(string[] args)
        {
            Course pluralsightCourse = new();
            pluralsightCourse.Name = "Working with C# Records";
            pluralsightCourse.Author = "Roland Guijt";

            CourseRecord classroomCourse = new(
                "Working with C# records",
                "Roland Guijt"
                );
        }
    }

    public class Course
    {
        public string Name { get; set; }
        public string Author { get; set; }
    }

    public record CourseRecord(string Name, string Author);
}