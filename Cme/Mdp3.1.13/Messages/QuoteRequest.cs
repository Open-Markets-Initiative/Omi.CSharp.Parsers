using System.Runtime.InteropServices;

namespace Cme.Sbe
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
            QuoteReqId QuoteReqId;
            MatchEventIndicator MatchEventIndicator;
            Padding3 Padding3;
        };
    };
}