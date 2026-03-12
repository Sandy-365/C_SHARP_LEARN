namespace _10_Task_OneToOne_JWT.Models
{
    public class UserCourse
    {
        public int Id { get; set; }
        public string Course {  get; set; }
        public int M1 {  get; set; }
        public int M2 { get; set; }

        public string StudentId {  get; set; }

        public User User {  get; set; }
    }
}
