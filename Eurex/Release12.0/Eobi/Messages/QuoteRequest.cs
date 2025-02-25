using System.Runtime.InteropServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Quote Request
    /// </summary>

    public partial class QuoteRequest
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public SecurityId SecurityId;
            public LastQty LastQty;
            public Side Side;
            public Pad7 Pad7;
            public TransactTime TransactTime;
        };
    };
}