using System.Runtime.InteropServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Md Instrument Entry Grp Comp
    /// </summary>

    public partial class MdInstrumentEntryGrpComp
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public MdEntryPx MdEntryPx;
            public MdEntrySize MdEntrySize;
            public MdOriginType MdOriginType;
            public MdEntryType MdEntryType;
            public TradeCondition TradeCondition;
            public TrdType TrdType;
            public MultiLegReportingType MultiLegReportingType;
            public MultiLegPriceModel MultiLegPriceModel;
            public NonDisclosedTradeVolume NonDisclosedTradeVolume;
        };
    };
}