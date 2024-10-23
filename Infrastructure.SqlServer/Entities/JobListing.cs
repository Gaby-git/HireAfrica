

namespace Infrastructure.SqlServer.Entities
{
    public class JobListing
    {
        public int Id { get; set; }
        public int AppicationId { get; set; }
        public int CompanyId { get; set; }
        public string JobTitle { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public decimal Salary { get; set; }
        public string EmploymentType { get; set; }
        public int HoursOfWork { get; set; }
        public List<string> RequiredSkills { get; set; }
        public string EducationLevel { get; set; }
        public string ExperienceLevel { get; set; } 

     
        public Application Application { get; set; }
        public Company Company { get; set; }
        public Quiz Quiz { get; set; }
        public ICollection<Interview> Interviews { get; set; }

    }
}
