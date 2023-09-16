using System.Runtime.InteropServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Tes Trade Report
    /// </summary>

    public partial class TesTradeReport
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            SecurityId SecurityId;
            TransactTime TransactTime;
            LastQty LastQty;
            LastPx LastPx;
            TrdMatchId TrdMatchId;
            TrdType TrdType;
            TradeCondition TradeCondition;
            MultiLegReportingType MultiLegReportingType;
            MultiLegPriceModel MultiLegPriceModel;
            Pad6 Pad6;
            NonDisclosedTradeVolume NonDisclosedTradeVolume;
        };
    };
}