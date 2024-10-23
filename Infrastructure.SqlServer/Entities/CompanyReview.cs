
namespace Infrastructure.SqlServer.Entities
{
    public class CompanyReview
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int UserId  { get; set; }
        public int Rating { get; set; }
        public string ReviewText { get; set; }
        public DateTime ReviewDate { get; set; }

      
        public User User { get; set; }
        public Company Company { get; set; }
    }
}
