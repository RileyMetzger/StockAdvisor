namespace Stock.Lib.Data.PgStockTrader;

public class Company
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string TickerSymbol { get; set; }
    public string Industry { get; set; }
    public string Sector { get; set; }
    public string Country { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<DailyPrice> DailyPrices { get; set; }
    public ICollection<HistoricalDividend> HistoricalDividends { get; set; }
    public ICollection<IntradayPrice> IntradayPrices { get; set; }
    public Metadata Metadata { get; set; }
    public ICollection<SplitHistory> SplitHistories { get; set; }
}