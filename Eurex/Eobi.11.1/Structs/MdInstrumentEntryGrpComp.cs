using System.Runtime.InteropServices;

namespace Eurex.T7
{
    /// <summary>
    ///  Md Instrument Entry Grp Comp
    /// </summary>

    public partial class MdInstrumentEntryGrpComp
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MdEntryPx MdEntryPx;
            MdEntrySize MdEntrySize;
            MdOriginType MdOriginType;
            MdEntryType MdEntryType;
            TradeCondition TradeCondition;
            TrdType TrdType;
            MultiLegReportingType MultiLegReportingType;
            MultiLegPriceModel MultiLegPriceModel;
            NonDisclosedTradeVolume NonDisclosedTradeVolume;
        };
    };
}