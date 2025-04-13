using System.Runtime.InteropServices;

namespace Eurex.Eobi;

/// <summary>
///  Product State Change
/// </summary>

public partial class ProductStateChange
{
    /// <summary>
    ///  Trading Session Id
    /// </summary>
    public TradingSessionId TradingSessionId => Fields.TradingSessionId.Value;

    /// <summary>
    ///  Trading Session Sub Id
    /// </summary>
    public TradingSessionSubId TradingSessionSubId => Fields.TradingSessionSubId.Value;

    /// <summary>
    ///  Trad Ses Status
    /// </summary>
    public TradSesStatus TradSesStatus => Fields.TradSesStatus.Value;

    /// <summary>
    ///  Market Condition
    /// </summary>
    public MarketCondition MarketCondition => Fields.MarketCondition.Value;

    /// <summary>
    ///  Fast Market Indicator
    /// </summary>
    public FastMarketIndicator FastMarketIndicator => Fields.FastMarketIndicator.Value;

    /// <summary>
    ///  Tes Trad Ses Status
    /// </summary>
    public TesTradSesStatus TesTradSesStatus => Fields.TesTradSesStatus.Value;

    /// <summary>
    ///  Pad 2
    /// </summary>
    public string Pad2 => Fields.Pad2.Value;

    /// <summary>
    ///  Transact Time
    /// </summary>
    public DateTime TransactTime => Fields.TransactTime.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public TradingSessionId TradingSessionId;
        public TradingSessionSubId TradingSessionSubId;
        public TradSesStatus TradSesStatus;
        public MarketCondition MarketCondition;
        public FastMarketIndicator FastMarketIndicator;
        public TesTradSesStatus TesTradSesStatus;
        public Pad2 Pad2;
        public TransactTime TransactTime;
    };

    protected Layout Fields;
};
