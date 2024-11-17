using Metzkins.Data.Lib.UnitOfWork;
using Stock.Lib.Data.PgStockTrader;

namespace Stock.Lib.Data.Repository;

public class SplitHistoryRepository : Repository<SplitHistory>
{
    public SplitHistoryRepository(StockDbContext context) : base(context)
    {
    }

    // Add any SplitHistory-specific repository methods here if needed.
}