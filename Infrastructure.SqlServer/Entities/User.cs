
namespace Infrastructure.SqlServer.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Profession { get; set; }
        public int YearsOfExperience { get; set; }
        public string Sex { get; set; }
        public string Country { get; set; }
        public string CV { get; set; }
        public string ProfileImage { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<string> Skills { get; set; }
        public string PreferredJobType { get; set; } 
        public string LinkedInProfile { get; set; }

       
        public ICollection<Application> Applications { get; set; }
        public ICollection<CompanyReview> Reviews { get; set; }
        ICollection<JobListing> JobListing { get; set; }
        public ICollection<Answer> Answers { get; set; }
        public Resume Resume { get; set; }
        public Portfolio Portfolio { get; set; }
        public ICollection<Notification> Notifications { get; set; }
    }
}
