namespace Domain.Models;

using System.ComponentModel.DataAnnotations;

public class UserModel
{
    public int UserId { get; set; } = default;

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public DateTime DateOfBirth { get; set; }

    public string Profession { get; set; } = string.Empty;

    public int YearsOfExperience { get; set; }

    public string PhoneNumber { get; set; } = string.Empty;

    public string Sex { get; set; } = string.Empty;

    public string Country { get; set; } = string.Empty;

    public byte[] Resume { get; set; }

    public List<SkillModel> Skills { get; set; } = new List<SkillModel>();

    public string LinkedInProfile { get; set; } = string.Empty;

    [Url]
    public string PreferredJobType {  get; set; } = string.Empty;

}
