using System.ComponentModel;

namespace GAMF_ENG.Models
{
    public class Student
    {
        public int Id { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("First or Midle Name")]
        public string FirstMidName { get; set; }
        [DisplayName("First Attend")]
        public DateTimeOffset EnrollmentDate { get; set; }

        [DisplayName("Attends")]
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
