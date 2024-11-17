using Metzkins.Data.Lib.UnitOfWork;
using Stock.Lib.Data.PgStockTrader;

namespace Stock.Lib.Data.Repository;

public class IntradayPriceRepository : Repository<IntradayPrice>
{
    public IntradayPriceRepository(StockDbContext context) : base(context)
    {
    }

    // Add any IntradayPrice-specific repository methods here if needed.
}