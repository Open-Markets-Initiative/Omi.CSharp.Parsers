using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Quote Request: QuoteRequest
    /// </summary>

    public partial class QuoteRequest
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            TransactTime TransactTime;
            MatchEventIndicator MatchEventIndicator;
            QuoteReqId QuoteReqId;
        };
    };
}