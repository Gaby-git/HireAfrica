namespace Domain.JobApplicationModels;
public class JobApplicationModel
{
    public int ApplicationId { get; set; } = default;
    public DateTime ApplicationDate { get; set; }
    public string CandidateName { get; set; } = string.Empty;
    public byte[] CVFile { get; set; } = default!;
    public List<PortfolioItem> Portfolio { get; set; } = new List<PortfolioItem>();
}

public class PortfolioItem
{
    public string Link { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime Date { get; set; }
}
