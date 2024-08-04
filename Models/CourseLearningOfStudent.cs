namespace Project_ASP_WEB_SIMS.Models
{
    public class CourseLearningOfStudent
    {
        public int CourseLearningID { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}
