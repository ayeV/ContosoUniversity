namespace ContosoUniversity.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }

        public Grade? Grade { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }

    }

    public enum Grade
    {
        A = 'A',
        B = 'B',
        C = 'C',
        F = 'F'
    }
}
