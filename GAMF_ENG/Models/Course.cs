using System.ComponentModel.DataAnnotations.Schema;

namespace GAMF_ENG.Models
{
    public class Course
    {
        //we don't want to generate the CourseId automatically
        [DatabaseGenerated(DatabaseGeneratedOption.None)] 
        public  int CourseId { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
