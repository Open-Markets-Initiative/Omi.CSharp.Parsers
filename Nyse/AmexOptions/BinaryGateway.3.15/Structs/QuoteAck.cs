using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway;

/// <summary>
///  Quote Ack
/// </summary>

public partial class QuoteAck
{
    /// <summary>
    ///  Options series index
    /// </summary>
    public uint SeriesIndex => Layout.SeriesIndex.Value;

    /// <summary>
    ///  Side
    /// </summary>
    public byte SideU81 => Layout.SideU81.Value;

    /// <summary>
    ///  AckType
    /// </summary>
    public AckType AckType => Layout.AckType.Value;

    /// <summary>
    ///  0.01 - 9,999.99
    /// </summary>
    public long PricePrice8 => Layout.PricePrice8.Value;

    /// <summary>
    ///  0 - 999,999
    /// </summary>
    public uint Quantity => Layout.Quantity.Value;

    /// <summary>
    ///  These reason codes are provided by the matching engine and qualify the event that produced the message. See Appendix for list of values.
    /// </summary>
    public ReasonCode ReasonCode => Layout.ReasonCode.Value;

    /// <summary>
    ///  0 = Working Price is equal to Display Price 1 = Working Price is different from Display Price
    /// </summary>
    public byte WorkingAwayFromDisplay => Layout.WorkingAwayFromDisplay.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public SeriesIndex SeriesIndex;
        public SideU81 SideU81;
        public AckType AckType;
        public PricePrice8 PricePrice8;
        public Quantity Quantity;
        public ReasonCode ReasonCode;
        public WorkingAwayFromDisplay WorkingAwayFromDisplay;
    };
};
