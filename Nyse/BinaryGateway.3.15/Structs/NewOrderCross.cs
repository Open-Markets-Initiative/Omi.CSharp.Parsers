using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  New Order Cross
    /// </summary>

    public partial class NewOrderCross
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            SeqMsgHeader SeqMsgHeader;
            CrossId CrossId;
            AllocationPct AllocationPct;
            ClearingFirmExposed ClearingFirmExposed;
            ClearingAccountExposed ClearingAccountExposed;
            ClearingFirmCovered ClearingFirmCovered;
            ClearingAccountCovered ClearingAccountCovered;
            Reserved16 Reserved16;
            Exposed Exposed;
        };
    };
}