
using static System.Net.Mime.MediaTypeNames;

namespace Infrastructure.SqlServer.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }
        public string WorkField { get; set; }
        public int NumberOfWorkers { get; set; }
        public DateTime YearOfCreation { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Website { get; set; }
        public string Industry { get; set; }
        public string LinkedInPage { get; set; }

      
        public ICollection<JobListing> JobListings { get; set; }
        public ICollection<CompanyReview> Reviews { get; set; }
        public ICollection<Application> Applications { get; set; }
    }
}
