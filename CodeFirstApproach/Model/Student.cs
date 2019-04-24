using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApproach.Model
{
    [Table("Student Profile")]
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Column("Student Name")]
        public string Name { get; set; }

        [Column("DOB", TypeName = "DateTime2")]
        public DateTime Date_Of_Birth { get; set; }
    }
}
