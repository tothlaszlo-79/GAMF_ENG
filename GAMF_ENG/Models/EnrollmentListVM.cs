using System.ComponentModel;

namespace GAMF_ENG.Models
{
    public class EnrollmentListVM
    {
        [DisplayName("Course Name")]
        public string CourseTitle { get; set; }
        [DisplayName("Student Name")]
        public string StudentFullName { get; set; }
        [DisplayName("Grade")]
        public string Grade { get; set; }
    }
}
