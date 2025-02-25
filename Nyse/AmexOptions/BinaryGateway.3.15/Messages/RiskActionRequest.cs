using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Risk Action Request
    /// </summary>

    public partial class RiskActionRequest
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public SeqMsgHeader SeqMsgHeader;
            public SymbolId SymbolId;
            public Mpid Mpid;
            public MarketMaker MarketMaker;
            public MpSubId MpSubId;
            public FloorBrokerFirmCrd FloorBrokerFirmCrd;
            public ClearingNumber ClearingNumber;
            public ClOrdId ClOrdId;
            public RiskUserCrd RiskUserCrd;
            public RiskUserType RiskUserType;
            public RiskControlType RiskControlType;
            public RiskActionType RiskActionType;
            public Reserved200 Reserved200;
        };
    };
}