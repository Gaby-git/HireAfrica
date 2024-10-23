
namespace Infrastructure.SqlServer.Entities
{
    public class Resume
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FilePath { get; set; }
        public DateTime UploadDate { get; set; }

        
        public User User { get; set; }
    }
}
