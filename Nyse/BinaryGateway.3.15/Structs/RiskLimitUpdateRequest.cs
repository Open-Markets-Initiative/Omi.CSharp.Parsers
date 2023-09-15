using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Risk Limit Update Request
    /// </summary>

    public partial class RiskLimitUpdateRequest
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
            RiskControlActivation RiskControlActivation;
            UsdLimit UsdLimit;
            TimeLimit TimeLimit;
            PercentageLimit PercentageLimit;
            CountLimit CountLimit;
            BreachActionRequest BreachActionRequest;
            IocAttribution IocAttribution;
            Reserved200 Reserved200;
        };
    };
}