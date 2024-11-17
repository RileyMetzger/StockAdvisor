using Microsoft.EntityFrameworkCore;

namespace Stock.Lib.Data.PgStockTrader;

public class StockDbContext : DbContext
{
    public DbSet<Company> Companies { get; set; }
    public DbSet<DailyPrice> DailyPrices { get; set; }
    public DbSet<HistoricalDividend> HistoricalDividends { get; set; }
    public DbSet<IntradayPrice> IntradayPrices { get; set; }
    public DbSet<Metadata> Metadata { get; set; }
    public DbSet<SplitHistory> SplitHistories { get; set; }

    public StockDbContext(DbContextOptions<StockDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Company>()
            .HasIndex(c => c.TickerSymbol)
            .IsUnique();

        modelBuilder.Entity<DailyPrice>()
            .HasIndex(dp => new { dp.CompanyId, dp.Date })
            .IsUnique();

        modelBuilder.Entity<IntradayPrice>()
            .HasIndex(ip => new { ip.CompanyId, ip.Timestamp })
            .IsUnique();

        modelBuilder.Entity<Company>()
            .HasMany(c => c.DailyPrices)
            .WithOne(dp => dp.Company)
            .HasForeignKey(dp => dp.CompanyId);

        modelBuilder.Entity<Company>()
            .HasMany(c => c.HistoricalDividends)
            .WithOne(hd => hd.Company)
            .HasForeignKey(hd => hd.CompanyId);

        modelBuilder.Entity<Company>()
            .HasMany(c => c.IntradayPrices)
            .WithOne(ip => ip.Company)
            .HasForeignKey(ip => ip.CompanyId);

        modelBuilder.Entity<Company>()
            .HasOne(c => c.Metadata)
            .WithOne(m => m.Company)
            .HasForeignKey<Metadata>(m => m.CompanyId);

        modelBuilder.Entity<Company>()
            .HasMany(c => c.SplitHistories)
            .WithOne(sh => sh.Company)
            .HasForeignKey(sh => sh.CompanyId);
    }
}