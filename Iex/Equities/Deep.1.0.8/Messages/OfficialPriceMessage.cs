using System.Runtime.InteropServices;

namespace Iex.Deep
{
    /// <summary>
    ///  Official Price Message: Official Price Messages are sent for each IEX-listed security to indicate the IEX Official Opening Price and IEX Official Closing Price.
    /// </summary>

    public partial class OfficialPriceMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public PriceType PriceType;
            public Timestamp Timestamp;
            public Symbol Symbol;
            public OfficialPrice OfficialPrice;
        };
    };
}