using System.Runtime.InteropServices;

namespace Eurex.T7
{
    /// <summary>
    ///  Cross Request
    /// </summary>

    public partial class CrossRequest
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            SecurityId SecurityId;
            LastPx LastPx;
            LastQty LastQty;
            Side Side;
            CrossRequestType CrossRequestType;
            InputSource InputSource;
            Pad5 Pad5;
            TransactTime TransactTime;
        };
    };
}