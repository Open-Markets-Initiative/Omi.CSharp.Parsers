using System.Runtime.InteropServices;

namespace Eurex.Eobi;

/// <summary>
///  Cross Request
/// </summary>

public partial class CrossRequest
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public SecurityId SecurityId;
        public LastPx LastPx;
        public LastQty LastQty;
        public Side Side;
        public CrossRequestType CrossRequestType;
        public InputSource InputSource;
        public Pad5 Pad5;
        public TransactTime TransactTime;
    };
};
