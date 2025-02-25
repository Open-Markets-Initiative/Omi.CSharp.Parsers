using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  New Order Cross
    /// </summary>

    public partial class NewOrderCross
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public SeqMsgHeader SeqMsgHeader;
            public CrossId CrossId;
            public AllocationPct AllocationPct;
            public ClearingFirmExposed ClearingFirmExposed;
            public ClearingAccountExposed ClearingAccountExposed;
            public ClearingFirmCovered ClearingFirmCovered;
            public ClearingAccountCovered ClearingAccountCovered;
            public Reserved16 Reserved16;
            public Exposed Exposed;
        };
    };
}