namespace _10_Task_OneToOne_JWT.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DOB {  get; set; }
        public string Email { get; set; }
        public string Year { get; set; }
        public string Phone {  get; set; }
        public string FatherName {  get; set; }
        public string Address { get; set; }

        public string StudentId {  get; set; }
        public User User { get; set; }
    }
}
