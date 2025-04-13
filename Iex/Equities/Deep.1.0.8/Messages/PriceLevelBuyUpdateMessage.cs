using System.Runtime.InteropServices;

namespace Iex.Deep;

/// <summary>
///  Price Level Buy Update Message: Deep broadcasts a real-time Price Level Update Message each time a displayed price level on IEX is updated during the trading day
/// </summary>

public partial class PriceLevelBuyUpdateMessage
{
    /// <summary>
    ///  Identifies event processing by the System
    /// </summary>
    public EventFlags EventFlags => Fields.EventFlags.Value;

    /// <summary>
    ///  Time stamp of the system event
    /// </summary>
    public DateTime Timestamp => Fields.Timestamp.Value;

    /// <summary>
    ///  Security identifier
    /// </summary>
    public string Symbol => Fields.Symbol.Value;

    /// <summary>
    ///  Aggregate quoted size
    /// </summary>
    public uint Size => Fields.Size.Value;

    /// <summary>
    ///  Price level to add/update in the IEX Order Book
    /// </summary>
    public long Price => Fields.Price.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public EventFlags EventFlags;
        public Timestamp Timestamp;
        public Symbol Symbol;
        public Size Size;
        public Price Price;
    };

    protected Layout Fields;
};
