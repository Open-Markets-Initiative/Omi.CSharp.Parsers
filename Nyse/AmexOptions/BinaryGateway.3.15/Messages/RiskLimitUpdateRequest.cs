using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Risk Limit Update Request
    /// </summary>

    public partial class RiskLimitUpdateRequest
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
            public RiskControlActivation RiskControlActivation;
            public UsdLimit UsdLimit;
            public TimeLimit TimeLimit;
            public PercentageLimit PercentageLimit;
            public CountLimit CountLimit;
            public BreachActionRequest BreachActionRequest;
            public IocAttribution IocAttribution;
            public Reserved200 Reserved200;
        };
    };
}