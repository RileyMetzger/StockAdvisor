using Metzkins.Data.Lib.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Stock.Lib.Data.PgStockTrader;
using Stock.Lib.Data.Repository;

namespace Stock.Lib.Data;

public class StockDbUnitOfWork : UnitOfWork<StockDbContext>, IStockDbUnitOfWork
{
    private readonly Lazy<CompanyRepository> _companies;
    private readonly Lazy<DailyPriceRepository> _dailyPrices;
    private readonly Lazy<HistoricalDividendRepository> _historicalDividends;
    private readonly Lazy<IntradayPriceRepository> _intradayPrices;
    private readonly Lazy<MetadataRepository> _metadata;
    private readonly Lazy<SplitHistoryRepository> _splitHistories;


    public CompanyRepository Companies => _companies.Value;
    public DailyPriceRepository DailyPrices => _dailyPrices.Value;
    public HistoricalDividendRepository HistoricalDividends => _historicalDividends.Value;
    public IntradayPriceRepository IntradayPrices => _intradayPrices.Value;
    public MetadataRepository Metadata => _metadata.Value;
    public SplitHistoryRepository SplitHistories => _splitHistories.Value;


    public override bool SupportsTransactions { get; }

    public StockDbUnitOfWork(StockDbContext context) : base(context)
    {
        _companies = new Lazy<CompanyRepository>(() => new CompanyRepository(context));
        _dailyPrices = new Lazy<DailyPriceRepository>(() => new DailyPriceRepository(context));
        _historicalDividends = new Lazy<HistoricalDividendRepository>(() => new HistoricalDividendRepository(context));
        _intradayPrices = new Lazy<IntradayPriceRepository>(() => new IntradayPriceRepository(context));
        _metadata = new Lazy<MetadataRepository>(() => new MetadataRepository(context));
        _splitHistories = new Lazy<SplitHistoryRepository>(() => new SplitHistoryRepository(context));

        SupportsTransactions = context.Database.IsRelational();
    }

    
}