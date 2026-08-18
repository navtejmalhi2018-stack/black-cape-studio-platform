namespace Domain.Entities;

public class PortfolioItem
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string YoutubeUrl { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
}