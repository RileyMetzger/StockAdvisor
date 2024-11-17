namespace Stock.Lib.Data.PgStockTrader;

public class HistoricalDividend
{
    public int Id { get; set; }
    public int CompanyId { get; set; }
    public Company Company { get; set; }
    public DateTime? DeclarationDate { get; set; }
    public DateTime? ExDividendDate { get; set; }
    public DateTime? PaymentDate { get; set; }
    public decimal? DividendAmount { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}