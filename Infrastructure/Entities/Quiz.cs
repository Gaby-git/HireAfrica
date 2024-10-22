
namespace Infrastructure.Entities
{
    public class Quiz
    {
        public int Id { get; set; }
        public int JobListingId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int QuestionCount { get; set; }
        public TimeSpan Duration { get; set; }
        public float PassPercentage { get; set; }
        public DateTime CreationDate { get; set; }

        
        public ICollection<Question> Questions { get; set; }
        public ICollection<Answer> Answers { get; set; }
        public JobListing JobListing { get; set; }
       
    }
}
