namespace Stock.Lib.Data.PgStockTrader;

public class SplitHistory
{
    public int Id { get; set; }
    public int CompanyId { get; set; }
    public Company Company { get; set; }
    public DateTime? SplitDate { get; set; }
    public string SplitRatio { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}