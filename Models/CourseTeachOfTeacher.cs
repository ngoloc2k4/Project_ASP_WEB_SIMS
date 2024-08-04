namespace Project_ASP_WEB_SIMS.Models
{
    public class CourseTeachOfTeacher
    {
        public int CourseTeachingID { get; set; }
        public int TeacherID { get; set; }
        public int CourseID { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Course Course { get; set; }
    }
}
