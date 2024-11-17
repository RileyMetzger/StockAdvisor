using Metzkins.Data.Lib.UnitOfWork;
using Stock.Lib.Data.PgStockTrader;

namespace Stock.Lib.Data.Repository;

public class DailyPriceRepository : Repository<DailyPrice>
{
    public DailyPriceRepository(StockDbContext context) : base(context)
    {
    }

    // Add any DailyPrice-specific repository methods here if needed.
}