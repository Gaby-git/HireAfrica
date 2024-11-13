namespace Domain.Models;
using System;
using System.Collections.Generic;

public class JobApplicationModel
{
    public int ApplicationId { get; set; }
    public int UserId { get; set; }
    public int JobId { get; set; }
    public DateTime ApplicationDate { get; set; }
    public byte[] CVFile { get; set; } = default!;
    public List<PortfolioItemModel> Portfolio { get; set; } = new List<PortfolioItemModel>();
}
