using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway;

/// <summary>
///  Bulk Quote
/// </summary>

public partial class BulkQuote
{
    /// <summary>
    ///  Options series index
    /// </summary>
    public uint SeriesIndex => Layout.SeriesIndex.Value;

    /// <summary>
    ///  Bitfield (containing Side and Type)
    /// </summary>
    public byte BitFieldQuoteInst => Layout.BitFieldQuoteInst.Value;

    /// <summary>
    ///  0.01 - 9,999.99
    /// </summary>
    public long PricePrice8 => Layout.PricePrice8.Value;

    /// <summary>
    ///  1 - 999,999
    /// </summary>
    public uint OrderQty => Layout.OrderQty.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public SeriesIndex SeriesIndex;
        public BitFieldQuoteInst BitFieldQuoteInst;
        public PricePrice8 PricePrice8;
        public OrderQty OrderQty;
    };
};
