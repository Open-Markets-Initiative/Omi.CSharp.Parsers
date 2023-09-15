using System.Runtime.InteropServices;

namespace Eurex.T7
{
    /// <summary>
    ///  Quote Request
    /// </summary>

    public partial class QuoteRequest
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            SecurityId SecurityId;
            LastQty LastQty;
            Side Side;
            Pad7 Pad7;
            TransactTime TransactTime;
        };
    };
}