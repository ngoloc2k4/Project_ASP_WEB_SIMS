namespace Project_ASP_WEB_SIMS.Models
{
    public class Schedule
    {
        public int ScheduleId { get; set; }
        public int CourseID { get; set; }
        public int TeacherID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Room { get; set; }
        public string DayOfWeek { get; set; }

        // Navigation properties
        public virtual Course Course { get; set; }
        public virtual Teacher Teacher { get; set; }

    }
}
