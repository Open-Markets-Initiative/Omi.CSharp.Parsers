using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Risk Control Acknowledgement
    /// </summary>

    public partial class RiskControlAcknowledgement
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
            public RiskAckType RiskAckType;
            public RiskUserCrd RiskUserCrd;
            public RiskUserType RiskUserType;
            public RiskControlType RiskControlType;
            public RiskControlActivation RiskControlActivation;
            public RiskActionType RiskActionType;
            public UsdLimit UsdLimit;
            public TimeLimit TimeLimit;
            public PercentageLimit PercentageLimit;
            public CountLimit CountLimit;
            public BreachActionResponse BreachActionResponse;
            public IocAttribution IocAttribution;
            public UsdCalculation1 UsdCalculation1;
            public UsdCalculation2 UsdCalculation2;
            public UsdCalculation3 UsdCalculation3;
            public UsdCalculation4 UsdCalculation4;
            public CountCalculation CountCalculation;
            public BlockedByBreachIndicator BlockedByBreachIndicator;
            public BlockedByKillSwitchIndicator BlockedByKillSwitchIndicator;
            public ReinstatementRequiredbySelf ReinstatementRequiredbySelf;
            public ReinstatementRequiredbyOther ReinstatementRequiredbyOther;
            public Reserved200 Reserved200;
        };
    };
}