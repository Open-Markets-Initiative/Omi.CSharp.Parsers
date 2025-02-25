using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth;

/// <summary>
///  Add Order Long Message: An Add Order Message indicates that a new order has been accepted by the options system and was added to the displayable book. The message includes a day-unique Order Reference Number used by options system to track the order.
/// </summary>

public partial class AddOrderLongMessage
{
    /// <summary>
    ///  Nanoseconds portion of the timestamp.
    /// </summary>
    public uint Timestamp => Layout.Timestamp.Value;

    /// <summary>
    ///  The unique reference number delta assigned to the new order. The order reference number is Increasing, but not necessarily sequential.
    /// </summary>
    public uint OrderReferenceNumberDelta => Layout.OrderReferenceNumberDelta.Value;

    /// <summary>
    ///  The type of order being added. Note: AON order is not posted on the option’s book. Hence it should not be used to calculate the best bid/ask.
    /// </summary>
    public MarketSide MarketSide => Layout.MarketSide.Value;

    /// <summary>
    ///  Option ID assigned daily, valid for trading day.
    /// </summary>
    public uint OptionId => Layout.OptionId.Value;

    /// <summary>
    ///  NOTE: When converted to a decimal format, this price is in fixed point format with 6 whole number places followed by 4 decimal digits. The display price of the new order being added to the book.
    /// </summary>
    public int Price => Layout.Price.Value;

    /// <summary>
    ///  The total number of contracts of the new order being added to the book.
    /// </summary>
    public uint Volume => Layout.Volume.Value;

    /// <summary>
    ///  PHLX assigned order ID.
    /// </summary>
    public uint OrderId => Layout.OrderId.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public Timestamp Timestamp;
        public OrderReferenceNumberDelta OrderReferenceNumberDelta;
        public MarketSide MarketSide;
        public OptionId OptionId;
        public Price Price;
        public Volume Volume;
        public OrderId OrderId;
    };
};
