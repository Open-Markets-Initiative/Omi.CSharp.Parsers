using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Trade Flags: Trage Message Flags
    /// </summary>

    public partial class TradeFlags
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            IsRfcCrossing IsRfcCrossing;
            IsLegDealOutsideIpl IsLegDealOutsideIpl;
            IsImpliedOrder IsImpliedOrder;
            IsVerticalSplit IsVerticalSplit;
            FutureTradeFlags FutureTradeFlags;
        };
    };
}