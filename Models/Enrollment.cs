namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-09-<jyi2>-dykstra1 - more getter and setters.
    //The Grade property is an enum. The ? indicates that Grade property is nullable. 
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }
        public Student Student { get; set; }

    }
}