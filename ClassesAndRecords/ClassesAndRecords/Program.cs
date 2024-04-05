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

            var clonedCourse = classroomCourse with { Name = "John" };
            var castCourse = (TimedCourseRecord) clonedCourse;
            var duration = castCourse.Duration;
        }
    }

    public record CourseRecord(string Name, string Author);
    public record TimedCourseRecord(string Name, string Author, int Duration):
        CourseRecord(Name, Author);
}