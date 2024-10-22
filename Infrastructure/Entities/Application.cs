
namespace Infrastructure.Entities
{
    public class Application
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int JobListingId { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string Status { get; set; } 
        public float Score { get; set; }
        public int UserId { get; set; }
     
        public User User { get; set; }
        public ICollection<JobListing> JobListings { get; set; }
        public Company Company { get; set; }
        public ICollection<Interview> Interview { get; set; }

        
    }
}
