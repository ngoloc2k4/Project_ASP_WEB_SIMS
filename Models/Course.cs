namespace Project_ASP_WEB_SIMS.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public int Credit { get; set; }
        public int SemesterID { get; set; }
        public int ProgramID { get; set; }

        // Navigation properties
        public Semester Semester { get; set; }
        public Program Program { get; set; }
        public virtual required ICollection<CourseTeachOfTeacher> CourseTeaching { get; set; }
        public virtual required ICollection<CourseLearningOfStudent> CourseLearning { get; set; }
        public virtual ICollection<Grades> Grades { get; set; }
    }
}
