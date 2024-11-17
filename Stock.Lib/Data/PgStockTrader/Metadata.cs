namespace Stock.Lib.Data.PgStockTrader;

public class Metadata
{
    public int Id { get; set; }
    public int CompanyId { get; set; }
    public Company Company { get; set; }
    public DateTime? LastDailyUpdate { get; set; }
    public DateTime? LastIntradayUpdate { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}