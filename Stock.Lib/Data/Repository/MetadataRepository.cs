using Metzkins.Data.Lib.UnitOfWork;
using Stock.Lib.Data.PgStockTrader;

namespace Stock.Lib.Data.Repository;

public class MetadataRepository : Repository<Metadata>
{
    public MetadataRepository(StockDbContext context) : base(context)
    {
    }

    // Add any Metadata-specific repository methods here if needed.
}