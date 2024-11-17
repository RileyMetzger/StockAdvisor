using Metzkins.Data.Lib.UnitOfWork;
using Stock.Lib.Data.Repository;

namespace Stock.Lib.Data;

public interface IStockDbUnitOfWork : IUnitOfWork
{
    CompanyRepository Companies { get; }
    DailyPriceRepository DailyPrices { get; }
    HistoricalDividendRepository HistoricalDividends { get; }
    IntradayPriceRepository IntradayPrices { get; }
    MetadataRepository Metadata { get; }
    SplitHistoryRepository SplitHistories { get; }
}