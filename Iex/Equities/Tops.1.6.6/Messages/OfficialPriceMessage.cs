using System.Runtime.InteropServices;

namespace Iex.Tops;

/// <summary>
///  Official Price Message: Official Price Messages are sent for each IEX-listed security to indicate the IEX Official Opening Price and IEX Official Closing Price.
/// </summary>

public partial class OfficialPriceMessage
{
    /// <summary>
    ///  Price type identifier
    /// </summary>
    public PriceType PriceType => Fields.PriceType.Value;

    /// <summary>
    ///  Time stamp of the system event
    /// </summary>
    public DateTime Timestamp => Fields.Timestamp.Value;

    /// <summary>
    ///  Security identifier
    /// </summary>
    public string Symbol => Fields.Symbol.Value;

    /// <summary>
    ///  Official opening or closing price, as specified
    /// </summary>
    public long OfficialPrice => Fields.OfficialPrice.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public PriceType PriceType;
        public Timestamp Timestamp;
        public Symbol Symbol;
        public OfficialPrice OfficialPrice;
    };

    protected Layout Fields;
};
