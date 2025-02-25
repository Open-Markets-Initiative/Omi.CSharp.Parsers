using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Risk Control Alert
    /// </summary>

    public partial class RiskControlAlert
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
            public RiskUserCrd RiskUserCrd;
            public RiskUserType RiskUserType;
            public RiskControlType RiskControlType;
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
            public RiskActionType RiskActionType;
            public ThresholdBreachLevel ThresholdBreachLevel;
            public BlockedByBreachIndicator BlockedByBreachIndicator;
            public BlockedByKillSwitchIndicator BlockedByKillSwitchIndicator;
            public ReinstatementRequiredbySelf ReinstatementRequiredbySelf;
            public ReinstatementRequiredbyOther ReinstatementRequiredbyOther;
            public Reserved200 Reserved200;
        };
    };
}