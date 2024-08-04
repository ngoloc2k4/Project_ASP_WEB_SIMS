namespace Project_ASP_WEB_SIMS.Models
{
    public class Student
    {
        public int studentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int ProgramID { get; set; }

        // Navigation properties
        public Program Program { get; set; }
        public virtual ICollection<CourseLearningOfStudent> Course { get; set; }

    }
}
