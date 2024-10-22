

namespace Infrastructure.Entities
{
    public class Portfolio
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string PortfolioURL { get; set; }
        public string Description { get; set; }
        public DateTime UploadDate { get; set; }


        public User User { get; set; }
    }
}
