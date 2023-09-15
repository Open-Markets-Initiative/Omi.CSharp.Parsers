using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Risk Action Request
    /// </summary>

    public partial class RiskActionRequest
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            SeqMsgHeader SeqMsgHeader;
            SymbolId SymbolId;
            Mpid Mpid;
            MarketMaker MarketMaker;
            MpSubId MpSubId;
            FloorBrokerFirmCrd FloorBrokerFirmCrd;
            ClearingNumber ClearingNumber;
            ClOrdId ClOrdId;
            RiskUserCrd RiskUserCrd;
            RiskUserType RiskUserType;
            RiskControlType RiskControlType;
            RiskActionType RiskActionType;
            Reserved200 Reserved200;
        };
    };
}