namespace Domain.Models;
public class PortfolioItemModel
{
    public int ItemId { get; set; }
    public int UserId { get; set; }
    public string Link { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime Date { get; set; }

}
