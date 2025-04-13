using System.Runtime.InteropServices;

namespace Iex.Tops;

/// <summary>
///  Retail Liquidity Indicator Message: broadcasts a real-time Retail Liquidity Indicator Message each time there is an update to IEX's eligible retail liquidity interest during the trading day
/// </summary>

public partial class RetailLiquidityIndicatorMessage
{
    /// <summary>
    ///  Retail Liquidity Indicator identifier
    /// </summary>
    public RetailLiquidityIndicator RetailLiquidityIndicator => Fields.RetailLiquidityIndicator.Value;

    /// <summary>
    ///  Time stamp of the system event
    /// </summary>
    public DateTime Timestamp => Fields.Timestamp.Value;

    /// <summary>
    ///  Security identifier
    /// </summary>
    public string Symbol => Fields.Symbol.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public RetailLiquidityIndicator RetailLiquidityIndicator;
        public Timestamp Timestamp;
        public Symbol Symbol;
    };

    protected Layout Fields;
};
