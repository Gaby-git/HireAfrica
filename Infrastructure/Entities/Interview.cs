

namespace Infrastructure.SqlServer.Entities
{
    public class Interview
    {
        public int Id { get; set; }
        public int JobListingId { get; set; }
        public int ApplicationId { get; set; }
        public DateTime InterviewDate { get; set; }
        public string InterviewType { get; set; } 
        public string InterviewerName { get; set; }
        public string InterviewerFeedback { get; set; }

        
        public JobListing JobListing { get; set; }
        public Application Application { get; set; }
    }
}
