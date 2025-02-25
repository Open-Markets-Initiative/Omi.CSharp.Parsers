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
            public SecurityId SecurityId;
            public TransactTime TransactTime;
            public LastQty LastQty;
            public LastPx LastPx;
            public TrdMatchId TrdMatchId;
            public TrdType TrdType;
            public TradeCondition TradeCondition;
            public MultiLegReportingType MultiLegReportingType;
            public MultiLegPriceModel MultiLegPriceModel;
            public Pad6 Pad6;
            public NonDisclosedTradeVolume NonDisclosedTradeVolume;
        };
    };
}