using System.Runtime.InteropServices;

namespace Iex.Tops;

/// <summary>
///  Quote Update Message: Tops broadcasts a real-time Quote Update Message each time IEX's best bid or offer quotation is updated during the trading day
/// </summary>

public partial class QuoteUpdateMessage
{
    /// <summary>
    ///  Quote Update Flags
    /// </summary>
    public string QuoteUpdateFlags => Fields.QuoteUpdateFlags.Value;

    /// <summary>
    ///  Time stamp of the system event
    /// </summary>
    public DateTime Timestamp => Fields.Timestamp.Value;

    /// <summary>
    ///  Security identifier
    /// </summary>
    public string Symbol => Fields.Symbol.Value;

    /// <summary>
    ///  Aggregate quoted best bid size
    /// </summary>
    public uint BidSize => Fields.BidSize.Value;

    /// <summary>
    ///  Best quoted bid price
    /// </summary>
    public long BidPrice => Fields.BidPrice.Value;

    /// <summary>
    ///  Best quoted ask price
    /// </summary>
    public long AskPrice => Fields.AskPrice.Value;

    /// <summary>
    ///  Aggregate quoted best ask size
    /// </summary>
    public uint AskSize => Fields.AskSize.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public QuoteUpdateFlags QuoteUpdateFlags;
        public Timestamp Timestamp;
        public Symbol Symbol;
        public BidSize BidSize;
        public BidPrice BidPrice;
        public AskPrice AskPrice;
        public AskSize AskSize;
    };

    protected Layout Fields;
};
