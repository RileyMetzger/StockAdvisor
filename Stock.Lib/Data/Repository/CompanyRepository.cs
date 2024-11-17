using Metzkins.Data.Lib.UnitOfWork;
using Stock.Lib.Data.PgStockTrader;

namespace Stock.Lib.Data.Repository;

public class CompanyRepository : Repository<Company>
{
    public CompanyRepository(StockDbContext context) : base(context)
    {
    }

    // Add any Company-specific repository methods here if needed.
}