using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Quote Request: QuoteRequest
    /// </summary>

    public partial class QuoteRequest
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public TransactTime TransactTime;
            public QuoteReqId QuoteReqId;
            public MatchEventIndicator MatchEventIndicator;
            public Padding3 Padding3;
        };
    };
}