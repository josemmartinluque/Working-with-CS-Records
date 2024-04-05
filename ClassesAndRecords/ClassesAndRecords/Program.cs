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

            CourseRecord classroomCourse = new("Working with C# records");

            CourseRecord anotherCourse = classroomCourse with { Name = "C# Getting Started" };
        }
    }

    public class Course
    {
        public string Name { get; set; }
        public string Author { get; set; }

        public void Deconstruct(out string name, out string author)
        {
            name = Name;
            author = Author;
        }
    }

    public record CourseRecord(string Name)
    {
        public CourseRecord(string name, string author): this(name)
        {
            Author = author;
        }
        public string Author { get; init; }
        public string Title
        {
            get
            {
                return $"{Name} - {Author}";
            }
        }
    }
}