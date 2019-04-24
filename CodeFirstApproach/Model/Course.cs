using System.ComponentModel.DataAnnotations.Schema;
namespace CodeFirstApproach.Model
{
    [Table("Course Details")]
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
    }
}
