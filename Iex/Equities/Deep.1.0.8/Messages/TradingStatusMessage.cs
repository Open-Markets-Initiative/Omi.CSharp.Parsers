using System.Runtime.InteropServices;

namespace Iex.Deep
{
    /// <summary>
    ///  Trading Status Message: The Trading Status Message is used to indicate the current trading status of a security.
    /// </summary>

    public partial class TradingStatusMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public TradingStatus TradingStatus;
            public Timestamp Timestamp;
            public Symbol Symbol;
            public Reason Reason;
        };
    };
}