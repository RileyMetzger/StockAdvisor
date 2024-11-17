using Metzkins.Data.Lib.UnitOfWork;
using Stock.Lib.Data.PgStockTrader;

namespace Stock.Lib.Data.Repository;

public class HistoricalDividendRepository : Repository<HistoricalDividend>
{
    public HistoricalDividendRepository(StockDbContext context) : base(context)
    {
    }

    // Add any HistoricalDividend-specific repository methods here if needed.
}