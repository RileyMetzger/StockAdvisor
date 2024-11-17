namespace Stock.Lib.Data.PgStockTrader;

public class DailyPrice
{
    public int Id { get; set; }
    public int CompanyId { get; set; }
    public Company Company { get; set; }
    public DateTime Date { get; set; }
    public decimal? Open { get; set; }
    public decimal? High { get; set; }
    public decimal? Low { get; set; }
    public decimal? Close { get; set; }
    public long? Volume { get; set; }
    public decimal? AdjustedClose { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}