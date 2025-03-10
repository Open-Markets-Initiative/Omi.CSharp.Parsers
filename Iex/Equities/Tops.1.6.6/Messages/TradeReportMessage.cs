using System.Runtime.InteropServices;

namespace Iex.Tops;

/// <summary>
///  Trade Report Message: Trade Report Messages are sent when an order on the IEX Order Book is executed in whole or in part
/// </summary>

public partial class TradeReportMessage
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public SaleConditionFlags SaleConditionFlags;
        public Timestamp Timestamp;
        public Symbol Symbol;
        public Size Size;
        public Price Price;
        public TradeId TradeId;
    };
};
