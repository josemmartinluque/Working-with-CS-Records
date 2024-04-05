using System;

namespace ClassesAndRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            TimedCourseRecord classroomCourse = new(
                "Working with C# Records",
                "Roland Guijt",
                Duration: 90
                );

            TimedCourseRecord videoCourse = new(
                "Working with C# Records",
                "John Doe",
                Duration: 90
                );

            Console.WriteLine(classroomCourse == videoCourse);
        }
    }

    public record CourseRecord(string Name, string Author)
    {

    }

    public record TimedCourseRecord(string Name, string Author, int Duration):
        CourseRecord(Name, Author)
    {
        public string Venue { get; set; }

        public virtual bool Equals(TimedCourseRecord other)
        {
            return Name == other.Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }

    internal record AnotherTimedCourseRecord(string Name, string Author, int Duration) : TimedCourseRecord(Name, Author, Duration)
    {

    }


}