﻿namespace Stock.Lib.Data.PgStockTrader;

public class IntradayPrice
{
    public int Id { get; set; }
    public int CompanyId { get; set; }
    public Company Company { get; set; }
    public DateTime Timestamp { get; set; }
    public decimal? Open { get; set; }
    public decimal? High { get; set; }
    public decimal? Low { get; set; }
    public decimal? Close { get; set; }
    public long? Volume { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}