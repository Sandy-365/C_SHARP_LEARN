namespace _10_Task_OneToOne_JWT.Models
{
    public class User
    {
        public string StudentId {  get; set; }
        public string Name { get; set; }

        public UserProfile userprofile {  get; set; }

        public ICollection<UserCourse> usercourse {  get; set; }
    }
}
