namespace Project_ASP_WEB_SIMS.Models
{
    public class Semester
    {
        public int SemesterId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
