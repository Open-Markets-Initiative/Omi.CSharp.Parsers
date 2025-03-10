using System.Runtime.InteropServices;

namespace Iex.Tops;

/// <summary>
///  Quote Update Message: Tops broadcasts a real-time Quote Update Message each time IEX's best bid or offer quotation is updated during the trading day
/// </summary>

public partial class QuoteUpdateMessage
{

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
};
