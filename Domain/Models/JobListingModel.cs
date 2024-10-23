namespace Domain.Models;

public class JobListingModel
{
    public int JobId { get; set; } = default;
    public string JobTitle { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public decimal Salary { get; set; } = default;
    public EmploymentType Employment { get; set; }
    public int HoursOfWork { get; set; }
    public List<string> RequiredSkills { get; set; } = default!;
    public string EducationLevel { get; set; } = string.Empty;
    public ExperienceLevel Experience { get; set; }
}

public enum EmploymentType
{
    FullTime,
    PartTime,
    Contract
}

public enum ExperienceLevel
{
    Entry,
    Mid,
    Senior
}