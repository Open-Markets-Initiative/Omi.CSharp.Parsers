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
            SeqMsgHeader SeqMsgHeader;
            SymbolId SymbolId;
            Mpid Mpid;
            MarketMaker MarketMaker;
            MpSubId MpSubId;
            FloorBrokerFirmCrd FloorBrokerFirmCrd;
            ClearingNumber ClearingNumber;
            ClOrdId ClOrdId;
            RiskAckType RiskAckType;
            RiskUserCrd RiskUserCrd;
            RiskUserType RiskUserType;
            RiskControlType RiskControlType;
            RiskControlActivation RiskControlActivation;
            RiskActionType RiskActionType;
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
            BlockedByBreachIndicator BlockedByBreachIndicator;
            BlockedByKillSwitchIndicator BlockedByKillSwitchIndicator;
            ReinstatementRequiredbySelf ReinstatementRequiredbySelf;
            ReinstatementRequiredbyOther ReinstatementRequiredbyOther;
            Reserved200 Reserved200;
        };
    };
}