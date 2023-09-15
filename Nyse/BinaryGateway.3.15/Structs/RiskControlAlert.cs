using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Risk Control Alert
    /// </summary>

    public partial class RiskControlAlert
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
            RiskUserCrd RiskUserCrd;
            RiskUserType RiskUserType;
            RiskControlType RiskControlType;
            UsdLimit UsdLimit;
            TimeLimit TimeLimit;
            PercentageLimit PercentageLimit;
            CountLimit CountLimit;
            BreachActionResponse BreachActionResponse;
            IocAttribution IocAttribution;
            UsdCalculation1 UsdCalculation1;
            UsdCalculation2 UsdCalculation2;
            UsdCalculation3 UsdCalculation3;
            UsdCalculation4 UsdCalculation4;
            CountCalculation CountCalculation;
            RiskActionType RiskActionType;
            ThresholdBreachLevel ThresholdBreachLevel;
            BlockedByBreachIndicator BlockedByBreachIndicator;
            BlockedByKillSwitchIndicator BlockedByKillSwitchIndicator;
            ReinstatementRequiredbySelf ReinstatementRequiredbySelf;
            ReinstatementRequiredbyOther ReinstatementRequiredbyOther;
            Reserved200 Reserved200;
        };
    };
}